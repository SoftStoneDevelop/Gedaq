

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
    internal partial interface IInt16ListsmallintListD1
    {
    }
    
    internal partial class Int16ListsmallintListD1 : IInt16ListsmallintListD1
    {


#region TestData

        private readonly Int16smallintListD1E2M[] _testData = new Int16smallintListD1E2M[]
        {
            new Int16smallintListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2888,

18383,

2769,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
24865,

5035,

18098,

16783,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
23873,

4214,

24344,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
29478,

22444,

4770,

19829,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
13347,

13803,

18434,

15377,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
4886,

16305,

10414,

8199,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
32604,

7626,

30453,

6748,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
21433,

14611,

25322,

23680,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
6999,

30158,

21654,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
9285,

27430,

6835,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
17105,

5269,

5928,

19805,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
28964,

16625,

28013,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22522,

23826,

12115,

19856,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
21006,

21390,

7115,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
4331,

24847,

5847,

8522,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
11852,

26709,

6111,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
28160,

4655,

14579,

19371,

},
},
            new Int16smallintListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
10177,

30527,

30592,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
31758,

22104,

26037,

8402,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
21690,

20140,

14856,

24869,

},
},
            new Int16smallintListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
8785,

18426,

7786,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
16748,

26217,

391,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
2757,

28299,

16087,

8996,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
21534,

20336,

9598,

19415,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15698,

14189,

8973,

13413,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2204,

24580,

32510,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
23600,

1265,

3341,

28023,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
25477,

4672,

21603,

},
},
            new Int16smallintListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17194,

14613,

28437,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
8736,

1090,

10489,

12738,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
4812,

25489,

30558,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
3585,

23932,

9819,

30385,

},
},
            new Int16smallintListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24130,

2763,

1835,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
18162,

31805,

24456,

},
},
            new Int16smallintListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
722,

23556,

19236,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
10639,

21128,

26623,

26627,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
22998,

32156,

14145,

13635,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
30165,

20016,

27129,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
10159,

9460,

2545,

},
},
            new Int16smallintListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
9022,

16486,

2585,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
12366,

15195,

26638,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
15159,

18710,

6539,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
229,

18304,

24209,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
27563,

22639,

8460,

30696,

},
},
            new Int16smallintListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
8914,

22031,

18000,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
28576,

11999,

16898,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
19191,

30520,

21534,

2854,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
29110,

12040,

373,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
14794,

17634,

5660,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17831,

30568,

3889,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
20426,

32299,

23715,

},
},
            new Int16smallintListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
31935,

816,

2528,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
20036,

10532,

224,

24205,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
23819,

23300,

23358,

32303,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
3595,

3760,

9445,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
3964,

26870,

12807,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22573,

7106,

11205,

27291,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
925,

22424,

5172,

5232,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
69,

24837,

17684,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17158,

8650,

6937,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
6696,

2509,

230,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
7771,

20396,

31610,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
24111,

29637,

22189,

},
},
            new Int16smallintListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
1334,

1740,

1110,

271,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
4005,

18725,

32570,

30871,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
32269,

22747,

6819,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
18970,

14523,

25746,

},
},
            new Int16smallintListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
22180,

16749,

26489,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
20958,

15403,

29907,

32566,

},
    ModelInner = new Int16smallintListD1E2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
24473,

25378,

19678,

14683,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
4769,

9548,

5099,

85,

},
},
    NullableValue = null,
},
            new Int16smallintListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
10567,

16873,

12341,

7028,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintlistd1e2mi(
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
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
INSERT INTO public.int16smallintlistd1e2mi(
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
            queryMapTypes: [typeof(Int16smallintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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

                changedRows =  ((IInt16ListsmallintListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16ListsmallintListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16ListsmallintListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16ListsmallintListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt16ListsmallintListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt16ListsmallintListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt16ListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintlistd1e2m(
	id,
    value,
    nullablevalue,
    int16smallintlistd1e2mi_id
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
            asPartInterface: typeof(IInt16ListsmallintListD1)), 
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
                methodParametrName: "int16smallintlistd1e2mi_id", 
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
                changedRows =  ((IInt16ListsmallintListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt16ListsmallintListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt16ListsmallintListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt16ListsmallintListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintlistd1e2m(
	id,
    value,
    nullablevalue,
    int16smallintlistd1e2mi_id
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
    int16smallintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int16smallintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintlistd1e2m(
	id,
    value,
    nullablevalue,
    int16smallintlistd1e2mi_id
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
    int16smallintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int16smallintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                methodParametrName: "int16smallintlistd1e2mi_id", 
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
                List<Int16smallintListD1E2M> models = null;

                models =  ((IInt16ListsmallintListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt16ListsmallintListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt16ListsmallintListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt16ListsmallintListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintListD1E2M> models = null;

                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt16ListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintListD1E2M), typeof(FlatInt16smallintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
FROM public.int16smallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintListD1E2M>();
                var models2 = new List<FlatInt16smallintListD1E2M>();
                await ((IInt16ListsmallintListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintListD1E2M>();
                var models2 = new List<FlatInt16smallintListD1E2M>();
                ((IInt16ListsmallintListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
FROM public.int16smallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt16ListsmallintListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt16ListsmallintListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
LEFT JOIN public.int16smallintlistd1e2mi mi ON mi.id = m.int16smallintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models = await ((IInt16ListsmallintListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16ListsmallintListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintListD1E2M), typeof(FlatInt16smallintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
FROM public.int16smallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintListD1E2M>();
                var models2 = new List<FlatInt16smallintListD1E2M>();
                await ((IInt16ListsmallintListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintListD1E2M>();
                var models2 = new List<FlatInt16smallintListD1E2M>();
                ((IInt16ListsmallintListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
FROM public.int16smallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt16ListsmallintListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt16ListsmallintListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
LEFT JOIN public.int16smallintlistd1e2mi mi ON mi.id = m.int16smallintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models = await ((IInt16ListsmallintListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt16ListsmallintListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintListD1E2M), typeof(FlatInt16smallintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintListD1E2M>();
                var models2 = new List<FlatInt16smallintListD1E2M>();
                await((IInt16ListsmallintListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var firstItems2 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems2 = new List<FlatInt16smallintListD1E2M>();
                await ((IInt16ListsmallintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var firstItems2 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                await ((IInt16ListsmallintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintListD1E2M>();
                var models2 = new List<FlatInt16smallintListD1E2M>();
                ((IInt16ListsmallintListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var firstItems2 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems2 = new List<FlatInt16smallintListD1E2M>();
                 ((IInt16ListsmallintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var firstItems2 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                 ((IInt16ListsmallintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16ListsmallintListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ListsmallintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt16smallintListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt16smallintListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems2 = new List<FlatInt16smallintListD1E2M>();
                await ((IInt16ListsmallintListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16ListsmallintListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ListsmallintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt16smallintListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt16smallintListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems2 = new List<FlatInt16smallintListD1E2M>();
                 ((IInt16ListsmallintListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
LEFT JOIN public.int16smallintlistd1e2mi mi ON mi.id = m.int16smallintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models = await((IInt16ListsmallintListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ListsmallintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int16smallintListD1E2M.AssertModel(models[0],_testData[1], false);
                        Int16smallintListD1E2M.AssertModel(models[1],_testData[2], false);
                        Int16smallintListD1E2M.AssertModel(models[2],_testData[3], false);
                        Int16smallintListD1E2M.AssertModel(models[3],_testData[4], false);
                        Int16smallintListD1E2M.AssertModel(models[4],_testData[5], false);
                        Int16smallintListD1E2M.AssertModel(models[5],_testData[6], false);
                        Int16smallintListD1E2M.AssertModel(models[6],_testData[7], false);
                        Int16smallintListD1E2M.AssertModel(models[7],_testData[8], false);
                        Int16smallintListD1E2M.AssertModel(models[8],_testData[9], false);
                        Int16smallintListD1E2M.AssertModel(models[9],_testData[10], false);
                        Int16smallintListD1E2M.AssertModel(models[10],_testData[11], false);
                        Int16smallintListD1E2M.AssertModel(models[11],_testData[12], false);
                        Int16smallintListD1E2M.AssertModel(models[12],_testData[13], false);
                        Int16smallintListD1E2M.AssertModel(models[13],_testData[14], false);
                        Int16smallintListD1E2M.AssertModel(models[14],_testData[15], false);
                        Int16smallintListD1E2M.AssertModel(models[15],_testData[16], false);
                        Int16smallintListD1E2M.AssertModel(models[16],_testData[17], false);
                        Int16smallintListD1E2M.AssertModel(models[17],_testData[18], false);
                        Int16smallintListD1E2M.AssertModel(models[18],_testData[19], false);
                        Int16smallintListD1E2M.AssertModel(models[19],_testData[20], false);
                        Int16smallintListD1E2M.AssertModel(models[20],_testData[21], false);
                        Int16smallintListD1E2M.AssertModel(models[21],_testData[22], false);
                        Int16smallintListD1E2M.AssertModel(models[22],_testData[23], false);
                        Int16smallintListD1E2M.AssertModel(models[23],_testData[24], false);
                        Int16smallintListD1E2M.AssertModel(models[24],_testData[25], false);
                        Int16smallintListD1E2M.AssertModel(models[25],_testData[26], false);
                        Int16smallintListD1E2M.AssertModel(models[26],_testData[27], false);
                        Int16smallintListD1E2M.AssertModel(models[27],_testData[28], false);
                        Int16smallintListD1E2M.AssertModel(models[28],_testData[29], false);
                        Int16smallintListD1E2M.AssertModel(models[29],_testData[30], false);
                        Int16smallintListD1E2M.AssertModel(models[30],_testData[31], false);
                        Int16smallintListD1E2M.AssertModel(models[31],_testData[32], false);
                        Int16smallintListD1E2M.AssertModel(models[32],_testData[33], false);
                        Int16smallintListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int16smallintListD1E2M.AssertModel(models[0],_testData[13], false);
                        Int16smallintListD1E2M.AssertModel(models[1],_testData[14], false);
                        Int16smallintListD1E2M.AssertModel(models[2],_testData[15], false);
                        Int16smallintListD1E2M.AssertModel(models[3],_testData[16], false);
                        Int16smallintListD1E2M.AssertModel(models[4],_testData[17], false);
                        Int16smallintListD1E2M.AssertModel(models[5],_testData[18], false);
                        Int16smallintListD1E2M.AssertModel(models[6],_testData[19], false);
                        Int16smallintListD1E2M.AssertModel(models[7],_testData[20], false);
                        Int16smallintListD1E2M.AssertModel(models[8],_testData[21], false);
                        Int16smallintListD1E2M.AssertModel(models[9],_testData[22], false);
                        Int16smallintListD1E2M.AssertModel(models[10],_testData[23], false);
                        Int16smallintListD1E2M.AssertModel(models[11],_testData[24], false);
                        Int16smallintListD1E2M.AssertModel(models[12],_testData[25], false);
                        Int16smallintListD1E2M.AssertModel(models[13],_testData[26], false);
                        Int16smallintListD1E2M.AssertModel(models[14],_testData[27], false);
                        Int16smallintListD1E2M.AssertModel(models[15],_testData[28], false);
                        Int16smallintListD1E2M.AssertModel(models[16],_testData[29], false);
                        Int16smallintListD1E2M.AssertModel(models[17],_testData[30], false);
                        Int16smallintListD1E2M.AssertModel(models[18],_testData[31], false);
                        Int16smallintListD1E2M.AssertModel(models[19],_testData[32], false);
                        Int16smallintListD1E2M.AssertModel(models[20],_testData[33], false);
                        Int16smallintListD1E2M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IInt16ListsmallintListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ListsmallintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int16smallintListD1E2M.AssertModel(models[0],_testData[4], false);
                        Int16smallintListD1E2M.AssertModel(models[1],_testData[5], false);
                        Int16smallintListD1E2M.AssertModel(models[2],_testData[6], false);
                        Int16smallintListD1E2M.AssertModel(models[3],_testData[7], false);
                        Int16smallintListD1E2M.AssertModel(models[4],_testData[8], false);
                        Int16smallintListD1E2M.AssertModel(models[5],_testData[9], false);
                        Int16smallintListD1E2M.AssertModel(models[6],_testData[10], false);
                        Int16smallintListD1E2M.AssertModel(models[7],_testData[11], false);
                        Int16smallintListD1E2M.AssertModel(models[8],_testData[12], false);
                        Int16smallintListD1E2M.AssertModel(models[9],_testData[13], false);
                        Int16smallintListD1E2M.AssertModel(models[10],_testData[14], false);
                        Int16smallintListD1E2M.AssertModel(models[11],_testData[15], false);
                        Int16smallintListD1E2M.AssertModel(models[12],_testData[16], false);
                        Int16smallintListD1E2M.AssertModel(models[13],_testData[17], false);
                        Int16smallintListD1E2M.AssertModel(models[14],_testData[18], false);
                        Int16smallintListD1E2M.AssertModel(models[15],_testData[19], false);
                        Int16smallintListD1E2M.AssertModel(models[16],_testData[20], false);
                        Int16smallintListD1E2M.AssertModel(models[17],_testData[21], false);
                        Int16smallintListD1E2M.AssertModel(models[18],_testData[22], false);
                        Int16smallintListD1E2M.AssertModel(models[19],_testData[23], false);
                        Int16smallintListD1E2M.AssertModel(models[20],_testData[24], false);
                        Int16smallintListD1E2M.AssertModel(models[21],_testData[25], false);
                        Int16smallintListD1E2M.AssertModel(models[22],_testData[26], false);
                        Int16smallintListD1E2M.AssertModel(models[23],_testData[27], false);
                        Int16smallintListD1E2M.AssertModel(models[24],_testData[28], false);
                        Int16smallintListD1E2M.AssertModel(models[25],_testData[29], false);
                        Int16smallintListD1E2M.AssertModel(models[26],_testData[30], false);
                        Int16smallintListD1E2M.AssertModel(models[27],_testData[31], false);
                        Int16smallintListD1E2M.AssertModel(models[28],_testData[32], false);
                        Int16smallintListD1E2M.AssertModel(models[29],_testData[33], false);
                        Int16smallintListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int16smallintListD1E2M.AssertModel(models[0],_testData[9], false);
                        Int16smallintListD1E2M.AssertModel(models[1],_testData[10], false);
                        Int16smallintListD1E2M.AssertModel(models[2],_testData[11], false);
                        Int16smallintListD1E2M.AssertModel(models[3],_testData[12], false);
                        Int16smallintListD1E2M.AssertModel(models[4],_testData[13], false);
                        Int16smallintListD1E2M.AssertModel(models[5],_testData[14], false);
                        Int16smallintListD1E2M.AssertModel(models[6],_testData[15], false);
                        Int16smallintListD1E2M.AssertModel(models[7],_testData[16], false);
                        Int16smallintListD1E2M.AssertModel(models[8],_testData[17], false);
                        Int16smallintListD1E2M.AssertModel(models[9],_testData[18], false);
                        Int16smallintListD1E2M.AssertModel(models[10],_testData[19], false);
                        Int16smallintListD1E2M.AssertModel(models[11],_testData[20], false);
                        Int16smallintListD1E2M.AssertModel(models[12],_testData[21], false);
                        Int16smallintListD1E2M.AssertModel(models[13],_testData[22], false);
                        Int16smallintListD1E2M.AssertModel(models[14],_testData[23], false);
                        Int16smallintListD1E2M.AssertModel(models[15],_testData[24], false);
                        Int16smallintListD1E2M.AssertModel(models[16],_testData[25], false);
                        Int16smallintListD1E2M.AssertModel(models[17],_testData[26], false);
                        Int16smallintListD1E2M.AssertModel(models[18],_testData[27], false);
                        Int16smallintListD1E2M.AssertModel(models[19],_testData[28], false);
                        Int16smallintListD1E2M.AssertModel(models[20],_testData[29], false);
                        Int16smallintListD1E2M.AssertModel(models[21],_testData[30], false);
                        Int16smallintListD1E2M.AssertModel(models[22],_testData[31], false);
                        Int16smallintListD1E2M.AssertModel(models[23],_testData[32], false);
                        Int16smallintListD1E2M.AssertModel(models[24],_testData[33], false);
                        Int16smallintListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintListD1E2M), typeof(FlatInt16smallintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintListD1E2M>();
                var models2 = new List<FlatInt16smallintListD1E2M>();
                await((IInt16ListsmallintListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var firstItems2 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems2 = new List<FlatInt16smallintListD1E2M>();
                await ((IInt16ListsmallintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var firstItems2 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                await ((IInt16ListsmallintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 12, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintListD1E2M>();
                var models2 = new List<FlatInt16smallintListD1E2M>();
                ((IInt16ListsmallintListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var firstItems2 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems2 = new List<FlatInt16smallintListD1E2M>();
                 ((IInt16ListsmallintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 3, query1, 172, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var firstItems2 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                 ((IInt16ListsmallintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 150, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16ListsmallintListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ListsmallintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 132, query1, 159, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt16smallintListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt16smallintListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[4],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems2 = new List<FlatInt16smallintListD1E2M>();
                await ((IInt16ListsmallintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 74, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16ListsmallintListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ListsmallintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt16smallintListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt16smallintListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(models[21],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
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
FROM public.int16smallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems1 = new List<FlatInt16smallintListD1E2M>();
                var secondItems2 = new List<FlatInt16smallintListD1E2M>();
                 ((IInt16ListsmallintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 115, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt16smallintListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int16smallintlistd1e2m m
LEFT JOIN public.int16smallintlistd1e2mi mi ON mi.id = m.int16smallintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models = await((IInt16ListsmallintListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16ListsmallintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 132, 150))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int16smallintListD1E2M.AssertModel(models[0],_testData[26], false);
                        Int16smallintListD1E2M.AssertModel(models[1],_testData[27], false);
                        Int16smallintListD1E2M.AssertModel(models[2],_testData[28], false);
                        Int16smallintListD1E2M.AssertModel(models[3],_testData[29], false);
                        Int16smallintListD1E2M.AssertModel(models[4],_testData[30], false);
                        Int16smallintListD1E2M.AssertModel(models[5],_testData[31], false);
                        Int16smallintListD1E2M.AssertModel(models[6],_testData[32], false);
                        Int16smallintListD1E2M.AssertModel(models[7],_testData[33], false);
                        Int16smallintListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallintListD1E2M.AssertModel(models[0],_testData[28], false);
                        Int16smallintListD1E2M.AssertModel(models[1],_testData[29], false);
                        Int16smallintListD1E2M.AssertModel(models[2],_testData[30], false);
                        Int16smallintListD1E2M.AssertModel(models[3],_testData[31], false);
                        Int16smallintListD1E2M.AssertModel(models[4],_testData[32], false);
                        Int16smallintListD1E2M.AssertModel(models[5],_testData[33], false);
                        Int16smallintListD1E2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IInt16ListsmallintListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16ListsmallintListD1)this).DbConnectionSTSelectModelBatch(connection, 73, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int16smallintListD1E2M.AssertModel(models[0],_testData[13], false);
                        Int16smallintListD1E2M.AssertModel(models[1],_testData[14], false);
                        Int16smallintListD1E2M.AssertModel(models[2],_testData[15], false);
                        Int16smallintListD1E2M.AssertModel(models[3],_testData[16], false);
                        Int16smallintListD1E2M.AssertModel(models[4],_testData[17], false);
                        Int16smallintListD1E2M.AssertModel(models[5],_testData[18], false);
                        Int16smallintListD1E2M.AssertModel(models[6],_testData[19], false);
                        Int16smallintListD1E2M.AssertModel(models[7],_testData[20], false);
                        Int16smallintListD1E2M.AssertModel(models[8],_testData[21], false);
                        Int16smallintListD1E2M.AssertModel(models[9],_testData[22], false);
                        Int16smallintListD1E2M.AssertModel(models[10],_testData[23], false);
                        Int16smallintListD1E2M.AssertModel(models[11],_testData[24], false);
                        Int16smallintListD1E2M.AssertModel(models[12],_testData[25], false);
                        Int16smallintListD1E2M.AssertModel(models[13],_testData[26], false);
                        Int16smallintListD1E2M.AssertModel(models[14],_testData[27], false);
                        Int16smallintListD1E2M.AssertModel(models[15],_testData[28], false);
                        Int16smallintListD1E2M.AssertModel(models[16],_testData[29], false);
                        Int16smallintListD1E2M.AssertModel(models[17],_testData[30], false);
                        Int16smallintListD1E2M.AssertModel(models[18],_testData[31], false);
                        Int16smallintListD1E2M.AssertModel(models[19],_testData[32], false);
                        Int16smallintListD1E2M.AssertModel(models[20],_testData[33], false);
                        Int16smallintListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int16smallintListD1E2M.AssertModel(models[0],_testData[5], false);
                        Int16smallintListD1E2M.AssertModel(models[1],_testData[6], false);
                        Int16smallintListD1E2M.AssertModel(models[2],_testData[7], false);
                        Int16smallintListD1E2M.AssertModel(models[3],_testData[8], false);
                        Int16smallintListD1E2M.AssertModel(models[4],_testData[9], false);
                        Int16smallintListD1E2M.AssertModel(models[5],_testData[10], false);
                        Int16smallintListD1E2M.AssertModel(models[6],_testData[11], false);
                        Int16smallintListD1E2M.AssertModel(models[7],_testData[12], false);
                        Int16smallintListD1E2M.AssertModel(models[8],_testData[13], false);
                        Int16smallintListD1E2M.AssertModel(models[9],_testData[14], false);
                        Int16smallintListD1E2M.AssertModel(models[10],_testData[15], false);
                        Int16smallintListD1E2M.AssertModel(models[11],_testData[16], false);
                        Int16smallintListD1E2M.AssertModel(models[12],_testData[17], false);
                        Int16smallintListD1E2M.AssertModel(models[13],_testData[18], false);
                        Int16smallintListD1E2M.AssertModel(models[14],_testData[19], false);
                        Int16smallintListD1E2M.AssertModel(models[15],_testData[20], false);
                        Int16smallintListD1E2M.AssertModel(models[16],_testData[21], false);
                        Int16smallintListD1E2M.AssertModel(models[17],_testData[22], false);
                        Int16smallintListD1E2M.AssertModel(models[18],_testData[23], false);
                        Int16smallintListD1E2M.AssertModel(models[19],_testData[24], false);
                        Int16smallintListD1E2M.AssertModel(models[20],_testData[25], false);
                        Int16smallintListD1E2M.AssertModel(models[21],_testData[26], false);
                        Int16smallintListD1E2M.AssertModel(models[22],_testData[27], false);
                        Int16smallintListD1E2M.AssertModel(models[23],_testData[28], false);
                        Int16smallintListD1E2M.AssertModel(models[24],_testData[29], false);
                        Int16smallintListD1E2M.AssertModel(models[25],_testData[30], false);
                        Int16smallintListD1E2M.AssertModel(models[26],_testData[31], false);
                        Int16smallintListD1E2M.AssertModel(models[27],_testData[32], false);
                        Int16smallintListD1E2M.AssertModel(models[28],_testData[33], false);
                        Int16smallintListD1E2M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((IInt16ListsmallintListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16ListsmallintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models = await ((IInt16ListsmallintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Int16smallintListD1E2M.AssertModel(models[0],_testData[14], false);
                Int16smallintListD1E2M.AssertModel(models[1],_testData[15], false);
                Int16smallintListD1E2M.AssertModel(models[2],_testData[16], false);
                Int16smallintListD1E2M.AssertModel(models[3],_testData[17], false);
                Int16smallintListD1E2M.AssertModel(models[4],_testData[18], false);
                Int16smallintListD1E2M.AssertModel(models[5],_testData[19], false);
                Int16smallintListD1E2M.AssertModel(models[6],_testData[20], false);
                Int16smallintListD1E2M.AssertModel(models[7],_testData[21], false);
                Int16smallintListD1E2M.AssertModel(models[8],_testData[22], false);
                Int16smallintListD1E2M.AssertModel(models[9],_testData[23], false);
                Int16smallintListD1E2M.AssertModel(models[10],_testData[24], false);
                Int16smallintListD1E2M.AssertModel(models[11],_testData[25], false);
                Int16smallintListD1E2M.AssertModel(models[12],_testData[26], false);
                Int16smallintListD1E2M.AssertModel(models[13],_testData[27], false);
                Int16smallintListD1E2M.AssertModel(models[14],_testData[28], false);
                Int16smallintListD1E2M.AssertModel(models[15],_testData[29], false);
                Int16smallintListD1E2M.AssertModel(models[16],_testData[30], false);
                Int16smallintListD1E2M.AssertModel(models[17],_testData[31], false);
                Int16smallintListD1E2M.AssertModel(models[18],_testData[32], false);
                Int16smallintListD1E2M.AssertModel(models[19],_testData[33], false);
                Int16smallintListD1E2M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ListsmallintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ListsmallintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((IInt16ListsmallintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                Int16smallintListD1E2M.AssertModel(models[0],_testData[7], false);
                Int16smallintListD1E2M.AssertModel(models[1],_testData[8], false);
                Int16smallintListD1E2M.AssertModel(models[2],_testData[9], false);
                Int16smallintListD1E2M.AssertModel(models[3],_testData[10], false);
                Int16smallintListD1E2M.AssertModel(models[4],_testData[11], false);
                Int16smallintListD1E2M.AssertModel(models[5],_testData[12], false);
                Int16smallintListD1E2M.AssertModel(models[6],_testData[13], false);
                Int16smallintListD1E2M.AssertModel(models[7],_testData[14], false);
                Int16smallintListD1E2M.AssertModel(models[8],_testData[15], false);
                Int16smallintListD1E2M.AssertModel(models[9],_testData[16], false);
                Int16smallintListD1E2M.AssertModel(models[10],_testData[17], false);
                Int16smallintListD1E2M.AssertModel(models[11],_testData[18], false);
                Int16smallintListD1E2M.AssertModel(models[12],_testData[19], false);
                Int16smallintListD1E2M.AssertModel(models[13],_testData[20], false);
                Int16smallintListD1E2M.AssertModel(models[14],_testData[21], false);
                Int16smallintListD1E2M.AssertModel(models[15],_testData[22], false);
                Int16smallintListD1E2M.AssertModel(models[16],_testData[23], false);
                Int16smallintListD1E2M.AssertModel(models[17],_testData[24], false);
                Int16smallintListD1E2M.AssertModel(models[18],_testData[25], false);
                Int16smallintListD1E2M.AssertModel(models[19],_testData[26], false);
                Int16smallintListD1E2M.AssertModel(models[20],_testData[27], false);
                Int16smallintListD1E2M.AssertModel(models[21],_testData[28], false);
                Int16smallintListD1E2M.AssertModel(models[22],_testData[29], false);
                Int16smallintListD1E2M.AssertModel(models[23],_testData[30], false);
                Int16smallintListD1E2M.AssertModel(models[24],_testData[31], false);
                Int16smallintListD1E2M.AssertModel(models[25],_testData[32], false);
                Int16smallintListD1E2M.AssertModel(models[26],_testData[33], false);
                Int16smallintListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_int16smallintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int16smallintListD1E2MIWA),
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
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ListsmallintListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16ListsmallintListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ListsmallintListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16ListsmallintListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int16smallintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ListsmallintListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16ListsmallintListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ListsmallintListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16ListsmallintListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int16smallintListD1E2MI),
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
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt16ListsmallintListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16ListsmallintListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt16ListsmallintListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt16ListsmallintListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int16smallintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ListsmallintListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16ListsmallintListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ListsmallintListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16ListsmallintListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int16smallintlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int16smallintListD1E2M),
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
            asPartInterface: typeof(IInt16ListsmallintListD1))]
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
FROM public.binary_int16smallintlistd1e2m m
LEFT JOIN public.binary_int16smallintlistd1e2mi mi ON mi.id = m.int16smallintlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int16smallintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt16ListsmallintListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt16ListsmallintListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt16ListsmallintListD1)this).ImportModel(connection, importCollection);
                var models = ((IInt16ListsmallintListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int16smallintlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int16smallintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models =  ((IInt16ListsmallintListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16ListsmallintListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA), typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models1 = new List<Int16smallintListD1E2MIWA>();
                var models2 = new List<Int16smallintListD1E2MIWA>();
                await ((IInt16ListsmallintListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintListD1E2MIWA>();
                var models2 = new List<Int16smallintListD1E2MIWA>();
                ((IInt16ListsmallintListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models = await ((IInt16ListsmallintListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintlistd1e2mi
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
                    Int16smallintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ListsmallintListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int16smallintlistd1e2mi
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
                    Int16smallintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA), typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
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
                var models1 = new List<Int16smallintListD1E2MIWA>();
                var models2 = new List<Int16smallintListD1E2MIWA>();
                await ((IInt16ListsmallintListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintListD1E2MIWA>();
                var models2 = new List<Int16smallintListD1E2MIWA>();
                ((IInt16ListsmallintListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
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
                var models = await ((IInt16ListsmallintListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintlistd1e2mi
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
                    Int16smallintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ListsmallintListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int16smallintlistd1e2mi
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
                    Int16smallintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MI), typeof(Int16smallintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models1 = new List<Int16smallintListD1E2MI>();
                var models2 = new List<Int16smallintListD1E2MI>();
                await ((IInt16ListsmallintListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintListD1E2MI>();
                var models2 = new List<Int16smallintListD1E2MI>();
                ((IInt16ListsmallintListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1)),
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
                var models = await ((IInt16ListsmallintListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ListsmallintListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA), typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
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
                var models1 = new List<Int16smallintListD1E2MIWA>();
                var models2 = new List<Int16smallintListD1E2MIWA>();
                await ((IInt16ListsmallintListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintListD1E2MIWA>();
                var models2 = new List<Int16smallintListD1E2MIWA>();
                ((IInt16ListsmallintListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int16smallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintListD1))]
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
                var models = await ((IInt16ListsmallintListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ListsmallintListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


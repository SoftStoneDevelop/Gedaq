

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
32118,

7992,

3935,

27644,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16025,

12263,

1835,

15903,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
25619,

27882,

21263,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
16824,

23816,

31298,

29346,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
31795,

2846,

16775,

18338,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16373,

15103,

15266,

26969,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
20871,

30598,

27582,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
4376,

16804,

16417,

19124,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
31862,

22147,

16092,

19598,

},
},
            new Int16smallintArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
543,

4851,

15859,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
8578,

2702,

10004,

31793,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
16530,

25731,

30240,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
15757,

1715,

22373,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
19616,

5741,

14374,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
23692,

4784,

24997,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24397,

18980,

21577,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
29183,

31627,

11845,

},
},
            new Int16smallintArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
3825,

7280,

5567,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
32087,

15844,

4398,

},
},
            new Int16smallintArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
0,

6255,

2597,

5899,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
7449,

8725,

25844,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
21009,

32421,

7205,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
8472,

15524,

17833,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
11428,

9769,

32712,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
950,

17248,

26565,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
21018,

19619,

21947,

20721,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
3677,

23232,

15524,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
28155,

7916,

1309,

22958,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
9591,

8235,

29772,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
11785,

22771,

12240,

12299,

},
},
            new Int16smallintArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22509,

3914,

12733,

4623,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
30666,

3659,

14678,

},
},
            new Int16smallintArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
16381,

30137,

9439,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16197,

29595,

17908,

3853,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
28581,

8460,

14697,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
13553,

2941,

24491,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
18477,

8686,

7520,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
28196,

16536,

32535,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
26853,

5583,

32416,

},
},
            new Int16smallintArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
8217,

30812,

31234,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
10224,

22867,

8927,

20842,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
27981,

32233,

9779,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
5591,

28366,

31910,

},
},
            new Int16smallintArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16575,

26938,

1037,

19264,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
18947,

7505,

18887,

23623,

},
},
            new Int16smallintArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
31976,

20165,

1862,

2478,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
3614,

18307,

4323,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
9921,

2662,

31945,

11025,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
1928,

22948,

7221,

},
},
            new Int16smallintArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
6100,

22201,

25744,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
24931,

17341,

20951,

32025,

},
},
            new Int16smallintArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
1967,

22655,

10727,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
8300,

23269,

9120,

21210,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
29717,

27294,

10733,

7009,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
16994,

9625,

20237,

},
},
            new Int16smallintArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
9487,

32438,

18249,

20451,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
27938,

20522,

18171,

28401,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
29159,

179,

17205,

28084,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
16005,

25285,

4218,

27872,

},
},
            new Int16smallintArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
9149,

27858,

12745,

8195,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
26000,

19018,

13810,

32205,

},
},
            new Int16smallintArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
28486,

659,

10106,

22832,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15636,

13941,

21635,

1834,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
29687,

4853,

11721,

},
},
            new Int16smallintArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
2083,

11130,

13634,

16501,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
7023,

8996,

18550,

},
},
            new Int16smallintArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
32228,

27925,

19194,

16549,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
8646,

6207,

17206,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
26360,

19980,

27478,

26025,

},
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 142;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int16smallintArray2M.AssertModel(models[0],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int16smallintArray2M.AssertModel(models[0],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int16smallintArray2M.AssertModel(models[0],_testData[3], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[4], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[5], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[6], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[7], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[8], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[9], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[10], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[11], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[12], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[19],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[20],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[21],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[22],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[23],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[24],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[25],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int16smallintArray2M.AssertModel(models[0],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
                await ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 113, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 33, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
                 ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 89, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 144, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[29], false);
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
                await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 145, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 119, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[29], false);
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
                 ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 89, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 1, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatch(connection, 119, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int16smallintArray2M.AssertModel(models[0],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int16smallintArray2M.AssertModel(models[0],_testData[11], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[12], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[29], false);
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
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models = await ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Int16smallintArray2M.AssertModel(models[0],_testData[27], false);Int16smallintArray2M.AssertModel(models[1],_testData[28], false);Int16smallintArray2M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
Int16smallintArray2M.AssertModel(models[0],_testData[12], false);Int16smallintArray2M.AssertModel(models[1],_testData[13], false);Int16smallintArray2M.AssertModel(models[2],_testData[14], false);Int16smallintArray2M.AssertModel(models[3],_testData[15], false);Int16smallintArray2M.AssertModel(models[4],_testData[16], false);Int16smallintArray2M.AssertModel(models[5],_testData[17], false);Int16smallintArray2M.AssertModel(models[6],_testData[18], false);Int16smallintArray2M.AssertModel(models[7],_testData[19], false);Int16smallintArray2M.AssertModel(models[8],_testData[20], false);Int16smallintArray2M.AssertModel(models[9],_testData[21], false);Int16smallintArray2M.AssertModel(models[10],_testData[22], false);Int16smallintArray2M.AssertModel(models[11],_testData[23], false);Int16smallintArray2M.AssertModel(models[12],_testData[24], false);Int16smallintArray2M.AssertModel(models[13],_testData[25], false);Int16smallintArray2M.AssertModel(models[14],_testData[26], false);Int16smallintArray2M.AssertModel(models[15],_testData[27], false);Int16smallintArray2M.AssertModel(models[16],_testData[28], false);Int16smallintArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
FROM public.binary_int16smallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int16smallintArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt16ListsmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16ListsmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(actual, expect, false);
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
                await ((IInt16ListsmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt16ListsmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int16smallintArray2M>(15);

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
                ((IInt16ListsmallintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt16ListsmallintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int16smallintArray2M.AssertModel(models[0],_testData[0], false);
                Int16smallintArray2M.AssertModel(models[1],_testData[1], false);
                Int16smallintArray2M.AssertModel(models[2],_testData[2], false);
                Int16smallintArray2M.AssertModel(models[3],_testData[3], false);
                Int16smallintArray2M.AssertModel(models[4],_testData[4], false);
                Int16smallintArray2M.AssertModel(models[5],_testData[5], false);
                Int16smallintArray2M.AssertModel(models[6],_testData[6], false);
                Int16smallintArray2M.AssertModel(models[7],_testData[7], false);
                Int16smallintArray2M.AssertModel(models[8],_testData[8], false);
                Int16smallintArray2M.AssertModel(models[9],_testData[9], false);
                Int16smallintArray2M.AssertModel(models[10],_testData[10], false);
                Int16smallintArray2M.AssertModel(models[11],_testData[11], false);
                Int16smallintArray2M.AssertModel(models[12],_testData[12], false);
                Int16smallintArray2M.AssertModel(models[13],_testData[13], false);
                Int16smallintArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt16ListsmallintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt16ListsmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int16smallintArray2M.AssertModel(models[0],_testData[0], false);
                Int16smallintArray2M.AssertModel(models[1],_testData[1], false);
                Int16smallintArray2M.AssertModel(models[2],_testData[2], false);
                Int16smallintArray2M.AssertModel(models[3],_testData[3], false);
                Int16smallintArray2M.AssertModel(models[4],_testData[4], false);
                Int16smallintArray2M.AssertModel(models[5],_testData[5], false);
                Int16smallintArray2M.AssertModel(models[6],_testData[6], false);
                Int16smallintArray2M.AssertModel(models[7],_testData[7], false);
                Int16smallintArray2M.AssertModel(models[8],_testData[8], false);
                Int16smallintArray2M.AssertModel(models[9],_testData[9], false);
                Int16smallintArray2M.AssertModel(models[10],_testData[10], false);
                Int16smallintArray2M.AssertModel(models[11],_testData[11], false);
                Int16smallintArray2M.AssertModel(models[12],_testData[12], false);
                Int16smallintArray2M.AssertModel(models[13],_testData[13], false);
                Int16smallintArray2M.AssertModel(models[14],_testData[14], false);
                Int16smallintArray2M.AssertModel(models[15],_testData[15], false);
                Int16smallintArray2M.AssertModel(models[16],_testData[16], false);
                Int16smallintArray2M.AssertModel(models[17],_testData[17], false);
                Int16smallintArray2M.AssertModel(models[18],_testData[18], false);
                Int16smallintArray2M.AssertModel(models[19],_testData[19], false);
                Int16smallintArray2M.AssertModel(models[20],_testData[20], false);
                Int16smallintArray2M.AssertModel(models[21],_testData[21], false);
                Int16smallintArray2M.AssertModel(models[22],_testData[22], false);
                Int16smallintArray2M.AssertModel(models[23],_testData[23], false);
                Int16smallintArray2M.AssertModel(models[24],_testData[24], false);
                Int16smallintArray2M.AssertModel(models[25],_testData[25], false);
                Int16smallintArray2M.AssertModel(models[26],_testData[26], false);
                Int16smallintArray2M.AssertModel(models[27],_testData[27], false);
                Int16smallintArray2M.AssertModel(models[28],_testData[28], false);
                Int16smallintArray2M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_int16smallintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16ListsmallintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16ListsmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


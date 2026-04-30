

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
15409,

2238,

20786,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
6395,

22757,

9182,

},
},
            new Int16smallintArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24674,

2009,

24437,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15349,

13899,

12749,

22911,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
31923,

3206,

1304,

19377,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
1997,

31153,

26730,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
11490,

15810,

9014,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
9132,

7074,

19607,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
9677,

11092,

28414,

5429,

},
},
            new Int16smallintArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
6362,

10595,

771,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
14382,

8005,

27972,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
3319,

27125,

3931,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
27980,

1991,

1154,

},
},
            new Int16smallintArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
31180,

22293,

2043,

27423,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
11982,

24003,

7863,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
21909,

19288,

2611,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
9574,

21725,

2725,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
1757,

31426,

32376,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
20131,

21063,

4621,

9533,

},
},
            new Int16smallintArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
9828,

28568,

31515,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
20689,

20512,

3114,

8277,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
9293,

5111,

21604,

25804,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
5794,

6676,

15799,

},
},
            new Int16smallintArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
2282,

26417,

14448,

9207,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
14896,

11081,

25309,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22899,

18340,

7216,

2103,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
166,

8929,

28523,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
14991,

20451,

16345,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
10622,

24856,

26830,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
24115,

10836,

9256,

24654,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
3564,

19335,

11885,

4363,

},
},
            new Int16smallintArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
10083,

29154,

32708,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
28153,

28698,

5327,

},
},
            new Int16smallintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
26587,

5455,

7409,

13371,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
2722,

24522,

7280,

13668,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
25496,

30457,

13503,

15262,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
5267,

9236,

20134,

25854,

},
},
            new Int16smallintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
10128,

18520,

16862,

5632,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
22672,

13506,

8250,

15578,

},
},
            new Int16smallintArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
3845,

23083,

10252,

16224,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
5097,

9479,

1248,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
7412,

11829,

9366,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
25743,

17420,

4263,

27440,

},
},
            new Int16smallintArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
11401,

29297,

32509,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
14676,

13969,

15089,

11999,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
361,

17912,

337,

26180,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
26844,

30379,

9318,

},
},
            new Int16smallintArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
13501,

4836,

5914,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
26750,

8970,

11161,

4565,

},
},
            new Int16smallintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24352,

4614,

18278,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
15821,

22082,

29101,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
17582,

10582,

11239,

29074,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
27128,

32649,

15591,

28268,

},
},
            new Int16smallintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22625,

18802,

9155,

12196,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
8601,

20799,

32022,

24888,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22286,

32646,

14665,

11671,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
25198,

18481,

20844,

4233,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
21617,

5772,

15923,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
25850,

21092,

19047,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
26224,

7960,

10381,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
10483,

21959,

24064,

},
},
            new Int16smallintArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
5701,

24668,

6821,

27115,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17936,

30958,

6115,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
32029,

30315,

10177,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
30380,

20323,

30642,

30827,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
18110,

11870,

2912,

},
},
            new Int16smallintArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
5277,

23400,

32119,

30353,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
9144,

762,

5335,

4730,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
8126,

4652,

22134,

12269,

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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                parametr1.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                        Assert.That(models, Has.Count.EqualTo(26));

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
                parametr1.Value = 71;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int16smallintArray2M.AssertModel(models[0],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[29], false);
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
                await ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                await ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 144, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[29], false);
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
                 ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 49, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
                 ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 124, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[29], false);
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
                await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 144, query1, 80, query2))
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
                 ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 15, query1, 102, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int16smallintArray2M.AssertModel(models[0],_testData[6], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[7], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[8], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[9], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[10], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[11], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[12], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[19],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[20],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[21],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[22],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatch(connection, 102, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallintArray2M.AssertModel(models[0],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[29], false);
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
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models = await ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Int16smallintArray2M.AssertModel(models[0],_testData[14], false);Int16smallintArray2M.AssertModel(models[1],_testData[15], false);Int16smallintArray2M.AssertModel(models[2],_testData[16], false);Int16smallintArray2M.AssertModel(models[3],_testData[17], false);Int16smallintArray2M.AssertModel(models[4],_testData[18], false);Int16smallintArray2M.AssertModel(models[5],_testData[19], false);Int16smallintArray2M.AssertModel(models[6],_testData[20], false);Int16smallintArray2M.AssertModel(models[7],_testData[21], false);Int16smallintArray2M.AssertModel(models[8],_testData[22], false);Int16smallintArray2M.AssertModel(models[9],_testData[23], false);Int16smallintArray2M.AssertModel(models[10],_testData[24], false);Int16smallintArray2M.AssertModel(models[11],_testData[25], false);Int16smallintArray2M.AssertModel(models[12],_testData[26], false);Int16smallintArray2M.AssertModel(models[13],_testData[27], false);Int16smallintArray2M.AssertModel(models[14],_testData[28], false);Int16smallintArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
Int16smallintArray2M.AssertModel(models[0],_testData[2], false);Int16smallintArray2M.AssertModel(models[1],_testData[3], false);Int16smallintArray2M.AssertModel(models[2],_testData[4], false);Int16smallintArray2M.AssertModel(models[3],_testData[5], false);Int16smallintArray2M.AssertModel(models[4],_testData[6], false);Int16smallintArray2M.AssertModel(models[5],_testData[7], false);Int16smallintArray2M.AssertModel(models[6],_testData[8], false);Int16smallintArray2M.AssertModel(models[7],_testData[9], false);Int16smallintArray2M.AssertModel(models[8],_testData[10], false);Int16smallintArray2M.AssertModel(models[9],_testData[11], false);Int16smallintArray2M.AssertModel(models[10],_testData[12], false);Int16smallintArray2M.AssertModel(models[11],_testData[13], false);Int16smallintArray2M.AssertModel(models[12],_testData[14], false);Int16smallintArray2M.AssertModel(models[13],_testData[15], false);Int16smallintArray2M.AssertModel(models[14],_testData[16], false);Int16smallintArray2M.AssertModel(models[15],_testData[17], false);Int16smallintArray2M.AssertModel(models[16],_testData[18], false);Int16smallintArray2M.AssertModel(models[17],_testData[19], false);Int16smallintArray2M.AssertModel(models[18],_testData[20], false);Int16smallintArray2M.AssertModel(models[19],_testData[21], false);Int16smallintArray2M.AssertModel(models[20],_testData[22], false);Int16smallintArray2M.AssertModel(models[21],_testData[23], false);Int16smallintArray2M.AssertModel(models[22],_testData[24], false);Int16smallintArray2M.AssertModel(models[23],_testData[25], false);Int16smallintArray2M.AssertModel(models[24],_testData[26], false);Int16smallintArray2M.AssertModel(models[25],_testData[27], false);Int16smallintArray2M.AssertModel(models[26],_testData[28], false);Int16smallintArray2M.AssertModel(models[27],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt16ListsmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16ListsmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int16smallintArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt16ListsmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16ListsmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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


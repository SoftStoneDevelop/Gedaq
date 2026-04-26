

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
19861,

24379,

5638,

5821,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
22440,

8808,

19811,

151,

},
},
            new Int16smallintArray2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
18129,

194,

26702,

18363,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
8055,

4382,

27589,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
1993,

31903,

6874,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16243,

1001,

18019,

19488,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
31815,

24688,

31633,

13067,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
30913,

6499,

3982,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
11132,

23809,

13989,

},
},
            new Int16smallintArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15912,

13884,

24625,

12463,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
8431,

5690,

4029,

10677,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2708,

25070,

2005,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
10147,

15319,

7634,

23044,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
32624,

28274,

4543,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
6585,

4779,

4217,

10433,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
7051,

10942,

9595,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
7530,

31257,

825,

27625,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
29201,

28982,

16562,

4133,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
11189,

8726,

12602,

15670,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
14923,

21418,

23745,

11065,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
22429,

6529,

12796,

},
},
            new Int16smallintArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24550,

18525,

4654,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
16310,

32187,

7023,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
23197,

26993,

3568,

23789,

},
},
            new Int16smallintArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
8002,

9538,

13678,

26556,

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
5367,

25591,

19800,

2900,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
31115,

11070,

15590,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
31354,

8205,

13410,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
20924,

3009,

2782,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
13773,

14384,

8726,

18632,

},
},
            new Int16smallintArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
11098,

17692,

19843,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
6449,

1176,

29862,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
23436,

2835,

3350,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
25425,

25377,

21940,

},
},
            new Int16smallintArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
25969,

2898,

15422,

13585,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16127,

32337,

17071,

16246,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
18237,

18507,

14858,

22979,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
24043,

22162,

29240,

},
},
            new Int16smallintArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
984,

1200,

12435,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
32578,

6820,

15535,

},
},
            new Int16smallintArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
18537,

9465,

9717,

18628,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
14326,

32706,

20874,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
3555,

30914,

15862,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
3245,

18832,

24875,

},
},
            new Int16smallintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
31908,

14104,

19672,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
19900,

20597,

17417,

},
},
            new Int16smallintArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
8546,

31111,

1740,

114,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
21220,

28348,

16694,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
1956,

1914,

12829,

22299,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2116,

23617,

16575,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
15945,

26364,

5092,

},
},
            new Int16smallintArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
12577,

15635,

30457,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
9958,

12157,

25396,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
23927,

28875,

18608,

3534,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
31530,

14739,

5759,

},
},
            new Int16smallintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
27342,

13969,

23731,

27885,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
9694,

22095,

5211,

2751,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
15554,

31433,

1915,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
25903,

22093,

15476,

222,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22934,

20156,

17749,

16758,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
7392,

2668,

28455,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
10947,

16406,

11118,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
14961,

6791,

17423,

21541,

},
},
            new Int16smallintArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
26599,

27377,

31348,

7293,

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
16309,

23647,

19535,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
32254,

26657,

4419,

},
    NullableValue = null,
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray2M)],
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IInt16ListsmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IInt16ListsmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray2M)],
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IInt16ListsmallintArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IInt16ListsmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatInt16smallintArray2M.AssertModel(models[0],_testData[16], false);FlatInt16smallintArray2M.AssertModel(models[1],_testData[17], false);FlatInt16smallintArray2M.AssertModel(models[2],_testData[18], false);FlatInt16smallintArray2M.AssertModel(models[3],_testData[19], false);FlatInt16smallintArray2M.AssertModel(models[4],_testData[20], false);FlatInt16smallintArray2M.AssertModel(models[5],_testData[21], false);FlatInt16smallintArray2M.AssertModel(models[6],_testData[22], false);FlatInt16smallintArray2M.AssertModel(models[7],_testData[23], false);FlatInt16smallintArray2M.AssertModel(models[8],_testData[24], false);FlatInt16smallintArray2M.AssertModel(models[9],_testData[25], false);FlatInt16smallintArray2M.AssertModel(models[10],_testData[26], false);FlatInt16smallintArray2M.AssertModel(models[11],_testData[27], false);FlatInt16smallintArray2M.AssertModel(models[12],_testData[28], false);FlatInt16smallintArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatInt16smallintArray2M.AssertModel(models[0],_testData[21], false);FlatInt16smallintArray2M.AssertModel(models[1],_testData[22], false);FlatInt16smallintArray2M.AssertModel(models[2],_testData[23], false);FlatInt16smallintArray2M.AssertModel(models[3],_testData[24], false);FlatInt16smallintArray2M.AssertModel(models[4],_testData[25], false);FlatInt16smallintArray2M.AssertModel(models[5],_testData[26], false);FlatInt16smallintArray2M.AssertModel(models[6],_testData[27], false);FlatInt16smallintArray2M.AssertModel(models[7],_testData[28], false);FlatInt16smallintArray2M.AssertModel(models[8],_testData[29], false);
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
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatInt16smallintArray2M.AssertModel(models[0],_testData[8], false);FlatInt16smallintArray2M.AssertModel(models[1],_testData[9], false);FlatInt16smallintArray2M.AssertModel(models[2],_testData[10], false);FlatInt16smallintArray2M.AssertModel(models[3],_testData[11], false);FlatInt16smallintArray2M.AssertModel(models[4],_testData[12], false);FlatInt16smallintArray2M.AssertModel(models[5],_testData[13], false);FlatInt16smallintArray2M.AssertModel(models[6],_testData[14], false);FlatInt16smallintArray2M.AssertModel(models[7],_testData[15], false);FlatInt16smallintArray2M.AssertModel(models[8],_testData[16], false);FlatInt16smallintArray2M.AssertModel(models[9],_testData[17], false);FlatInt16smallintArray2M.AssertModel(models[10],_testData[18], false);FlatInt16smallintArray2M.AssertModel(models[11],_testData[19], false);FlatInt16smallintArray2M.AssertModel(models[12],_testData[20], false);FlatInt16smallintArray2M.AssertModel(models[13],_testData[21], false);FlatInt16smallintArray2M.AssertModel(models[14],_testData[22], false);FlatInt16smallintArray2M.AssertModel(models[15],_testData[23], false);FlatInt16smallintArray2M.AssertModel(models[16],_testData[24], false);FlatInt16smallintArray2M.AssertModel(models[17],_testData[25], false);FlatInt16smallintArray2M.AssertModel(models[18],_testData[26], false);FlatInt16smallintArray2M.AssertModel(models[19],_testData[27], false);FlatInt16smallintArray2M.AssertModel(models[20],_testData[28], false);FlatInt16smallintArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatInt16smallintArray2M.AssertModel(models[0],_testData[28], false);FlatInt16smallintArray2M.AssertModel(models[1],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IInt16ListsmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Int16smallintArray2M.AssertModel(models[0],_testData[9], false);Int16smallintArray2M.AssertModel(models[1],_testData[10], false);Int16smallintArray2M.AssertModel(models[2],_testData[11], false);Int16smallintArray2M.AssertModel(models[3],_testData[12], false);Int16smallintArray2M.AssertModel(models[4],_testData[13], false);Int16smallintArray2M.AssertModel(models[5],_testData[14], false);Int16smallintArray2M.AssertModel(models[6],_testData[15], false);Int16smallintArray2M.AssertModel(models[7],_testData[16], false);Int16smallintArray2M.AssertModel(models[8],_testData[17], false);Int16smallintArray2M.AssertModel(models[9],_testData[18], false);Int16smallintArray2M.AssertModel(models[10],_testData[19], false);Int16smallintArray2M.AssertModel(models[11],_testData[20], false);Int16smallintArray2M.AssertModel(models[12],_testData[21], false);Int16smallintArray2M.AssertModel(models[13],_testData[22], false);Int16smallintArray2M.AssertModel(models[14],_testData[23], false);Int16smallintArray2M.AssertModel(models[15],_testData[24], false);Int16smallintArray2M.AssertModel(models[16],_testData[25], false);Int16smallintArray2M.AssertModel(models[17],_testData[26], false);Int16smallintArray2M.AssertModel(models[18],_testData[27], false);Int16smallintArray2M.AssertModel(models[19],_testData[28], false);Int16smallintArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
Int16smallintArray2M.AssertModel(models[0],_testData[1], false);Int16smallintArray2M.AssertModel(models[1],_testData[2], false);Int16smallintArray2M.AssertModel(models[2],_testData[3], false);Int16smallintArray2M.AssertModel(models[3],_testData[4], false);Int16smallintArray2M.AssertModel(models[4],_testData[5], false);Int16smallintArray2M.AssertModel(models[5],_testData[6], false);Int16smallintArray2M.AssertModel(models[6],_testData[7], false);Int16smallintArray2M.AssertModel(models[7],_testData[8], false);Int16smallintArray2M.AssertModel(models[8],_testData[9], false);Int16smallintArray2M.AssertModel(models[9],_testData[10], false);Int16smallintArray2M.AssertModel(models[10],_testData[11], false);Int16smallintArray2M.AssertModel(models[11],_testData[12], false);Int16smallintArray2M.AssertModel(models[12],_testData[13], false);Int16smallintArray2M.AssertModel(models[13],_testData[14], false);Int16smallintArray2M.AssertModel(models[14],_testData[15], false);Int16smallintArray2M.AssertModel(models[15],_testData[16], false);Int16smallintArray2M.AssertModel(models[16],_testData[17], false);Int16smallintArray2M.AssertModel(models[17],_testData[18], false);Int16smallintArray2M.AssertModel(models[18],_testData[19], false);Int16smallintArray2M.AssertModel(models[19],_testData[20], false);Int16smallintArray2M.AssertModel(models[20],_testData[21], false);Int16smallintArray2M.AssertModel(models[21],_testData[22], false);Int16smallintArray2M.AssertModel(models[22],_testData[23], false);Int16smallintArray2M.AssertModel(models[23],_testData[24], false);Int16smallintArray2M.AssertModel(models[24],_testData[25], false);Int16smallintArray2M.AssertModel(models[25],_testData[26], false);Int16smallintArray2M.AssertModel(models[26],_testData[27], false);Int16smallintArray2M.AssertModel(models[27],_testData[28], false);Int16smallintArray2M.AssertModel(models[28],_testData[29], false);
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

                var models =  ((IInt16ListsmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
Int16smallintArray2M.AssertModel(models[0],_testData[14], false);Int16smallintArray2M.AssertModel(models[1],_testData[15], false);Int16smallintArray2M.AssertModel(models[2],_testData[16], false);Int16smallintArray2M.AssertModel(models[3],_testData[17], false);Int16smallintArray2M.AssertModel(models[4],_testData[18], false);Int16smallintArray2M.AssertModel(models[5],_testData[19], false);Int16smallintArray2M.AssertModel(models[6],_testData[20], false);Int16smallintArray2M.AssertModel(models[7],_testData[21], false);Int16smallintArray2M.AssertModel(models[8],_testData[22], false);Int16smallintArray2M.AssertModel(models[9],_testData[23], false);Int16smallintArray2M.AssertModel(models[10],_testData[24], false);Int16smallintArray2M.AssertModel(models[11],_testData[25], false);Int16smallintArray2M.AssertModel(models[12],_testData[26], false);Int16smallintArray2M.AssertModel(models[13],_testData[27], false);Int16smallintArray2M.AssertModel(models[14],_testData[28], false);Int16smallintArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Int16smallintArray2M.AssertModel(models[0],_testData[22], false);Int16smallintArray2M.AssertModel(models[1],_testData[23], false);Int16smallintArray2M.AssertModel(models[2],_testData[24], false);Int16smallintArray2M.AssertModel(models[3],_testData[25], false);Int16smallintArray2M.AssertModel(models[4],_testData[26], false);Int16smallintArray2M.AssertModel(models[5],_testData[27], false);Int16smallintArray2M.AssertModel(models[6],_testData[28], false);Int16smallintArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 98, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatInt16smallintArray2M.AssertModel(models[0],_testData[21], false);FlatInt16smallintArray2M.AssertModel(models[1],_testData[22], false);FlatInt16smallintArray2M.AssertModel(models[2],_testData[23], false);FlatInt16smallintArray2M.AssertModel(models[3],_testData[24], false);FlatInt16smallintArray2M.AssertModel(models[4],_testData[25], false);FlatInt16smallintArray2M.AssertModel(models[5],_testData[26], false);FlatInt16smallintArray2M.AssertModel(models[6],_testData[27], false);FlatInt16smallintArray2M.AssertModel(models[7],_testData[28], false);FlatInt16smallintArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatInt16smallintArray2M.AssertModel(models[0],_testData[10], false);FlatInt16smallintArray2M.AssertModel(models[1],_testData[11], false);FlatInt16smallintArray2M.AssertModel(models[2],_testData[12], false);FlatInt16smallintArray2M.AssertModel(models[3],_testData[13], false);FlatInt16smallintArray2M.AssertModel(models[4],_testData[14], false);FlatInt16smallintArray2M.AssertModel(models[5],_testData[15], false);FlatInt16smallintArray2M.AssertModel(models[6],_testData[16], false);FlatInt16smallintArray2M.AssertModel(models[7],_testData[17], false);FlatInt16smallintArray2M.AssertModel(models[8],_testData[18], false);FlatInt16smallintArray2M.AssertModel(models[9],_testData[19], false);FlatInt16smallintArray2M.AssertModel(models[10],_testData[20], false);FlatInt16smallintArray2M.AssertModel(models[11],_testData[21], false);FlatInt16smallintArray2M.AssertModel(models[12],_testData[22], false);FlatInt16smallintArray2M.AssertModel(models[13],_testData[23], false);FlatInt16smallintArray2M.AssertModel(models[14],_testData[24], false);FlatInt16smallintArray2M.AssertModel(models[15],_testData[25], false);FlatInt16smallintArray2M.AssertModel(models[16],_testData[26], false);FlatInt16smallintArray2M.AssertModel(models[17],_testData[27], false);FlatInt16smallintArray2M.AssertModel(models[18],_testData[28], false);FlatInt16smallintArray2M.AssertModel(models[19],_testData[29], false);
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
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
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
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 1, query1, 1, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatInt16smallintArray2M.AssertModel(models[0],_testData[1], false);FlatInt16smallintArray2M.AssertModel(models[1],_testData[2], false);FlatInt16smallintArray2M.AssertModel(models[2],_testData[3], false);FlatInt16smallintArray2M.AssertModel(models[3],_testData[4], false);FlatInt16smallintArray2M.AssertModel(models[4],_testData[5], false);FlatInt16smallintArray2M.AssertModel(models[5],_testData[6], false);FlatInt16smallintArray2M.AssertModel(models[6],_testData[7], false);FlatInt16smallintArray2M.AssertModel(models[7],_testData[8], false);FlatInt16smallintArray2M.AssertModel(models[8],_testData[9], false);FlatInt16smallintArray2M.AssertModel(models[9],_testData[10], false);FlatInt16smallintArray2M.AssertModel(models[10],_testData[11], false);FlatInt16smallintArray2M.AssertModel(models[11],_testData[12], false);FlatInt16smallintArray2M.AssertModel(models[12],_testData[13], false);FlatInt16smallintArray2M.AssertModel(models[13],_testData[14], false);FlatInt16smallintArray2M.AssertModel(models[14],_testData[15], false);FlatInt16smallintArray2M.AssertModel(models[15],_testData[16], false);FlatInt16smallintArray2M.AssertModel(models[16],_testData[17], false);FlatInt16smallintArray2M.AssertModel(models[17],_testData[18], false);FlatInt16smallintArray2M.AssertModel(models[18],_testData[19], false);FlatInt16smallintArray2M.AssertModel(models[19],_testData[20], false);FlatInt16smallintArray2M.AssertModel(models[20],_testData[21], false);FlatInt16smallintArray2M.AssertModel(models[21],_testData[22], false);FlatInt16smallintArray2M.AssertModel(models[22],_testData[23], false);FlatInt16smallintArray2M.AssertModel(models[23],_testData[24], false);FlatInt16smallintArray2M.AssertModel(models[24],_testData[25], false);FlatInt16smallintArray2M.AssertModel(models[25],_testData[26], false);FlatInt16smallintArray2M.AssertModel(models[26],_testData[27], false);FlatInt16smallintArray2M.AssertModel(models[27],_testData[28], false);FlatInt16smallintArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatInt16smallintArray2M.AssertModel(models[0],_testData[1], false);FlatInt16smallintArray2M.AssertModel(models[1],_testData[2], false);FlatInt16smallintArray2M.AssertModel(models[2],_testData[3], false);FlatInt16smallintArray2M.AssertModel(models[3],_testData[4], false);FlatInt16smallintArray2M.AssertModel(models[4],_testData[5], false);FlatInt16smallintArray2M.AssertModel(models[5],_testData[6], false);FlatInt16smallintArray2M.AssertModel(models[6],_testData[7], false);FlatInt16smallintArray2M.AssertModel(models[7],_testData[8], false);FlatInt16smallintArray2M.AssertModel(models[8],_testData[9], false);FlatInt16smallintArray2M.AssertModel(models[9],_testData[10], false);FlatInt16smallintArray2M.AssertModel(models[10],_testData[11], false);FlatInt16smallintArray2M.AssertModel(models[11],_testData[12], false);FlatInt16smallintArray2M.AssertModel(models[12],_testData[13], false);FlatInt16smallintArray2M.AssertModel(models[13],_testData[14], false);FlatInt16smallintArray2M.AssertModel(models[14],_testData[15], false);FlatInt16smallintArray2M.AssertModel(models[15],_testData[16], false);FlatInt16smallintArray2M.AssertModel(models[16],_testData[17], false);FlatInt16smallintArray2M.AssertModel(models[17],_testData[18], false);FlatInt16smallintArray2M.AssertModel(models[18],_testData[19], false);FlatInt16smallintArray2M.AssertModel(models[19],_testData[20], false);FlatInt16smallintArray2M.AssertModel(models[20],_testData[21], false);FlatInt16smallintArray2M.AssertModel(models[21],_testData[22], false);FlatInt16smallintArray2M.AssertModel(models[22],_testData[23], false);FlatInt16smallintArray2M.AssertModel(models[23],_testData[24], false);FlatInt16smallintArray2M.AssertModel(models[24],_testData[25], false);FlatInt16smallintArray2M.AssertModel(models[25],_testData[26], false);FlatInt16smallintArray2M.AssertModel(models[26],_testData[27], false);FlatInt16smallintArray2M.AssertModel(models[27],_testData[28], false);FlatInt16smallintArray2M.AssertModel(models[28],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16ListsmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSelectModelBatchAsync(connection, 57, 32))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
Int16smallintArray2M.AssertModel(models[0],_testData[11], false);Int16smallintArray2M.AssertModel(models[1],_testData[12], false);Int16smallintArray2M.AssertModel(models[2],_testData[13], false);Int16smallintArray2M.AssertModel(models[3],_testData[14], false);Int16smallintArray2M.AssertModel(models[4],_testData[15], false);Int16smallintArray2M.AssertModel(models[5],_testData[16], false);Int16smallintArray2M.AssertModel(models[6],_testData[17], false);Int16smallintArray2M.AssertModel(models[7],_testData[18], false);Int16smallintArray2M.AssertModel(models[8],_testData[19], false);Int16smallintArray2M.AssertModel(models[9],_testData[20], false);Int16smallintArray2M.AssertModel(models[10],_testData[21], false);Int16smallintArray2M.AssertModel(models[11],_testData[22], false);Int16smallintArray2M.AssertModel(models[12],_testData[23], false);Int16smallintArray2M.AssertModel(models[13],_testData[24], false);Int16smallintArray2M.AssertModel(models[14],_testData[25], false);Int16smallintArray2M.AssertModel(models[15],_testData[26], false);Int16smallintArray2M.AssertModel(models[16],_testData[27], false);Int16smallintArray2M.AssertModel(models[17],_testData[28], false);Int16smallintArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Int16smallintArray2M.AssertModel(models[0],_testData[7], false);Int16smallintArray2M.AssertModel(models[1],_testData[8], false);Int16smallintArray2M.AssertModel(models[2],_testData[9], false);Int16smallintArray2M.AssertModel(models[3],_testData[10], false);Int16smallintArray2M.AssertModel(models[4],_testData[11], false);Int16smallintArray2M.AssertModel(models[5],_testData[12], false);Int16smallintArray2M.AssertModel(models[6],_testData[13], false);Int16smallintArray2M.AssertModel(models[7],_testData[14], false);Int16smallintArray2M.AssertModel(models[8],_testData[15], false);Int16smallintArray2M.AssertModel(models[9],_testData[16], false);Int16smallintArray2M.AssertModel(models[10],_testData[17], false);Int16smallintArray2M.AssertModel(models[11],_testData[18], false);Int16smallintArray2M.AssertModel(models[12],_testData[19], false);Int16smallintArray2M.AssertModel(models[13],_testData[20], false);Int16smallintArray2M.AssertModel(models[14],_testData[21], false);Int16smallintArray2M.AssertModel(models[15],_testData[22], false);Int16smallintArray2M.AssertModel(models[16],_testData[23], false);Int16smallintArray2M.AssertModel(models[17],_testData[24], false);Int16smallintArray2M.AssertModel(models[18],_testData[25], false);Int16smallintArray2M.AssertModel(models[19],_testData[26], false);Int16smallintArray2M.AssertModel(models[20],_testData[27], false);Int16smallintArray2M.AssertModel(models[21],_testData[28], false);Int16smallintArray2M.AssertModel(models[22],_testData[29], false);
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
                var models =  ((IInt16ListsmallintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSelectModelBatch(connection, 2, 2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Int16smallintArray2M.AssertModel(models[0],_testData[2], false);Int16smallintArray2M.AssertModel(models[1],_testData[3], false);Int16smallintArray2M.AssertModel(models[2],_testData[4], false);Int16smallintArray2M.AssertModel(models[3],_testData[5], false);Int16smallintArray2M.AssertModel(models[4],_testData[6], false);Int16smallintArray2M.AssertModel(models[5],_testData[7], false);Int16smallintArray2M.AssertModel(models[6],_testData[8], false);Int16smallintArray2M.AssertModel(models[7],_testData[9], false);Int16smallintArray2M.AssertModel(models[8],_testData[10], false);Int16smallintArray2M.AssertModel(models[9],_testData[11], false);Int16smallintArray2M.AssertModel(models[10],_testData[12], false);Int16smallintArray2M.AssertModel(models[11],_testData[13], false);Int16smallintArray2M.AssertModel(models[12],_testData[14], false);Int16smallintArray2M.AssertModel(models[13],_testData[15], false);Int16smallintArray2M.AssertModel(models[14],_testData[16], false);Int16smallintArray2M.AssertModel(models[15],_testData[17], false);Int16smallintArray2M.AssertModel(models[16],_testData[18], false);Int16smallintArray2M.AssertModel(models[17],_testData[19], false);Int16smallintArray2M.AssertModel(models[18],_testData[20], false);Int16smallintArray2M.AssertModel(models[19],_testData[21], false);Int16smallintArray2M.AssertModel(models[20],_testData[22], false);Int16smallintArray2M.AssertModel(models[21],_testData[23], false);Int16smallintArray2M.AssertModel(models[22],_testData[24], false);Int16smallintArray2M.AssertModel(models[23],_testData[25], false);Int16smallintArray2M.AssertModel(models[24],_testData[26], false);Int16smallintArray2M.AssertModel(models[25],_testData[27], false);Int16smallintArray2M.AssertModel(models[26],_testData[28], false);Int16smallintArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Int16smallintArray2M.AssertModel(models[0],_testData[2], false);Int16smallintArray2M.AssertModel(models[1],_testData[3], false);Int16smallintArray2M.AssertModel(models[2],_testData[4], false);Int16smallintArray2M.AssertModel(models[3],_testData[5], false);Int16smallintArray2M.AssertModel(models[4],_testData[6], false);Int16smallintArray2M.AssertModel(models[5],_testData[7], false);Int16smallintArray2M.AssertModel(models[6],_testData[8], false);Int16smallintArray2M.AssertModel(models[7],_testData[9], false);Int16smallintArray2M.AssertModel(models[8],_testData[10], false);Int16smallintArray2M.AssertModel(models[9],_testData[11], false);Int16smallintArray2M.AssertModel(models[10],_testData[12], false);Int16smallintArray2M.AssertModel(models[11],_testData[13], false);Int16smallintArray2M.AssertModel(models[12],_testData[14], false);Int16smallintArray2M.AssertModel(models[13],_testData[15], false);Int16smallintArray2M.AssertModel(models[14],_testData[16], false);Int16smallintArray2M.AssertModel(models[15],_testData[17], false);Int16smallintArray2M.AssertModel(models[16],_testData[18], false);Int16smallintArray2M.AssertModel(models[17],_testData[19], false);Int16smallintArray2M.AssertModel(models[18],_testData[20], false);Int16smallintArray2M.AssertModel(models[19],_testData[21], false);Int16smallintArray2M.AssertModel(models[20],_testData[22], false);Int16smallintArray2M.AssertModel(models[21],_testData[23], false);Int16smallintArray2M.AssertModel(models[22],_testData[24], false);Int16smallintArray2M.AssertModel(models[23],_testData[25], false);Int16smallintArray2M.AssertModel(models[24],_testData[26], false);Int16smallintArray2M.AssertModel(models[25],_testData[27], false);Int16smallintArray2M.AssertModel(models[26],_testData[28], false);Int16smallintArray2M.AssertModel(models[27],_testData[29], false);
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
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Int16smallintArray2M.AssertModel(models[0],_testData[7], false);Int16smallintArray2M.AssertModel(models[1],_testData[8], false);Int16smallintArray2M.AssertModel(models[2],_testData[9], false);Int16smallintArray2M.AssertModel(models[3],_testData[10], false);Int16smallintArray2M.AssertModel(models[4],_testData[11], false);Int16smallintArray2M.AssertModel(models[5],_testData[12], false);Int16smallintArray2M.AssertModel(models[6],_testData[13], false);Int16smallintArray2M.AssertModel(models[7],_testData[14], false);Int16smallintArray2M.AssertModel(models[8],_testData[15], false);Int16smallintArray2M.AssertModel(models[9],_testData[16], false);Int16smallintArray2M.AssertModel(models[10],_testData[17], false);Int16smallintArray2M.AssertModel(models[11],_testData[18], false);Int16smallintArray2M.AssertModel(models[12],_testData[19], false);Int16smallintArray2M.AssertModel(models[13],_testData[20], false);Int16smallintArray2M.AssertModel(models[14],_testData[21], false);Int16smallintArray2M.AssertModel(models[15],_testData[22], false);Int16smallintArray2M.AssertModel(models[16],_testData[23], false);Int16smallintArray2M.AssertModel(models[17],_testData[24], false);Int16smallintArray2M.AssertModel(models[18],_testData[25], false);Int16smallintArray2M.AssertModel(models[19],_testData[26], false);Int16smallintArray2M.AssertModel(models[20],_testData[27], false);Int16smallintArray2M.AssertModel(models[21],_testData[28], false);Int16smallintArray2M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models =  ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Int16smallintArray2M.AssertModel(models[0],_testData[18], false);Int16smallintArray2M.AssertModel(models[1],_testData[19], false);Int16smallintArray2M.AssertModel(models[2],_testData[20], false);Int16smallintArray2M.AssertModel(models[3],_testData[21], false);Int16smallintArray2M.AssertModel(models[4],_testData[22], false);Int16smallintArray2M.AssertModel(models[5],_testData[23], false);Int16smallintArray2M.AssertModel(models[6],_testData[24], false);Int16smallintArray2M.AssertModel(models[7],_testData[25], false);Int16smallintArray2M.AssertModel(models[8],_testData[26], false);Int16smallintArray2M.AssertModel(models[9],_testData[27], false);Int16smallintArray2M.AssertModel(models[10],_testData[28], false);Int16smallintArray2M.AssertModel(models[11],_testData[29], false);
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


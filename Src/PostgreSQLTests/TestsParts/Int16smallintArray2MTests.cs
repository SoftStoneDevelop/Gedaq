

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
new System.Collections.Generic.List<System.Int16>(4)
{
29270,

16282,

18512,

27679,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
13832,

10370,

2536,

9392,

},
},
            new Int16smallintArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15467,

12536,

6497,

4548,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
5025,

22455,

1286,

19748,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
10870,

29270,

20637,

28735,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
13029,

24364,

1813,

},
},
            new Int16smallintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
25171,

10613,

20374,

4970,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
18330,

9799,

5287,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
32433,

20893,

19162,

13219,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
9022,

20619,

12121,

32179,

},
},
            new Int16smallintArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
3033,

28782,

14566,

9181,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
26146,

19624,

22130,

14402,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
29182,

12475,

2571,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
20488,

15086,

31013,

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
24579,

18207,

21543,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
32589,

23260,

3532,

4953,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
29216,

18653,

29177,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
25691,

9843,

13401,

},
},
            new Int16smallintArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
10727,

5801,

26160,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
20383,

13732,

12567,

28229,

},
},
            new Int16smallintArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
18376,

29626,

22908,

10546,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2062,

13877,

15368,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
31891,

7507,

9147,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17709,

9900,

27216,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
12321,

5104,

15792,

},
},
            new Int16smallintArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
21360,

22708,

22920,

1019,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
5331,

6585,

31681,

2334,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
23301,

24076,

1038,

15492,

},
},
            new Int16smallintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
3133,

21084,

20116,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
22596,

9142,

17520,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
5418,

9261,

22125,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
10897,

31853,

1813,

10388,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
5036,

14672,

19871,

1242,

},
},
            new Int16smallintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
15361,

28647,

26308,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
22191,

23230,

20957,

30100,

},
},
            new Int16smallintArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
14004,

15814,

4322,

15371,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
16176,

27252,

25349,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
12721,

21820,

10605,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
6907,

25110,

30115,

},
},
            new Int16smallintArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
18483,

16971,

31945,

26444,

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
14175,

17151,

28705,

8400,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2612,

23457,

10039,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
2821,

14632,

13872,

24695,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
12356,

7032,

161,

22655,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
31386,

27580,

27347,

},
},
            new Int16smallintArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
7896,

12186,

7039,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15165,

15517,

14825,

13815,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
11613,

545,

17796,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
19380,

21586,

5240,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
16205,

4827,

2865,

},
},
            new Int16smallintArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
19076,

24378,

6409,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24571,

14808,

11443,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
30185,

19106,

3719,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
22581,

25486,

18120,

},
},
            new Int16smallintArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
5156,

27798,

26908,

32630,

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
4759,

1795,

29811,

22591,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
26030,

11687,

22495,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
4032,

7974,

830,

3280,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
31153,

4339,

9660,

},
},
            new Int16smallintArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
31800,

6723,

23681,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2425,

17709,

8304,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
30370,

984,

22943,

30120,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
25492,

7262,

23700,

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
3751,

19156,

30906,

13065,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
27748,

12821,

17110,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24141,

8893,

18030,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
18077,

17849,

10162,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16612,

26302,

6993,

29011,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
11600,

7059,

30732,

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[21],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[22],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[23],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[24],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallintArray2M.AssertModel(models[0],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int16smallintArray2M.AssertModel(models[0],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallintArray2M.AssertModel(models[0],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int16smallintArray2M.AssertModel(models[0],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 144, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 12, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                int resultIndex = 0;
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
                 ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 113, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 115, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 98, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 135, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 141, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int16smallintArray2M.AssertModel(models[0],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatch(connection, 7, 98))
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
                        Assert.That(models, Has.Count.EqualTo(16));

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
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models = await ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
Int16smallintArray2M.AssertModel(models[0],_testData[16], false);Int16smallintArray2M.AssertModel(models[1],_testData[17], false);Int16smallintArray2M.AssertModel(models[2],_testData[18], false);Int16smallintArray2M.AssertModel(models[3],_testData[19], false);Int16smallintArray2M.AssertModel(models[4],_testData[20], false);Int16smallintArray2M.AssertModel(models[5],_testData[21], false);Int16smallintArray2M.AssertModel(models[6],_testData[22], false);Int16smallintArray2M.AssertModel(models[7],_testData[23], false);Int16smallintArray2M.AssertModel(models[8],_testData[24], false);Int16smallintArray2M.AssertModel(models[9],_testData[25], false);Int16smallintArray2M.AssertModel(models[10],_testData[26], false);Int16smallintArray2M.AssertModel(models[11],_testData[27], false);Int16smallintArray2M.AssertModel(models[12],_testData[28], false);Int16smallintArray2M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 113);
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


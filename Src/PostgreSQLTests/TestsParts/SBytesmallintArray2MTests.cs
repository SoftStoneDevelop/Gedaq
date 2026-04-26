

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
    internal partial interface ISByteListsmallintArray
    {
    }
    
    internal partial class SByteListsmallintArray : ISByteListsmallintArray
    {


#region TestData

        private readonly SBytesmallintArray2M[] _testData = new SBytesmallintArray2M[]
        {
            new SBytesmallintArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
89,

9,

-9,

-82,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
11,

-5,

28,

104,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
21,

-5,

61,

4,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-73,

75,

-117,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-45,

117,

107,

},
},
            new SBytesmallintArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
63,

20,

-60,

-76,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-91,

26,

114,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-89,

38,

113,

-45,

},
},
            new SBytesmallintArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
7,

31,

121,

-127,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-79,

32,

-126,

},
},
            new SBytesmallintArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
32,

114,

-128,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
115,

112,

39,

-12,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-1,

-32,

126,

55,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-108,

-109,

-83,

31,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
31,

-91,

-88,

124,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-88,

-10,

-118,

57,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
69,

-56,

66,

},
},
            new SBytesmallintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
53,

120,

9,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
69,

-85,

-115,

-68,

},
},
            new SBytesmallintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-122,

28,

-14,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
7,

-8,

124,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
95,

-108,

9,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
77,

73,

25,

-76,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-119,

70,

27,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
97,

109,

-104,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-71,

1,

-27,

113,

},
},
            new SBytesmallintArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
44,

118,

14,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
52,

76,

8,

-75,

},
},
            new SBytesmallintArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-15,

-109,

-3,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-58,

90,

-38,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-83,

-32,

-37,

},
},
            new SBytesmallintArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-10,

-48,

15,

125,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
79,

-70,

19,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
101,

62,

92,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
64,

-32,

-65,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-103,

-89,

-4,

},
},
            new SBytesmallintArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
60,

116,

101,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-69,

79,

-15,

-11,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-51,

48,

38,

-101,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
92,

17,

102,

44,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-44,

-49,

-5,

-117,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
76,

78,

12,

-55,

},
},
            new SBytesmallintArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
102,

117,

23,

-62,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
24,

89,

-13,

-74,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-78,

-65,

-2,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-114,

-53,

-86,

103,

},
},
            new SBytesmallintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
60,

52,

80,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-121,

-100,

-37,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-40,

-10,

-16,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-109,

2,

-32,

72,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-4,

92,

114,

19,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
24,

4,

18,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-122,

60,

-54,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-83,

47,

-59,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-56,

-97,

-52,

},
},
            new SBytesmallintArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
59,

-112,

-11,

89,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
100,

-55,

-55,

99,

},
},
            new SBytesmallintArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
111,

37,

-61,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
49,

-66,

-41,

53,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
88,

-34,

35,

90,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-6,

-81,

81,

54,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
82,

115,

106,

-82,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
46,

-1,

11,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-2,

6,

-105,

43,

},
},
            new SBytesmallintArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
55,

-10,

27,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
43,

-53,

42,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-95,

103,

87,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-3,

-16,

-1,

-19,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-113,

-25,

72,

-112,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray2mi(
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
            asPartInterface: typeof(ISByteListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.SByte>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.SByte>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray2mi(
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
            queryMapTypes: [typeof(SBytesmallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.SByte>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.SByte>), 
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

                changedRows =  ((ISByteListsmallintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteListsmallintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISByteListsmallintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteListsmallintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISByteListsmallintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISByteListsmallintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray2m(
	id,
    value,
    nullablevalue,
    sbytesmallintarray2mi_id
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
            asPartInterface: typeof(ISByteListsmallintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.SByte>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.SByte>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallintarray2mi_id", 
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
                changedRows =  ((ISByteListsmallintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISByteListsmallintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISByteListsmallintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISByteListsmallintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray2m(
	id,
    value,
    nullablevalue,
    sbytesmallintarray2mi_id
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
    sbytesmallintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray2m(
	id,
    value,
    nullablevalue,
    sbytesmallintarray2mi_id
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
    sbytesmallintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.SByte>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.SByte>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallintarray2mi_id", 
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
                List<SBytesmallintArray2M> models = null;

                models =  ((ISByteListsmallintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((ISByteListsmallintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((ISByteListsmallintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((ISByteListsmallintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SBytesmallintArray2M> models = null;

                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((ISByteListsmallintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ISByteListsmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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

                var models = await ((ISByteListsmallintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((ISByteListsmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISByteListsmallintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ISByteListsmallintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
                var models = await ((ISByteListsmallintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteListsmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[11], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[12], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[13], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[14], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[15], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[16], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[17], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[18], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[11],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[12],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[13],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[14],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[15],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[16],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[17],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[4], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[5], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[6], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[7], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[8], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[9], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[10], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[11], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[12], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[13], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[14], false);FlatSBytesmallintArray2M.AssertModel(models[11],_testData[15], false);FlatSBytesmallintArray2M.AssertModel(models[12],_testData[16], false);FlatSBytesmallintArray2M.AssertModel(models[13],_testData[17], false);FlatSBytesmallintArray2M.AssertModel(models[14],_testData[18], false);FlatSBytesmallintArray2M.AssertModel(models[15],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[16],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[17],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[18],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[19],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[20],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[21],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[22],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[23],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[24],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[25],_testData[29], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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

                var models = await ((ISByteListsmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
SBytesmallintArray2M.AssertModel(models[0],_testData[1], false);SBytesmallintArray2M.AssertModel(models[1],_testData[2], false);SBytesmallintArray2M.AssertModel(models[2],_testData[3], false);SBytesmallintArray2M.AssertModel(models[3],_testData[4], false);SBytesmallintArray2M.AssertModel(models[4],_testData[5], false);SBytesmallintArray2M.AssertModel(models[5],_testData[6], false);SBytesmallintArray2M.AssertModel(models[6],_testData[7], false);SBytesmallintArray2M.AssertModel(models[7],_testData[8], false);SBytesmallintArray2M.AssertModel(models[8],_testData[9], false);SBytesmallintArray2M.AssertModel(models[9],_testData[10], false);SBytesmallintArray2M.AssertModel(models[10],_testData[11], false);SBytesmallintArray2M.AssertModel(models[11],_testData[12], false);SBytesmallintArray2M.AssertModel(models[12],_testData[13], false);SBytesmallintArray2M.AssertModel(models[13],_testData[14], false);SBytesmallintArray2M.AssertModel(models[14],_testData[15], false);SBytesmallintArray2M.AssertModel(models[15],_testData[16], false);SBytesmallintArray2M.AssertModel(models[16],_testData[17], false);SBytesmallintArray2M.AssertModel(models[17],_testData[18], false);SBytesmallintArray2M.AssertModel(models[18],_testData[19], false);SBytesmallintArray2M.AssertModel(models[19],_testData[20], false);SBytesmallintArray2M.AssertModel(models[20],_testData[21], false);SBytesmallintArray2M.AssertModel(models[21],_testData[22], false);SBytesmallintArray2M.AssertModel(models[22],_testData[23], false);SBytesmallintArray2M.AssertModel(models[23],_testData[24], false);SBytesmallintArray2M.AssertModel(models[24],_testData[25], false);SBytesmallintArray2M.AssertModel(models[25],_testData[26], false);SBytesmallintArray2M.AssertModel(models[26],_testData[27], false);SBytesmallintArray2M.AssertModel(models[27],_testData[28], false);SBytesmallintArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
SBytesmallintArray2M.AssertModel(models[0],_testData[5], false);SBytesmallintArray2M.AssertModel(models[1],_testData[6], false);SBytesmallintArray2M.AssertModel(models[2],_testData[7], false);SBytesmallintArray2M.AssertModel(models[3],_testData[8], false);SBytesmallintArray2M.AssertModel(models[4],_testData[9], false);SBytesmallintArray2M.AssertModel(models[5],_testData[10], false);SBytesmallintArray2M.AssertModel(models[6],_testData[11], false);SBytesmallintArray2M.AssertModel(models[7],_testData[12], false);SBytesmallintArray2M.AssertModel(models[8],_testData[13], false);SBytesmallintArray2M.AssertModel(models[9],_testData[14], false);SBytesmallintArray2M.AssertModel(models[10],_testData[15], false);SBytesmallintArray2M.AssertModel(models[11],_testData[16], false);SBytesmallintArray2M.AssertModel(models[12],_testData[17], false);SBytesmallintArray2M.AssertModel(models[13],_testData[18], false);SBytesmallintArray2M.AssertModel(models[14],_testData[19], false);SBytesmallintArray2M.AssertModel(models[15],_testData[20], false);SBytesmallintArray2M.AssertModel(models[16],_testData[21], false);SBytesmallintArray2M.AssertModel(models[17],_testData[22], false);SBytesmallintArray2M.AssertModel(models[18],_testData[23], false);SBytesmallintArray2M.AssertModel(models[19],_testData[24], false);SBytesmallintArray2M.AssertModel(models[20],_testData[25], false);SBytesmallintArray2M.AssertModel(models[21],_testData[26], false);SBytesmallintArray2M.AssertModel(models[22],_testData[27], false);SBytesmallintArray2M.AssertModel(models[23],_testData[28], false);SBytesmallintArray2M.AssertModel(models[24],_testData[29], false);
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

                var models =  ((ISByteListsmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
SBytesmallintArray2M.AssertModel(models[0],_testData[12], false);SBytesmallintArray2M.AssertModel(models[1],_testData[13], false);SBytesmallintArray2M.AssertModel(models[2],_testData[14], false);SBytesmallintArray2M.AssertModel(models[3],_testData[15], false);SBytesmallintArray2M.AssertModel(models[4],_testData[16], false);SBytesmallintArray2M.AssertModel(models[5],_testData[17], false);SBytesmallintArray2M.AssertModel(models[6],_testData[18], false);SBytesmallintArray2M.AssertModel(models[7],_testData[19], false);SBytesmallintArray2M.AssertModel(models[8],_testData[20], false);SBytesmallintArray2M.AssertModel(models[9],_testData[21], false);SBytesmallintArray2M.AssertModel(models[10],_testData[22], false);SBytesmallintArray2M.AssertModel(models[11],_testData[23], false);SBytesmallintArray2M.AssertModel(models[12],_testData[24], false);SBytesmallintArray2M.AssertModel(models[13],_testData[25], false);SBytesmallintArray2M.AssertModel(models[14],_testData[26], false);SBytesmallintArray2M.AssertModel(models[15],_testData[27], false);SBytesmallintArray2M.AssertModel(models[16],_testData[28], false);SBytesmallintArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
SBytesmallintArray2M.AssertModel(models[0],_testData[24], false);SBytesmallintArray2M.AssertModel(models[1],_testData[25], false);SBytesmallintArray2M.AssertModel(models[2],_testData[26], false);SBytesmallintArray2M.AssertModel(models[3],_testData[27], false);SBytesmallintArray2M.AssertModel(models[4],_testData[28], false);SBytesmallintArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
            asPartInterface: typeof(ISByteListsmallintArray)),
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 145, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[29], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 102, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[18], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[11],_testData[29], false);
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
FROM public.sbytesmallintarray2m m
LEFT JOIN public.sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
            asPartInterface: typeof(ISByteListsmallintArray)),
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
                var models = await ((ISByteListsmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionSelectModelBatchAsync(connection, 111, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
SBytesmallintArray2M.AssertModel(models[0],_testData[20], false);SBytesmallintArray2M.AssertModel(models[1],_testData[21], false);SBytesmallintArray2M.AssertModel(models[2],_testData[22], false);SBytesmallintArray2M.AssertModel(models[3],_testData[23], false);SBytesmallintArray2M.AssertModel(models[4],_testData[24], false);SBytesmallintArray2M.AssertModel(models[5],_testData[25], false);SBytesmallintArray2M.AssertModel(models[6],_testData[26], false);SBytesmallintArray2M.AssertModel(models[7],_testData[27], false);SBytesmallintArray2M.AssertModel(models[8],_testData[28], false);SBytesmallintArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
SBytesmallintArray2M.AssertModel(models[0],_testData[26], false);SBytesmallintArray2M.AssertModel(models[1],_testData[27], false);SBytesmallintArray2M.AssertModel(models[2],_testData[28], false);SBytesmallintArray2M.AssertModel(models[3],_testData[29], false);
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
                var models =  ((ISByteListsmallintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionSelectModelBatch(connection, 133, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
SBytesmallintArray2M.AssertModel(models[0],_testData[25], false);SBytesmallintArray2M.AssertModel(models[1],_testData[26], false);SBytesmallintArray2M.AssertModel(models[2],_testData[27], false);SBytesmallintArray2M.AssertModel(models[3],_testData[28], false);SBytesmallintArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
SBytesmallintArray2M.AssertModel(models[0],_testData[5], false);SBytesmallintArray2M.AssertModel(models[1],_testData[6], false);SBytesmallintArray2M.AssertModel(models[2],_testData[7], false);SBytesmallintArray2M.AssertModel(models[3],_testData[8], false);SBytesmallintArray2M.AssertModel(models[4],_testData[9], false);SBytesmallintArray2M.AssertModel(models[5],_testData[10], false);SBytesmallintArray2M.AssertModel(models[6],_testData[11], false);SBytesmallintArray2M.AssertModel(models[7],_testData[12], false);SBytesmallintArray2M.AssertModel(models[8],_testData[13], false);SBytesmallintArray2M.AssertModel(models[9],_testData[14], false);SBytesmallintArray2M.AssertModel(models[10],_testData[15], false);SBytesmallintArray2M.AssertModel(models[11],_testData[16], false);SBytesmallintArray2M.AssertModel(models[12],_testData[17], false);SBytesmallintArray2M.AssertModel(models[13],_testData[18], false);SBytesmallintArray2M.AssertModel(models[14],_testData[19], false);SBytesmallintArray2M.AssertModel(models[15],_testData[20], false);SBytesmallintArray2M.AssertModel(models[16],_testData[21], false);SBytesmallintArray2M.AssertModel(models[17],_testData[22], false);SBytesmallintArray2M.AssertModel(models[18],_testData[23], false);SBytesmallintArray2M.AssertModel(models[19],_testData[24], false);SBytesmallintArray2M.AssertModel(models[20],_testData[25], false);SBytesmallintArray2M.AssertModel(models[21],_testData[26], false);SBytesmallintArray2M.AssertModel(models[22],_testData[27], false);SBytesmallintArray2M.AssertModel(models[23],_testData[28], false);SBytesmallintArray2M.AssertModel(models[24],_testData[29], false);
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
                await using var cmd = await ((ISByteListsmallintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models = await ((ISByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
SBytesmallintArray2M.AssertModel(models[0],_testData[12], false);SBytesmallintArray2M.AssertModel(models[1],_testData[13], false);SBytesmallintArray2M.AssertModel(models[2],_testData[14], false);SBytesmallintArray2M.AssertModel(models[3],_testData[15], false);SBytesmallintArray2M.AssertModel(models[4],_testData[16], false);SBytesmallintArray2M.AssertModel(models[5],_testData[17], false);SBytesmallintArray2M.AssertModel(models[6],_testData[18], false);SBytesmallintArray2M.AssertModel(models[7],_testData[19], false);SBytesmallintArray2M.AssertModel(models[8],_testData[20], false);SBytesmallintArray2M.AssertModel(models[9],_testData[21], false);SBytesmallintArray2M.AssertModel(models[10],_testData[22], false);SBytesmallintArray2M.AssertModel(models[11],_testData[23], false);SBytesmallintArray2M.AssertModel(models[12],_testData[24], false);SBytesmallintArray2M.AssertModel(models[13],_testData[25], false);SBytesmallintArray2M.AssertModel(models[14],_testData[26], false);SBytesmallintArray2M.AssertModel(models[15],_testData[27], false);SBytesmallintArray2M.AssertModel(models[16],_testData[28], false);SBytesmallintArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((ISByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
SBytesmallintArray2M.AssertModel(models[0],_testData[23], false);SBytesmallintArray2M.AssertModel(models[1],_testData[24], false);SBytesmallintArray2M.AssertModel(models[2],_testData[25], false);SBytesmallintArray2M.AssertModel(models[3],_testData[26], false);SBytesmallintArray2M.AssertModel(models[4],_testData[27], false);SBytesmallintArray2M.AssertModel(models[5],_testData[28], false);SBytesmallintArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MI)],
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
            asPartInterface: typeof(ISByteListsmallintArray))]
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
FROM public.binary_sbytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SBytesmallintArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISByteListsmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteListsmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(actual, expect, false);
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
                await ((ISByteListsmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ISByteListsmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
sbytesmallintarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
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
            asPartInterface: typeof(ISByteListsmallintArray))]
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
FROM public.binary_sbytesmallintarray2m m
LEFT JOIN public.binary_sbytesmallintarray2mi mi ON mi.id = m.sbytesmallintarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SBytesmallintArray2M>(15);

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
                ((ISByteListsmallintArray)this).ImportModel(connection, importCollection);
                var models = ((ISByteListsmallintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SBytesmallintArray2M.AssertModel(models[0],_testData[0], false);
                SBytesmallintArray2M.AssertModel(models[1],_testData[1], false);
                SBytesmallintArray2M.AssertModel(models[2],_testData[2], false);
                SBytesmallintArray2M.AssertModel(models[3],_testData[3], false);
                SBytesmallintArray2M.AssertModel(models[4],_testData[4], false);
                SBytesmallintArray2M.AssertModel(models[5],_testData[5], false);
                SBytesmallintArray2M.AssertModel(models[6],_testData[6], false);
                SBytesmallintArray2M.AssertModel(models[7],_testData[7], false);
                SBytesmallintArray2M.AssertModel(models[8],_testData[8], false);
                SBytesmallintArray2M.AssertModel(models[9],_testData[9], false);
                SBytesmallintArray2M.AssertModel(models[10],_testData[10], false);
                SBytesmallintArray2M.AssertModel(models[11],_testData[11], false);
                SBytesmallintArray2M.AssertModel(models[12],_testData[12], false);
                SBytesmallintArray2M.AssertModel(models[13],_testData[13], false);
                SBytesmallintArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((ISByteListsmallintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ISByteListsmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SBytesmallintArray2M.AssertModel(models[0],_testData[0], false);
                SBytesmallintArray2M.AssertModel(models[1],_testData[1], false);
                SBytesmallintArray2M.AssertModel(models[2],_testData[2], false);
                SBytesmallintArray2M.AssertModel(models[3],_testData[3], false);
                SBytesmallintArray2M.AssertModel(models[4],_testData[4], false);
                SBytesmallintArray2M.AssertModel(models[5],_testData[5], false);
                SBytesmallintArray2M.AssertModel(models[6],_testData[6], false);
                SBytesmallintArray2M.AssertModel(models[7],_testData[7], false);
                SBytesmallintArray2M.AssertModel(models[8],_testData[8], false);
                SBytesmallintArray2M.AssertModel(models[9],_testData[9], false);
                SBytesmallintArray2M.AssertModel(models[10],_testData[10], false);
                SBytesmallintArray2M.AssertModel(models[11],_testData[11], false);
                SBytesmallintArray2M.AssertModel(models[12],_testData[12], false);
                SBytesmallintArray2M.AssertModel(models[13],_testData[13], false);
                SBytesmallintArray2M.AssertModel(models[14],_testData[14], false);
                SBytesmallintArray2M.AssertModel(models[15],_testData[15], false);
                SBytesmallintArray2M.AssertModel(models[16],_testData[16], false);
                SBytesmallintArray2M.AssertModel(models[17],_testData[17], false);
                SBytesmallintArray2M.AssertModel(models[18],_testData[18], false);
                SBytesmallintArray2M.AssertModel(models[19],_testData[19], false);
                SBytesmallintArray2M.AssertModel(models[20],_testData[20], false);
                SBytesmallintArray2M.AssertModel(models[21],_testData[21], false);
                SBytesmallintArray2M.AssertModel(models[22],_testData[22], false);
                SBytesmallintArray2M.AssertModel(models[23],_testData[23], false);
                SBytesmallintArray2M.AssertModel(models[24],_testData[24], false);
                SBytesmallintArray2M.AssertModel(models[25],_testData[25], false);
                SBytesmallintArray2M.AssertModel(models[26],_testData[26], false);
                SBytesmallintArray2M.AssertModel(models[27],_testData[27], false);
                SBytesmallintArray2M.AssertModel(models[28],_testData[28], false);
                SBytesmallintArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    sbytesmallintarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SBytesmallintArray2M)],
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
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteListsmallintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteListsmallintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MI)],
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
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteListsmallintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteListsmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


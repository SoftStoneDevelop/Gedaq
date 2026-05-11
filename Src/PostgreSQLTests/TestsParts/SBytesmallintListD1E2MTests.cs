

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
    internal partial interface ISByteListsmallintListD1
    {
    }
    
    internal partial class SByteListsmallintListD1 : ISByteListsmallintListD1
    {


#region TestData

        private readonly SBytesmallintListD1E2M[] _testData = new SBytesmallintListD1E2M[]
        {
            new SBytesmallintListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
88,

15,

99,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
63,

109,

-74,

-43,

},
},
            new SBytesmallintListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-44,

83,

37,

57,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
124,

41,

12,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
32,

7,

60,

},
},
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-117,

-5,

-22,

58,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
87,

-97,

59,

},
},
            new SBytesmallintListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-19,

72,

119,

115,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
36,

79,

62,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-91,

-22,

97,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-83,

-117,

-86,

-109,

},
},
            new SBytesmallintListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-31,

-21,

13,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
51,

-96,

78,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-84,

10,

-120,

61,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-97,

19,

-57,

17,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
11,

66,

53,

-9,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-118,

92,

52,

},
},
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
19,

-9,

98,

104,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
101,

-50,

-112,

},
},
            new SBytesmallintListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
85,

-30,

-3,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
67,

87,

-72,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-86,

29,

-65,

94,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
101,

-2,

-69,

-31,

},
},
            new SBytesmallintListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
26,

-32,

-37,

-126,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
92,

99,

-4,

},
},
            new SBytesmallintListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
20,

16,

-102,

33,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
72,

65,

-17,

47,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
119,

70,

114,

69,

},
},
            new SBytesmallintListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-50,

-76,

-23,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-123,

98,

97,

69,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
108,

-25,

32,

-37,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
3,

76,

-21,

-87,

},
},
            new SBytesmallintListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-128,

-103,

-15,

90,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-60,

32,

73,

},
},
            new SBytesmallintListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-81,

-79,

-82,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-65,

-101,

76,

57,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
45,

-91,

-23,

},
},
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-33,

110,

46,

-59,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-119,

18,

45,

},
},
            new SBytesmallintListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
8,

122,

-54,

2,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-104,

-60,

99,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
91,

-122,

-74,

},
},
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-51,

50,

67,

63,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-88,

-30,

-34,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
42,

63,

-64,

-27,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
104,

-16,

114,

},
},
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
24,

-70,

89,

38,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
36,

-45,

-24,

88,

},
},
            new SBytesmallintListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-107,

11,

-89,

74,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
103,

-50,

-117,

-23,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
119,

75,

-48,

117,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-41,

-73,

-3,

},
},
            new SBytesmallintListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
100,

-76,

107,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
102,

-50,

90,

-85,

},
},
            new SBytesmallintListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-116,

-39,

35,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
122,

-1,

94,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
125,

-90,

49,

},
},
            new SBytesmallintListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-58,

-66,

49,

6,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-15,

-18,

-126,

},
},
            new SBytesmallintListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-86,

-34,

-97,

90,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-100,

-114,

-48,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-13,

-103,

91,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
57,

-56,

84,

},
},
            new SBytesmallintListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-105,

-121,

-77,

125,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-2,

-37,

-52,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-34,

-50,

-64,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-43,

-127,

74,

113,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
81,

-65,

-57,

-53,

},
},
            new SBytesmallintListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-40,

-80,

73,

-86,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-48,

-28,

-68,

84,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-54,

-35,

-68,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
52,

-91,

-16,

-19,

},
},
            new SBytesmallintListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
10,

80,

-26,

101,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
58,

88,

-87,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-119,

61,

10,

-114,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
39,

-99,

-13,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-95,

19,

-63,

},
    ModelInner = new SBytesmallintListD1E2MI
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
61,

7,

-62,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-14,

-110,

-128,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-35,

-38,

82,

},
},
            new SBytesmallintListD1E2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
63,

-5,

109,

-103,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
84,

-84,

9,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintlistd1e2mi(
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
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
INSERT INTO public.sbytesmallintlistd1e2mi(
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
            queryMapTypes: [typeof(SBytesmallintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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

                changedRows =  ((ISByteListsmallintListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteListsmallintListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISByteListsmallintListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteListsmallintListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISByteListsmallintListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISByteListsmallintListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISByteListsmallintListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintlistd1e2m(
	id,
    value,
    nullablevalue,
    sbytesmallintlistd1e2mi_id
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
            asPartInterface: typeof(ISByteListsmallintListD1)), 
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
                methodParametrName: "sbytesmallintlistd1e2mi_id", 
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
                changedRows =  ((ISByteListsmallintListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISByteListsmallintListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISByteListsmallintListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISByteListsmallintListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintlistd1e2m(
	id,
    value,
    nullablevalue,
    sbytesmallintlistd1e2mi_id
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
    sbytesmallintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SBytesmallintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintlistd1e2m(
	id,
    value,
    nullablevalue,
    sbytesmallintlistd1e2mi_id
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
    sbytesmallintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SBytesmallintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                methodParametrName: "sbytesmallintlistd1e2mi_id", 
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
                List<SBytesmallintListD1E2M> models = null;

                models =  ((ISByteListsmallintListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((ISByteListsmallintListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((ISByteListsmallintListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((ISByteListsmallintListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SBytesmallintListD1E2M> models = null;

                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((ISByteListsmallintListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintListD1E2M), typeof(FlatSBytesmallintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
FROM public.sbytesmallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintListD1E2M>();
                var models2 = new List<FlatSBytesmallintListD1E2M>();
                await ((ISByteListsmallintListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintListD1E2M>();
                var models2 = new List<FlatSBytesmallintListD1E2M>();
                ((ISByteListsmallintListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
FROM public.sbytesmallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISByteListsmallintListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISByteListsmallintListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
LEFT JOIN public.sbytesmallintlistd1e2mi mi ON mi.id = m.sbytesmallintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models = await ((ISByteListsmallintListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISByteListsmallintListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintListD1E2M), typeof(FlatSBytesmallintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
FROM public.sbytesmallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintListD1E2M>();
                var models2 = new List<FlatSBytesmallintListD1E2M>();
                await ((ISByteListsmallintListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintListD1E2M>();
                var models2 = new List<FlatSBytesmallintListD1E2M>();
                ((ISByteListsmallintListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
FROM public.sbytesmallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISByteListsmallintListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISByteListsmallintListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
LEFT JOIN public.sbytesmallintlistd1e2mi mi ON mi.id = m.sbytesmallintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SBytesmallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models = await ((ISByteListsmallintListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISByteListsmallintListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintListD1E2M), typeof(FlatSBytesmallintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintListD1E2M>();
                var models2 = new List<FlatSBytesmallintListD1E2M>();
                await((ISByteListsmallintListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var firstItems2 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems2 = new List<FlatSBytesmallintListD1E2M>();
                await ((ISByteListsmallintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var firstItems2 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                await ((ISByteListsmallintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintListD1E2M>();
                var models2 = new List<FlatSBytesmallintListD1E2M>();
                ((ISByteListsmallintListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var firstItems2 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems2 = new List<FlatSBytesmallintListD1E2M>();
                 ((ISByteListsmallintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var firstItems2 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                 ((ISByteListsmallintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISByteListsmallintListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteListsmallintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSBytesmallintListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSBytesmallintListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 44;
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems2 = new List<FlatSBytesmallintListD1E2M>();
                await ((ISByteListsmallintListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISByteListsmallintListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteListsmallintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSBytesmallintListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSBytesmallintListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems2 = new List<FlatSBytesmallintListD1E2M>();
                 ((ISByteListsmallintListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
LEFT JOIN public.sbytesmallintlistd1e2mi mi ON mi.id = m.sbytesmallintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models = await((ISByteListsmallintListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteListsmallintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SBytesmallintListD1E2M.AssertModel(models[0],_testData[10], false);
                        SBytesmallintListD1E2M.AssertModel(models[1],_testData[11], false);
                        SBytesmallintListD1E2M.AssertModel(models[2],_testData[12], false);
                        SBytesmallintListD1E2M.AssertModel(models[3],_testData[13], false);
                        SBytesmallintListD1E2M.AssertModel(models[4],_testData[14], false);
                        SBytesmallintListD1E2M.AssertModel(models[5],_testData[15], false);
                        SBytesmallintListD1E2M.AssertModel(models[6],_testData[16], false);
                        SBytesmallintListD1E2M.AssertModel(models[7],_testData[17], false);
                        SBytesmallintListD1E2M.AssertModel(models[8],_testData[18], false);
                        SBytesmallintListD1E2M.AssertModel(models[9],_testData[19], false);
                        SBytesmallintListD1E2M.AssertModel(models[10],_testData[20], false);
                        SBytesmallintListD1E2M.AssertModel(models[11],_testData[21], false);
                        SBytesmallintListD1E2M.AssertModel(models[12],_testData[22], false);
                        SBytesmallintListD1E2M.AssertModel(models[13],_testData[23], false);
                        SBytesmallintListD1E2M.AssertModel(models[14],_testData[24], false);
                        SBytesmallintListD1E2M.AssertModel(models[15],_testData[25], false);
                        SBytesmallintListD1E2M.AssertModel(models[16],_testData[26], false);
                        SBytesmallintListD1E2M.AssertModel(models[17],_testData[27], false);
                        SBytesmallintListD1E2M.AssertModel(models[18],_testData[28], false);
                        SBytesmallintListD1E2M.AssertModel(models[19],_testData[29], false);
                        SBytesmallintListD1E2M.AssertModel(models[20],_testData[30], false);
                        SBytesmallintListD1E2M.AssertModel(models[21],_testData[31], false);
                        SBytesmallintListD1E2M.AssertModel(models[22],_testData[32], false);
                        SBytesmallintListD1E2M.AssertModel(models[23],_testData[33], false);
                        SBytesmallintListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        SBytesmallintListD1E2M.AssertModel(models[0],_testData[25], false);
                        SBytesmallintListD1E2M.AssertModel(models[1],_testData[26], false);
                        SBytesmallintListD1E2M.AssertModel(models[2],_testData[27], false);
                        SBytesmallintListD1E2M.AssertModel(models[3],_testData[28], false);
                        SBytesmallintListD1E2M.AssertModel(models[4],_testData[29], false);
                        SBytesmallintListD1E2M.AssertModel(models[5],_testData[30], false);
                        SBytesmallintListD1E2M.AssertModel(models[6],_testData[31], false);
                        SBytesmallintListD1E2M.AssertModel(models[7],_testData[32], false);
                        SBytesmallintListD1E2M.AssertModel(models[8],_testData[33], false);
                        SBytesmallintListD1E2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((ISByteListsmallintListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteListsmallintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        SBytesmallintListD1E2M.AssertModel(models[0],_testData[32], false);
                        SBytesmallintListD1E2M.AssertModel(models[1],_testData[33], false);
                        SBytesmallintListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SBytesmallintListD1E2M.AssertModel(models[0],_testData[33], false);
                        SBytesmallintListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintListD1E2M), typeof(FlatSBytesmallintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintListD1E2M>();
                var models2 = new List<FlatSBytesmallintListD1E2M>();
                await((ISByteListsmallintListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var firstItems2 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems2 = new List<FlatSBytesmallintListD1E2M>();
                await ((ISByteListsmallintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 63, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var firstItems2 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                await ((ISByteListsmallintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 172, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintListD1E2M>();
                var models2 = new List<FlatSBytesmallintListD1E2M>();
                ((ISByteListsmallintListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var firstItems2 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems2 = new List<FlatSBytesmallintListD1E2M>();
                 ((ISByteListsmallintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var firstItems2 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                 ((ISByteListsmallintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 162, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISByteListsmallintListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteListsmallintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 43, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSBytesmallintListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSBytesmallintListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[4],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems2 = new List<FlatSBytesmallintListD1E2M>();
                await ((ISByteListsmallintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 139, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISByteListsmallintListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteListsmallintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 139, query1, 156, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSBytesmallintListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSBytesmallintListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(models[6],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
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
FROM public.sbytesmallintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems1 = new List<FlatSBytesmallintListD1E2M>();
                var secondItems2 = new List<FlatSBytesmallintListD1E2M>();
                 ((ISByteListsmallintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 43, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatSBytesmallintListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.sbytesmallintlistd1e2m m
LEFT JOIN public.sbytesmallintlistd1e2mi mi ON mi.id = m.sbytesmallintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SBytesmallintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models = await((ISByteListsmallintListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISByteListsmallintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        SBytesmallintListD1E2M.AssertModel(models[0],_testData[14], false);
                        SBytesmallintListD1E2M.AssertModel(models[1],_testData[15], false);
                        SBytesmallintListD1E2M.AssertModel(models[2],_testData[16], false);
                        SBytesmallintListD1E2M.AssertModel(models[3],_testData[17], false);
                        SBytesmallintListD1E2M.AssertModel(models[4],_testData[18], false);
                        SBytesmallintListD1E2M.AssertModel(models[5],_testData[19], false);
                        SBytesmallintListD1E2M.AssertModel(models[6],_testData[20], false);
                        SBytesmallintListD1E2M.AssertModel(models[7],_testData[21], false);
                        SBytesmallintListD1E2M.AssertModel(models[8],_testData[22], false);
                        SBytesmallintListD1E2M.AssertModel(models[9],_testData[23], false);
                        SBytesmallintListD1E2M.AssertModel(models[10],_testData[24], false);
                        SBytesmallintListD1E2M.AssertModel(models[11],_testData[25], false);
                        SBytesmallintListD1E2M.AssertModel(models[12],_testData[26], false);
                        SBytesmallintListD1E2M.AssertModel(models[13],_testData[27], false);
                        SBytesmallintListD1E2M.AssertModel(models[14],_testData[28], false);
                        SBytesmallintListD1E2M.AssertModel(models[15],_testData[29], false);
                        SBytesmallintListD1E2M.AssertModel(models[16],_testData[30], false);
                        SBytesmallintListD1E2M.AssertModel(models[17],_testData[31], false);
                        SBytesmallintListD1E2M.AssertModel(models[18],_testData[32], false);
                        SBytesmallintListD1E2M.AssertModel(models[19],_testData[33], false);
                        SBytesmallintListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SBytesmallintListD1E2M.AssertModel(models[0],_testData[24], false);
                        SBytesmallintListD1E2M.AssertModel(models[1],_testData[25], false);
                        SBytesmallintListD1E2M.AssertModel(models[2],_testData[26], false);
                        SBytesmallintListD1E2M.AssertModel(models[3],_testData[27], false);
                        SBytesmallintListD1E2M.AssertModel(models[4],_testData[28], false);
                        SBytesmallintListD1E2M.AssertModel(models[5],_testData[29], false);
                        SBytesmallintListD1E2M.AssertModel(models[6],_testData[30], false);
                        SBytesmallintListD1E2M.AssertModel(models[7],_testData[31], false);
                        SBytesmallintListD1E2M.AssertModel(models[8],_testData[32], false);
                        SBytesmallintListD1E2M.AssertModel(models[9],_testData[33], false);
                        SBytesmallintListD1E2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((ISByteListsmallintListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISByteListsmallintListD1)this).DbConnectionSTSelectModelBatch(connection, 124, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        SBytesmallintListD1E2M.AssertModel(models[0],_testData[22], false);
                        SBytesmallintListD1E2M.AssertModel(models[1],_testData[23], false);
                        SBytesmallintListD1E2M.AssertModel(models[2],_testData[24], false);
                        SBytesmallintListD1E2M.AssertModel(models[3],_testData[25], false);
                        SBytesmallintListD1E2M.AssertModel(models[4],_testData[26], false);
                        SBytesmallintListD1E2M.AssertModel(models[5],_testData[27], false);
                        SBytesmallintListD1E2M.AssertModel(models[6],_testData[28], false);
                        SBytesmallintListD1E2M.AssertModel(models[7],_testData[29], false);
                        SBytesmallintListD1E2M.AssertModel(models[8],_testData[30], false);
                        SBytesmallintListD1E2M.AssertModel(models[9],_testData[31], false);
                        SBytesmallintListD1E2M.AssertModel(models[10],_testData[32], false);
                        SBytesmallintListD1E2M.AssertModel(models[11],_testData[33], false);
                        SBytesmallintListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        SBytesmallintListD1E2M.AssertModel(models[0],_testData[14], false);
                        SBytesmallintListD1E2M.AssertModel(models[1],_testData[15], false);
                        SBytesmallintListD1E2M.AssertModel(models[2],_testData[16], false);
                        SBytesmallintListD1E2M.AssertModel(models[3],_testData[17], false);
                        SBytesmallintListD1E2M.AssertModel(models[4],_testData[18], false);
                        SBytesmallintListD1E2M.AssertModel(models[5],_testData[19], false);
                        SBytesmallintListD1E2M.AssertModel(models[6],_testData[20], false);
                        SBytesmallintListD1E2M.AssertModel(models[7],_testData[21], false);
                        SBytesmallintListD1E2M.AssertModel(models[8],_testData[22], false);
                        SBytesmallintListD1E2M.AssertModel(models[9],_testData[23], false);
                        SBytesmallintListD1E2M.AssertModel(models[10],_testData[24], false);
                        SBytesmallintListD1E2M.AssertModel(models[11],_testData[25], false);
                        SBytesmallintListD1E2M.AssertModel(models[12],_testData[26], false);
                        SBytesmallintListD1E2M.AssertModel(models[13],_testData[27], false);
                        SBytesmallintListD1E2M.AssertModel(models[14],_testData[28], false);
                        SBytesmallintListD1E2M.AssertModel(models[15],_testData[29], false);
                        SBytesmallintListD1E2M.AssertModel(models[16],_testData[30], false);
                        SBytesmallintListD1E2M.AssertModel(models[17],_testData[31], false);
                        SBytesmallintListD1E2M.AssertModel(models[18],_testData[32], false);
                        SBytesmallintListD1E2M.AssertModel(models[19],_testData[33], false);
                        SBytesmallintListD1E2M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((ISByteListsmallintListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteListsmallintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((ISByteListsmallintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                SBytesmallintListD1E2M.AssertModel(models[0],_testData[18], false);
                SBytesmallintListD1E2M.AssertModel(models[1],_testData[19], false);
                SBytesmallintListD1E2M.AssertModel(models[2],_testData[20], false);
                SBytesmallintListD1E2M.AssertModel(models[3],_testData[21], false);
                SBytesmallintListD1E2M.AssertModel(models[4],_testData[22], false);
                SBytesmallintListD1E2M.AssertModel(models[5],_testData[23], false);
                SBytesmallintListD1E2M.AssertModel(models[6],_testData[24], false);
                SBytesmallintListD1E2M.AssertModel(models[7],_testData[25], false);
                SBytesmallintListD1E2M.AssertModel(models[8],_testData[26], false);
                SBytesmallintListD1E2M.AssertModel(models[9],_testData[27], false);
                SBytesmallintListD1E2M.AssertModel(models[10],_testData[28], false);
                SBytesmallintListD1E2M.AssertModel(models[11],_testData[29], false);
                SBytesmallintListD1E2M.AssertModel(models[12],_testData[30], false);
                SBytesmallintListD1E2M.AssertModel(models[13],_testData[31], false);
                SBytesmallintListD1E2M.AssertModel(models[14],_testData[32], false);
                SBytesmallintListD1E2M.AssertModel(models[15],_testData[33], false);
                SBytesmallintListD1E2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteListsmallintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteListsmallintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((ISByteListsmallintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                SBytesmallintListD1E2M.AssertModel(models[0],_testData[15], false);
                SBytesmallintListD1E2M.AssertModel(models[1],_testData[16], false);
                SBytesmallintListD1E2M.AssertModel(models[2],_testData[17], false);
                SBytesmallintListD1E2M.AssertModel(models[3],_testData[18], false);
                SBytesmallintListD1E2M.AssertModel(models[4],_testData[19], false);
                SBytesmallintListD1E2M.AssertModel(models[5],_testData[20], false);
                SBytesmallintListD1E2M.AssertModel(models[6],_testData[21], false);
                SBytesmallintListD1E2M.AssertModel(models[7],_testData[22], false);
                SBytesmallintListD1E2M.AssertModel(models[8],_testData[23], false);
                SBytesmallintListD1E2M.AssertModel(models[9],_testData[24], false);
                SBytesmallintListD1E2M.AssertModel(models[10],_testData[25], false);
                SBytesmallintListD1E2M.AssertModel(models[11],_testData[26], false);
                SBytesmallintListD1E2M.AssertModel(models[12],_testData[27], false);
                SBytesmallintListD1E2M.AssertModel(models[13],_testData[28], false);
                SBytesmallintListD1E2M.AssertModel(models[14],_testData[29], false);
                SBytesmallintListD1E2M.AssertModel(models[15],_testData[30], false);
                SBytesmallintListD1E2M.AssertModel(models[16],_testData[31], false);
                SBytesmallintListD1E2M.AssertModel(models[17],_testData[32], false);
                SBytesmallintListD1E2M.AssertModel(models[18],_testData[33], false);
                SBytesmallintListD1E2M.AssertModel(models[19],_testData[34], false);
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
FROM public.binary_sbytesmallintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SBytesmallintListD1E2MIWA),
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
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteListsmallintListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteListsmallintListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteListsmallintListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteListsmallintListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SBytesmallintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteListsmallintListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteListsmallintListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteListsmallintListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteListsmallintListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SBytesmallintListD1E2MI),
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
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISByteListsmallintListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteListsmallintListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISByteListsmallintListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ISByteListsmallintListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SBytesmallintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteListsmallintListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteListsmallintListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteListsmallintListD1)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteListsmallintListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
sbytesmallintlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SBytesmallintListD1E2M),
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
            asPartInterface: typeof(ISByteListsmallintListD1))]
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
FROM public.binary_sbytesmallintlistd1e2m m
LEFT JOIN public.binary_sbytesmallintlistd1e2mi mi ON mi.id = m.sbytesmallintlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SBytesmallintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISByteListsmallintListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISByteListsmallintListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISByteListsmallintListD1)this).ImportModel(connection, importCollection);
                var models = ((ISByteListsmallintListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    sbytesmallintlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SBytesmallintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models =  ((ISByteListsmallintListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteListsmallintListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA), typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models1 = new List<SBytesmallintListD1E2MIWA>();
                var models2 = new List<SBytesmallintListD1E2MIWA>();
                await ((ISByteListsmallintListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintListD1E2MIWA>();
                var models2 = new List<SBytesmallintListD1E2MIWA>();
                ((ISByteListsmallintListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models = await ((ISByteListsmallintListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintlistd1e2mi
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
                    SBytesmallintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteListsmallintListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_sbytesmallintlistd1e2mi
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
                    SBytesmallintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA), typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
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
                var models1 = new List<SBytesmallintListD1E2MIWA>();
                var models2 = new List<SBytesmallintListD1E2MIWA>();
                await ((ISByteListsmallintListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintListD1E2MIWA>();
                var models2 = new List<SBytesmallintListD1E2MIWA>();
                ((ISByteListsmallintListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
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
                var models = await ((ISByteListsmallintListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintlistd1e2mi
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
                    SBytesmallintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteListsmallintListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_sbytesmallintlistd1e2mi
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
                    SBytesmallintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_sbytesmallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MI), typeof(SBytesmallintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models1 = new List<SBytesmallintListD1E2MI>();
                var models2 = new List<SBytesmallintListD1E2MI>();
                await ((ISByteListsmallintListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintListD1E2MI>();
                var models2 = new List<SBytesmallintListD1E2MI>();
                ((ISByteListsmallintListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1)),
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
                var models = await ((ISByteListsmallintListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteListsmallintListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_sbytesmallintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA), typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
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
                var models1 = new List<SBytesmallintListD1E2MIWA>();
                var models2 = new List<SBytesmallintListD1E2MIWA>();
                await ((ISByteListsmallintListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintListD1E2MIWA>();
                var models2 = new List<SBytesmallintListD1E2MIWA>();
                ((ISByteListsmallintListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SBytesmallintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintListD1))]
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
                var models = await ((ISByteListsmallintListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteListsmallintListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


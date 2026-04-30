

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
28,

-25,

115,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-56,

112,

120,

-46,

},
},
            new SBytesmallintArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
90,

44,

90,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
43,

-84,

87,

-109,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
0,

119,

4,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-17,

73,

-123,

-9,

},
},
            new SBytesmallintArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
26,

59,

50,

23,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
73,

-75,

-119,

67,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-110,

-118,

-123,

},
},
            new SBytesmallintArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-69,

11,

-8,

104,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-96,

-89,

-99,

-118,

},
},
            new SBytesmallintArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-93,

-91,

125,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-1,

-18,

41,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-89,

-16,

-76,

-99,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
119,

-84,

-16,

120,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
29,

-52,

64,

-58,

},
},
            new SBytesmallintArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
31,

101,

-85,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
40,

-19,

29,

-52,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
82,

-97,

-112,

-118,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
126,

-14,

107,

-59,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-100,

-78,

-44,

19,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
53,

89,

36,

-69,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-35,

-103,

-66,

},
},
            new SBytesmallintArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-22,

-83,

104,

-52,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-125,

-124,

-105,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
87,

-20,

-55,

105,

},
},
            new SBytesmallintArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
77,

-43,

-57,

110,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-10,

-31,

24,

},
},
            new SBytesmallintArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
71,

77,

-40,

109,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
84,

44,

68,

-24,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-103,

104,

117,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
69,

13,

-121,

-23,

},
},
            new SBytesmallintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-65,

-95,

-88,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
43,

0,

-29,

},
},
            new SBytesmallintArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
78,

24,

-108,

40,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-54,

-24,

91,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
103,

-36,

47,

-71,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-54,

96,

91,

},
},
            new SBytesmallintArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
37,

-32,

-29,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-5,

-78,

46,

-34,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-49,

45,

122,

115,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-65,

77,

30,

-98,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
23,

-27,

-31,

10,

},
},
            new SBytesmallintArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-19,

-64,

96,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-102,

1,

-24,

},
},
            new SBytesmallintArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
86,

108,

57,

-7,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-15,

-32,

-28,

125,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-3,

-62,

23,

-39,

},
},
            new SBytesmallintArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
51,

20,

-6,

-27,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-25,

78,

-61,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
121,

125,

-82,

-61,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
123,

-70,

30,

119,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
53,

57,

-33,

-93,

},
},
            new SBytesmallintArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
89,

2,

-94,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
44,

-98,

49,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-68,

-127,

97,

-71,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-17,

-24,

-7,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
116,

94,

-69,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
100,

-31,

-70,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
16,

69,

-35,

},
},
            new SBytesmallintArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-107,

-78,

-15,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
117,

37,

106,

-54,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
103,

-94,

-65,

101,

},
},
            new SBytesmallintArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
26,

-63,

85,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-91,

-92,

-16,

9,

},
},
            new SBytesmallintArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
76,

-12,

-44,

-47,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-76,

64,

-5,

-100,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-12,

17,

-1,

74,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-6,

-117,

19,

-55,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-23,

117,

8,

121,

},
},
            new SBytesmallintArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-96,

48,

83,

50,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
70,

43,

-72,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-55,

-71,

34,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-114,

64,

-41,

},
},
            new SBytesmallintArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
61,

-22,

-82,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
109,

30,

64,

14,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-7,

-45,

-17,

22,

},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((ISByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M), typeof(FlatSBytesmallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
FROM public.sbytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintArray2M>();
                var models2 = new List<FlatSBytesmallintArray2M>();
                await ((ISByteListsmallintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintArray2M>();
                var models2 = new List<FlatSBytesmallintArray2M>();
                ((ISByteListsmallintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISByteListsmallintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISByteListsmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((ISByteListsmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M), typeof(FlatSBytesmallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.sbytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintArray2M>();
                var models2 = new List<FlatSBytesmallintArray2M>();
                await ((ISByteListsmallintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintArray2M>();
                var models2 = new List<FlatSBytesmallintArray2M>();
                ((ISByteListsmallintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISByteListsmallintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISByteListsmallintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((ISByteListsmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M), typeof(FlatSBytesmallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
            asPartInterface: typeof(ISByteListsmallintArray)),
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintArray2M>();
                var models2 = new List<FlatSBytesmallintArray2M>();
                await((ISByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.sbytesmallintarray2m m
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var firstItems2 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems2 = new List<FlatSBytesmallintArray2M>();
                await ((ISByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.sbytesmallintarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var firstItems2 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                await ((ISByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintArray2M>();
                var models2 = new List<FlatSBytesmallintArray2M>();
                ((ISByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.sbytesmallintarray2m m
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var firstItems2 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems2 = new List<FlatSBytesmallintArray2M>();
                 ((ISByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
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
FROM public.sbytesmallintarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var firstItems2 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                 ((ISByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSBytesmallintArray2M.AssertModel(models[0],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(models[1],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(models[2],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(models[3],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(models[4],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(models[5],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(models[6],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(models[7],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(models[8],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(models[9],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(models[10],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(models[11],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(models[12],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(models[13],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(models[14],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(models[15],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(models[16],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(models[17],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(models[18],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(models[19],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(models[20],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatSBytesmallintArray2M.AssertModel(models[0],_testData[4], false);
                        FlatSBytesmallintArray2M.AssertModel(models[1],_testData[5], false);
                        FlatSBytesmallintArray2M.AssertModel(models[2],_testData[6], false);
                        FlatSBytesmallintArray2M.AssertModel(models[3],_testData[7], false);
                        FlatSBytesmallintArray2M.AssertModel(models[4],_testData[8], false);
                        FlatSBytesmallintArray2M.AssertModel(models[5],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(models[6],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(models[7],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(models[8],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(models[9],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(models[10],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(models[11],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(models[12],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(models[13],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(models[14],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(models[15],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(models[16],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(models[17],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(models[18],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(models[19],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(models[20],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(models[21],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(models[22],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(models[23],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(models[24],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(models[25],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(models[26],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(models[27],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(models[28],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(models[29],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintarray2m m
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems2 = new List<FlatSBytesmallintArray2M>();
                await ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSBytesmallintArray2M.AssertModel(models[0],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(models[1],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(models[2],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(models[3],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(models[4],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(models[5],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(models[6],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(models[7],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(models[8],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(models[9],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatSBytesmallintArray2M.AssertModel(models[0],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(models[1],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(models[2],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(models[3],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(models[4],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(models[5],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(models[6],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(models[7],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(models[8],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(models[9],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(models[10],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintarray2m m
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems2 = new List<FlatSBytesmallintArray2M>();
                 ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((ISByteListsmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        SBytesmallintArray2M.AssertModel(models[0],_testData[6], false);
                        SBytesmallintArray2M.AssertModel(models[1],_testData[7], false);
                        SBytesmallintArray2M.AssertModel(models[2],_testData[8], false);
                        SBytesmallintArray2M.AssertModel(models[3],_testData[9], false);
                        SBytesmallintArray2M.AssertModel(models[4],_testData[10], false);
                        SBytesmallintArray2M.AssertModel(models[5],_testData[11], false);
                        SBytesmallintArray2M.AssertModel(models[6],_testData[12], false);
                        SBytesmallintArray2M.AssertModel(models[7],_testData[13], false);
                        SBytesmallintArray2M.AssertModel(models[8],_testData[14], false);
                        SBytesmallintArray2M.AssertModel(models[9],_testData[15], false);
                        SBytesmallintArray2M.AssertModel(models[10],_testData[16], false);
                        SBytesmallintArray2M.AssertModel(models[11],_testData[17], false);
                        SBytesmallintArray2M.AssertModel(models[12],_testData[18], false);
                        SBytesmallintArray2M.AssertModel(models[13],_testData[19], false);
                        SBytesmallintArray2M.AssertModel(models[14],_testData[20], false);
                        SBytesmallintArray2M.AssertModel(models[15],_testData[21], false);
                        SBytesmallintArray2M.AssertModel(models[16],_testData[22], false);
                        SBytesmallintArray2M.AssertModel(models[17],_testData[23], false);
                        SBytesmallintArray2M.AssertModel(models[18],_testData[24], false);
                        SBytesmallintArray2M.AssertModel(models[19],_testData[25], false);
                        SBytesmallintArray2M.AssertModel(models[20],_testData[26], false);
                        SBytesmallintArray2M.AssertModel(models[21],_testData[27], false);
                        SBytesmallintArray2M.AssertModel(models[22],_testData[28], false);
                        SBytesmallintArray2M.AssertModel(models[23],_testData[29], false);
                        SBytesmallintArray2M.AssertModel(models[24],_testData[30], false);
                        SBytesmallintArray2M.AssertModel(models[25],_testData[31], false);
                        SBytesmallintArray2M.AssertModel(models[26],_testData[32], false);
                        SBytesmallintArray2M.AssertModel(models[27],_testData[33], false);
                        SBytesmallintArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SBytesmallintArray2M.AssertModel(models[0],_testData[10], false);
                        SBytesmallintArray2M.AssertModel(models[1],_testData[11], false);
                        SBytesmallintArray2M.AssertModel(models[2],_testData[12], false);
                        SBytesmallintArray2M.AssertModel(models[3],_testData[13], false);
                        SBytesmallintArray2M.AssertModel(models[4],_testData[14], false);
                        SBytesmallintArray2M.AssertModel(models[5],_testData[15], false);
                        SBytesmallintArray2M.AssertModel(models[6],_testData[16], false);
                        SBytesmallintArray2M.AssertModel(models[7],_testData[17], false);
                        SBytesmallintArray2M.AssertModel(models[8],_testData[18], false);
                        SBytesmallintArray2M.AssertModel(models[9],_testData[19], false);
                        SBytesmallintArray2M.AssertModel(models[10],_testData[20], false);
                        SBytesmallintArray2M.AssertModel(models[11],_testData[21], false);
                        SBytesmallintArray2M.AssertModel(models[12],_testData[22], false);
                        SBytesmallintArray2M.AssertModel(models[13],_testData[23], false);
                        SBytesmallintArray2M.AssertModel(models[14],_testData[24], false);
                        SBytesmallintArray2M.AssertModel(models[15],_testData[25], false);
                        SBytesmallintArray2M.AssertModel(models[16],_testData[26], false);
                        SBytesmallintArray2M.AssertModel(models[17],_testData[27], false);
                        SBytesmallintArray2M.AssertModel(models[18],_testData[28], false);
                        SBytesmallintArray2M.AssertModel(models[19],_testData[29], false);
                        SBytesmallintArray2M.AssertModel(models[20],_testData[30], false);
                        SBytesmallintArray2M.AssertModel(models[21],_testData[31], false);
                        SBytesmallintArray2M.AssertModel(models[22],_testData[32], false);
                        SBytesmallintArray2M.AssertModel(models[23],_testData[33], false);
                        SBytesmallintArray2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((ISByteListsmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        SBytesmallintArray2M.AssertModel(models[0],_testData[12], false);
                        SBytesmallintArray2M.AssertModel(models[1],_testData[13], false);
                        SBytesmallintArray2M.AssertModel(models[2],_testData[14], false);
                        SBytesmallintArray2M.AssertModel(models[3],_testData[15], false);
                        SBytesmallintArray2M.AssertModel(models[4],_testData[16], false);
                        SBytesmallintArray2M.AssertModel(models[5],_testData[17], false);
                        SBytesmallintArray2M.AssertModel(models[6],_testData[18], false);
                        SBytesmallintArray2M.AssertModel(models[7],_testData[19], false);
                        SBytesmallintArray2M.AssertModel(models[8],_testData[20], false);
                        SBytesmallintArray2M.AssertModel(models[9],_testData[21], false);
                        SBytesmallintArray2M.AssertModel(models[10],_testData[22], false);
                        SBytesmallintArray2M.AssertModel(models[11],_testData[23], false);
                        SBytesmallintArray2M.AssertModel(models[12],_testData[24], false);
                        SBytesmallintArray2M.AssertModel(models[13],_testData[25], false);
                        SBytesmallintArray2M.AssertModel(models[14],_testData[26], false);
                        SBytesmallintArray2M.AssertModel(models[15],_testData[27], false);
                        SBytesmallintArray2M.AssertModel(models[16],_testData[28], false);
                        SBytesmallintArray2M.AssertModel(models[17],_testData[29], false);
                        SBytesmallintArray2M.AssertModel(models[18],_testData[30], false);
                        SBytesmallintArray2M.AssertModel(models[19],_testData[31], false);
                        SBytesmallintArray2M.AssertModel(models[20],_testData[32], false);
                        SBytesmallintArray2M.AssertModel(models[21],_testData[33], false);
                        SBytesmallintArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SBytesmallintArray2M.AssertModel(models[0],_testData[16], false);
                        SBytesmallintArray2M.AssertModel(models[1],_testData[17], false);
                        SBytesmallintArray2M.AssertModel(models[2],_testData[18], false);
                        SBytesmallintArray2M.AssertModel(models[3],_testData[19], false);
                        SBytesmallintArray2M.AssertModel(models[4],_testData[20], false);
                        SBytesmallintArray2M.AssertModel(models[5],_testData[21], false);
                        SBytesmallintArray2M.AssertModel(models[6],_testData[22], false);
                        SBytesmallintArray2M.AssertModel(models[7],_testData[23], false);
                        SBytesmallintArray2M.AssertModel(models[8],_testData[24], false);
                        SBytesmallintArray2M.AssertModel(models[9],_testData[25], false);
                        SBytesmallintArray2M.AssertModel(models[10],_testData[26], false);
                        SBytesmallintArray2M.AssertModel(models[11],_testData[27], false);
                        SBytesmallintArray2M.AssertModel(models[12],_testData[28], false);
                        SBytesmallintArray2M.AssertModel(models[13],_testData[29], false);
                        SBytesmallintArray2M.AssertModel(models[14],_testData[30], false);
                        SBytesmallintArray2M.AssertModel(models[15],_testData[31], false);
                        SBytesmallintArray2M.AssertModel(models[16],_testData[32], false);
                        SBytesmallintArray2M.AssertModel(models[17],_testData[33], false);
                        SBytesmallintArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M), typeof(FlatSBytesmallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
            asPartInterface: typeof(ISByteListsmallintArray)),
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintArray2M>();
                var models2 = new List<FlatSBytesmallintArray2M>();
                await((ISByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var firstItems2 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems2 = new List<FlatSBytesmallintArray2M>();
                await ((ISByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 155, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.sbytesmallintarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var firstItems2 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                await ((ISByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintArray2M>();
                var models2 = new List<FlatSBytesmallintArray2M>();
                ((ISByteListsmallintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var firstItems2 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems2 = new List<FlatSBytesmallintArray2M>();
                 ((ISByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.sbytesmallintarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var firstItems2 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                 ((ISByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 119, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 13, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatSBytesmallintArray2M.AssertModel(models[0],_testData[3], false);
                        FlatSBytesmallintArray2M.AssertModel(models[1],_testData[4], false);
                        FlatSBytesmallintArray2M.AssertModel(models[2],_testData[5], false);
                        FlatSBytesmallintArray2M.AssertModel(models[3],_testData[6], false);
                        FlatSBytesmallintArray2M.AssertModel(models[4],_testData[7], false);
                        FlatSBytesmallintArray2M.AssertModel(models[5],_testData[8], false);
                        FlatSBytesmallintArray2M.AssertModel(models[6],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(models[7],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(models[8],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(models[9],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(models[10],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(models[11],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(models[12],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(models[13],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(models[14],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(models[15],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(models[16],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(models[17],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(models[18],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(models[19],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(models[20],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(models[21],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(models[22],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(models[23],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(models[24],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(models[25],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(models[26],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(models[27],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(models[28],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(models[29],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(models[30],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSBytesmallintArray2M.AssertModel(models[0],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(models[1],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(models[2],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(models[3],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(models[4],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(models[5],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(models[6],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(models[7],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(models[8],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(models[9],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(models[10],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(models[11],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(models[12],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(models[13],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(models[14],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(models[15],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(models[16],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(models[17],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(models[18],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(models[19],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(models[20],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(models[21],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(models[22],_testData[34], false);
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
FROM public.sbytesmallintarray2m m
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems2 = new List<FlatSBytesmallintArray2M>();
                await ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatSBytesmallintArray2M.AssertModel(models[0],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(models[1],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(models[2],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(models[3],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(models[4],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(models[5],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(models[6],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(models[7],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(models[8],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(models[9],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(models[10],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(models[11],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(models[12],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(models[13],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(models[14],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(models[15],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(models[16],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(models[17],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(models[18],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(models[19],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(models[20],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(models[21],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(models[22],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(models[23],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(models[24],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatSBytesmallintArray2M.AssertModel(models[0],_testData[3], false);
                        FlatSBytesmallintArray2M.AssertModel(models[1],_testData[4], false);
                        FlatSBytesmallintArray2M.AssertModel(models[2],_testData[5], false);
                        FlatSBytesmallintArray2M.AssertModel(models[3],_testData[6], false);
                        FlatSBytesmallintArray2M.AssertModel(models[4],_testData[7], false);
                        FlatSBytesmallintArray2M.AssertModel(models[5],_testData[8], false);
                        FlatSBytesmallintArray2M.AssertModel(models[6],_testData[9], false);
                        FlatSBytesmallintArray2M.AssertModel(models[7],_testData[10], false);
                        FlatSBytesmallintArray2M.AssertModel(models[8],_testData[11], false);
                        FlatSBytesmallintArray2M.AssertModel(models[9],_testData[12], false);
                        FlatSBytesmallintArray2M.AssertModel(models[10],_testData[13], false);
                        FlatSBytesmallintArray2M.AssertModel(models[11],_testData[14], false);
                        FlatSBytesmallintArray2M.AssertModel(models[12],_testData[15], false);
                        FlatSBytesmallintArray2M.AssertModel(models[13],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(models[14],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(models[15],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(models[16],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(models[17],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(models[18],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(models[19],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(models[20],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(models[21],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(models[22],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(models[23],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(models[24],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(models[25],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(models[26],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(models[27],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(models[28],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(models[29],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(models[30],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(models[31],_testData[34], false);
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
FROM public.sbytesmallintarray2m m
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
FROM public.sbytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems1 = new List<FlatSBytesmallintArray2M>();
                var secondItems2 = new List<FlatSBytesmallintArray2M>();
                 ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 144, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSBytesmallintArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((ISByteListsmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 133, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        SBytesmallintArray2M.AssertModel(models[0],_testData[25], false);
                        SBytesmallintArray2M.AssertModel(models[1],_testData[26], false);
                        SBytesmallintArray2M.AssertModel(models[2],_testData[27], false);
                        SBytesmallintArray2M.AssertModel(models[3],_testData[28], false);
                        SBytesmallintArray2M.AssertModel(models[4],_testData[29], false);
                        SBytesmallintArray2M.AssertModel(models[5],_testData[30], false);
                        SBytesmallintArray2M.AssertModel(models[6],_testData[31], false);
                        SBytesmallintArray2M.AssertModel(models[7],_testData[32], false);
                        SBytesmallintArray2M.AssertModel(models[8],_testData[33], false);
                        SBytesmallintArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        SBytesmallintArray2M.AssertModel(models[0],_testData[18], false);
                        SBytesmallintArray2M.AssertModel(models[1],_testData[19], false);
                        SBytesmallintArray2M.AssertModel(models[2],_testData[20], false);
                        SBytesmallintArray2M.AssertModel(models[3],_testData[21], false);
                        SBytesmallintArray2M.AssertModel(models[4],_testData[22], false);
                        SBytesmallintArray2M.AssertModel(models[5],_testData[23], false);
                        SBytesmallintArray2M.AssertModel(models[6],_testData[24], false);
                        SBytesmallintArray2M.AssertModel(models[7],_testData[25], false);
                        SBytesmallintArray2M.AssertModel(models[8],_testData[26], false);
                        SBytesmallintArray2M.AssertModel(models[9],_testData[27], false);
                        SBytesmallintArray2M.AssertModel(models[10],_testData[28], false);
                        SBytesmallintArray2M.AssertModel(models[11],_testData[29], false);
                        SBytesmallintArray2M.AssertModel(models[12],_testData[30], false);
                        SBytesmallintArray2M.AssertModel(models[13],_testData[31], false);
                        SBytesmallintArray2M.AssertModel(models[14],_testData[32], false);
                        SBytesmallintArray2M.AssertModel(models[15],_testData[33], false);
                        SBytesmallintArray2M.AssertModel(models[16],_testData[34], false);
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
                var models = ((ISByteListsmallintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionSTSelectModelBatch(connection, 166, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SBytesmallintArray2M.AssertModel(models[0],_testData[33], false);
                        SBytesmallintArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        SBytesmallintArray2M.AssertModel(models[0],_testData[6], false);
                        SBytesmallintArray2M.AssertModel(models[1],_testData[7], false);
                        SBytesmallintArray2M.AssertModel(models[2],_testData[8], false);
                        SBytesmallintArray2M.AssertModel(models[3],_testData[9], false);
                        SBytesmallintArray2M.AssertModel(models[4],_testData[10], false);
                        SBytesmallintArray2M.AssertModel(models[5],_testData[11], false);
                        SBytesmallintArray2M.AssertModel(models[6],_testData[12], false);
                        SBytesmallintArray2M.AssertModel(models[7],_testData[13], false);
                        SBytesmallintArray2M.AssertModel(models[8],_testData[14], false);
                        SBytesmallintArray2M.AssertModel(models[9],_testData[15], false);
                        SBytesmallintArray2M.AssertModel(models[10],_testData[16], false);
                        SBytesmallintArray2M.AssertModel(models[11],_testData[17], false);
                        SBytesmallintArray2M.AssertModel(models[12],_testData[18], false);
                        SBytesmallintArray2M.AssertModel(models[13],_testData[19], false);
                        SBytesmallintArray2M.AssertModel(models[14],_testData[20], false);
                        SBytesmallintArray2M.AssertModel(models[15],_testData[21], false);
                        SBytesmallintArray2M.AssertModel(models[16],_testData[22], false);
                        SBytesmallintArray2M.AssertModel(models[17],_testData[23], false);
                        SBytesmallintArray2M.AssertModel(models[18],_testData[24], false);
                        SBytesmallintArray2M.AssertModel(models[19],_testData[25], false);
                        SBytesmallintArray2M.AssertModel(models[20],_testData[26], false);
                        SBytesmallintArray2M.AssertModel(models[21],_testData[27], false);
                        SBytesmallintArray2M.AssertModel(models[22],_testData[28], false);
                        SBytesmallintArray2M.AssertModel(models[23],_testData[29], false);
                        SBytesmallintArray2M.AssertModel(models[24],_testData[30], false);
                        SBytesmallintArray2M.AssertModel(models[25],_testData[31], false);
                        SBytesmallintArray2M.AssertModel(models[26],_testData[32], false);
                        SBytesmallintArray2M.AssertModel(models[27],_testData[33], false);
                        SBytesmallintArray2M.AssertModel(models[28],_testData[34], false);
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
                ((ISByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((ISByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
SBytesmallintArray2M.AssertModel(models[0],_testData[7], false);SBytesmallintArray2M.AssertModel(models[1],_testData[8], false);SBytesmallintArray2M.AssertModel(models[2],_testData[9], false);SBytesmallintArray2M.AssertModel(models[3],_testData[10], false);SBytesmallintArray2M.AssertModel(models[4],_testData[11], false);SBytesmallintArray2M.AssertModel(models[5],_testData[12], false);SBytesmallintArray2M.AssertModel(models[6],_testData[13], false);SBytesmallintArray2M.AssertModel(models[7],_testData[14], false);SBytesmallintArray2M.AssertModel(models[8],_testData[15], false);SBytesmallintArray2M.AssertModel(models[9],_testData[16], false);SBytesmallintArray2M.AssertModel(models[10],_testData[17], false);SBytesmallintArray2M.AssertModel(models[11],_testData[18], false);SBytesmallintArray2M.AssertModel(models[12],_testData[19], false);SBytesmallintArray2M.AssertModel(models[13],_testData[20], false);SBytesmallintArray2M.AssertModel(models[14],_testData[21], false);SBytesmallintArray2M.AssertModel(models[15],_testData[22], false);SBytesmallintArray2M.AssertModel(models[16],_testData[23], false);SBytesmallintArray2M.AssertModel(models[17],_testData[24], false);SBytesmallintArray2M.AssertModel(models[18],_testData[25], false);SBytesmallintArray2M.AssertModel(models[19],_testData[26], false);SBytesmallintArray2M.AssertModel(models[20],_testData[27], false);SBytesmallintArray2M.AssertModel(models[21],_testData[28], false);SBytesmallintArray2M.AssertModel(models[22],_testData[29], false);SBytesmallintArray2M.AssertModel(models[23],_testData[30], false);SBytesmallintArray2M.AssertModel(models[24],_testData[31], false);SBytesmallintArray2M.AssertModel(models[25],_testData[32], false);SBytesmallintArray2M.AssertModel(models[26],_testData[33], false);SBytesmallintArray2M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 162);
                var models =  ((ISByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
SBytesmallintArray2M.AssertModel(models[0],_testData[32], false);SBytesmallintArray2M.AssertModel(models[1],_testData[33], false);SBytesmallintArray2M.AssertModel(models[2],_testData[34], false);
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
FROM public.binary_sbytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SBytesmallintArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteListsmallintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteListsmallintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteListsmallintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteListsmallintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SBytesmallintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteListsmallintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteListsmallintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteListsmallintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteListsmallintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(SBytesmallintArray2MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISByteListsmallintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteListsmallintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISByteListsmallintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ISByteListsmallintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SBytesmallintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteListsmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteListsmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteListsmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteListsmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(SBytesmallintArray2M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISByteListsmallintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISByteListsmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISByteListsmallintArray)this).ImportModel(connection, importCollection);
                var models = ((ISByteListsmallintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA), typeof(SBytesmallintArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
                var models1 = new List<SBytesmallintArray2MIWA>();
                var models2 = new List<SBytesmallintArray2MIWA>();
                await ((ISByteListsmallintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintArray2MIWA>();
                var models2 = new List<SBytesmallintArray2MIWA>();
                ((ISByteListsmallintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
                var models = await ((ISByteListsmallintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintarray2mi
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
                    SBytesmallintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteListsmallintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_sbytesmallintarray2mi
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
                    SBytesmallintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA), typeof(SBytesmallintArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
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
                var models1 = new List<SBytesmallintArray2MIWA>();
                var models2 = new List<SBytesmallintArray2MIWA>();
                await ((ISByteListsmallintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintArray2MIWA>();
                var models2 = new List<SBytesmallintArray2MIWA>();
                ((ISByteListsmallintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
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
                var models = await ((ISByteListsmallintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintarray2mi
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
                    SBytesmallintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteListsmallintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_sbytesmallintarray2mi
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
                    SBytesmallintArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_sbytesmallintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MI), typeof(SBytesmallintArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
                var models1 = new List<SBytesmallintArray2MI>();
                var models2 = new List<SBytesmallintArray2MI>();
                await ((ISByteListsmallintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintArray2MI>();
                var models2 = new List<SBytesmallintArray2MI>();
                ((ISByteListsmallintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray)),
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
                var models = await ((ISByteListsmallintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteListsmallintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_sbytesmallintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA), typeof(SBytesmallintArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
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
                var models1 = new List<SBytesmallintArray2MIWA>();
                var models2 = new List<SBytesmallintArray2MIWA>();
                await ((ISByteListsmallintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintArray2MIWA>();
                var models2 = new List<SBytesmallintArray2MIWA>();
                ((ISByteListsmallintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteListsmallintArray))]
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
                var models = await ((ISByteListsmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteListsmallintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


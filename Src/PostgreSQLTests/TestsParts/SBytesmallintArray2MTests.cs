

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-89,

67,

-70,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-77,

-22,

-37,

112,

},
},
            new SBytesmallintArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
118,

61,

-77,

-23,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-42,

-40,

-25,

-42,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
72,

50,

-33,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
59,

-86,

-87,

-56,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
126,

-92,

-32,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
4,

30,

123,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
102,

14,

-116,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-29,

-72,

86,

},
},
            new SBytesmallintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
11,

25,

-78,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-27,

114,

-32,

},
},
            new SBytesmallintArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
123,

-50,

-7,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-71,

-32,

75,

-18,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-60,

-97,

52,

89,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-127,

-53,

63,

-70,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-111,

-38,

34,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-15,

123,

88,

-86,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-121,

37,

41,

-111,

},
},
            new SBytesmallintArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-87,

122,

35,

-42,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
4,

65,

35,

},
},
            new SBytesmallintArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-6,

114,

-18,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-69,

-28,

-114,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-36,

15,

-87,

},
},
            new SBytesmallintArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
72,

-64,

-28,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-84,

-66,

67,

},
},
            new SBytesmallintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
42,

-19,

61,

112,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
109,

80,

124,

-7,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
25,

22,

-83,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-32,

48,

61,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-121,

40,

35,

87,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
99,

29,

-101,

-77,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
28,

-36,

-2,

83,

},
},
            new SBytesmallintArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-88,

23,

19,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
2,

54,

29,

33,

},
},
            new SBytesmallintArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
37,

-119,

-46,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
106,

126,

-33,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
9,

-122,

-2,

-27,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-89,

-16,

-1,

-13,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
27,

25,

38,

},
},
            new SBytesmallintArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
75,

-110,

-82,

39,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-56,

-104,

74,

113,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
44,

116,

-80,

9,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
-76,

120,

108,

},
},
            new SBytesmallintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-41,

81,

11,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-87,

-35,

-72,

-89,

},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
111,

-86,

-44,

77,

},
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
106,

-66,

37,

124,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-105,

96,

81,

-29,

},
},
            new SBytesmallintArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
62,

-28,

-106,

116,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-26,

118,

58,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-17,

-6,

117,

7,

},
},
            new SBytesmallintArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
17,

72,

-36,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
49,

52,

102,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
58,

-77,

-108,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
19,

-11,

-82,

-59,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
56,

59,

-106,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
34,

91,

104,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
58,

84,

21,

},
},
            new SBytesmallintArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
114,

-83,

120,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(3)
{
67,

-38,

-52,

},
},
            new SBytesmallintArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.SByte>(3)
{
-118,

83,

119,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-77,

23,

-15,

-95,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.SByte>(4)
{
-108,

-117,

54,

54,

},
},
            new SBytesmallintArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
78,

-48,

-7,

-56,

},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
-74,

92,

13,

124,

},
    ModelInner = new SBytesmallintArray2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.SByte>(4)
{
30,

59,

118,

-6,

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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                        Assert.That(models, Has.Count.EqualTo(12));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[18], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[7], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[8], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[9], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[10], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[11], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[12], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[13], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[14], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[15], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[16], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[17], false);FlatSBytesmallintArray2M.AssertModel(models[11],_testData[18], false);FlatSBytesmallintArray2M.AssertModel(models[12],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[13],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[14],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[15],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[16],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[17],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[18],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[19],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[20],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[21],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                        Assert.That(models, Has.Count.EqualTo(5));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
SBytesmallintArray2M.AssertModel(models[0],_testData[4], false);SBytesmallintArray2M.AssertModel(models[1],_testData[5], false);SBytesmallintArray2M.AssertModel(models[2],_testData[6], false);SBytesmallintArray2M.AssertModel(models[3],_testData[7], false);SBytesmallintArray2M.AssertModel(models[4],_testData[8], false);SBytesmallintArray2M.AssertModel(models[5],_testData[9], false);SBytesmallintArray2M.AssertModel(models[6],_testData[10], false);SBytesmallintArray2M.AssertModel(models[7],_testData[11], false);SBytesmallintArray2M.AssertModel(models[8],_testData[12], false);SBytesmallintArray2M.AssertModel(models[9],_testData[13], false);SBytesmallintArray2M.AssertModel(models[10],_testData[14], false);SBytesmallintArray2M.AssertModel(models[11],_testData[15], false);SBytesmallintArray2M.AssertModel(models[12],_testData[16], false);SBytesmallintArray2M.AssertModel(models[13],_testData[17], false);SBytesmallintArray2M.AssertModel(models[14],_testData[18], false);SBytesmallintArray2M.AssertModel(models[15],_testData[19], false);SBytesmallintArray2M.AssertModel(models[16],_testData[20], false);SBytesmallintArray2M.AssertModel(models[17],_testData[21], false);SBytesmallintArray2M.AssertModel(models[18],_testData[22], false);SBytesmallintArray2M.AssertModel(models[19],_testData[23], false);SBytesmallintArray2M.AssertModel(models[20],_testData[24], false);SBytesmallintArray2M.AssertModel(models[21],_testData[25], false);SBytesmallintArray2M.AssertModel(models[22],_testData[26], false);SBytesmallintArray2M.AssertModel(models[23],_testData[27], false);SBytesmallintArray2M.AssertModel(models[24],_testData[28], false);SBytesmallintArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
SBytesmallintArray2M.AssertModel(models[0],_testData[19], false);SBytesmallintArray2M.AssertModel(models[1],_testData[20], false);SBytesmallintArray2M.AssertModel(models[2],_testData[21], false);SBytesmallintArray2M.AssertModel(models[3],_testData[22], false);SBytesmallintArray2M.AssertModel(models[4],_testData[23], false);SBytesmallintArray2M.AssertModel(models[5],_testData[24], false);SBytesmallintArray2M.AssertModel(models[6],_testData[25], false);SBytesmallintArray2M.AssertModel(models[7],_testData[26], false);SBytesmallintArray2M.AssertModel(models[8],_testData[27], false);SBytesmallintArray2M.AssertModel(models[9],_testData[28], false);SBytesmallintArray2M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
SBytesmallintArray2M.AssertModel(models[0],_testData[21], false);SBytesmallintArray2M.AssertModel(models[1],_testData[22], false);SBytesmallintArray2M.AssertModel(models[2],_testData[23], false);SBytesmallintArray2M.AssertModel(models[3],_testData[24], false);SBytesmallintArray2M.AssertModel(models[4],_testData[25], false);SBytesmallintArray2M.AssertModel(models[5],_testData[26], false);SBytesmallintArray2M.AssertModel(models[6],_testData[27], false);SBytesmallintArray2M.AssertModel(models[7],_testData[28], false);SBytesmallintArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
SBytesmallintArray2M.AssertModel(models[0],_testData[10], false);SBytesmallintArray2M.AssertModel(models[1],_testData[11], false);SBytesmallintArray2M.AssertModel(models[2],_testData[12], false);SBytesmallintArray2M.AssertModel(models[3],_testData[13], false);SBytesmallintArray2M.AssertModel(models[4],_testData[14], false);SBytesmallintArray2M.AssertModel(models[5],_testData[15], false);SBytesmallintArray2M.AssertModel(models[6],_testData[16], false);SBytesmallintArray2M.AssertModel(models[7],_testData[17], false);SBytesmallintArray2M.AssertModel(models[8],_testData[18], false);SBytesmallintArray2M.AssertModel(models[9],_testData[19], false);SBytesmallintArray2M.AssertModel(models[10],_testData[20], false);SBytesmallintArray2M.AssertModel(models[11],_testData[21], false);SBytesmallintArray2M.AssertModel(models[12],_testData[22], false);SBytesmallintArray2M.AssertModel(models[13],_testData[23], false);SBytesmallintArray2M.AssertModel(models[14],_testData[24], false);SBytesmallintArray2M.AssertModel(models[15],_testData[25], false);SBytesmallintArray2M.AssertModel(models[16],_testData[26], false);SBytesmallintArray2M.AssertModel(models[17],_testData[27], false);SBytesmallintArray2M.AssertModel(models[18],_testData[28], false);SBytesmallintArray2M.AssertModel(models[19],_testData[29], false);
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
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 1, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[1], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[2], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[3], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[4], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[5], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[6], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[7], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[8], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[9], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[10], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[11], false);FlatSBytesmallintArray2M.AssertModel(models[11],_testData[12], false);FlatSBytesmallintArray2M.AssertModel(models[12],_testData[13], false);FlatSBytesmallintArray2M.AssertModel(models[13],_testData[14], false);FlatSBytesmallintArray2M.AssertModel(models[14],_testData[15], false);FlatSBytesmallintArray2M.AssertModel(models[15],_testData[16], false);FlatSBytesmallintArray2M.AssertModel(models[16],_testData[17], false);FlatSBytesmallintArray2M.AssertModel(models[17],_testData[18], false);FlatSBytesmallintArray2M.AssertModel(models[18],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[19],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[20],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[21],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[22],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[23],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[24],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[25],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[26],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[27],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[3], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[4], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[5], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[6], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[7], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[8], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[9], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[10], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[11], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[12], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[13], false);FlatSBytesmallintArray2M.AssertModel(models[11],_testData[14], false);FlatSBytesmallintArray2M.AssertModel(models[12],_testData[15], false);FlatSBytesmallintArray2M.AssertModel(models[13],_testData[16], false);FlatSBytesmallintArray2M.AssertModel(models[14],_testData[17], false);FlatSBytesmallintArray2M.AssertModel(models[15],_testData[18], false);FlatSBytesmallintArray2M.AssertModel(models[16],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[17],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[18],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[19],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[20],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[21],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[22],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[23],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[24],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[25],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatSBytesmallintArray2M.AssertModel(models[0],_testData[16], false);FlatSBytesmallintArray2M.AssertModel(models[1],_testData[17], false);FlatSBytesmallintArray2M.AssertModel(models[2],_testData[18], false);FlatSBytesmallintArray2M.AssertModel(models[3],_testData[19], false);FlatSBytesmallintArray2M.AssertModel(models[4],_testData[20], false);FlatSBytesmallintArray2M.AssertModel(models[5],_testData[21], false);FlatSBytesmallintArray2M.AssertModel(models[6],_testData[22], false);FlatSBytesmallintArray2M.AssertModel(models[7],_testData[23], false);FlatSBytesmallintArray2M.AssertModel(models[8],_testData[24], false);FlatSBytesmallintArray2M.AssertModel(models[9],_testData[25], false);FlatSBytesmallintArray2M.AssertModel(models[10],_testData[26], false);FlatSBytesmallintArray2M.AssertModel(models[11],_testData[27], false);FlatSBytesmallintArray2M.AssertModel(models[12],_testData[28], false);FlatSBytesmallintArray2M.AssertModel(models[13],_testData[29], false);
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
                foreach(var batchResult in await ((ISByteListsmallintArray)this).DbConnectionSelectModelBatchAsync(connection, 34, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
SBytesmallintArray2M.AssertModel(models[0],_testData[10], false);SBytesmallintArray2M.AssertModel(models[1],_testData[11], false);SBytesmallintArray2M.AssertModel(models[2],_testData[12], false);SBytesmallintArray2M.AssertModel(models[3],_testData[13], false);SBytesmallintArray2M.AssertModel(models[4],_testData[14], false);SBytesmallintArray2M.AssertModel(models[5],_testData[15], false);SBytesmallintArray2M.AssertModel(models[6],_testData[16], false);SBytesmallintArray2M.AssertModel(models[7],_testData[17], false);SBytesmallintArray2M.AssertModel(models[8],_testData[18], false);SBytesmallintArray2M.AssertModel(models[9],_testData[19], false);SBytesmallintArray2M.AssertModel(models[10],_testData[20], false);SBytesmallintArray2M.AssertModel(models[11],_testData[21], false);SBytesmallintArray2M.AssertModel(models[12],_testData[22], false);SBytesmallintArray2M.AssertModel(models[13],_testData[23], false);SBytesmallintArray2M.AssertModel(models[14],_testData[24], false);SBytesmallintArray2M.AssertModel(models[15],_testData[25], false);SBytesmallintArray2M.AssertModel(models[16],_testData[26], false);SBytesmallintArray2M.AssertModel(models[17],_testData[27], false);SBytesmallintArray2M.AssertModel(models[18],_testData[28], false);SBytesmallintArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
SBytesmallintArray2M.AssertModel(models[0],_testData[28], false);SBytesmallintArray2M.AssertModel(models[1],_testData[29], false);
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
                foreach(var batchResult in  ((ISByteListsmallintArray)this).DbConnectionSelectModelBatch(connection, 12, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
SBytesmallintArray2M.AssertModel(models[0],_testData[3], false);SBytesmallintArray2M.AssertModel(models[1],_testData[4], false);SBytesmallintArray2M.AssertModel(models[2],_testData[5], false);SBytesmallintArray2M.AssertModel(models[3],_testData[6], false);SBytesmallintArray2M.AssertModel(models[4],_testData[7], false);SBytesmallintArray2M.AssertModel(models[5],_testData[8], false);SBytesmallintArray2M.AssertModel(models[6],_testData[9], false);SBytesmallintArray2M.AssertModel(models[7],_testData[10], false);SBytesmallintArray2M.AssertModel(models[8],_testData[11], false);SBytesmallintArray2M.AssertModel(models[9],_testData[12], false);SBytesmallintArray2M.AssertModel(models[10],_testData[13], false);SBytesmallintArray2M.AssertModel(models[11],_testData[14], false);SBytesmallintArray2M.AssertModel(models[12],_testData[15], false);SBytesmallintArray2M.AssertModel(models[13],_testData[16], false);SBytesmallintArray2M.AssertModel(models[14],_testData[17], false);SBytesmallintArray2M.AssertModel(models[15],_testData[18], false);SBytesmallintArray2M.AssertModel(models[16],_testData[19], false);SBytesmallintArray2M.AssertModel(models[17],_testData[20], false);SBytesmallintArray2M.AssertModel(models[18],_testData[21], false);SBytesmallintArray2M.AssertModel(models[19],_testData[22], false);SBytesmallintArray2M.AssertModel(models[20],_testData[23], false);SBytesmallintArray2M.AssertModel(models[21],_testData[24], false);SBytesmallintArray2M.AssertModel(models[22],_testData[25], false);SBytesmallintArray2M.AssertModel(models[23],_testData[26], false);SBytesmallintArray2M.AssertModel(models[24],_testData[27], false);SBytesmallintArray2M.AssertModel(models[25],_testData[28], false);SBytesmallintArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
SBytesmallintArray2M.AssertModel(models[0],_testData[1], false);SBytesmallintArray2M.AssertModel(models[1],_testData[2], false);SBytesmallintArray2M.AssertModel(models[2],_testData[3], false);SBytesmallintArray2M.AssertModel(models[3],_testData[4], false);SBytesmallintArray2M.AssertModel(models[4],_testData[5], false);SBytesmallintArray2M.AssertModel(models[5],_testData[6], false);SBytesmallintArray2M.AssertModel(models[6],_testData[7], false);SBytesmallintArray2M.AssertModel(models[7],_testData[8], false);SBytesmallintArray2M.AssertModel(models[8],_testData[9], false);SBytesmallintArray2M.AssertModel(models[9],_testData[10], false);SBytesmallintArray2M.AssertModel(models[10],_testData[11], false);SBytesmallintArray2M.AssertModel(models[11],_testData[12], false);SBytesmallintArray2M.AssertModel(models[12],_testData[13], false);SBytesmallintArray2M.AssertModel(models[13],_testData[14], false);SBytesmallintArray2M.AssertModel(models[14],_testData[15], false);SBytesmallintArray2M.AssertModel(models[15],_testData[16], false);SBytesmallintArray2M.AssertModel(models[16],_testData[17], false);SBytesmallintArray2M.AssertModel(models[17],_testData[18], false);SBytesmallintArray2M.AssertModel(models[18],_testData[19], false);SBytesmallintArray2M.AssertModel(models[19],_testData[20], false);SBytesmallintArray2M.AssertModel(models[20],_testData[21], false);SBytesmallintArray2M.AssertModel(models[21],_testData[22], false);SBytesmallintArray2M.AssertModel(models[22],_testData[23], false);SBytesmallintArray2M.AssertModel(models[23],_testData[24], false);SBytesmallintArray2M.AssertModel(models[24],_testData[25], false);SBytesmallintArray2M.AssertModel(models[25],_testData[26], false);SBytesmallintArray2M.AssertModel(models[26],_testData[27], false);SBytesmallintArray2M.AssertModel(models[27],_testData[28], false);SBytesmallintArray2M.AssertModel(models[28],_testData[29], false);
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
                ((ISByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models = await ((ISByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
SBytesmallintArray2M.AssertModel(models[0],_testData[16], false);SBytesmallintArray2M.AssertModel(models[1],_testData[17], false);SBytesmallintArray2M.AssertModel(models[2],_testData[18], false);SBytesmallintArray2M.AssertModel(models[3],_testData[19], false);SBytesmallintArray2M.AssertModel(models[4],_testData[20], false);SBytesmallintArray2M.AssertModel(models[5],_testData[21], false);SBytesmallintArray2M.AssertModel(models[6],_testData[22], false);SBytesmallintArray2M.AssertModel(models[7],_testData[23], false);SBytesmallintArray2M.AssertModel(models[8],_testData[24], false);SBytesmallintArray2M.AssertModel(models[9],_testData[25], false);SBytesmallintArray2M.AssertModel(models[10],_testData[26], false);SBytesmallintArray2M.AssertModel(models[11],_testData[27], false);SBytesmallintArray2M.AssertModel(models[12],_testData[28], false);SBytesmallintArray2M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((ISByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
SBytesmallintArray2M.AssertModel(models[0],_testData[17], false);SBytesmallintArray2M.AssertModel(models[1],_testData[18], false);SBytesmallintArray2M.AssertModel(models[2],_testData[19], false);SBytesmallintArray2M.AssertModel(models[3],_testData[20], false);SBytesmallintArray2M.AssertModel(models[4],_testData[21], false);SBytesmallintArray2M.AssertModel(models[5],_testData[22], false);SBytesmallintArray2M.AssertModel(models[6],_testData[23], false);SBytesmallintArray2M.AssertModel(models[7],_testData[24], false);SBytesmallintArray2M.AssertModel(models[8],_testData[25], false);SBytesmallintArray2M.AssertModel(models[9],_testData[26], false);SBytesmallintArray2M.AssertModel(models[10],_testData[27], false);SBytesmallintArray2M.AssertModel(models[11],_testData[28], false);SBytesmallintArray2M.AssertModel(models[12],_testData[29], false);
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


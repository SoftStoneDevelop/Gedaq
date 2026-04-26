

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
    internal partial interface IByteListsmallintArray
    {
    }
    
    internal partial class ByteListsmallintArray : IByteListsmallintArray
    {


#region TestData

        private readonly BytesmallintArray2M[] _testData = new BytesmallintArray2M[]
        {
            new BytesmallintArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
229,

241,

133,

109,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
159,

219,

120,

101,

},
},
            new BytesmallintArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
119,

118,

249,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
82,

71,

30,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
60,

59,

121,

233,

},
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
67,

213,

214,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
233,

31,

81,

84,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
83,

16,

41,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
62,

239,

17,

},
},
            new BytesmallintArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
158,

150,

160,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
88,

105,

78,

},
},
            new BytesmallintArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
167,

203,

145,

139,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
183,

101,

208,

145,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
5,

111,

104,

42,

},
},
            new BytesmallintArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
94,

4,

4,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
181,

25,

157,

},
},
            new BytesmallintArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
213,

192,

197,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
206,

28,

136,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
115,

61,

225,

},
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
47,

100,

84,

176,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
114,

56,

187,

13,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
174,

124,

38,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
0,

227,

108,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
133,

198,

84,

},
},
            new BytesmallintArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
150,

237,

8,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
187,

58,

40,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
135,

6,

208,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
249,

104,

140,

227,

},
},
            new BytesmallintArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
103,

55,

222,

85,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
106,

135,

196,

147,

},
},
            new BytesmallintArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
80,

64,

227,

236,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
244,

194,

7,

127,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
252,

251,

195,

},
},
            new BytesmallintArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
131,

81,

108,

95,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
103,

20,

102,

151,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
79,

181,

249,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
72,

87,

176,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
85,

225,

197,

},
},
            new BytesmallintArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
172,

31,

5,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
101,

211,

229,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
84,

153,

172,

69,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
48,

163,

146,

121,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
107,

241,

149,

},
},
            new BytesmallintArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
111,

74,

64,

244,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
109,

107,

185,

20,

},
},
            new BytesmallintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
140,

137,

186,

236,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
84,

103,

208,

143,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
220,

109,

149,

},
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
126,

148,

52,

199,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
96,

253,

71,

},
},
            new BytesmallintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
148,

249,

7,

129,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
57,

170,

230,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
27,

113,

72,

},
},
            new BytesmallintArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
248,

3,

141,

234,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
38,

38,

49,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
130,

34,

252,

205,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
67,

242,

100,

},
},
            new BytesmallintArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
49,

68,

22,

128,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
252,

43,

105,

205,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
118,

254,

26,

126,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
161,

206,

103,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
252,

237,

87,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
129,

25,

181,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
79,

201,

166,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
49,

201,

122,

41,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
236,

142,

72,

72,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
170,

139,

231,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
133,

14,

120,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray2mi(
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
            asPartInterface: typeof(IByteListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Byte>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Byte>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray2mi(
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
            queryMapTypes: [typeof(BytesmallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Byte>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Byte>), 
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

                changedRows =  ((IByteListsmallintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteListsmallintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IByteListsmallintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteListsmallintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IByteListsmallintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IByteListsmallintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray2m(
	id,
    value,
    nullablevalue,
    bytesmallintarray2mi_id
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
            asPartInterface: typeof(IByteListsmallintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Byte>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Byte>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallintarray2mi_id", 
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
                changedRows =  ((IByteListsmallintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IByteListsmallintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IByteListsmallintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IByteListsmallintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray2m(
	id,
    value,
    nullablevalue,
    bytesmallintarray2mi_id
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
    bytesmallintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray2m(
	id,
    value,
    nullablevalue,
    bytesmallintarray2mi_id
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
    bytesmallintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Byte>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Byte>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallintarray2mi_id", 
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
                List<BytesmallintArray2M> models = null;

                models =  ((IByteListsmallintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IByteListsmallintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IByteListsmallintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IByteListsmallintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BytesmallintArray2M> models = null;

                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintArray2M), typeof(FlatBytesmallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
FROM public.bytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintArray2M>();
                var models2 = new List<FlatBytesmallintArray2M>();
                await ((IByteListsmallintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintArray2M>();
                var models2 = new List<FlatBytesmallintArray2M>();
                ((IByteListsmallintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
FROM public.bytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IByteListsmallintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IByteListsmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
LEFT JOIN public.bytesmallintarray2mi mi ON mi.id = m.bytesmallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
                var models = await ((IByteListsmallintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IByteListsmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintArray2M), typeof(FlatBytesmallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
FROM public.bytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintArray2M>();
                var models2 = new List<FlatBytesmallintArray2M>();
                await ((IByteListsmallintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintArray2M>();
                var models2 = new List<FlatBytesmallintArray2M>();
                ((IByteListsmallintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
FROM public.bytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IByteListsmallintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IByteListsmallintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
LEFT JOIN public.bytesmallintarray2mi mi ON mi.id = m.bytesmallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BytesmallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
                var models = await ((IByteListsmallintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IByteListsmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintArray2M), typeof(FlatBytesmallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
            asPartInterface: typeof(IByteListsmallintArray)),
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintArray2M>();
                var models2 = new List<FlatBytesmallintArray2M>();
                await((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var firstItems2 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems2 = new List<FlatBytesmallintArray2M>();
                await ((IByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var firstItems2 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                await ((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintArray2M>();
                var models2 = new List<FlatBytesmallintArray2M>();
                ((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var firstItems2 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems2 = new List<FlatBytesmallintArray2M>();
                 ((IByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var firstItems2 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                 ((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
            asPartInterface: typeof(IByteListsmallintArray)),
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems2 = new List<FlatBytesmallintArray2M>();
                await ((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems2 = new List<FlatBytesmallintArray2M>();
                 ((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.bytesmallintarray2m m
LEFT JOIN public.bytesmallintarray2mi mi ON mi.id = m.bytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
                var models = await((IByteListsmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteListsmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BytesmallintArray2M.AssertModel(models[0],_testData[12], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[13], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[14], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[15], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[16], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[17], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[18], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[19], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[20], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[12],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[13],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[14],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[15],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[16],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BytesmallintArray2M.AssertModel(models[0],_testData[13], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[14], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[15], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[16], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[17], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[18], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[19], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[20], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[12],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[13],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[14],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[15],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IByteListsmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteListsmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BytesmallintArray2M.AssertModel(models[0],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BytesmallintArray2M.AssertModel(models[0],_testData[16], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[17], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[18], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[19], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[20], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[12],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintArray2M), typeof(FlatBytesmallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
            asPartInterface: typeof(IByteListsmallintArray)),
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
            asPartInterface: typeof(IByteListsmallintArray)),
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintArray2M>();
                var models2 = new List<FlatBytesmallintArray2M>();
                await((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var firstItems2 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems2 = new List<FlatBytesmallintArray2M>();
                await ((IByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 113, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var firstItems2 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                await ((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 44, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintArray2M>();
                var models2 = new List<FlatBytesmallintArray2M>();
                ((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var firstItems2 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems2 = new List<FlatBytesmallintArray2M>();
                 ((IByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var firstItems2 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                 ((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
            asPartInterface: typeof(IByteListsmallintArray)),
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
            asPartInterface: typeof(IByteListsmallintArray)),
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 53, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(models[10],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[11],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[12],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[13],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[14],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[15],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[16],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[17],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[18],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(models[10],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(models[11],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(models[12],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(models[13],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(models[14],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(models[15],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(models[16],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[17],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[18],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[19],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[20],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[21],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[22],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[23],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[24],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[25],_testData[29], false);
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems2 = new List<FlatBytesmallintArray2M>();
                await ((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 154, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteListsmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 100, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[10],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[11],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[12],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[13],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[14],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.bytesmallintarray2m m
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
FROM public.bytesmallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems1 = new List<FlatBytesmallintArray2M>();
                var secondItems2 = new List<FlatBytesmallintArray2M>();
                 ((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 58, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.bytesmallintarray2m m
LEFT JOIN public.bytesmallintarray2mi mi ON mi.id = m.bytesmallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BytesmallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray)),
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
            asPartInterface: typeof(IByteListsmallintArray)),
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
                var models = await((IByteListsmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteListsmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 148, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BytesmallintArray2M.AssertModel(models[0],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BytesmallintArray2M.AssertModel(models[0],_testData[1], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[2], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[3], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[4], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[5], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[6], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[7], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[8], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[9], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[10], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[11], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[12], false);
                        BytesmallintArray2M.AssertModel(models[12],_testData[13], false);
                        BytesmallintArray2M.AssertModel(models[13],_testData[14], false);
                        BytesmallintArray2M.AssertModel(models[14],_testData[15], false);
                        BytesmallintArray2M.AssertModel(models[15],_testData[16], false);
                        BytesmallintArray2M.AssertModel(models[16],_testData[17], false);
                        BytesmallintArray2M.AssertModel(models[17],_testData[18], false);
                        BytesmallintArray2M.AssertModel(models[18],_testData[19], false);
                        BytesmallintArray2M.AssertModel(models[19],_testData[20], false);
                        BytesmallintArray2M.AssertModel(models[20],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[21],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[22],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[23],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[24],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[25],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[26],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[27],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((IByteListsmallintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteListsmallintArray)this).DbConnectionSTSelectModelBatch(connection, 92, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BytesmallintArray2M.AssertModel(models[0],_testData[18], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[19], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[20], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BytesmallintArray2M.AssertModel(models[0],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[29], false);
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
                await using var cmd = await ((IByteListsmallintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models = await ((IByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
BytesmallintArray2M.AssertModel(models[0],_testData[3], false);BytesmallintArray2M.AssertModel(models[1],_testData[4], false);BytesmallintArray2M.AssertModel(models[2],_testData[5], false);BytesmallintArray2M.AssertModel(models[3],_testData[6], false);BytesmallintArray2M.AssertModel(models[4],_testData[7], false);BytesmallintArray2M.AssertModel(models[5],_testData[8], false);BytesmallintArray2M.AssertModel(models[6],_testData[9], false);BytesmallintArray2M.AssertModel(models[7],_testData[10], false);BytesmallintArray2M.AssertModel(models[8],_testData[11], false);BytesmallintArray2M.AssertModel(models[9],_testData[12], false);BytesmallintArray2M.AssertModel(models[10],_testData[13], false);BytesmallintArray2M.AssertModel(models[11],_testData[14], false);BytesmallintArray2M.AssertModel(models[12],_testData[15], false);BytesmallintArray2M.AssertModel(models[13],_testData[16], false);BytesmallintArray2M.AssertModel(models[14],_testData[17], false);BytesmallintArray2M.AssertModel(models[15],_testData[18], false);BytesmallintArray2M.AssertModel(models[16],_testData[19], false);BytesmallintArray2M.AssertModel(models[17],_testData[20], false);BytesmallintArray2M.AssertModel(models[18],_testData[21], false);BytesmallintArray2M.AssertModel(models[19],_testData[22], false);BytesmallintArray2M.AssertModel(models[20],_testData[23], false);BytesmallintArray2M.AssertModel(models[21],_testData[24], false);BytesmallintArray2M.AssertModel(models[22],_testData[25], false);BytesmallintArray2M.AssertModel(models[23],_testData[26], false);BytesmallintArray2M.AssertModel(models[24],_testData[27], false);BytesmallintArray2M.AssertModel(models[25],_testData[28], false);BytesmallintArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models =  ((IByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
BytesmallintArray2M.AssertModel(models[0],_testData[24], false);BytesmallintArray2M.AssertModel(models[1],_testData[25], false);BytesmallintArray2M.AssertModel(models[2],_testData[26], false);BytesmallintArray2M.AssertModel(models[3],_testData[27], false);BytesmallintArray2M.AssertModel(models[4],_testData[28], false);BytesmallintArray2M.AssertModel(models[5],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(BytesmallintArray2MI)],
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
            asPartInterface: typeof(IByteListsmallintArray))]
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
FROM public.binary_bytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BytesmallintArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IByteListsmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IByteListsmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MI.AssertModel(actual, expect, false);
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
                await ((IByteListsmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IByteListsmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bytesmallintarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(BytesmallintArray2M)],
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
            asPartInterface: typeof(IByteListsmallintArray))]
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
FROM public.binary_bytesmallintarray2m m
LEFT JOIN public.binary_bytesmallintarray2mi mi ON mi.id = m.bytesmallintarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BytesmallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BytesmallintArray2M>(15);

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
                ((IByteListsmallintArray)this).ImportModel(connection, importCollection);
                var models = ((IByteListsmallintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BytesmallintArray2M.AssertModel(models[0],_testData[0], false);
                BytesmallintArray2M.AssertModel(models[1],_testData[1], false);
                BytesmallintArray2M.AssertModel(models[2],_testData[2], false);
                BytesmallintArray2M.AssertModel(models[3],_testData[3], false);
                BytesmallintArray2M.AssertModel(models[4],_testData[4], false);
                BytesmallintArray2M.AssertModel(models[5],_testData[5], false);
                BytesmallintArray2M.AssertModel(models[6],_testData[6], false);
                BytesmallintArray2M.AssertModel(models[7],_testData[7], false);
                BytesmallintArray2M.AssertModel(models[8],_testData[8], false);
                BytesmallintArray2M.AssertModel(models[9],_testData[9], false);
                BytesmallintArray2M.AssertModel(models[10],_testData[10], false);
                BytesmallintArray2M.AssertModel(models[11],_testData[11], false);
                BytesmallintArray2M.AssertModel(models[12],_testData[12], false);
                BytesmallintArray2M.AssertModel(models[13],_testData[13], false);
                BytesmallintArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IByteListsmallintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IByteListsmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BytesmallintArray2M.AssertModel(models[0],_testData[0], false);
                BytesmallintArray2M.AssertModel(models[1],_testData[1], false);
                BytesmallintArray2M.AssertModel(models[2],_testData[2], false);
                BytesmallintArray2M.AssertModel(models[3],_testData[3], false);
                BytesmallintArray2M.AssertModel(models[4],_testData[4], false);
                BytesmallintArray2M.AssertModel(models[5],_testData[5], false);
                BytesmallintArray2M.AssertModel(models[6],_testData[6], false);
                BytesmallintArray2M.AssertModel(models[7],_testData[7], false);
                BytesmallintArray2M.AssertModel(models[8],_testData[8], false);
                BytesmallintArray2M.AssertModel(models[9],_testData[9], false);
                BytesmallintArray2M.AssertModel(models[10],_testData[10], false);
                BytesmallintArray2M.AssertModel(models[11],_testData[11], false);
                BytesmallintArray2M.AssertModel(models[12],_testData[12], false);
                BytesmallintArray2M.AssertModel(models[13],_testData[13], false);
                BytesmallintArray2M.AssertModel(models[14],_testData[14], false);
                BytesmallintArray2M.AssertModel(models[15],_testData[15], false);
                BytesmallintArray2M.AssertModel(models[16],_testData[16], false);
                BytesmallintArray2M.AssertModel(models[17],_testData[17], false);
                BytesmallintArray2M.AssertModel(models[18],_testData[18], false);
                BytesmallintArray2M.AssertModel(models[19],_testData[19], false);
                BytesmallintArray2M.AssertModel(models[20],_testData[20], false);
                BytesmallintArray2M.AssertModel(models[21],_testData[21], false);
                BytesmallintArray2M.AssertModel(models[22],_testData[22], false);
                BytesmallintArray2M.AssertModel(models[23],_testData[23], false);
                BytesmallintArray2M.AssertModel(models[24],_testData[24], false);
                BytesmallintArray2M.AssertModel(models[25],_testData[25], false);
                BytesmallintArray2M.AssertModel(models[26],_testData[26], false);
                BytesmallintArray2M.AssertModel(models[27],_testData[27], false);
                BytesmallintArray2M.AssertModel(models[28],_testData[28], false);
                BytesmallintArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bytesmallintarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BytesmallintArray2M)],
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
            asPartInterface: typeof(IByteListsmallintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IByteListsmallintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteListsmallintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BytesmallintArray2MI)],
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
            asPartInterface: typeof(IByteListsmallintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IByteListsmallintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteListsmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


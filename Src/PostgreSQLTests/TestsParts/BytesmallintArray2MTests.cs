

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
198,

153,

209,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
26,

139,

124,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
174,

204,

86,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
244,

35,

222,

33,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
129,

119,

180,

},
},
            new BytesmallintArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
128,

76,

151,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
65,

19,

252,

9,

},
},
            new BytesmallintArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
21,

216,

1,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
128,

127,

20,

114,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
208,

175,

246,

},
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
105,

114,

181,

206,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
205,

142,

149,

158,

},
},
            new BytesmallintArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
97,

227,

129,

32,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
97,

51,

138,

1,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
186,

202,

160,

108,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
226,

166,

173,

18,

},
},
            new BytesmallintArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
92,

82,

127,

185,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
134,

98,

84,

},
},
            new BytesmallintArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
91,

25,

202,

247,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
155,

94,

209,

135,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
222,

238,

9,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
246,

110,

118,

30,

},
},
            new BytesmallintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
2,

177,

210,

129,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
215,

6,

187,

},
},
            new BytesmallintArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
234,

238,

104,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
140,

47,

142,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
14,

154,

197,

},
},
            new BytesmallintArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
67,

36,

215,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
41,

139,

54,

},
},
            new BytesmallintArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
145,

105,

77,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
55,

139,

37,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
113,

82,

96,

250,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
45,

218,

131,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
128,

177,

44,

244,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
64,

39,

213,

111,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
12,

150,

239,

230,

},
},
            new BytesmallintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
204,

63,

5,

100,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
90,

184,

155,

},
},
            new BytesmallintArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
12,

168,

98,

216,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
101,

202,

159,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
214,

117,

101,

116,

},
},
            new BytesmallintArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
32,

131,

87,

183,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
37,

55,

253,

},
},
            new BytesmallintArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
11,

199,

90,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
117,

131,

13,

4,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
215,

62,

88,

210,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
140,

14,

21,

},
},
            new BytesmallintArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
71,

165,

183,

178,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
4,

64,

206,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
148,

32,

170,

122,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
85,

84,

156,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
152,

228,

159,

184,

},
},
            new BytesmallintArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
245,

10,

55,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
90,

252,

20,

110,

},
},
            new BytesmallintArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
55,

44,

130,

188,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
160,

106,

29,

237,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
142,

247,

142,

},
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
90,

190,

140,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
160,

96,

163,

59,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
0,

119,

233,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
237,

168,

186,

114,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
86,

207,

95,

219,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
31,

201,

238,

81,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
131,

194,

48,

20,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
218,

92,

115,

161,

},
},
            new BytesmallintArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
162,

95,

117,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
13,

118,

13,

},
},
            new BytesmallintArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
97,

68,

243,

174,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
212,

100,

137,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
174,

217,

76,

136,

},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
192,

88,

66,

100,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
181,

91,

195,

217,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(4)
{
90,

251,

164,

12,

},
},
            new BytesmallintArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
68,

131,

245,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
100,

171,

3,

},
},
            new BytesmallintArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
232,

122,

22,

88,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
249,

129,

58,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
148,

173,

22,

},
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
138,

145,

91,

22,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
140,

200,

44,

},
},
            new BytesmallintArray2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.Byte>(3)
{
116,

49,

177,

},
    ModelInner = new BytesmallintArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
56,

0,

20,

207,

},
    NullableValue = 
new System.Collections.Generic.List<System.Byte>(3)
{
212,

191,

223,

},
},
    NullableValue = null,
},
            new BytesmallintArray2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Byte>(4)
{
229,

126,

147,

223,

},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IByteListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IByteListsmallintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatBytesmallintArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
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
                        FlatBytesmallintArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 180;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[6], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[7], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[8], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(models[10],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(models[11],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(models[12],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(models[13],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(models[14],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[15],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[16],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[17],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[18],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[19],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[20],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[21],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[22],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[23],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(models[24],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(models[25],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(models[26],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(models[27],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        FlatBytesmallintArray2M.AssertModel(models[16],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(models[17],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(models[18],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(models[19],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[10],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[11],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[12],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[13],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[14],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(models[15],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(models[16],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(models[17],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(models[18],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteListsmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BytesmallintArray2M.AssertModel(models[0],_testData[17], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[18], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[19], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[20], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[12],_testData[29], false);
                        BytesmallintArray2M.AssertModel(models[13],_testData[30], false);
                        BytesmallintArray2M.AssertModel(models[14],_testData[31], false);
                        BytesmallintArray2M.AssertModel(models[15],_testData[32], false);
                        BytesmallintArray2M.AssertModel(models[16],_testData[33], false);
                        BytesmallintArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BytesmallintArray2M.AssertModel(models[0],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[29], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[30], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[31], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[32], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[33], false);
                        BytesmallintArray2M.AssertModel(models[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteListsmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BytesmallintArray2M.AssertModel(models[0],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[29], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[30], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[31], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[32], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[33], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BytesmallintArray2M.AssertModel(models[0],_testData[29], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[30], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[31], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[32], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[33], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 173, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                await ((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IByteListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 50, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
                 ((IByteListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 175, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBytesmallintArray2M.AssertModel(models[0],_testData[12], false);
                        FlatBytesmallintArray2M.AssertModel(models[1],_testData[13], false);
                        FlatBytesmallintArray2M.AssertModel(models[2],_testData[14], false);
                        FlatBytesmallintArray2M.AssertModel(models[3],_testData[15], false);
                        FlatBytesmallintArray2M.AssertModel(models[4],_testData[16], false);
                        FlatBytesmallintArray2M.AssertModel(models[5],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(models[6],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(models[7],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(models[8],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(models[9],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(models[10],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(models[11],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(models[12],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(models[13],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(models[14],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(models[15],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(models[16],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(models[17],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(models[18],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(models[19],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(models[20],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(models[21],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(models[22],_testData[34], false);
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
                await ((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 81, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IByteListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 94, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        FlatBytesmallintArray2M.AssertModel(models[11],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(models[12],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(models[13],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(models[14],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        FlatBytesmallintArray2M.AssertModel(models[26],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(models[27],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(models[28],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(models[29],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(models[30],_testData[34], false);
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
                 ((IByteListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 81, query1, 173, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatBytesmallintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBytesmallintArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBytesmallintArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IByteListsmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 81, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BytesmallintArray2M.AssertModel(models[0],_testData[17], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[18], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[19], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[20], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[12],_testData[29], false);
                        BytesmallintArray2M.AssertModel(models[13],_testData[30], false);
                        BytesmallintArray2M.AssertModel(models[14],_testData[31], false);
                        BytesmallintArray2M.AssertModel(models[15],_testData[32], false);
                        BytesmallintArray2M.AssertModel(models[16],_testData[33], false);
                        BytesmallintArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        BytesmallintArray2M.AssertModel(models[14],_testData[30], false);
                        BytesmallintArray2M.AssertModel(models[15],_testData[31], false);
                        BytesmallintArray2M.AssertModel(models[16],_testData[32], false);
                        BytesmallintArray2M.AssertModel(models[17],_testData[33], false);
                        BytesmallintArray2M.AssertModel(models[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IByteListsmallintArray)this).DbConnectionSTSelectModelBatch(connection, 169, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BytesmallintArray2M.AssertModel(models[0],_testData[30], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[31], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[32], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[33], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BytesmallintArray2M.AssertModel(models[0],_testData[14], false);
                        BytesmallintArray2M.AssertModel(models[1],_testData[15], false);
                        BytesmallintArray2M.AssertModel(models[2],_testData[16], false);
                        BytesmallintArray2M.AssertModel(models[3],_testData[17], false);
                        BytesmallintArray2M.AssertModel(models[4],_testData[18], false);
                        BytesmallintArray2M.AssertModel(models[5],_testData[19], false);
                        BytesmallintArray2M.AssertModel(models[6],_testData[20], false);
                        BytesmallintArray2M.AssertModel(models[7],_testData[21], false);
                        BytesmallintArray2M.AssertModel(models[8],_testData[22], false);
                        BytesmallintArray2M.AssertModel(models[9],_testData[23], false);
                        BytesmallintArray2M.AssertModel(models[10],_testData[24], false);
                        BytesmallintArray2M.AssertModel(models[11],_testData[25], false);
                        BytesmallintArray2M.AssertModel(models[12],_testData[26], false);
                        BytesmallintArray2M.AssertModel(models[13],_testData[27], false);
                        BytesmallintArray2M.AssertModel(models[14],_testData[28], false);
                        BytesmallintArray2M.AssertModel(models[15],_testData[29], false);
                        BytesmallintArray2M.AssertModel(models[16],_testData[30], false);
                        BytesmallintArray2M.AssertModel(models[17],_testData[31], false);
                        BytesmallintArray2M.AssertModel(models[18],_testData[32], false);
                        BytesmallintArray2M.AssertModel(models[19],_testData[33], false);
                        BytesmallintArray2M.AssertModel(models[20],_testData[34], false);
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
                ((IByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models = await ((IByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
BytesmallintArray2M.AssertModel(models[0],_testData[18], false);BytesmallintArray2M.AssertModel(models[1],_testData[19], false);BytesmallintArray2M.AssertModel(models[2],_testData[20], false);BytesmallintArray2M.AssertModel(models[3],_testData[21], false);BytesmallintArray2M.AssertModel(models[4],_testData[22], false);BytesmallintArray2M.AssertModel(models[5],_testData[23], false);BytesmallintArray2M.AssertModel(models[6],_testData[24], false);BytesmallintArray2M.AssertModel(models[7],_testData[25], false);BytesmallintArray2M.AssertModel(models[8],_testData[26], false);BytesmallintArray2M.AssertModel(models[9],_testData[27], false);BytesmallintArray2M.AssertModel(models[10],_testData[28], false);BytesmallintArray2M.AssertModel(models[11],_testData[29], false);BytesmallintArray2M.AssertModel(models[12],_testData[30], false);BytesmallintArray2M.AssertModel(models[13],_testData[31], false);BytesmallintArray2M.AssertModel(models[14],_testData[32], false);BytesmallintArray2M.AssertModel(models[15],_testData[33], false);BytesmallintArray2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models =  ((IByteListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
BytesmallintArray2M.AssertModel(models[0],_testData[6], false);BytesmallintArray2M.AssertModel(models[1],_testData[7], false);BytesmallintArray2M.AssertModel(models[2],_testData[8], false);BytesmallintArray2M.AssertModel(models[3],_testData[9], false);BytesmallintArray2M.AssertModel(models[4],_testData[10], false);BytesmallintArray2M.AssertModel(models[5],_testData[11], false);BytesmallintArray2M.AssertModel(models[6],_testData[12], false);BytesmallintArray2M.AssertModel(models[7],_testData[13], false);BytesmallintArray2M.AssertModel(models[8],_testData[14], false);BytesmallintArray2M.AssertModel(models[9],_testData[15], false);BytesmallintArray2M.AssertModel(models[10],_testData[16], false);BytesmallintArray2M.AssertModel(models[11],_testData[17], false);BytesmallintArray2M.AssertModel(models[12],_testData[18], false);BytesmallintArray2M.AssertModel(models[13],_testData[19], false);BytesmallintArray2M.AssertModel(models[14],_testData[20], false);BytesmallintArray2M.AssertModel(models[15],_testData[21], false);BytesmallintArray2M.AssertModel(models[16],_testData[22], false);BytesmallintArray2M.AssertModel(models[17],_testData[23], false);BytesmallintArray2M.AssertModel(models[18],_testData[24], false);BytesmallintArray2M.AssertModel(models[19],_testData[25], false);BytesmallintArray2M.AssertModel(models[20],_testData[26], false);BytesmallintArray2M.AssertModel(models[21],_testData[27], false);BytesmallintArray2M.AssertModel(models[22],_testData[28], false);BytesmallintArray2M.AssertModel(models[23],_testData[29], false);BytesmallintArray2M.AssertModel(models[24],_testData[30], false);BytesmallintArray2M.AssertModel(models[25],_testData[31], false);BytesmallintArray2M.AssertModel(models[26],_testData[32], false);BytesmallintArray2M.AssertModel(models[27],_testData[33], false);BytesmallintArray2M.AssertModel(models[28],_testData[34], false);
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
FROM public.binary_bytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BytesmallintArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteListsmallintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IByteListsmallintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteListsmallintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IByteListsmallintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BytesmallintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteListsmallintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IByteListsmallintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteListsmallintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IByteListsmallintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(BytesmallintArray2MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IByteListsmallintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IByteListsmallintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IByteListsmallintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IByteListsmallintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BytesmallintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteListsmallintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteListsmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IByteListsmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteListsmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IByteListsmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(BytesmallintArray2M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IByteListsmallintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IByteListsmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BytesmallintArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IByteListsmallintArray)this).ImportModel(connection, importCollection);
                var models = ((IByteListsmallintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BytesmallintArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BytesmallintArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteListsmallintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bytesmallintarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IByteListsmallintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bytesmallintarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IByteListsmallintArray)this).ExportModelInner(connection).ToList();
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


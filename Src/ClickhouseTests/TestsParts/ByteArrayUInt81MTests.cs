

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IByteArrayArrayUInt8
    {
    }
    
    internal partial class ByteArrayArrayUInt8 : IByteArrayArrayUInt8
    {


#region TestData

        private readonly ByteArrayUInt81M[] _testData = new ByteArrayUInt81M[]
        {
            new ByteArrayUInt81M
{
    Id = 6,
    Value = 
new System.Byte[3]
{
136,
60,
233,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 7,
    Value = 
new System.Byte[3]
{
249,
236,
50,
},
    NullableValue = 
new System.Byte[4]
{
235,
39,
57,
9,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 14,
    Value = 
new System.Byte[3]
{
157,
111,
247,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 14,
    Value = 
new System.Byte[4]
{
31,
164,
206,
12,
},
    NullableValue = 
new System.Byte[3]
{
54,
27,
47,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 21,
    Value = 
new System.Byte[3]
{
133,
19,
187,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 16,
    Value = 
new System.Byte[3]
{
62,
69,
91,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 26,
    Value = 
new System.Byte[4]
{
161,
220,
154,
155,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 18,
    Value = 
new System.Byte[4]
{
210,
221,
69,
223,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
95,
195,
108,
162,
},
},
            new ByteArrayUInt81M
{
    Id = 31,
    Value = 
new System.Byte[3]
{
239,
180,
254,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 24,
    Value = 
new System.Byte[4]
{
183,
64,
71,
158,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 36,
    Value = 
new System.Byte[3]
{
203,
5,
37,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 27,
    Value = 
new System.Byte[4]
{
1,
5,
234,
66,
},
    NullableValue = 
new System.Byte[4]
{
92,
13,
214,
141,
},
},
    NullableValue = 
new System.Byte[4]
{
111,
128,
78,
49,
},
},
            new ByteArrayUInt81M
{
    Id = 38,
    Value = 
new System.Byte[4]
{
208,
190,
27,
54,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 35,
    Value = 
new System.Byte[3]
{
1,
29,
232,
},
    NullableValue = 
new System.Byte[3]
{
191,
109,
182,
},
},
    NullableValue = 
new System.Byte[4]
{
124,
205,
92,
194,
},
},
            new ByteArrayUInt81M
{
    Id = 45,
    Value = 
new System.Byte[4]
{
14,
184,
223,
89,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 38,
    Value = 
new System.Byte[4]
{
209,
34,
254,
236,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 53,
    Value = 
new System.Byte[3]
{
94,
55,
130,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 42,
    Value = 
new System.Byte[4]
{
231,
190,
243,
195,
},
    NullableValue = 
new System.Byte[3]
{
43,
60,
27,
},
},
    NullableValue = 
new System.Byte[3]
{
40,
216,
194,
},
},
            new ByteArrayUInt81M
{
    Id = 56,
    Value = 
new System.Byte[4]
{
57,
232,
11,
214,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 44,
    Value = 
new System.Byte[3]
{
102,
103,
194,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 64,
    Value = 
new System.Byte[3]
{
239,
129,
30,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 48,
    Value = 
new System.Byte[4]
{
129,
172,
16,
145,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 68,
    Value = 
new System.Byte[3]
{
157,
204,
26,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 50,
    Value = 
new System.Byte[4]
{
214,
98,
171,
112,
},
    NullableValue = 
new System.Byte[3]
{
27,
187,
205,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 70,
    Value = 
new System.Byte[3]
{
181,
28,
38,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 56,
    Value = 
new System.Byte[3]
{
69,
65,
2,
},
    NullableValue = 
new System.Byte[4]
{
124,
47,
231,
195,
},
},
    NullableValue = 
new System.Byte[3]
{
213,
128,
191,
},
},
            new ByteArrayUInt81M
{
    Id = 71,
    Value = 
new System.Byte[3]
{
158,
227,
244,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 63,
    Value = 
new System.Byte[3]
{
73,
140,
14,
},
    NullableValue = 
new System.Byte[3]
{
173,
48,
182,
},
},
    NullableValue = 
new System.Byte[3]
{
32,
135,
241,
},
},
            new ByteArrayUInt81M
{
    Id = 72,
    Value = 
new System.Byte[3]
{
118,
156,
251,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 69,
    Value = 
new System.Byte[3]
{
128,
90,
72,
},
    NullableValue = 
new System.Byte[3]
{
190,
53,
149,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 74,
    Value = 
new System.Byte[4]
{
115,
42,
44,
117,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 73,
    Value = 
new System.Byte[4]
{
235,
98,
87,
179,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
244,
50,
191,
},
},
            new ByteArrayUInt81M
{
    Id = 81,
    Value = 
new System.Byte[4]
{
186,
56,
200,
39,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 80,
    Value = 
new System.Byte[4]
{
88,
188,
117,
213,
},
    NullableValue = 
new System.Byte[4]
{
83,
165,
135,
86,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 84,
    Value = 
new System.Byte[3]
{
87,
118,
93,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 85,
    Value = 
new System.Byte[4]
{
164,
176,
33,
178,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
122,
238,
251,
},
},
            new ByteArrayUInt81M
{
    Id = 93,
    Value = 
new System.Byte[3]
{
208,
151,
239,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 86,
    Value = 
new System.Byte[3]
{
173,
60,
235,
},
    NullableValue = 
new System.Byte[4]
{
166,
19,
0,
106,
},
},
    NullableValue = 
new System.Byte[4]
{
95,
149,
237,
23,
},
},
            new ByteArrayUInt81M
{
    Id = 99,
    Value = 
new System.Byte[3]
{
106,
1,
52,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 88,
    Value = 
new System.Byte[3]
{
107,
97,
223,
},
    NullableValue = 
new System.Byte[4]
{
250,
135,
248,
8,
},
},
    NullableValue = 
new System.Byte[3]
{
151,
124,
185,
},
},
            new ByteArrayUInt81M
{
    Id = 108,
    Value = 
new System.Byte[4]
{
20,
58,
237,
222,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 95,
    Value = 
new System.Byte[3]
{
14,
12,
207,
},
    NullableValue = 
new System.Byte[3]
{
141,
135,
200,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 111,
    Value = 
new System.Byte[3]
{
246,
94,
134,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 101,
    Value = 
new System.Byte[4]
{
141,
166,
87,
181,
},
    NullableValue = 
new System.Byte[3]
{
139,
91,
226,
},
},
    NullableValue = 
new System.Byte[4]
{
242,
179,
38,
197,
},
},
            new ByteArrayUInt81M
{
    Id = 114,
    Value = 
new System.Byte[3]
{
131,
5,
225,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 106,
    Value = 
new System.Byte[3]
{
253,
208,
200,
},
    NullableValue = 
new System.Byte[3]
{
173,
238,
139,
},
},
    NullableValue = 
new System.Byte[3]
{
47,
104,
23,
},
},
            new ByteArrayUInt81M
{
    Id = 115,
    Value = 
new System.Byte[3]
{
80,
152,
145,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 110,
    Value = 
new System.Byte[3]
{
197,
251,
220,
},
    NullableValue = 
new System.Byte[3]
{
229,
237,
157,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 119,
    Value = 
new System.Byte[3]
{
242,
88,
32,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 112,
    Value = 
new System.Byte[4]
{
89,
237,
246,
28,
},
    NullableValue = 
new System.Byte[4]
{
136,
83,
58,
109,
},
},
    NullableValue = 
new System.Byte[4]
{
27,
178,
73,
77,
},
},
            new ByteArrayUInt81M
{
    Id = 126,
    Value = 
new System.Byte[3]
{
198,
218,
156,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 118,
    Value = 
new System.Byte[4]
{
157,
7,
54,
252,
},
    NullableValue = 
new System.Byte[4]
{
200,
54,
241,
34,
},
},
    NullableValue = 
new System.Byte[4]
{
84,
159,
197,
62,
},
},
            new ByteArrayUInt81M
{
    Id = 128,
    Value = 
new System.Byte[3]
{
182,
120,
26,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 120,
    Value = 
new System.Byte[3]
{
130,
29,
19,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 134,
    Value = 
new System.Byte[4]
{
2,
158,
92,
104,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 125,
    Value = 
new System.Byte[4]
{
82,
106,
240,
119,
},
    NullableValue = 
new System.Byte[3]
{
80,
124,
253,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 138,
    Value = 
new System.Byte[3]
{
168,
104,
6,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 129,
    Value = 
new System.Byte[4]
{
252,
226,
137,
197,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
3,
251,
142,
108,
},
},
            new ByteArrayUInt81M
{
    Id = 141,
    Value = 
new System.Byte[4]
{
49,
95,
179,
149,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 130,
    Value = 
new System.Byte[3]
{
69,
228,
216,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
60,
229,
158,
120,
},
},
            new ByteArrayUInt81M
{
    Id = 143,
    Value = 
new System.Byte[4]
{
22,
130,
134,
97,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 139,
    Value = 
new System.Byte[4]
{
169,
126,
204,
95,
},
    NullableValue = 
new System.Byte[4]
{
52,
118,
18,
116,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 151,
    Value = 
new System.Byte[3]
{
68,
22,
211,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 142,
    Value = 
new System.Byte[3]
{
247,
42,
110,
},
    NullableValue = 
new System.Byte[4]
{
146,
246,
225,
172,
},
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 158,
    Value = 
new System.Byte[4]
{
134,
161,
190,
105,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 150,
    Value = 
new System.Byte[3]
{
212,
166,
129,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 160,
    Value = 
new System.Byte[3]
{
166,
239,
96,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 154,
    Value = 
new System.Byte[4]
{
164,
84,
53,
198,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt81M
{
    Id = 163,
    Value = 
new System.Byte[3]
{
22,
91,
25,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 155,
    Value = 
new System.Byte[3]
{
88,
234,
71,
},
    NullableValue = 
new System.Byte[3]
{
233,
176,
91,
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.bytearrayuint81m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt8)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt8)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArrayArrayUInt8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IByteArrayArrayUInt8)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IByteArrayArrayUInt8)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.bytearrayuint81m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteArrayUInt81M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArrayArrayUInt8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IByteArrayArrayUInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteArrayUInt81M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IByteArrayArrayUInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteArrayUInt81M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


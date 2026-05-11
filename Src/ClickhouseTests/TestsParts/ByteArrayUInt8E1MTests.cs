

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
    internal partial interface IByteMArrayArrayUInt8
    {
    }
    
    internal partial class ByteMArrayArrayUInt8 : IByteMArrayArrayUInt8
    {


#region TestData

        private readonly ByteArrayUInt8E1M[] _testData = new ByteArrayUInt8E1M[]
        {
            new ByteArrayUInt8E1M
{
    Id = 9,
    Value = 
new System.Byte[4]
{
236,
71,
87,
0,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 4,
    Value = 
new System.Byte[3]
{
128,
234,
28,
},
    NullableValue = 
new System.Byte[4]
{
124,
237,
91,
224,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 11,
    Value = 
new System.Byte[3]
{
15,
81,
100,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 11,
    Value = 
new System.Byte[3]
{
83,
167,
80,
},
    NullableValue = 
new System.Byte[3]
{
247,
105,
1,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 19,
    Value = 
new System.Byte[3]
{
165,
21,
231,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 14,
    Value = 
new System.Byte[3]
{
103,
118,
1,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 26,
    Value = 
new System.Byte[4]
{
98,
76,
243,
137,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 22,
    Value = 
new System.Byte[3]
{
12,
249,
246,
},
    NullableValue = 
new System.Byte[3]
{
6,
71,
21,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 34,
    Value = 
new System.Byte[4]
{
193,
10,
138,
218,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 30,
    Value = 
new System.Byte[3]
{
158,
83,
133,
},
    NullableValue = 
new System.Byte[3]
{
51,
107,
196,
},
},
    NullableValue = 
new System.Byte[3]
{
217,
105,
144,
},
},
            new ByteArrayUInt8E1M
{
    Id = 39,
    Value = 
new System.Byte[4]
{
121,
166,
220,
195,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 37,
    Value = 
new System.Byte[4]
{
55,
232,
180,
91,
},
    NullableValue = 
new System.Byte[3]
{
253,
94,
66,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 44,
    Value = 
new System.Byte[4]
{
33,
198,
184,
74,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 41,
    Value = 
new System.Byte[4]
{
195,
222,
86,
208,
},
    NullableValue = 
new System.Byte[4]
{
28,
156,
187,
193,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 53,
    Value = 
new System.Byte[4]
{
231,
242,
113,
23,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 49,
    Value = 
new System.Byte[4]
{
135,
218,
15,
5,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
16,
28,
236,
},
},
            new ByteArrayUInt8E1M
{
    Id = 61,
    Value = 
new System.Byte[4]
{
158,
11,
155,
174,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 51,
    Value = 
new System.Byte[3]
{
191,
242,
114,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 65,
    Value = 
new System.Byte[4]
{
1,
27,
59,
136,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 52,
    Value = 
new System.Byte[3]
{
175,
59,
245,
},
    NullableValue = 
new System.Byte[4]
{
97,
168,
79,
100,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 71,
    Value = 
new System.Byte[3]
{
38,
172,
45,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 60,
    Value = 
new System.Byte[4]
{
238,
66,
57,
201,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 77,
    Value = 
new System.Byte[3]
{
53,
119,
93,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 68,
    Value = 
new System.Byte[3]
{
71,
84,
175,
},
    NullableValue = 
new System.Byte[4]
{
217,
151,
62,
234,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 86,
    Value = 
new System.Byte[3]
{
158,
188,
253,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 76,
    Value = 
new System.Byte[4]
{
188,
167,
209,
126,
},
    NullableValue = 
new System.Byte[3]
{
203,
56,
159,
},
},
    NullableValue = 
new System.Byte[3]
{
40,
131,
77,
},
},
            new ByteArrayUInt8E1M
{
    Id = 87,
    Value = 
new System.Byte[3]
{
96,
57,
61,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 85,
    Value = 
new System.Byte[3]
{
79,
11,
69,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
90,
3,
250,
},
},
            new ByteArrayUInt8E1M
{
    Id = 95,
    Value = 
new System.Byte[4]
{
81,
214,
134,
203,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 88,
    Value = 
new System.Byte[3]
{
180,
75,
200,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
144,
254,
149,
183,
},
},
            new ByteArrayUInt8E1M
{
    Id = 102,
    Value = 
new System.Byte[4]
{
51,
180,
139,
2,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 96,
    Value = 
new System.Byte[3]
{
67,
184,
117,
},
    NullableValue = 
new System.Byte[4]
{
117,
155,
52,
241,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 107,
    Value = 
new System.Byte[3]
{
129,
7,
234,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 100,
    Value = 
new System.Byte[4]
{
197,
116,
1,
249,
},
    NullableValue = 
new System.Byte[3]
{
6,
233,
19,
},
},
    NullableValue = 
new System.Byte[3]
{
36,
27,
37,
},
},
            new ByteArrayUInt8E1M
{
    Id = 109,
    Value = 
new System.Byte[3]
{
156,
82,
188,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 102,
    Value = 
new System.Byte[4]
{
94,
3,
86,
69,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 110,
    Value = 
new System.Byte[3]
{
131,
7,
124,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 109,
    Value = 
new System.Byte[4]
{
177,
54,
122,
8,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 111,
    Value = 
new System.Byte[3]
{
16,
198,
178,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 113,
    Value = 
new System.Byte[4]
{
143,
40,
126,
200,
},
    NullableValue = 
new System.Byte[3]
{
39,
196,
208,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 114,
    Value = 
new System.Byte[3]
{
106,
147,
58,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 117,
    Value = 
new System.Byte[3]
{
21,
119,
129,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 122,
    Value = 
new System.Byte[3]
{
43,
129,
206,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 125,
    Value = 
new System.Byte[4]
{
28,
59,
138,
4,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
27,
230,
200,
},
},
            new ByteArrayUInt8E1M
{
    Id = 125,
    Value = 
new System.Byte[3]
{
199,
149,
100,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 129,
    Value = 
new System.Byte[4]
{
196,
29,
98,
171,
},
    NullableValue = 
new System.Byte[4]
{
49,
47,
13,
182,
},
},
    NullableValue = 
new System.Byte[4]
{
130,
196,
45,
19,
},
},
            new ByteArrayUInt8E1M
{
    Id = 132,
    Value = 
new System.Byte[4]
{
216,
59,
206,
179,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 133,
    Value = 
new System.Byte[3]
{
171,
22,
53,
},
    NullableValue = 
new System.Byte[3]
{
115,
54,
62,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 134,
    Value = 
new System.Byte[4]
{
77,
196,
39,
226,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 138,
    Value = 
new System.Byte[4]
{
209,
73,
235,
73,
},
    NullableValue = 
new System.Byte[4]
{
241,
68,
24,
170,
},
},
    NullableValue = 
new System.Byte[3]
{
153,
112,
59,
},
},
            new ByteArrayUInt8E1M
{
    Id = 138,
    Value = 
new System.Byte[3]
{
113,
149,
81,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 144,
    Value = 
new System.Byte[4]
{
173,
106,
43,
132,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
151,
4,
177,
},
},
            new ByteArrayUInt8E1M
{
    Id = 140,
    Value = 
new System.Byte[4]
{
202,
80,
91,
88,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 148,
    Value = 
new System.Byte[4]
{
74,
163,
125,
213,
},
    NullableValue = 
new System.Byte[3]
{
167,
197,
237,
},
},
    NullableValue = 
new System.Byte[3]
{
5,
200,
222,
},
},
            new ByteArrayUInt8E1M
{
    Id = 148,
    Value = 
new System.Byte[3]
{
25,
44,
162,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 151,
    Value = 
new System.Byte[3]
{
82,
8,
141,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
36,
70,
158,
207,
},
},
            new ByteArrayUInt8E1M
{
    Id = 154,
    Value = 
new System.Byte[4]
{
58,
155,
88,
54,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 153,
    Value = 
new System.Byte[3]
{
173,
47,
132,
},
    NullableValue = 
new System.Byte[3]
{
114,
61,
172,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 156,
    Value = 
new System.Byte[4]
{
24,
91,
138,
214,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 158,
    Value = 
new System.Byte[4]
{
143,
211,
252,
212,
},
    NullableValue = 
new System.Byte[3]
{
153,
105,
154,
},
},
    NullableValue = 
new System.Byte[3]
{
69,
141,
87,
},
},
            new ByteArrayUInt8E1M
{
    Id = 161,
    Value = 
new System.Byte[3]
{
85,
207,
16,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 167,
    Value = 
new System.Byte[3]
{
78,
60,
0,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 163,
    Value = 
new System.Byte[3]
{
175,
225,
76,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 175,
    Value = 
new System.Byte[4]
{
160,
92,
246,
177,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
21,
184,
251,
},
},
            new ByteArrayUInt8E1M
{
    Id = 170,
    Value = 
new System.Byte[4]
{
47,
65,
119,
97,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 179,
    Value = 
new System.Byte[3]
{
36,
244,
40,
},
    NullableValue = 
new System.Byte[4]
{
73,
233,
220,
199,
},
},
    NullableValue = null,
},
            new ByteArrayUInt8E1M
{
    Id = 172,
    Value = 
new System.Byte[4]
{
120,
147,
49,
25,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 185,
    Value = 
new System.Byte[3]
{
252,
161,
200,
},
    NullableValue = 
new System.Byte[4]
{
112,
168,
46,
240,
},
},
    NullableValue = 
new System.Byte[4]
{
238,
91,
138,
209,
},
},
            new ByteArrayUInt8E1M
{
    Id = 176,
    Value = 
new System.Byte[4]
{
12,
61,
254,
134,
},
    ModelInner = new ByteArrayUInt81MI
{
    Id = 186,
    Value = 
new System.Byte[3]
{
187,
146,
0,
},
    NullableValue = 
new System.Byte[3]
{
88,
30,
14,
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
INSERT INTO gedaqtests.bytearrayuint8e1m(
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
            asPartInterface: typeof(IByteMArrayArrayUInt8)),
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
                    await ((IByteMArrayArrayUInt8)this).InsertModelDbConnectionAsync(
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
                     ((IByteMArrayArrayUInt8)this).InsertModelDbConnection(
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
FROM gedaqtests.bytearrayuint8e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteArrayUInt8E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArrayArrayUInt8)),
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
                    var models = await ((IByteMArrayArrayUInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteArrayUInt8E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IByteMArrayArrayUInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteArrayUInt8E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


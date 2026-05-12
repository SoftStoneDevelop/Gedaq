

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
    internal partial interface IByteMArrayMArrayD1
    {
    }
    
    internal partial class ByteMArrayMArrayD1 : IByteMArrayMArrayD1
    {


#region TestData

        private readonly ByteMArrayD1E1M[] _testData = new ByteMArrayD1E1M[]
        {
            new ByteMArrayD1E1M
{
    Id = 2,
    Value = 
new System.Byte[3]
{
57,
177,
149,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Byte[4]
{
248,
90,
32,
252,
},
    NullableValue = 
new System.Byte[4]
{
95,
116,
134,
28,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Byte[3]
{
110,
223,
245,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Byte[3]
{
69,
84,
245,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
27,
124,
253,
},
},
            new ByteMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Byte[3]
{
105,
26,
50,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Byte[3]
{
150,
133,
73,
},
    NullableValue = 
new System.Byte[3]
{
82,
224,
191,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Byte[3]
{
41,
254,
139,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Byte[3]
{
106,
9,
61,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
55,
229,
26,
},
},
            new ByteMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Byte[3]
{
7,
164,
56,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Byte[4]
{
52,
89,
73,
72,
},
    NullableValue = 
new System.Byte[4]
{
171,
185,
151,
25,
},
},
    NullableValue = 
new System.Byte[3]
{
51,
48,
128,
},
},
            new ByteMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Byte[4]
{
78,
246,
167,
191,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Byte[4]
{
6,
96,
213,
110,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Byte[4]
{
161,
3,
216,
21,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Byte[4]
{
3,
82,
92,
164,
},
    NullableValue = 
new System.Byte[4]
{
163,
218,
4,
109,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Byte[3]
{
91,
222,
31,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Byte[3]
{
59,
114,
185,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Byte[4]
{
183,
5,
160,
3,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Byte[3]
{
178,
241,
135,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
145,
49,
66,
82,
},
},
            new ByteMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Byte[4]
{
91,
254,
71,
189,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Byte[3]
{
200,
251,
61,
},
    NullableValue = 
new System.Byte[4]
{
180,
232,
98,
145,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Byte[3]
{
200,
68,
86,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Byte[4]
{
15,
16,
56,
126,
},
    NullableValue = 
new System.Byte[4]
{
126,
126,
59,
102,
},
},
    NullableValue = 
new System.Byte[3]
{
154,
250,
186,
},
},
            new ByteMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Byte[4]
{
6,
21,
218,
106,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Byte[4]
{
122,
21,
236,
165,
},
    NullableValue = 
new System.Byte[4]
{
194,
246,
223,
191,
},
},
    NullableValue = 
new System.Byte[4]
{
121,
85,
248,
198,
},
},
            new ByteMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Byte[3]
{
96,
212,
120,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Byte[4]
{
93,
238,
229,
66,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Byte[4]
{
129,
206,
131,
91,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Byte[4]
{
41,
168,
137,
4,
},
    NullableValue = 
new System.Byte[4]
{
65,
228,
162,
220,
},
},
    NullableValue = 
new System.Byte[4]
{
217,
42,
141,
219,
},
},
            new ByteMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Byte[4]
{
233,
90,
109,
18,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Byte[4]
{
194,
217,
139,
41,
},
    NullableValue = 
new System.Byte[4]
{
211,
122,
71,
240,
},
},
    NullableValue = 
new System.Byte[4]
{
94,
151,
197,
65,
},
},
            new ByteMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Byte[3]
{
72,
8,
180,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Byte[3]
{
60,
55,
79,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
85,
187,
93,
176,
},
},
            new ByteMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Byte[3]
{
96,
153,
192,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Byte[4]
{
195,
41,
66,
135,
},
    NullableValue = 
new System.Byte[4]
{
179,
131,
152,
35,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Byte[3]
{
223,
17,
179,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Byte[4]
{
253,
18,
72,
156,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
52,
133,
43,
181,
},
},
            new ByteMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Byte[4]
{
235,
37,
35,
242,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 94,
    Value = 
new System.Byte[3]
{
120,
92,
169,
},
    NullableValue = 
new System.Byte[4]
{
27,
173,
179,
76,
},
},
    NullableValue = 
new System.Byte[3]
{
76,
92,
70,
},
},
            new ByteMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Byte[3]
{
139,
250,
56,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Byte[3]
{
108,
15,
155,
},
    NullableValue = 
new System.Byte[4]
{
147,
67,
64,
88,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Byte[4]
{
13,
200,
40,
93,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Byte[4]
{
186,
214,
161,
225,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
245,
245,
229,
},
},
            new ByteMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Byte[4]
{
198,
149,
184,
90,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Byte[3]
{
111,
171,
29,
},
    NullableValue = 
new System.Byte[4]
{
10,
218,
105,
104,
},
},
    NullableValue = 
new System.Byte[4]
{
107,
122,
239,
43,
},
},
            new ByteMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Byte[4]
{
41,
199,
27,
99,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Byte[4]
{
16,
171,
107,
203,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Byte[4]
{
78,
71,
120,
100,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Byte[3]
{
230,
95,
158,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
138,
164,
153,
108,
},
},
            new ByteMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Byte[4]
{
203,
202,
138,
10,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Byte[3]
{
78,
117,
14,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Byte[3]
{
28,
212,
110,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Byte[4]
{
179,
191,
68,
33,
},
    NullableValue = 
new System.Byte[4]
{
220,
221,
200,
66,
},
},
    NullableValue = 
new System.Byte[3]
{
235,
171,
141,
},
},
            new ByteMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Byte[4]
{
238,
51,
216,
158,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Byte[4]
{
237,
50,
235,
236,
},
    NullableValue = 
new System.Byte[4]
{
113,
229,
227,
144,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Byte[3]
{
103,
69,
54,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 145,
    Value = 
new System.Byte[3]
{
182,
171,
94,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
137,
229,
211,
},
},
            new ByteMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Byte[3]
{
121,
56,
21,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 151,
    Value = 
new System.Byte[4]
{
13,
208,
173,
211,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
208,
153,
119,
},
},
            new ByteMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Byte[4]
{
72,
120,
79,
96,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Byte[3]
{
105,
176,
254,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Byte[4]
{
9,
74,
182,
123,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 158,
    Value = 
new System.Byte[4]
{
171,
183,
145,
117,
},
    NullableValue = 
new System.Byte[3]
{
207,
146,
193,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Byte[3]
{
229,
55,
147,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 161,
    Value = 
new System.Byte[4]
{
41,
164,
18,
14,
},
    NullableValue = 
new System.Byte[4]
{
74,
169,
131,
96,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Byte[3]
{
206,
51,
149,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Byte[4]
{
66,
206,
122,
152,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
122,
100,
80,
178,
},
},
            new ByteMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Byte[4]
{
132,
185,
160,
149,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 174,
    Value = 
new System.Byte[3]
{
192,
139,
39,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Byte[4]
{
80,
91,
114,
67,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 176,
    Value = 
new System.Byte[3]
{
64,
123,
43,
},
    NullableValue = null,
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
INSERT INTO gedaqtests.bytemarrayd1e1m(
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
            asPartInterface: typeof(IByteMArrayMArrayD1)),
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
                    await ((IByteMArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IByteMArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.bytemarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArrayMArrayD1)),
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
                    var models = await ((IByteMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteMArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IByteMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


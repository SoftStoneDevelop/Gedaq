

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
    Id = 7,
    Value = 
new System.Byte[3]
{
92,
63,
140,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Byte[3]
{
112,
21,
224,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Byte[4]
{
100,
244,
58,
4,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Byte[3]
{
8,
15,
250,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
174,
87,
176,
136,
},
},
            new ByteMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Byte[3]
{
195,
93,
73,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Byte[4]
{
96,
226,
138,
239,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Byte[3]
{
192,
26,
234,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Byte[3]
{
112,
170,
141,
},
    NullableValue = 
new System.Byte[3]
{
253,
39,
174,
},
},
    NullableValue = 
new System.Byte[3]
{
83,
158,
113,
},
},
            new ByteMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Byte[3]
{
86,
63,
206,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Byte[4]
{
146,
218,
81,
91,
},
    NullableValue = 
new System.Byte[3]
{
25,
154,
39,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Byte[4]
{
144,
254,
82,
38,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Byte[3]
{
157,
196,
73,
},
    NullableValue = 
new System.Byte[4]
{
22,
22,
225,
48,
},
},
    NullableValue = 
new System.Byte[4]
{
62,
125,
232,
138,
},
},
            new ByteMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Byte[4]
{
239,
254,
251,
189,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Byte[4]
{
207,
23,
59,
207,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
143,
215,
41,
},
},
            new ByteMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Byte[3]
{
102,
69,
95,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Byte[3]
{
173,
106,
149,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Byte[3]
{
203,
242,
21,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Byte[3]
{
119,
197,
127,
},
    NullableValue = 
new System.Byte[4]
{
7,
87,
143,
29,
},
},
    NullableValue = 
new System.Byte[4]
{
53,
157,
22,
84,
},
},
            new ByteMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Byte[4]
{
86,
15,
205,
182,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Byte[3]
{
58,
94,
127,
},
    NullableValue = 
new System.Byte[3]
{
231,
1,
34,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Byte[3]
{
77,
190,
132,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Byte[4]
{
68,
147,
176,
11,
},
    NullableValue = 
new System.Byte[4]
{
172,
36,
54,
140,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Byte[4]
{
166,
42,
217,
121,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Byte[4]
{
184,
214,
89,
100,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Byte[3]
{
140,
207,
32,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Byte[4]
{
201,
220,
25,
180,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
39,
115,
49,
49,
},
},
            new ByteMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Byte[3]
{
13,
202,
234,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Byte[3]
{
17,
52,
207,
},
    NullableValue = 
new System.Byte[4]
{
223,
145,
142,
191,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Byte[3]
{
222,
190,
59,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Byte[3]
{
123,
205,
128,
},
    NullableValue = 
new System.Byte[4]
{
248,
152,
212,
74,
},
},
    NullableValue = 
new System.Byte[3]
{
171,
251,
168,
},
},
            new ByteMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Byte[4]
{
139,
46,
237,
93,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Byte[4]
{
64,
192,
174,
120,
},
    NullableValue = 
new System.Byte[3]
{
130,
81,
71,
},
},
    NullableValue = 
new System.Byte[3]
{
82,
221,
113,
},
},
            new ByteMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Byte[3]
{
56,
129,
234,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Byte[3]
{
19,
11,
123,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
170,
8,
50,
30,
},
},
            new ByteMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Byte[3]
{
54,
39,
13,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Byte[3]
{
151,
23,
37,
},
    NullableValue = 
new System.Byte[4]
{
188,
229,
118,
22,
},
},
    NullableValue = 
new System.Byte[4]
{
215,
221,
221,
176,
},
},
            new ByteMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Byte[4]
{
149,
89,
190,
74,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Byte[4]
{
217,
13,
218,
222,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
244,
149,
243,
},
},
            new ByteMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Byte[4]
{
37,
153,
25,
55,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Byte[4]
{
48,
39,
226,
234,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
119,
215,
158,
},
},
            new ByteMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Byte[4]
{
238,
18,
220,
142,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Byte[4]
{
1,
198,
80,
169,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
139,
246,
120,
225,
},
},
            new ByteMArrayD1E1M
{
    Id = 102,
    Value = 
new System.Byte[4]
{
228,
105,
55,
198,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.Byte[4]
{
240,
37,
138,
198,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
118,
126,
239,
66,
},
},
            new ByteMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Byte[3]
{
42,
182,
237,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Byte[4]
{
214,
179,
20,
22,
},
    NullableValue = 
new System.Byte[4]
{
150,
239,
32,
91,
},
},
    NullableValue = 
new System.Byte[4]
{
71,
27,
60,
160,
},
},
            new ByteMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Byte[4]
{
110,
99,
247,
56,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 105,
    Value = 
new System.Byte[4]
{
246,
34,
71,
41,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
232,
119,
158,
},
},
            new ByteMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Byte[4]
{
145,
193,
46,
7,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 111,
    Value = 
new System.Byte[3]
{
94,
131,
191,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
182,
238,
111,
},
},
            new ByteMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Byte[3]
{
26,
238,
128,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 119,
    Value = 
new System.Byte[4]
{
96,
161,
128,
232,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Byte[4]
{
167,
132,
92,
126,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 126,
    Value = 
new System.Byte[4]
{
7,
9,
14,
222,
},
    NullableValue = 
new System.Byte[3]
{
111,
161,
82,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Byte[4]
{
47,
154,
144,
61,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 131,
    Value = 
new System.Byte[4]
{
225,
174,
247,
189,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
77,
153,
206,
},
},
            new ByteMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Byte[3]
{
29,
226,
43,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 136,
    Value = 
new System.Byte[4]
{
191,
156,
158,
66,
},
    NullableValue = 
new System.Byte[4]
{
176,
39,
131,
180,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Byte[3]
{
67,
147,
199,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Byte[3]
{
138,
136,
243,
},
    NullableValue = 
new System.Byte[3]
{
62,
43,
125,
},
},
    NullableValue = 
new System.Byte[4]
{
112,
81,
159,
9,
},
},
            new ByteMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Byte[3]
{
218,
95,
223,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 142,
    Value = 
new System.Byte[3]
{
170,
189,
158,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
35,
45,
152,
},
},
            new ByteMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Byte[3]
{
192,
32,
220,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Byte[4]
{
26,
189,
193,
78,
},
    NullableValue = 
new System.Byte[4]
{
76,
186,
235,
54,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Byte[4]
{
42,
176,
241,
30,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Byte[4]
{
136,
46,
7,
50,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 179,
    Value = 
new System.Byte[4]
{
88,
211,
140,
137,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Byte[4]
{
89,
249,
167,
226,
},
    NullableValue = 
new System.Byte[3]
{
53,
149,
43,
},
},
    NullableValue = 
new System.Byte[4]
{
243,
155,
194,
247,
},
},
            new ByteMArrayD1E1M
{
    Id = 187,
    Value = 
new System.Byte[4]
{
124,
22,
248,
247,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Byte[4]
{
135,
153,
41,
1,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
24,
62,
113,
182,
},
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


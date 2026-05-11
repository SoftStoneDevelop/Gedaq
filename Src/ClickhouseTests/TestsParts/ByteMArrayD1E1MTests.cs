

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
    Id = 9,
    Value = 
new System.Byte[3]
{
184,
104,
228,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Byte[3]
{
92,
243,
76,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Byte[4]
{
242,
166,
16,
169,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Byte[3]
{
253,
98,
129,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
87,
210,
53,
202,
},
},
            new ByteMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Byte[3]
{
47,
148,
221,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Byte[4]
{
140,
19,
66,
100,
},
    NullableValue = 
new System.Byte[3]
{
45,
246,
108,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Byte[3]
{
124,
14,
54,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Byte[3]
{
13,
149,
92,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Byte[3]
{
207,
10,
53,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Byte[3]
{
80,
157,
245,
},
    NullableValue = 
new System.Byte[3]
{
242,
205,
182,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Byte[3]
{
251,
68,
50,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Byte[4]
{
154,
229,
254,
155,
},
    NullableValue = 
new System.Byte[3]
{
206,
120,
224,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Byte[3]
{
17,
113,
56,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Byte[3]
{
208,
170,
232,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Byte[3]
{
80,
183,
203,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Byte[3]
{
103,
56,
165,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
223,
67,
219,
179,
},
},
            new ByteMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Byte[4]
{
234,
88,
185,
123,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Byte[4]
{
125,
117,
164,
41,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
175,
128,
44,
209,
},
},
            new ByteMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Byte[4]
{
150,
197,
31,
250,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Byte[4]
{
233,
125,
235,
144,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Byte[4]
{
75,
59,
184,
56,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Byte[4]
{
181,
83,
136,
35,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Byte[4]
{
189,
189,
198,
120,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Byte[4]
{
198,
93,
130,
173,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
111,
94,
56,
95,
},
},
            new ByteMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Byte[4]
{
182,
121,
228,
96,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Byte[3]
{
158,
120,
91,
},
    NullableValue = 
new System.Byte[3]
{
53,
191,
52,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Byte[3]
{
154,
184,
36,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Byte[3]
{
69,
206,
21,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
161,
109,
80,
},
},
            new ByteMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Byte[3]
{
143,
121,
48,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Byte[3]
{
6,
233,
30,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Byte[3]
{
196,
44,
139,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Byte[4]
{
173,
206,
209,
14,
},
    NullableValue = 
new System.Byte[4]
{
122,
187,
120,
245,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Byte[4]
{
187,
48,
180,
37,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Byte[4]
{
86,
79,
231,
251,
},
    NullableValue = 
new System.Byte[4]
{
245,
130,
147,
182,
},
},
    NullableValue = 
new System.Byte[4]
{
0,
152,
69,
37,
},
},
            new ByteMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Byte[3]
{
24,
126,
54,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Byte[3]
{
202,
124,
202,
},
    NullableValue = 
new System.Byte[4]
{
228,
86,
169,
209,
},
},
    NullableValue = 
new System.Byte[3]
{
88,
238,
210,
},
},
            new ByteMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Byte[4]
{
55,
243,
156,
109,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Byte[3]
{
78,
227,
136,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
166,
138,
99,
130,
},
},
            new ByteMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Byte[4]
{
177,
210,
197,
38,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Byte[3]
{
182,
105,
192,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
58,
105,
93,
},
},
            new ByteMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Byte[4]
{
176,
74,
174,
227,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Byte[4]
{
128,
64,
20,
28,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
83,
145,
68,
235,
},
},
            new ByteMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Byte[3]
{
215,
200,
64,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.Byte[3]
{
82,
96,
175,
},
    NullableValue = 
new System.Byte[4]
{
122,
100,
187,
219,
},
},
    NullableValue = 
new System.Byte[3]
{
251,
226,
254,
},
},
            new ByteMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Byte[4]
{
247,
149,
4,
0,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Byte[3]
{
240,
164,
31,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Byte[4]
{
216,
90,
51,
138,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Byte[4]
{
21,
140,
161,
149,
},
    NullableValue = 
new System.Byte[4]
{
121,
200,
225,
141,
},
},
    NullableValue = 
new System.Byte[3]
{
144,
156,
41,
},
},
            new ByteMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Byte[3]
{
17,
61,
113,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Byte[3]
{
81,
175,
130,
},
    NullableValue = 
new System.Byte[3]
{
8,
226,
178,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Byte[4]
{
56,
175,
57,
200,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 117,
    Value = 
new System.Byte[3]
{
176,
65,
119,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
111,
38,
67,
},
},
            new ByteMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Byte[4]
{
136,
168,
233,
1,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Byte[4]
{
243,
1,
97,
169,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
146,
42,
225,
238,
},
},
            new ByteMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Byte[3]
{
184,
72,
213,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Byte[4]
{
58,
126,
164,
61,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Byte[4]
{
10,
91,
124,
20,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 141,
    Value = 
new System.Byte[4]
{
92,
43,
34,
187,
},
    NullableValue = 
new System.Byte[4]
{
73,
122,
47,
95,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Byte[3]
{
212,
17,
171,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Byte[4]
{
113,
219,
195,
13,
},
    NullableValue = 
new System.Byte[3]
{
37,
131,
137,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Byte[4]
{
212,
196,
129,
188,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 148,
    Value = 
new System.Byte[3]
{
54,
118,
172,
},
    NullableValue = 
new System.Byte[4]
{
166,
116,
231,
168,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 177,
    Value = 
new System.Byte[4]
{
232,
220,
231,
92,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Byte[4]
{
28,
139,
128,
234,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 180,
    Value = 
new System.Byte[4]
{
97,
113,
24,
92,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Byte[4]
{
13,
118,
194,
36,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
70,
95,
121,
},
},
            new ByteMArrayD1E1M
{
    Id = 183,
    Value = 
new System.Byte[3]
{
56,
213,
3,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 158,
    Value = 
new System.Byte[3]
{
76,
51,
97,
},
    NullableValue = 
new System.Byte[4]
{
190,
101,
51,
9,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 184,
    Value = 
new System.Byte[3]
{
99,
136,
194,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Byte[4]
{
205,
31,
35,
116,
},
    NullableValue = 
new System.Byte[4]
{
220,
75,
50,
164,
},
},
    NullableValue = 
new System.Byte[4]
{
114,
219,
144,
172,
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


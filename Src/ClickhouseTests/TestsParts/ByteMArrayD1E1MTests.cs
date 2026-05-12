

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
    Id = 3,
    Value = 
new System.Byte[4]
{
103,
213,
60,
79,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Byte[3]
{
227,
122,
112,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
206,
188,
251,
},
},
            new ByteMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Byte[3]
{
136,
250,
134,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Byte[4]
{
53,
237,
8,
208,
},
    NullableValue = 
new System.Byte[4]
{
194,
8,
144,
150,
},
},
    NullableValue = 
new System.Byte[3]
{
36,
245,
3,
},
},
            new ByteMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Byte[4]
{
126,
225,
39,
199,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Byte[3]
{
182,
4,
188,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
226,
1,
49,
53,
},
},
            new ByteMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Byte[4]
{
89,
5,
229,
73,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Byte[4]
{
251,
169,
103,
114,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
125,
183,
97,
},
},
            new ByteMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Byte[3]
{
117,
69,
207,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Byte[4]
{
129,
5,
208,
224,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Byte[3]
{
213,
48,
65,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Byte[4]
{
51,
48,
71,
68,
},
    NullableValue = 
new System.Byte[3]
{
37,
106,
202,
},
},
    NullableValue = 
new System.Byte[4]
{
134,
196,
95,
231,
},
},
            new ByteMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Byte[3]
{
244,
110,
21,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Byte[4]
{
238,
99,
186,
158,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
26,
192,
168,
240,
},
},
            new ByteMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Byte[4]
{
93,
240,
134,
38,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Byte[4]
{
55,
141,
56,
51,
},
    NullableValue = 
new System.Byte[4]
{
78,
96,
153,
226,
},
},
    NullableValue = 
new System.Byte[3]
{
154,
182,
123,
},
},
            new ByteMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Byte[3]
{
103,
157,
54,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Byte[4]
{
131,
91,
128,
175,
},
    NullableValue = 
new System.Byte[3]
{
235,
66,
68,
},
},
    NullableValue = 
new System.Byte[3]
{
116,
11,
206,
},
},
            new ByteMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Byte[3]
{
158,
13,
86,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Byte[4]
{
178,
94,
91,
54,
},
    NullableValue = 
new System.Byte[4]
{
192,
24,
113,
132,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Byte[3]
{
187,
23,
46,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Byte[4]
{
92,
232,
254,
118,
},
    NullableValue = 
new System.Byte[3]
{
14,
105,
39,
},
},
    NullableValue = 
new System.Byte[3]
{
21,
218,
39,
},
},
            new ByteMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Byte[3]
{
185,
62,
184,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Byte[4]
{
96,
42,
3,
165,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Byte[3]
{
240,
191,
92,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Byte[4]
{
236,
59,
243,
184,
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
60,
89,
105,
30,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Byte[3]
{
195,
122,
91,
},
    NullableValue = 
new System.Byte[4]
{
83,
67,
76,
16,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Byte[3]
{
54,
222,
44,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Byte[4]
{
113,
199,
80,
239,
},
    NullableValue = 
new System.Byte[4]
{
55,
243,
86,
170,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Byte[3]
{
113,
99,
194,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Byte[3]
{
40,
66,
253,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Byte[3]
{
197,
56,
47,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Byte[3]
{
179,
89,
235,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Byte[4]
{
149,
168,
218,
145,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Byte[4]
{
55,
31,
22,
59,
},
    NullableValue = 
new System.Byte[3]
{
138,
183,
177,
},
},
    NullableValue = 
new System.Byte[4]
{
143,
200,
99,
165,
},
},
            new ByteMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Byte[3]
{
202,
111,
243,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Byte[4]
{
21,
21,
17,
5,
},
    NullableValue = 
new System.Byte[4]
{
55,
117,
179,
126,
},
},
    NullableValue = 
new System.Byte[3]
{
241,
187,
177,
},
},
            new ByteMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Byte[4]
{
135,
35,
34,
13,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Byte[3]
{
80,
127,
176,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Byte[3]
{
44,
233,
215,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Byte[4]
{
50,
14,
3,
220,
},
    NullableValue = 
new System.Byte[4]
{
154,
33,
16,
158,
},
},
    NullableValue = 
new System.Byte[4]
{
213,
17,
237,
106,
},
},
            new ByteMArrayD1E1M
{
    Id = 102,
    Value = 
new System.Byte[4]
{
196,
182,
128,
177,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 113,
    Value = 
new System.Byte[3]
{
104,
109,
166,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
47,
82,
15,
133,
},
},
            new ByteMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Byte[3]
{
89,
154,
15,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 121,
    Value = 
new System.Byte[4]
{
232,
21,
163,
252,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Byte[3]
{
206,
115,
153,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Byte[4]
{
168,
72,
90,
87,
},
    NullableValue = 
new System.Byte[3]
{
72,
143,
70,
},
},
    NullableValue = 
new System.Byte[4]
{
221,
104,
84,
58,
},
},
            new ByteMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Byte[3]
{
131,
120,
109,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Byte[4]
{
127,
96,
2,
186,
},
    NullableValue = 
new System.Byte[4]
{
5,
214,
43,
248,
},
},
    NullableValue = 
new System.Byte[4]
{
93,
252,
253,
136,
},
},
            new ByteMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Byte[3]
{
54,
177,
208,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Byte[4]
{
81,
231,
146,
12,
},
    NullableValue = 
new System.Byte[4]
{
241,
72,
196,
157,
},
},
    NullableValue = 
new System.Byte[4]
{
62,
32,
216,
6,
},
},
            new ByteMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Byte[4]
{
70,
12,
134,
166,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Byte[4]
{
108,
35,
151,
233,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Byte[3]
{
164,
66,
17,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.Byte[3]
{
220,
139,
185,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Byte[3]
{
170,
42,
97,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 148,
    Value = 
new System.Byte[3]
{
194,
13,
35,
},
    NullableValue = 
new System.Byte[3]
{
209,
104,
20,
},
},
    NullableValue = 
new System.Byte[4]
{
143,
144,
139,
97,
},
},
            new ByteMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Byte[3]
{
65,
90,
106,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Byte[3]
{
1,
218,
19,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
43,
125,
78,
214,
},
},
            new ByteMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Byte[3]
{
146,
115,
254,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Byte[4]
{
140,
217,
149,
111,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Byte[3]
{
164,
141,
49,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 158,
    Value = 
new System.Byte[3]
{
4,
68,
143,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Byte[3]
{
210,
123,
2,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 160,
    Value = 
new System.Byte[3]
{
187,
40,
172,
},
    NullableValue = 
new System.Byte[3]
{
194,
235,
56,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Byte[4]
{
142,
209,
66,
0,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 167,
    Value = 
new System.Byte[3]
{
209,
106,
52,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Byte[4]
{
63,
248,
251,
158,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 175,
    Value = 
new System.Byte[3]
{
176,
110,
208,
},
    NullableValue = 
new System.Byte[4]
{
194,
112,
179,
240,
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




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
    Id = 5,
    Value = 
new System.Byte[3]
{
37,
80,
226,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Byte[4]
{
204,
151,
42,
185,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Byte[3]
{
216,
84,
17,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Byte[3]
{
233,
123,
23,
},
    NullableValue = 
new System.Byte[4]
{
19,
248,
130,
27,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Byte[3]
{
171,
9,
217,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Byte[3]
{
110,
25,
207,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
173,
42,
181,
},
},
            new ByteMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Byte[4]
{
219,
95,
128,
124,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Byte[3]
{
42,
148,
171,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
7,
245,
113,
135,
},
},
            new ByteMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Byte[3]
{
149,
42,
148,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Byte[3]
{
58,
80,
202,
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
59,
225,
54,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Byte[3]
{
44,
138,
170,
},
    NullableValue = 
new System.Byte[3]
{
144,
174,
109,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Byte[3]
{
128,
221,
3,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Byte[3]
{
245,
120,
132,
},
    NullableValue = 
new System.Byte[4]
{
220,
72,
32,
112,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Byte[3]
{
247,
38,
83,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Byte[4]
{
170,
156,
94,
132,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
139,
209,
150,
},
},
            new ByteMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Byte[3]
{
230,
242,
60,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Byte[4]
{
69,
137,
102,
40,
},
    NullableValue = 
new System.Byte[3]
{
13,
161,
43,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Byte[4]
{
175,
64,
193,
98,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Byte[3]
{
34,
213,
147,
},
    NullableValue = 
new System.Byte[4]
{
28,
239,
164,
249,
},
},
    NullableValue = 
new System.Byte[3]
{
146,
83,
135,
},
},
            new ByteMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Byte[3]
{
204,
221,
156,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Byte[4]
{
17,
185,
21,
10,
},
    NullableValue = 
new System.Byte[4]
{
153,
198,
159,
249,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Byte[4]
{
106,
124,
31,
78,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Byte[3]
{
120,
214,
73,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
146,
193,
166,
116,
},
},
            new ByteMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Byte[3]
{
160,
143,
14,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Byte[3]
{
135,
41,
50,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
32,
27,
107,
31,
},
},
            new ByteMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Byte[3]
{
114,
131,
228,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Byte[4]
{
26,
250,
251,
33,
},
    NullableValue = 
new System.Byte[3]
{
183,
154,
68,
},
},
    NullableValue = 
new System.Byte[4]
{
181,
248,
83,
23,
},
},
            new ByteMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Byte[3]
{
218,
149,
219,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Byte[4]
{
117,
200,
239,
43,
},
    NullableValue = 
new System.Byte[4]
{
202,
90,
101,
105,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Byte[3]
{
101,
18,
235,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Byte[3]
{
111,
216,
253,
},
    NullableValue = 
new System.Byte[4]
{
8,
102,
90,
202,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Byte[3]
{
39,
122,
145,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Byte[3]
{
137,
84,
48,
},
    NullableValue = 
new System.Byte[3]
{
133,
153,
114,
},
},
    NullableValue = 
new System.Byte[3]
{
183,
39,
123,
},
},
            new ByteMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Byte[4]
{
74,
59,
225,
30,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Byte[4]
{
224,
190,
229,
109,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Byte[4]
{
177,
99,
89,
170,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Byte[3]
{
54,
171,
232,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Byte[4]
{
13,
69,
81,
34,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Byte[3]
{
107,
228,
175,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
89,
208,
53,
},
},
            new ByteMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Byte[3]
{
248,
76,
118,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Byte[3]
{
243,
51,
107,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Byte[3]
{
10,
4,
246,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Byte[3]
{
237,
128,
222,
},
    NullableValue = 
new System.Byte[3]
{
94,
101,
23,
},
},
    NullableValue = 
new System.Byte[3]
{
228,
223,
96,
},
},
            new ByteMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Byte[4]
{
171,
32,
133,
4,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Byte[3]
{
120,
106,
171,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Byte[4]
{
233,
182,
241,
2,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Byte[3]
{
59,
205,
199,
},
    NullableValue = 
new System.Byte[3]
{
56,
65,
230,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Byte[4]
{
253,
172,
58,
25,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Byte[4]
{
168,
233,
15,
189,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
121,
69,
48,
234,
},
},
            new ByteMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Byte[4]
{
210,
172,
7,
49,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 152,
    Value = 
new System.Byte[4]
{
15,
248,
45,
72,
},
    NullableValue = 
new System.Byte[4]
{
222,
12,
105,
196,
},
},
    NullableValue = 
new System.Byte[4]
{
104,
209,
41,
105,
},
},
            new ByteMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Byte[4]
{
70,
23,
85,
232,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 158,
    Value = 
new System.Byte[4]
{
162,
209,
181,
62,
},
    NullableValue = 
new System.Byte[3]
{
247,
62,
19,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Byte[3]
{
210,
242,
113,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 159,
    Value = 
new System.Byte[3]
{
235,
87,
231,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
42,
39,
179,
},
},
            new ByteMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Byte[3]
{
36,
221,
20,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 161,
    Value = 
new System.Byte[3]
{
208,
114,
126,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 159,
    Value = 
new System.Byte[4]
{
226,
164,
110,
28,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Byte[4]
{
184,
85,
28,
24,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
197,
225,
10,
135,
},
},
            new ByteMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Byte[4]
{
38,
212,
8,
71,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 173,
    Value = 
new System.Byte[3]
{
247,
227,
100,
},
    NullableValue = 
new System.Byte[3]
{
89,
97,
249,
},
},
    NullableValue = 
new System.Byte[3]
{
172,
220,
175,
},
},
            new ByteMArrayD1E1M
{
    Id = 176,
    Value = 
new System.Byte[3]
{
189,
125,
43,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 178,
    Value = 
new System.Byte[3]
{
141,
41,
106,
},
    NullableValue = 
new System.Byte[4]
{
124,
205,
252,
2,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 178,
    Value = 
new System.Byte[4]
{
97,
33,
31,
108,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 179,
    Value = 
new System.Byte[3]
{
151,
111,
0,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 185,
    Value = 
new System.Byte[3]
{
70,
84,
230,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 187,
    Value = 
new System.Byte[4]
{
233,
167,
123,
158,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
186,
52,
19,
},
},
            new ByteMArrayD1E1M
{
    Id = 188,
    Value = 
new System.Byte[3]
{
80,
163,
201,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 190,
    Value = 
new System.Byte[3]
{
146,
35,
236,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
7,
107,
157,
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




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
238,
55,
157,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Byte[4]
{
188,
79,
15,
117,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Byte[3]
{
168,
191,
172,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Byte[4]
{
14,
193,
160,
109,
},
    NullableValue = 
new System.Byte[3]
{
65,
183,
219,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Byte[4]
{
213,
198,
139,
88,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Byte[4]
{
136,
253,
86,
14,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Byte[3]
{
3,
9,
223,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Byte[4]
{
184,
244,
78,
163,
},
    NullableValue = 
new System.Byte[4]
{
240,
47,
251,
158,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Byte[4]
{
246,
253,
74,
87,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Byte[4]
{
146,
116,
71,
95,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
210,
70,
25,
},
},
            new ByteMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Byte[4]
{
179,
124,
169,
23,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Byte[4]
{
0,
43,
83,
152,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
161,
23,
119,
243,
},
},
            new ByteMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Byte[4]
{
86,
53,
110,
47,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Byte[3]
{
114,
73,
98,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Byte[4]
{
178,
80,
109,
136,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Byte[4]
{
80,
150,
136,
11,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
33,
81,
245,
87,
},
},
            new ByteMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Byte[4]
{
27,
19,
19,
221,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Byte[3]
{
245,
163,
185,
},
    NullableValue = 
new System.Byte[3]
{
195,
81,
106,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Byte[4]
{
203,
78,
35,
125,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Byte[4]
{
143,
220,
145,
96,
},
    NullableValue = 
new System.Byte[4]
{
252,
68,
224,
214,
},
},
    NullableValue = 
new System.Byte[4]
{
139,
192,
134,
35,
},
},
            new ByteMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Byte[3]
{
190,
179,
228,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Byte[3]
{
105,
46,
103,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Byte[4]
{
190,
161,
214,
54,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Byte[3]
{
193,
134,
65,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
240,
110,
165,
165,
},
},
            new ByteMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Byte[3]
{
221,
60,
138,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Byte[3]
{
56,
208,
252,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
166,
145,
92,
},
},
            new ByteMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Byte[4]
{
28,
224,
190,
16,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Byte[4]
{
79,
212,
146,
187,
},
    NullableValue = 
new System.Byte[4]
{
169,
64,
181,
204,
},
},
    NullableValue = 
new System.Byte[4]
{
171,
166,
120,
179,
},
},
            new ByteMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Byte[3]
{
199,
209,
9,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Byte[3]
{
16,
156,
116,
},
    NullableValue = 
new System.Byte[4]
{
211,
225,
41,
87,
},
},
    NullableValue = 
new System.Byte[3]
{
154,
167,
224,
},
},
            new ByteMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Byte[4]
{
13,
225,
37,
117,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Byte[3]
{
175,
218,
161,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
117,
59,
248,
},
},
            new ByteMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Byte[3]
{
157,
203,
106,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Byte[3]
{
253,
40,
89,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
91,
126,
229,
},
},
            new ByteMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Byte[4]
{
59,
85,
158,
48,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Byte[3]
{
186,
0,
223,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
141,
149,
99,
244,
},
},
            new ByteMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Byte[3]
{
24,
45,
120,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Byte[4]
{
105,
40,
96,
250,
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
78,
179,
173,
7,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Byte[3]
{
171,
196,
205,
},
    NullableValue = 
new System.Byte[3]
{
93,
60,
163,
},
},
    NullableValue = 
new System.Byte[3]
{
123,
18,
71,
},
},
            new ByteMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Byte[4]
{
96,
100,
12,
40,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Byte[4]
{
47,
156,
90,
127,
},
    NullableValue = 
new System.Byte[3]
{
0,
153,
134,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Byte[4]
{
75,
21,
231,
176,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 110,
    Value = 
new System.Byte[3]
{
73,
41,
25,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Byte[4]
{
150,
115,
182,
102,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Byte[3]
{
31,
120,
114,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Byte[3]
{
110,
160,
30,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Byte[3]
{
219,
242,
13,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
93,
226,
3,
132,
},
},
            new ByteMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Byte[4]
{
57,
78,
136,
235,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Byte[4]
{
164,
91,
132,
104,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Byte[3]
{
171,
183,
99,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 131,
    Value = 
new System.Byte[4]
{
228,
209,
46,
31,
},
    NullableValue = 
new System.Byte[4]
{
137,
243,
180,
56,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Byte[3]
{
104,
191,
102,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Byte[4]
{
152,
231,
135,
215,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
1,
228,
171,
},
},
            new ByteMArrayD1E1M
{
    Id = 145,
    Value = 
new System.Byte[4]
{
144,
163,
145,
120,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Byte[3]
{
91,
13,
94,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
148,
144,
143,
0,
},
},
            new ByteMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Byte[4]
{
177,
63,
8,
117,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Byte[4]
{
116,
6,
119,
8,
},
    NullableValue = 
new System.Byte[3]
{
79,
233,
81,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Byte[3]
{
35,
112,
129,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Byte[4]
{
30,
235,
225,
204,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
190,
200,
41,
183,
},
},
            new ByteMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Byte[3]
{
106,
130,
60,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 158,
    Value = 
new System.Byte[3]
{
236,
14,
205,
},
    NullableValue = 
new System.Byte[3]
{
252,
24,
172,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Byte[4]
{
250,
245,
17,
14,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Byte[4]
{
117,
88,
43,
219,
},
    NullableValue = 
new System.Byte[4]
{
57,
149,
96,
0,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 166,
    Value = 
new System.Byte[3]
{
176,
36,
123,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 172,
    Value = 
new System.Byte[3]
{
45,
50,
69,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Byte[4]
{
223,
156,
35,
196,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 175,
    Value = 
new System.Byte[3]
{
231,
228,
111,
},
    NullableValue = 
new System.Byte[3]
{
96,
218,
98,
},
},
    NullableValue = 
new System.Byte[3]
{
110,
34,
230,
},
},
            new ByteMArrayD1E1M
{
    Id = 174,
    Value = 
new System.Byte[4]
{
12,
122,
46,
179,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 179,
    Value = 
new System.Byte[3]
{
175,
16,
57,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
203,
185,
219,
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


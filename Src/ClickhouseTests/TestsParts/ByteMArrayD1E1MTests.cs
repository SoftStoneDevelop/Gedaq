

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
    Id = 6,
    Value = 
new System.Byte[3]
{
141,
120,
8,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Byte[3]
{
163,
55,
145,
},
    NullableValue = 
new System.Byte[3]
{
7,
182,
29,
},
},
    NullableValue = 
new System.Byte[4]
{
142,
74,
176,
139,
},
},
            new ByteMArrayD1E1M
{
    Id = 10,
    Value = 
new System.Byte[3]
{
84,
109,
112,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Byte[3]
{
75,
56,
4,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Byte[3]
{
121,
221,
84,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Byte[3]
{
30,
189,
116,
},
    NullableValue = 
new System.Byte[3]
{
83,
52,
163,
},
},
    NullableValue = 
new System.Byte[4]
{
145,
35,
52,
213,
},
},
            new ByteMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Byte[4]
{
116,
229,
224,
210,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Byte[3]
{
117,
197,
76,
},
    NullableValue = 
new System.Byte[3]
{
112,
165,
154,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Byte[3]
{
132,
29,
53,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Byte[4]
{
239,
53,
137,
215,
},
    NullableValue = 
new System.Byte[4]
{
36,
11,
59,
97,
},
},
    NullableValue = 
new System.Byte[3]
{
216,
97,
214,
},
},
            new ByteMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Byte[3]
{
163,
100,
198,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Byte[4]
{
104,
183,
241,
3,
},
    NullableValue = 
new System.Byte[3]
{
6,
40,
82,
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
138,
209,
226,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Byte[4]
{
152,
169,
119,
225,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
142,
15,
55,
},
},
            new ByteMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Byte[4]
{
253,
171,
116,
13,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Byte[4]
{
72,
82,
240,
79,
},
    NullableValue = 
new System.Byte[3]
{
130,
88,
193,
},
},
    NullableValue = 
new System.Byte[4]
{
59,
209,
211,
168,
},
},
            new ByteMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Byte[3]
{
208,
100,
236,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Byte[4]
{
205,
160,
147,
1,
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
108,
19,
192,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Byte[4]
{
28,
159,
145,
92,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Byte[3]
{
129,
8,
198,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Byte[4]
{
85,
229,
4,
96,
},
    NullableValue = 
new System.Byte[4]
{
145,
221,
55,
150,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Byte[4]
{
90,
106,
185,
101,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Byte[3]
{
93,
204,
52,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Byte[4]
{
23,
15,
161,
31,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Byte[3]
{
115,
135,
191,
},
    NullableValue = 
new System.Byte[4]
{
221,
73,
190,
51,
},
},
    NullableValue = 
new System.Byte[4]
{
136,
235,
218,
35,
},
},
            new ByteMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Byte[4]
{
58,
237,
60,
85,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Byte[3]
{
242,
96,
128,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
73,
184,
136,
137,
},
},
            new ByteMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Byte[3]
{
175,
158,
196,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Byte[3]
{
146,
101,
144,
},
    NullableValue = 
new System.Byte[3]
{
47,
130,
191,
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
31,
239,
129,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Byte[4]
{
52,
164,
149,
53,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
78,
189,
61,
136,
},
},
            new ByteMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Byte[3]
{
109,
48,
228,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Byte[4]
{
129,
69,
115,
9,
},
    NullableValue = 
new System.Byte[3]
{
162,
7,
211,
},
},
    NullableValue = 
new System.Byte[3]
{
0,
95,
102,
},
},
            new ByteMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Byte[4]
{
251,
26,
63,
139,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Byte[4]
{
208,
85,
1,
74,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
34,
247,
82,
171,
},
},
            new ByteMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Byte[4]
{
118,
9,
179,
199,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Byte[4]
{
54,
35,
239,
96,
},
    NullableValue = 
new System.Byte[4]
{
156,
183,
33,
137,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 108,
    Value = 
new System.Byte[4]
{
241,
79,
197,
251,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Byte[3]
{
166,
235,
207,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
159,
174,
174,
89,
},
},
            new ByteMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Byte[4]
{
197,
102,
136,
111,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Byte[4]
{
168,
4,
168,
88,
},
    NullableValue = 
new System.Byte[4]
{
212,
14,
175,
240,
},
},
    NullableValue = 
new System.Byte[4]
{
142,
151,
78,
168,
},
},
            new ByteMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Byte[4]
{
167,
105,
97,
236,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Byte[4]
{
111,
3,
78,
76,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Byte[4]
{
251,
13,
237,
81,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Byte[3]
{
166,
186,
98,
},
    NullableValue = 
new System.Byte[3]
{
162,
145,
74,
},
},
    NullableValue = 
new System.Byte[4]
{
10,
26,
126,
207,
},
},
            new ByteMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Byte[3]
{
18,
82,
199,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Byte[4]
{
167,
152,
21,
141,
},
    NullableValue = 
new System.Byte[4]
{
69,
233,
64,
114,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Byte[3]
{
86,
198,
35,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Byte[4]
{
6,
23,
175,
167,
},
    NullableValue = 
new System.Byte[4]
{
124,
241,
62,
156,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Byte[4]
{
60,
176,
89,
212,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 131,
    Value = 
new System.Byte[3]
{
43,
114,
180,
},
    NullableValue = 
new System.Byte[3]
{
0,
182,
81,
},
},
    NullableValue = null,
},
            new ByteMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Byte[3]
{
244,
7,
204,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Byte[4]
{
120,
184,
109,
176,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
115,
167,
78,
},
},
            new ByteMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Byte[3]
{
192,
87,
176,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Byte[3]
{
207,
134,
127,
},
    NullableValue = 
new System.Byte[4]
{
250,
0,
114,
24,
},
},
    NullableValue = 
new System.Byte[3]
{
143,
51,
132,
},
},
            new ByteMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Byte[4]
{
62,
231,
81,
110,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Byte[3]
{
222,
164,
183,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
61,
120,
27,
},
},
            new ByteMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Byte[3]
{
64,
204,
190,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Byte[3]
{
218,
110,
210,
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
27,
171,
30,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Byte[4]
{
127,
82,
33,
214,
},
    NullableValue = 
new System.Byte[4]
{
135,
183,
119,
254,
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
70,
18,
230,
70,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 169,
    Value = 
new System.Byte[3]
{
66,
194,
59,
},
    NullableValue = 
new System.Byte[4]
{
202,
134,
228,
114,
},
},
    NullableValue = 
new System.Byte[4]
{
221,
37,
26,
46,
},
},
            new ByteMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Byte[4]
{
254,
150,
38,
51,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 177,
    Value = 
new System.Byte[4]
{
251,
235,
186,
172,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
234,
97,
50,
},
},
            new ByteMArrayD1E1M
{
    Id = 178,
    Value = 
new System.Byte[3]
{
42,
254,
74,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 178,
    Value = 
new System.Byte[3]
{
102,
226,
74,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
21,
128,
224,
},
},
            new ByteMArrayD1E1M
{
    Id = 186,
    Value = 
new System.Byte[4]
{
212,
235,
166,
138,
},
    ModelInner = new ByteMArrayD1E1MI
{
    Id = 184,
    Value = 
new System.Byte[4]
{
120,
103,
13,
159,
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


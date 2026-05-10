

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
    internal partial interface IByteArrayUInt8Array
    {
    }
    
    internal partial class ByteArrayUInt8Array : IByteArrayUInt8Array
    {


#region TestData

        private readonly ByteUInt8Array1M[] _testData = new ByteUInt8Array1M[]
        {
            new ByteUInt8Array1M
{
    Id = 5,
    Value = 
new System.Byte[3]
{
118,
247,
187,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 2,
    Value = 
new System.Byte[4]
{
153,
142,
36,
197,
},
    NullableValue = 
new System.Byte[3]
{
193,
87,
227,
},
},
    NullableValue = 
new System.Byte[3]
{
92,
190,
190,
},
},
            new ByteUInt8Array1M
{
    Id = 12,
    Value = 
new System.Byte[4]
{
123,
88,
220,
17,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 10,
    Value = 
new System.Byte[3]
{
169,
221,
188,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
6,
7,
201,
207,
},
},
            new ByteUInt8Array1M
{
    Id = 19,
    Value = 
new System.Byte[4]
{
205,
205,
224,
109,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 15,
    Value = 
new System.Byte[4]
{
63,
80,
84,
181,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
118,
134,
123,
95,
},
},
            new ByteUInt8Array1M
{
    Id = 26,
    Value = 
new System.Byte[4]
{
165,
128,
51,
209,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 21,
    Value = 
new System.Byte[3]
{
30,
40,
25,
},
    NullableValue = 
new System.Byte[4]
{
9,
98,
165,
172,
},
},
    NullableValue = 
new System.Byte[3]
{
98,
46,
80,
},
},
            new ByteUInt8Array1M
{
    Id = 35,
    Value = 
new System.Byte[4]
{
140,
73,
111,
151,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 26,
    Value = 
new System.Byte[4]
{
228,
78,
32,
224,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
141,
160,
217,
},
},
            new ByteUInt8Array1M
{
    Id = 43,
    Value = 
new System.Byte[3]
{
132,
87,
147,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 32,
    Value = 
new System.Byte[3]
{
143,
129,
72,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 47,
    Value = 
new System.Byte[4]
{
68,
239,
26,
240,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 34,
    Value = 
new System.Byte[4]
{
116,
192,
35,
114,
},
    NullableValue = 
new System.Byte[3]
{
188,
167,
109,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 49,
    Value = 
new System.Byte[4]
{
128,
29,
147,
128,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 39,
    Value = 
new System.Byte[3]
{
137,
38,
200,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
151,
160,
54,
},
},
            new ByteUInt8Array1M
{
    Id = 51,
    Value = 
new System.Byte[3]
{
220,
97,
179,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 43,
    Value = 
new System.Byte[4]
{
217,
228,
6,
72,
},
    NullableValue = 
new System.Byte[4]
{
129,
225,
115,
194,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 54,
    Value = 
new System.Byte[4]
{
243,
48,
35,
243,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 44,
    Value = 
new System.Byte[3]
{
80,
66,
253,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 62,
    Value = 
new System.Byte[3]
{
103,
194,
153,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 49,
    Value = 
new System.Byte[3]
{
165,
105,
113,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 66,
    Value = 
new System.Byte[4]
{
133,
183,
179,
147,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 55,
    Value = 
new System.Byte[3]
{
230,
115,
62,
},
    NullableValue = 
new System.Byte[4]
{
253,
27,
38,
168,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 67,
    Value = 
new System.Byte[4]
{
81,
249,
190,
212,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 63,
    Value = 
new System.Byte[4]
{
159,
205,
33,
48,
},
    NullableValue = 
new System.Byte[3]
{
118,
143,
166,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 68,
    Value = 
new System.Byte[4]
{
151,
43,
175,
121,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 71,
    Value = 
new System.Byte[4]
{
116,
104,
57,
61,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 70,
    Value = 
new System.Byte[3]
{
66,
34,
220,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 78,
    Value = 
new System.Byte[4]
{
171,
146,
227,
11,
},
    NullableValue = 
new System.Byte[4]
{
17,
163,
178,
253,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 73,
    Value = 
new System.Byte[3]
{
209,
228,
122,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 80,
    Value = 
new System.Byte[3]
{
139,
96,
35,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
147,
179,
114,
},
},
            new ByteUInt8Array1M
{
    Id = 79,
    Value = 
new System.Byte[3]
{
122,
52,
231,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 81,
    Value = 
new System.Byte[4]
{
57,
19,
147,
149,
},
    NullableValue = 
new System.Byte[3]
{
207,
80,
56,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 82,
    Value = 
new System.Byte[4]
{
199,
169,
234,
117,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 89,
    Value = 
new System.Byte[3]
{
26,
107,
252,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 87,
    Value = 
new System.Byte[4]
{
36,
73,
80,
61,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 92,
    Value = 
new System.Byte[4]
{
61,
226,
229,
242,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
68,
49,
181,
100,
},
},
            new ByteUInt8Array1M
{
    Id = 94,
    Value = 
new System.Byte[4]
{
194,
240,
66,
19,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 96,
    Value = 
new System.Byte[3]
{
245,
222,
100,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
142,
67,
159,
127,
},
},
            new ByteUInt8Array1M
{
    Id = 102,
    Value = 
new System.Byte[3]
{
14,
21,
170,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 98,
    Value = 
new System.Byte[3]
{
170,
85,
113,
},
    NullableValue = 
new System.Byte[3]
{
188,
50,
173,
},
},
    NullableValue = 
new System.Byte[4]
{
161,
169,
61,
152,
},
},
            new ByteUInt8Array1M
{
    Id = 105,
    Value = 
new System.Byte[4]
{
118,
9,
60,
248,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 100,
    Value = 
new System.Byte[3]
{
21,
100,
192,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
155,
68,
165,
},
},
            new ByteUInt8Array1M
{
    Id = 109,
    Value = 
new System.Byte[3]
{
42,
6,
112,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 102,
    Value = 
new System.Byte[3]
{
101,
223,
86,
},
    NullableValue = 
new System.Byte[3]
{
52,
253,
136,
},
},
    NullableValue = 
new System.Byte[4]
{
201,
69,
162,
108,
},
},
            new ByteUInt8Array1M
{
    Id = 111,
    Value = 
new System.Byte[3]
{
44,
85,
97,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 105,
    Value = 
new System.Byte[3]
{
17,
201,
64,
},
    NullableValue = 
new System.Byte[3]
{
125,
232,
81,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 114,
    Value = 
new System.Byte[4]
{
194,
241,
50,
23,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 108,
    Value = 
new System.Byte[4]
{
217,
32,
111,
16,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
37,
143,
14,
},
},
            new ByteUInt8Array1M
{
    Id = 121,
    Value = 
new System.Byte[3]
{
220,
97,
71,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 112,
    Value = 
new System.Byte[4]
{
49,
34,
188,
21,
},
    NullableValue = 
new System.Byte[4]
{
104,
31,
78,
125,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 130,
    Value = 
new System.Byte[3]
{
170,
8,
133,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 116,
    Value = 
new System.Byte[4]
{
244,
38,
73,
146,
},
    NullableValue = 
new System.Byte[3]
{
254,
54,
249,
},
},
    NullableValue = 
new System.Byte[3]
{
12,
68,
2,
},
},
            new ByteUInt8Array1M
{
    Id = 138,
    Value = 
new System.Byte[4]
{
209,
173,
44,
125,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 121,
    Value = 
new System.Byte[4]
{
50,
200,
97,
25,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 142,
    Value = 
new System.Byte[3]
{
26,
59,
1,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 128,
    Value = 
new System.Byte[4]
{
95,
230,
132,
42,
},
    NullableValue = 
new System.Byte[4]
{
219,
218,
126,
75,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 147,
    Value = 
new System.Byte[4]
{
207,
41,
175,
230,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 132,
    Value = 
new System.Byte[4]
{
134,
198,
72,
2,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 155,
    Value = 
new System.Byte[4]
{
160,
59,
125,
230,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 137,
    Value = 
new System.Byte[4]
{
39,
72,
242,
137,
},
    NullableValue = 
new System.Byte[4]
{
10,
11,
28,
240,
},
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 164,
    Value = 
new System.Byte[4]
{
25,
125,
161,
164,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 138,
    Value = 
new System.Byte[3]
{
96,
177,
223,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 169,
    Value = 
new System.Byte[3]
{
79,
137,
237,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 142,
    Value = 
new System.Byte[3]
{
155,
196,
250,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
171,
2,
210,
110,
},
},
            new ByteUInt8Array1M
{
    Id = 177,
    Value = 
new System.Byte[3]
{
117,
133,
0,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 145,
    Value = 
new System.Byte[3]
{
252,
136,
87,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8Array1M
{
    Id = 185,
    Value = 
new System.Byte[4]
{
78,
176,
80,
49,
},
    ModelInner = new ByteUInt8Array1MI
{
    Id = 151,
    Value = 
new System.Byte[4]
{
113,
111,
30,
193,
},
    NullableValue = 
new System.Byte[3]
{
238,
97,
6,
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
INSERT INTO gedaqtests.byteuint8array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt8[]}, 
    {mi_id:Int32},
    {mi_value:UInt8[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArrayUInt8Array)),
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
                    await ((IByteArrayUInt8Array)this).InsertModelDbConnectionAsync(
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
                     ((IByteArrayUInt8Array)this).InsertModelDbConnection(
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
FROM gedaqtests.byteuint8array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteUInt8Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArrayUInt8Array)),
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
                    var models = await ((IByteArrayUInt8Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteUInt8Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IByteArrayUInt8Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteUInt8Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


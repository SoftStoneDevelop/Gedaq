

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
    internal partial interface IByteMArrayArrayArrayUInt8
    {
    }
    
    internal partial class ByteMArrayArrayArrayUInt8 : IByteMArrayArrayArrayUInt8
    {


#region TestData

        private readonly ByteArrayArrayUInt8E1M[] _testData = new ByteArrayArrayUInt8E1M[]
        {
            new ByteArrayArrayUInt8E1M
{
    Id = 7,
    Value = 
new System.Byte[,] { {
51,
250, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 4,
    Value = 
new System.Byte[,] { {
225,
87, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
3,
246, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 8,
    Value = 
new System.Byte[,] { {
98,
221, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 7,
    Value = 
new System.Byte[,] { {
71,
2, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 15,
    Value = 
new System.Byte[,] { {
251,
235, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 13,
    Value = 
new System.Byte[,] { {
58,
62, } },
    NullableValue = 
new System.Byte[,] { {
242,
5, } },
},
    NullableValue = 
new System.Byte[,] { {
151,
124, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 20,
    Value = 
new System.Byte[,] { {
252,
85, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 14,
    Value = 
new System.Byte[,] { {
100,
173, } },
    NullableValue = 
new System.Byte[,] { {
19,
45, } },
},
    NullableValue = 
new System.Byte[,] { {
50,
149, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 27,
    Value = 
new System.Byte[,] { {
221,
52, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 20,
    Value = 
new System.Byte[,] { {
186,
167, } },
    NullableValue = 
new System.Byte[,] { {
71,
239, } },
},
    NullableValue = 
new System.Byte[,] { {
233,
132, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 34,
    Value = 
new System.Byte[,] { {
74,
160, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 23,
    Value = 
new System.Byte[,] { {
213,
198, } },
    NullableValue = 
new System.Byte[,] { {
232,
56, } },
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 38,
    Value = 
new System.Byte[,] { {
157,
77, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 26,
    Value = 
new System.Byte[,] { {
207,
57, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
204,
177, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 41,
    Value = 
new System.Byte[,] { {
50,
239, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 35,
    Value = 
new System.Byte[,] { {
159,
107, } },
    NullableValue = 
new System.Byte[,] { {
222,
74, } },
},
    NullableValue = 
new System.Byte[,] { {
177,
160, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 50,
    Value = 
new System.Byte[,] { {
189,
251, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 39,
    Value = 
new System.Byte[,] { {
232,
29, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 59,
    Value = 
new System.Byte[,] { {
50,
246, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 45,
    Value = 
new System.Byte[,] { {
56,
246, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
35,
226, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 67,
    Value = 
new System.Byte[,] { {
152,
230, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 47,
    Value = 
new System.Byte[,] { {
12,
39, } },
    NullableValue = 
new System.Byte[,] { {
79,
121, } },
},
    NullableValue = 
new System.Byte[,] { {
86,
50, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 69,
    Value = 
new System.Byte[,] { {
214,
81, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 51,
    Value = 
new System.Byte[,] { {
18,
146, } },
    NullableValue = 
new System.Byte[,] { {
187,
133, } },
},
    NullableValue = 
new System.Byte[,] { {
30,
248, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 76,
    Value = 
new System.Byte[,] { {
90,
46, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 56,
    Value = 
new System.Byte[,] { {
157,
146, } },
    NullableValue = 
new System.Byte[,] { {
231,
44, } },
},
    NullableValue = 
new System.Byte[,] { {
227,
221, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 82,
    Value = 
new System.Byte[,] { {
123,
34, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 64,
    Value = 
new System.Byte[,] { {
153,
190, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 87,
    Value = 
new System.Byte[,] { {
72,
65, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 66,
    Value = 
new System.Byte[,] { {
203,
165, } },
    NullableValue = 
new System.Byte[,] { {
247,
121, } },
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 93,
    Value = 
new System.Byte[,] { {
51,
235, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 69,
    Value = 
new System.Byte[,] { {
178,
188, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 95,
    Value = 
new System.Byte[,] { {
202,
229, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 75,
    Value = 
new System.Byte[,] { {
117,
194, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 104,
    Value = 
new System.Byte[,] { {
130,
24, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 83,
    Value = 
new System.Byte[,] { {
57,
132, } },
    NullableValue = 
new System.Byte[,] { {
177,
196, } },
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 106,
    Value = 
new System.Byte[,] { {
201,
15, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 87,
    Value = 
new System.Byte[,] { {
150,
56, } },
    NullableValue = 
new System.Byte[,] { {
177,
162, } },
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 107,
    Value = 
new System.Byte[,] { {
144,
248, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 93,
    Value = 
new System.Byte[,] { {
113,
21, } },
    NullableValue = 
new System.Byte[,] { {
128,
214, } },
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 108,
    Value = 
new System.Byte[,] { {
131,
121, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 100,
    Value = 
new System.Byte[,] { {
203,
91, } },
    NullableValue = 
new System.Byte[,] { {
120,
187, } },
},
    NullableValue = 
new System.Byte[,] { {
221,
206, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 113,
    Value = 
new System.Byte[,] { {
96,
83, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 105,
    Value = 
new System.Byte[,] { {
250,
209, } },
    NullableValue = 
new System.Byte[,] { {
220,
123, } },
},
    NullableValue = 
new System.Byte[,] { {
59,
33, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 116,
    Value = 
new System.Byte[,] { {
37,
99, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 112,
    Value = 
new System.Byte[,] { {
155,
9, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
190,
181, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 119,
    Value = 
new System.Byte[,] { {
41,
199, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 114,
    Value = 
new System.Byte[,] { {
236,
200, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
17,
156, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 123,
    Value = 
new System.Byte[,] { {
201,
5, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 119,
    Value = 
new System.Byte[,] { {
17,
250, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
170,
5, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 124,
    Value = 
new System.Byte[,] { {
213,
184, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 126,
    Value = 
new System.Byte[,] { {
211,
16, } },
    NullableValue = 
new System.Byte[,] { {
85,
61, } },
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 128,
    Value = 
new System.Byte[,] { {
113,
230, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 128,
    Value = 
new System.Byte[,] { {
172,
246, } },
    NullableValue = 
new System.Byte[,] { {
158,
165, } },
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 137,
    Value = 
new System.Byte[,] { {
72,
199, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 133,
    Value = 
new System.Byte[,] { {
229,
240, } },
    NullableValue = 
new System.Byte[,] { {
105,
16, } },
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 145,
    Value = 
new System.Byte[,] { {
100,
66, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 141,
    Value = 
new System.Byte[,] { {
207,
56, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
38,
32, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 149,
    Value = 
new System.Byte[,] { {
69,
219, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 149,
    Value = 
new System.Byte[,] { {
178,
250, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 155,
    Value = 
new System.Byte[,] { {
15,
232, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 158,
    Value = 
new System.Byte[,] { {
67,
236, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 160,
    Value = 
new System.Byte[,] { {
226,
123, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 167,
    Value = 
new System.Byte[,] { {
228,
151, } },
    NullableValue = 
new System.Byte[,] { {
196,
235, } },
},
    NullableValue = 
new System.Byte[,] { {
186,
146, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 163,
    Value = 
new System.Byte[,] { {
237,
133, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 168,
    Value = 
new System.Byte[,] { {
39,
130, } },
    NullableValue = 
new System.Byte[,] { {
28,
46, } },
},
    NullableValue = 
new System.Byte[,] { {
232,
247, } },
},
            new ByteArrayArrayUInt8E1M
{
    Id = 166,
    Value = 
new System.Byte[,] { {
57,
213, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 177,
    Value = 
new System.Byte[,] { {
127,
239, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteArrayArrayUInt8E1M
{
    Id = 168,
    Value = 
new System.Byte[,] { {
115,
250, } },
    ModelInner = new ByteArrayArrayUInt81MI
{
    Id = 182,
    Value = 
new System.Byte[,] { {
32,
92, } },
    NullableValue = 
new System.Byte[,] { {
194,
136, } },
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
INSERT INTO gedaqtests.bytearrayarrayuint8e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt8))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt8))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArrayArrayArrayUInt8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte[,]), 
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
                    await ((IByteMArrayArrayArrayUInt8)this).InsertModelDbConnectionAsync(
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
                     ((IByteMArrayArrayArrayUInt8)this).InsertModelDbConnection(
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
FROM gedaqtests.bytearrayarrayuint8e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteArrayArrayUInt8E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArrayArrayArrayUInt8)),
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
                    var models = await ((IByteMArrayArrayArrayUInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteArrayArrayUInt8E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IByteMArrayArrayArrayUInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteArrayArrayUInt8E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


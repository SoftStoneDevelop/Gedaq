

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
    internal partial interface IByteMArrayMArrayD2
    {
    }
    
    internal partial class ByteMArrayMArrayD2 : IByteMArrayMArrayD2
    {


#region TestData

        private readonly ByteMArrayD2E1M[] _testData = new ByteMArrayD2E1M[]
        {
            new ByteMArrayD2E1M
{
    Id = 7,
    Value = 
new System.Byte[,] { {
54,
17, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Byte[,] { {
235,
179, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Byte[,] { {
161,
27, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Byte[,] { {
120,
192, } },
    NullableValue = 
new System.Byte[,] { {
239,
206, } },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Byte[,] { {
219,
47, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Byte[,] { {
135,
15, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
87,
187, } },
},
            new ByteMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Byte[,] { {
92,
148, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Byte[,] { {
6,
132, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Byte[,] { {
111,
122, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Byte[,] { {
4,
247, } },
    NullableValue = 
new System.Byte[,] { {
57,
111, } },
},
    NullableValue = 
new System.Byte[,] { {
99,
196, } },
},
            new ByteMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Byte[,] { {
127,
150, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Byte[,] { {
103,
56, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Byte[,] { {
151,
65, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Byte[,] { {
133,
127, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
220,
97, } },
},
            new ByteMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Byte[,] { {
27,
229, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Byte[,] { {
239,
223, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Byte[,] { {
96,
186, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Byte[,] { {
113,
52, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
114,
164, } },
},
            new ByteMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Byte[,] { {
82,
71, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Byte[,] { {
38,
10, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
251,
230, } },
},
            new ByteMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Byte[,] { {
194,
171, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Byte[,] { {
7,
7, } },
    NullableValue = 
new System.Byte[,] { {
192,
144, } },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Byte[,] { {
153,
137, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Byte[,] { {
224,
22, } },
    NullableValue = 
new System.Byte[,] { {
166,
28, } },
},
    NullableValue = 
new System.Byte[,] { {
6,
158, } },
},
            new ByteMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Byte[,] { {
33,
65, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Byte[,] { {
15,
119, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
1,
10, } },
},
            new ByteMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Byte[,] { {
65,
41, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Byte[,] { {
105,
186, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
155,
147, } },
},
            new ByteMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Byte[,] { {
158,
108, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Byte[,] { {
188,
18, } },
    NullableValue = 
new System.Byte[,] { {
121,
135, } },
},
    NullableValue = 
new System.Byte[,] { {
119,
143, } },
},
            new ByteMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Byte[,] { {
221,
92, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Byte[,] { {
115,
123, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Byte[,] { {
164,
90, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Byte[,] { {
119,
59, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
13,
15, } },
},
            new ByteMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Byte[,] { {
29,
13, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Byte[,] { {
72,
200, } },
    NullableValue = 
new System.Byte[,] { {
216,
80, } },
},
    NullableValue = 
new System.Byte[,] { {
15,
44, } },
},
            new ByteMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Byte[,] { {
4,
90, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Byte[,] { {
113,
118, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Byte[,] { {
241,
9, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Byte[,] { {
0,
239, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
251,
33, } },
},
            new ByteMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Byte[,] { {
138,
220, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Byte[,] { {
216,
242, } },
    NullableValue = 
new System.Byte[,] { {
144,
223, } },
},
    NullableValue = 
new System.Byte[,] { {
52,
79, } },
},
            new ByteMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Byte[,] { {
228,
104, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 106,
    Value = 
new System.Byte[,] { {
189,
143, } },
    NullableValue = 
new System.Byte[,] { {
203,
27, } },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Byte[,] { {
217,
93, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Byte[,] { {
26,
14, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
242,
123, } },
},
            new ByteMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Byte[,] { {
104,
43, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 112,
    Value = 
new System.Byte[,] { {
192,
20, } },
    NullableValue = 
new System.Byte[,] { {
149,
156, } },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Byte[,] { {
226,
159, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Byte[,] { {
243,
130, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
196,
64, } },
},
            new ByteMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Byte[,] { {
85,
16, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Byte[,] { {
175,
28, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
21,
220, } },
},
            new ByteMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Byte[,] { {
43,
60, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Byte[,] { {
123,
71, } },
    NullableValue = 
new System.Byte[,] { {
75,
199, } },
},
    NullableValue = 
new System.Byte[,] { {
234,
6, } },
},
            new ByteMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Byte[,] { {
35,
205, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Byte[,] { {
84,
92, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
154,
91, } },
},
            new ByteMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Byte[,] { {
222,
110, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Byte[,] { {
218,
42, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Byte[,] { {
105,
20, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Byte[,] { {
138,
16, } },
    NullableValue = 
new System.Byte[,] { {
231,
110, } },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Byte[,] { {
186,
99, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 142,
    Value = 
new System.Byte[,] { {
73,
65, } },
    NullableValue = 
new System.Byte[,] { {
189,
171, } },
},
    NullableValue = 
new System.Byte[,] { {
49,
106, } },
},
            new ByteMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Byte[,] { {
64,
109, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Byte[,] { {
106,
148, } },
    NullableValue = 
new System.Byte[,] { {
72,
79, } },
},
    NullableValue = 
new System.Byte[,] { {
10,
96, } },
},
            new ByteMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Byte[,] { {
214,
132, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Byte[,] { {
219,
208, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
199,
165, } },
},
            new ByteMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Byte[,] { {
31,
27, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Byte[,] { {
100,
33, } },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { {
8,
3, } },
},
            new ByteMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Byte[,] { {
150,
142, } },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Byte[,] { {
231,
181, } },
    NullableValue = 
new System.Byte[,] { {
204,
35, } },
},
    NullableValue = 
new System.Byte[,] { {
250,
53, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.bytemarrayd2e1m(
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
            asPartInterface: typeof(IByteMArrayMArrayD2)),
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
                    await ((IByteMArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IByteMArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.bytemarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArrayMArrayD2)),
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
                    var models = await ((IByteMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteMArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IByteMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


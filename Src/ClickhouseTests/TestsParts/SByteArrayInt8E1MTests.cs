

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
    internal partial interface ISByteMArrayArrayInt8
    {
    }
    
    internal partial class SByteMArrayArrayInt8 : ISByteMArrayArrayInt8
    {


#region TestData

        private readonly SByteArrayInt8E1M[] _testData = new SByteArrayInt8E1M[]
        {
            new SByteArrayInt8E1M
{
    Id = 3,
    Value = 
new System.SByte[4]
{
-41,
-42,
-35,
-126,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 9,
    Value = 
new System.SByte[4]
{
77,
125,
52,
64,
},
    NullableValue = 
new System.SByte[4]
{
15,
60,
40,
54,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 12,
    Value = 
new System.SByte[4]
{
-61,
9,
114,
-79,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 13,
    Value = 
new System.SByte[3]
{
-120,
59,
16,
},
    NullableValue = 
new System.SByte[3]
{
-76,
37,
119,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 16,
    Value = 
new System.SByte[3]
{
-49,
-104,
30,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 19,
    Value = 
new System.SByte[4]
{
-25,
3,
102,
-84,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-99,
100,
14,
-24,
},
},
            new SByteArrayInt8E1M
{
    Id = 24,
    Value = 
new System.SByte[3]
{
-106,
-69,
-58,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 20,
    Value = 
new System.SByte[3]
{
82,
-38,
27,
},
    NullableValue = 
new System.SByte[4]
{
-10,
64,
44,
-62,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 33,
    Value = 
new System.SByte[3]
{
46,
-60,
-74,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 28,
    Value = 
new System.SByte[3]
{
-50,
-20,
36,
},
    NullableValue = 
new System.SByte[4]
{
77,
71,
111,
-46,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 39,
    Value = 
new System.SByte[3]
{
87,
35,
80,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 34,
    Value = 
new System.SByte[4]
{
36,
66,
102,
22,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 43,
    Value = 
new System.SByte[3]
{
-90,
-2,
-55,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 41,
    Value = 
new System.SByte[3]
{
-26,
32,
45,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-63,
55,
-90,
},
},
            new SByteArrayInt8E1M
{
    Id = 46,
    Value = 
new System.SByte[4]
{
26,
6,
96,
-75,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 47,
    Value = 
new System.SByte[3]
{
-86,
10,
3,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 47,
    Value = 
new System.SByte[4]
{
2,
78,
109,
-40,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 56,
    Value = 
new System.SByte[3]
{
33,
-103,
64,
},
    NullableValue = 
new System.SByte[4]
{
48,
-85,
100,
-45,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 54,
    Value = 
new System.SByte[4]
{
100,
-115,
9,
76,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 63,
    Value = 
new System.SByte[3]
{
-5,
-51,
4,
},
    NullableValue = 
new System.SByte[3]
{
-42,
-86,
22,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 55,
    Value = 
new System.SByte[4]
{
-37,
-90,
-38,
86,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 66,
    Value = 
new System.SByte[3]
{
125,
76,
-96,
},
    NullableValue = 
new System.SByte[3]
{
62,
-115,
98,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 60,
    Value = 
new System.SByte[3]
{
13,
47,
-116,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 71,
    Value = 
new System.SByte[4]
{
65,
0,
105,
100,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-108,
-103,
-11,
-109,
},
},
            new SByteArrayInt8E1M
{
    Id = 68,
    Value = 
new System.SByte[3]
{
92,
75,
29,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 77,
    Value = 
new System.SByte[3]
{
-52,
-21,
112,
},
    NullableValue = 
new System.SByte[4]
{
65,
-126,
-55,
51,
},
},
    NullableValue = 
new System.SByte[4]
{
91,
-59,
-80,
-4,
},
},
            new SByteArrayInt8E1M
{
    Id = 77,
    Value = 
new System.SByte[3]
{
-20,
-39,
-1,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 86,
    Value = 
new System.SByte[3]
{
-82,
22,
126,
},
    NullableValue = 
new System.SByte[3]
{
26,
-67,
-92,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 78,
    Value = 
new System.SByte[4]
{
96,
-121,
85,
-45,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 91,
    Value = 
new System.SByte[4]
{
-11,
7,
38,
-102,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-127,
-83,
8,
55,
},
},
            new SByteArrayInt8E1M
{
    Id = 83,
    Value = 
new System.SByte[3]
{
60,
-98,
-104,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 98,
    Value = 
new System.SByte[3]
{
61,
94,
2,
},
    NullableValue = 
new System.SByte[4]
{
94,
48,
60,
-76,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 90,
    Value = 
new System.SByte[3]
{
-67,
7,
87,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 103,
    Value = 
new System.SByte[4]
{
77,
14,
5,
21,
},
    NullableValue = 
new System.SByte[4]
{
-79,
-39,
10,
-72,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 95,
    Value = 
new System.SByte[4]
{
60,
85,
98,
53,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 111,
    Value = 
new System.SByte[3]
{
86,
-123,
87,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 103,
    Value = 
new System.SByte[4]
{
37,
4,
14,
21,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 116,
    Value = 
new System.SByte[3]
{
124,
-106,
-40,
},
    NullableValue = 
new System.SByte[4]
{
-29,
109,
-6,
92,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 107,
    Value = 
new System.SByte[3]
{
-18,
-3,
107,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 120,
    Value = 
new System.SByte[4]
{
-26,
-41,
-21,
64,
},
    NullableValue = 
new System.SByte[4]
{
11,
124,
-25,
-128,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 113,
    Value = 
new System.SByte[3]
{
103,
34,
-62,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 129,
    Value = 
new System.SByte[3]
{
115,
45,
46,
},
    NullableValue = 
new System.SByte[3]
{
53,
-37,
-81,
},
},
    NullableValue = 
new System.SByte[4]
{
-40,
73,
-27,
56,
},
},
            new SByteArrayInt8E1M
{
    Id = 121,
    Value = 
new System.SByte[4]
{
-84,
110,
-19,
85,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 131,
    Value = 
new System.SByte[4]
{
35,
27,
-9,
-71,
},
    NullableValue = 
new System.SByte[3]
{
123,
-79,
-64,
},
},
    NullableValue = 
new System.SByte[3]
{
-96,
-63,
103,
},
},
            new SByteArrayInt8E1M
{
    Id = 129,
    Value = 
new System.SByte[4]
{
54,
-83,
65,
69,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 137,
    Value = 
new System.SByte[3]
{
102,
50,
80,
},
    NullableValue = 
new System.SByte[3]
{
-92,
-1,
17,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 133,
    Value = 
new System.SByte[4]
{
-85,
62,
-23,
38,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 145,
    Value = 
new System.SByte[3]
{
23,
95,
-64,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
25,
-58,
3,
86,
},
},
            new SByteArrayInt8E1M
{
    Id = 139,
    Value = 
new System.SByte[3]
{
-93,
-28,
20,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 154,
    Value = 
new System.SByte[4]
{
-33,
21,
-100,
-78,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 147,
    Value = 
new System.SByte[3]
{
-110,
1,
-27,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 162,
    Value = 
new System.SByte[3]
{
-107,
-3,
-60,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-65,
-19,
100,
39,
},
},
            new SByteArrayInt8E1M
{
    Id = 151,
    Value = 
new System.SByte[4]
{
88,
-15,
109,
-33,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 165,
    Value = 
new System.SByte[4]
{
75,
-54,
20,
27,
},
    NullableValue = 
new System.SByte[4]
{
-97,
70,
-59,
-36,
},
},
    NullableValue = 
new System.SByte[3]
{
-83,
-39,
112,
},
},
            new SByteArrayInt8E1M
{
    Id = 160,
    Value = 
new System.SByte[4]
{
-49,
-123,
20,
-58,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 172,
    Value = 
new System.SByte[4]
{
-41,
-121,
101,
8,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 169,
    Value = 
new System.SByte[3]
{
-104,
10,
120,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 176,
    Value = 
new System.SByte[4]
{
95,
-89,
106,
55,
},
    NullableValue = 
new System.SByte[3]
{
-8,
-57,
116,
},
},
    NullableValue = 
new System.SByte[3]
{
3,
68,
-15,
},
},
            new SByteArrayInt8E1M
{
    Id = 175,
    Value = 
new System.SByte[4]
{
57,
-89,
-21,
123,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 177,
    Value = 
new System.SByte[3]
{
58,
120,
2,
},
    NullableValue = 
new System.SByte[3]
{
-13,
-52,
97,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 184,
    Value = 
new System.SByte[4]
{
22,
-12,
-49,
64,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 181,
    Value = 
new System.SByte[4]
{
-25,
18,
-89,
48,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
30,
76,
-117,
},
},
            new SByteArrayInt8E1M
{
    Id = 187,
    Value = 
new System.SByte[4]
{
-36,
70,
-23,
46,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 184,
    Value = 
new System.SByte[4]
{
19,
-59,
-117,
-86,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 190,
    Value = 
new System.SByte[3]
{
-121,
54,
-17,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 191,
    Value = 
new System.SByte[3]
{
2,
-85,
11,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-110,
26,
28,
45,
},
},
            new SByteArrayInt8E1M
{
    Id = 192,
    Value = 
new System.SByte[3]
{
25,
-110,
-52,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 200,
    Value = 
new System.SByte[3]
{
102,
2,
91,
},
    NullableValue = 
new System.SByte[3]
{
-77,
100,
8,
},
},
    NullableValue = null,
},
            new SByteArrayInt8E1M
{
    Id = 195,
    Value = 
new System.SByte[4]
{
117,
85,
3,
93,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 208,
    Value = 
new System.SByte[3]
{
51,
60,
-3,
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
INSERT INTO gedaqtests.sbytearrayint8e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int8)}, 
    {mi_id:Int32},
    {mi_value:Array(Int8)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArrayArrayInt8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte[]), 
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
                    await ((ISByteMArrayArrayInt8)this).InsertModelDbConnectionAsync(
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
                     ((ISByteMArrayArrayInt8)this).InsertModelDbConnection(
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
FROM gedaqtests.sbytearrayint8e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteArrayInt8E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArrayArrayInt8)),
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
                    var models = await ((ISByteMArrayArrayInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteArrayInt8E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteMArrayArrayInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteArrayInt8E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


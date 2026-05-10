

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
    internal partial interface ISByteArrayArrayInt8
    {
    }
    
    internal partial class SByteArrayArrayInt8 : ISByteArrayArrayInt8
    {


#region TestData

        private readonly SByteArrayInt81M[] _testData = new SByteArrayInt81M[]
        {
            new SByteArrayInt81M
{
    Id = 3,
    Value = 
new System.SByte[4]
{
46,
-26,
-125,
37,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 3,
    Value = 
new System.SByte[4]
{
-59,
69,
-34,
39,
},
    NullableValue = 
new System.SByte[4]
{
120,
69,
-45,
-23,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 6,
    Value = 
new System.SByte[4]
{
92,
-24,
-80,
98,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 5,
    Value = 
new System.SByte[4]
{
-80,
89,
-11,
31,
},
    NullableValue = 
new System.SByte[4]
{
-53,
100,
-76,
-57,
},
},
    NullableValue = 
new System.SByte[4]
{
113,
102,
-43,
-76,
},
},
            new SByteArrayInt81M
{
    Id = 11,
    Value = 
new System.SByte[3]
{
65,
79,
-4,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 7,
    Value = 
new System.SByte[4]
{
-6,
71,
-37,
-82,
},
    NullableValue = 
new System.SByte[3]
{
-88,
-25,
0,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 12,
    Value = 
new System.SByte[3]
{
-128,
124,
33,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 16,
    Value = 
new System.SByte[3]
{
51,
52,
-56,
},
    NullableValue = 
new System.SByte[3]
{
0,
-73,
54,
},
},
    NullableValue = 
new System.SByte[3]
{
84,
-14,
24,
},
},
            new SByteArrayInt81M
{
    Id = 15,
    Value = 
new System.SByte[4]
{
67,
-19,
-29,
-114,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 20,
    Value = 
new System.SByte[3]
{
-28,
73,
-88,
},
    NullableValue = 
new System.SByte[4]
{
-25,
-118,
12,
55,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 16,
    Value = 
new System.SByte[4]
{
-110,
111,
21,
88,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 29,
    Value = 
new System.SByte[3]
{
-80,
62,
-89,
},
    NullableValue = 
new System.SByte[3]
{
-32,
-107,
-111,
},
},
    NullableValue = 
new System.SByte[3]
{
-86,
20,
-47,
},
},
            new SByteArrayInt81M
{
    Id = 21,
    Value = 
new System.SByte[3]
{
71,
38,
-101,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 31,
    Value = 
new System.SByte[4]
{
-35,
-29,
52,
-46,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 29,
    Value = 
new System.SByte[3]
{
-87,
-34,
11,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 34,
    Value = 
new System.SByte[3]
{
95,
56,
-10,
},
    NullableValue = 
new System.SByte[4]
{
-97,
103,
76,
57,
},
},
    NullableValue = 
new System.SByte[3]
{
124,
-90,
-18,
},
},
            new SByteArrayInt81M
{
    Id = 38,
    Value = 
new System.SByte[3]
{
-24,
-60,
-69,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 41,
    Value = 
new System.SByte[4]
{
77,
-113,
91,
99,
},
    NullableValue = 
new System.SByte[4]
{
-110,
-100,
-47,
-21,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 42,
    Value = 
new System.SByte[4]
{
-80,
99,
-11,
93,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 45,
    Value = 
new System.SByte[4]
{
19,
69,
90,
117,
},
    NullableValue = 
new System.SByte[4]
{
-26,
-69,
40,
49,
},
},
    NullableValue = 
new System.SByte[4]
{
47,
-80,
-32,
47,
},
},
            new SByteArrayInt81M
{
    Id = 45,
    Value = 
new System.SByte[3]
{
49,
115,
56,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 46,
    Value = 
new System.SByte[4]
{
102,
123,
-116,
-115,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-100,
-105,
10,
},
},
            new SByteArrayInt81M
{
    Id = 51,
    Value = 
new System.SByte[3]
{
15,
114,
70,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 51,
    Value = 
new System.SByte[4]
{
23,
19,
-11,
59,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
52,
-56,
-86,
19,
},
},
            new SByteArrayInt81M
{
    Id = 54,
    Value = 
new System.SByte[3]
{
-55,
-95,
36,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 53,
    Value = 
new System.SByte[4]
{
-57,
99,
-47,
-10,
},
    NullableValue = 
new System.SByte[4]
{
-34,
-64,
56,
-108,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 61,
    Value = 
new System.SByte[4]
{
-59,
-41,
17,
40,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 57,
    Value = 
new System.SByte[4]
{
90,
-28,
-121,
-54,
},
    NullableValue = 
new System.SByte[3]
{
58,
74,
-112,
},
},
    NullableValue = 
new System.SByte[3]
{
-39,
118,
-29,
},
},
            new SByteArrayInt81M
{
    Id = 70,
    Value = 
new System.SByte[3]
{
26,
-116,
-88,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 64,
    Value = 
new System.SByte[4]
{
99,
98,
-51,
-44,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 77,
    Value = 
new System.SByte[4]
{
56,
81,
-88,
-63,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 65,
    Value = 
new System.SByte[4]
{
-64,
-9,
-61,
70,
},
    NullableValue = 
new System.SByte[3]
{
-111,
75,
-19,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 86,
    Value = 
new System.SByte[4]
{
57,
-72,
-9,
-24,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 66,
    Value = 
new System.SByte[4]
{
-22,
69,
93,
-8,
},
    NullableValue = 
new System.SByte[4]
{
122,
-53,
68,
-116,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 90,
    Value = 
new System.SByte[3]
{
-49,
103,
80,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 74,
    Value = 
new System.SByte[3]
{
-49,
101,
78,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 91,
    Value = 
new System.SByte[4]
{
40,
64,
-122,
-114,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 82,
    Value = 
new System.SByte[3]
{
-56,
-119,
-5,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-63,
-90,
50,
-126,
},
},
            new SByteArrayInt81M
{
    Id = 92,
    Value = 
new System.SByte[3]
{
-128,
-99,
-123,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 85,
    Value = 
new System.SByte[3]
{
-58,
110,
-122,
},
    NullableValue = 
new System.SByte[3]
{
-82,
16,
113,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 100,
    Value = 
new System.SByte[4]
{
-21,
-38,
8,
55,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 92,
    Value = 
new System.SByte[3]
{
88,
121,
-118,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 103,
    Value = 
new System.SByte[4]
{
-101,
-29,
50,
-113,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 99,
    Value = 
new System.SByte[4]
{
-112,
-12,
-91,
-61,
},
    NullableValue = 
new System.SByte[4]
{
-69,
53,
-102,
126,
},
},
    NullableValue = 
new System.SByte[4]
{
-112,
47,
-28,
-6,
},
},
            new SByteArrayInt81M
{
    Id = 112,
    Value = 
new System.SByte[3]
{
-46,
17,
116,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 106,
    Value = 
new System.SByte[3]
{
-48,
-51,
-13,
},
    NullableValue = 
new System.SByte[3]
{
26,
51,
-11,
},
},
    NullableValue = 
new System.SByte[4]
{
19,
-35,
-20,
-73,
},
},
            new SByteArrayInt81M
{
    Id = 115,
    Value = 
new System.SByte[4]
{
60,
-112,
-101,
-21,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 107,
    Value = 
new System.SByte[3]
{
-111,
-67,
39,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
108,
-68,
122,
-44,
},
},
            new SByteArrayInt81M
{
    Id = 119,
    Value = 
new System.SByte[4]
{
40,
114,
122,
-41,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 116,
    Value = 
new System.SByte[4]
{
51,
112,
-21,
-77,
},
    NullableValue = 
new System.SByte[3]
{
-91,
4,
-78,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 126,
    Value = 
new System.SByte[3]
{
44,
-80,
-1,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 123,
    Value = 
new System.SByte[4]
{
5,
43,
-91,
-89,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 127,
    Value = 
new System.SByte[4]
{
96,
59,
113,
-31,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 124,
    Value = 
new System.SByte[3]
{
-40,
-50,
112,
},
    NullableValue = 
new System.SByte[4]
{
-34,
-81,
63,
-40,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 131,
    Value = 
new System.SByte[3]
{
-117,
-88,
-79,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 126,
    Value = 
new System.SByte[4]
{
-51,
55,
-110,
-47,
},
    NullableValue = 
new System.SByte[3]
{
-25,
-16,
-85,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 135,
    Value = 
new System.SByte[4]
{
63,
-17,
70,
-31,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 135,
    Value = 
new System.SByte[4]
{
-33,
105,
-14,
-47,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-82,
47,
28,
},
},
            new SByteArrayInt81M
{
    Id = 142,
    Value = 
new System.SByte[4]
{
121,
68,
15,
-3,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 141,
    Value = 
new System.SByte[3]
{
99,
-7,
-24,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 149,
    Value = 
new System.SByte[4]
{
-59,
69,
70,
-127,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 144,
    Value = 
new System.SByte[3]
{
-103,
-22,
-83,
},
    NullableValue = 
new System.SByte[3]
{
89,
2,
-38,
},
},
    NullableValue = 
new System.SByte[3]
{
-79,
24,
52,
},
},
            new SByteArrayInt81M
{
    Id = 153,
    Value = 
new System.SByte[4]
{
25,
114,
111,
52,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 146,
    Value = 
new System.SByte[3]
{
22,
31,
60,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 155,
    Value = 
new System.SByte[3]
{
36,
39,
-50,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 154,
    Value = 
new System.SByte[4]
{
14,
-45,
-46,
-18,
},
    NullableValue = 
new System.SByte[3]
{
-61,
-38,
-91,
},
},
    NullableValue = null,
},
            new SByteArrayInt81M
{
    Id = 156,
    Value = 
new System.SByte[3]
{
51,
64,
-18,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 158,
    Value = 
new System.SByte[3]
{
-79,
-8,
116,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-46,
101,
-38,
22,
},
},
            new SByteArrayInt81M
{
    Id = 158,
    Value = 
new System.SByte[3]
{
-120,
-2,
-86,
},
    ModelInner = new SByteArrayInt81MI
{
    Id = 167,
    Value = 
new System.SByte[3]
{
-63,
-17,
109,
},
    NullableValue = 
new System.SByte[3]
{
13,
77,
99,
},
},
    NullableValue = 
new System.SByte[3]
{
38,
63,
-87,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbytearrayint81m(
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
            asPartInterface: typeof(ISByteArrayArrayInt8)),
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
                    await ((ISByteArrayArrayInt8)this).InsertModelDbConnectionAsync(
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
                     ((ISByteArrayArrayInt8)this).InsertModelDbConnection(
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
FROM gedaqtests.sbytearrayint81m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteArrayInt81M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArrayArrayInt8)),
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
                    var models = await ((ISByteArrayArrayInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteArrayInt81M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteArrayArrayInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteArrayInt81M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


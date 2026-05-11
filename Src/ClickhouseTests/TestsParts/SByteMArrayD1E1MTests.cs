

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
    internal partial interface ISByteMArrayMArrayD1
    {
    }
    
    internal partial class SByteMArrayMArrayD1 : ISByteMArrayMArrayD1
    {


#region TestData

        private readonly SByteMArrayD1E1M[] _testData = new SByteMArrayD1E1M[]
        {
            new SByteMArrayD1E1M
{
    Id = 1,
    Value = 
new System.SByte[4]
{
-126,
-1,
22,
69,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.SByte[4]
{
26,
37,
-110,
5,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
115,
45,
85,
122,
},
},
            new SByteMArrayD1E1M
{
    Id = 4,
    Value = 
new System.SByte[4]
{
-78,
58,
76,
-55,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.SByte[3]
{
-12,
42,
-47,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 8,
    Value = 
new System.SByte[4]
{
45,
-83,
-82,
-112,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.SByte[3]
{
-43,
89,
91,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 15,
    Value = 
new System.SByte[3]
{
19,
23,
-83,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.SByte[4]
{
5,
-90,
90,
24,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-47,
91,
-111,
},
},
            new SByteMArrayD1E1M
{
    Id = 18,
    Value = 
new System.SByte[4]
{
-65,
4,
123,
60,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.SByte[4]
{
-89,
9,
-59,
30,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 19,
    Value = 
new System.SByte[3]
{
51,
-82,
95,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.SByte[3]
{
115,
-55,
102,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-122,
9,
84,
-77,
},
},
            new SByteMArrayD1E1M
{
    Id = 23,
    Value = 
new System.SByte[4]
{
-19,
23,
47,
-54,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.SByte[4]
{
109,
15,
-82,
49,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
62,
-57,
0,
},
},
            new SByteMArrayD1E1M
{
    Id = 27,
    Value = 
new System.SByte[4]
{
1,
-11,
115,
-33,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.SByte[4]
{
-63,
-82,
80,
97,
},
    NullableValue = 
new System.SByte[4]
{
-85,
102,
41,
64,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 28,
    Value = 
new System.SByte[4]
{
12,
113,
126,
12,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.SByte[3]
{
-25,
-37,
-9,
},
    NullableValue = 
new System.SByte[3]
{
7,
-88,
-120,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 31,
    Value = 
new System.SByte[4]
{
57,
-77,
18,
50,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.SByte[3]
{
-95,
94,
81,
},
    NullableValue = 
new System.SByte[3]
{
-68,
-34,
-63,
},
},
    NullableValue = 
new System.SByte[4]
{
68,
52,
-52,
-13,
},
},
            new SByteMArrayD1E1M
{
    Id = 34,
    Value = 
new System.SByte[3]
{
46,
17,
-107,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.SByte[4]
{
19,
20,
62,
-43,
},
    NullableValue = 
new System.SByte[3]
{
28,
19,
30,
},
},
    NullableValue = 
new System.SByte[4]
{
-121,
109,
-114,
41,
},
},
            new SByteMArrayD1E1M
{
    Id = 38,
    Value = 
new System.SByte[3]
{
-28,
77,
-49,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.SByte[3]
{
-57,
119,
-51,
},
    NullableValue = 
new System.SByte[3]
{
-12,
-86,
-117,
},
},
    NullableValue = 
new System.SByte[4]
{
64,
-128,
9,
-38,
},
},
            new SByteMArrayD1E1M
{
    Id = 46,
    Value = 
new System.SByte[4]
{
125,
-99,
-27,
63,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.SByte[3]
{
-48,
15,
45,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 52,
    Value = 
new System.SByte[3]
{
36,
-119,
-54,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.SByte[3]
{
-15,
70,
2,
},
    NullableValue = 
new System.SByte[4]
{
-29,
89,
-69,
-113,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 60,
    Value = 
new System.SByte[3]
{
-115,
98,
-107,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 86,
    Value = 
new System.SByte[3]
{
-50,
-16,
-40,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 68,
    Value = 
new System.SByte[4]
{
107,
-88,
30,
-80,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.SByte[4]
{
9,
54,
87,
81,
},
    NullableValue = 
new System.SByte[3]
{
-87,
-18,
-44,
},
},
    NullableValue = 
new System.SByte[3]
{
79,
-124,
-29,
},
},
            new SByteMArrayD1E1M
{
    Id = 73,
    Value = 
new System.SByte[4]
{
74,
-8,
117,
69,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.SByte[3]
{
31,
86,
-71,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-58,
-73,
-124,
},
},
            new SByteMArrayD1E1M
{
    Id = 76,
    Value = 
new System.SByte[3]
{
93,
18,
93,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.SByte[3]
{
78,
-87,
-22,
},
    NullableValue = 
new System.SByte[4]
{
33,
-32,
23,
0,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 81,
    Value = 
new System.SByte[4]
{
-54,
88,
72,
117,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 112,
    Value = 
new System.SByte[4]
{
-7,
107,
-111,
28,
},
    NullableValue = 
new System.SByte[4]
{
-23,
60,
-105,
81,
},
},
    NullableValue = 
new System.SByte[4]
{
123,
13,
-120,
-2,
},
},
            new SByteMArrayD1E1M
{
    Id = 87,
    Value = 
new System.SByte[4]
{
35,
-119,
-54,
-103,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 115,
    Value = 
new System.SByte[3]
{
-24,
-98,
-6,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
79,
-14,
-105,
-49,
},
},
            new SByteMArrayD1E1M
{
    Id = 88,
    Value = 
new System.SByte[4]
{
16,
39,
-119,
21,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 118,
    Value = 
new System.SByte[4]
{
116,
-35,
51,
32,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 92,
    Value = 
new System.SByte[3]
{
-107,
18,
110,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 121,
    Value = 
new System.SByte[4]
{
-1,
-31,
-17,
-111,
},
    NullableValue = 
new System.SByte[4]
{
40,
24,
-74,
-95,
},
},
    NullableValue = 
new System.SByte[4]
{
-6,
-123,
98,
-31,
},
},
            new SByteMArrayD1E1M
{
    Id = 94,
    Value = 
new System.SByte[3]
{
-112,
76,
-80,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 123,
    Value = 
new System.SByte[4]
{
-59,
21,
30,
-71,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-98,
103,
19,
-82,
},
},
            new SByteMArrayD1E1M
{
    Id = 101,
    Value = 
new System.SByte[4]
{
11,
-109,
59,
121,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.SByte[4]
{
25,
-61,
-128,
-113,
},
    NullableValue = 
new System.SByte[4]
{
-88,
-76,
97,
68,
},
},
    NullableValue = 
new System.SByte[3]
{
-61,
96,
11,
},
},
            new SByteMArrayD1E1M
{
    Id = 109,
    Value = 
new System.SByte[3]
{
-111,
0,
-21,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.SByte[4]
{
12,
-42,
82,
-98,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 115,
    Value = 
new System.SByte[3]
{
90,
31,
-114,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 130,
    Value = 
new System.SByte[3]
{
12,
-105,
60,
},
    NullableValue = 
new System.SByte[4]
{
30,
40,
-105,
-68,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 122,
    Value = 
new System.SByte[3]
{
-42,
46,
15,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 136,
    Value = 
new System.SByte[4]
{
0,
-79,
-76,
44,
},
    NullableValue = 
new System.SByte[4]
{
16,
49,
-104,
-8,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 129,
    Value = 
new System.SByte[3]
{
-49,
88,
117,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 142,
    Value = 
new System.SByte[3]
{
109,
38,
-117,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
107,
-101,
-5,
},
},
            new SByteMArrayD1E1M
{
    Id = 132,
    Value = 
new System.SByte[4]
{
118,
-127,
-106,
-2,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 148,
    Value = 
new System.SByte[4]
{
-88,
-9,
-59,
62,
},
    NullableValue = 
new System.SByte[4]
{
125,
69,
-52,
82,
},
},
    NullableValue = 
new System.SByte[4]
{
116,
-6,
51,
97,
},
},
            new SByteMArrayD1E1M
{
    Id = 139,
    Value = 
new System.SByte[4]
{
103,
26,
32,
-13,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 152,
    Value = 
new System.SByte[3]
{
46,
-102,
100,
},
    NullableValue = 
new System.SByte[4]
{
52,
111,
32,
78,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 140,
    Value = 
new System.SByte[3]
{
-79,
-75,
63,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.SByte[4]
{
-83,
-106,
-76,
43,
},
    NullableValue = 
new System.SByte[3]
{
-82,
21,
117,
},
},
    NullableValue = 
new System.SByte[3]
{
-76,
-77,
-93,
},
},
            new SByteMArrayD1E1M
{
    Id = 146,
    Value = 
new System.SByte[4]
{
12,
-83,
114,
65,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.SByte[3]
{
-64,
98,
-116,
},
    NullableValue = 
new System.SByte[4]
{
120,
47,
-105,
93,
},
},
    NullableValue = 
new System.SByte[3]
{
76,
75,
35,
},
},
            new SByteMArrayD1E1M
{
    Id = 155,
    Value = 
new System.SByte[4]
{
-56,
-39,
-104,
-72,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 166,
    Value = 
new System.SByte[4]
{
15,
74,
-108,
71,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 161,
    Value = 
new System.SByte[3]
{
49,
-89,
71,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 175,
    Value = 
new System.SByte[3]
{
36,
55,
-30,
},
    NullableValue = 
new System.SByte[4]
{
105,
20,
-19,
-45,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 168,
    Value = 
new System.SByte[3]
{
-4,
-114,
79,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 184,
    Value = 
new System.SByte[4]
{
36,
119,
-45,
-9,
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
INSERT INTO gedaqtests.sbytemarrayd1e1m(
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
            asPartInterface: typeof(ISByteMArrayMArrayD1)),
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
                    await ((ISByteMArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((ISByteMArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.sbytemarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArrayMArrayD1)),
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
                    var models = await ((ISByteMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteMArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


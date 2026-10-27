

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
    Id = 4,
    Value = 
new System.SByte[3]
{
58,
-15,
16,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.SByte[4]
{
30,
26,
46,
-112,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 12,
    Value = 
new System.SByte[4]
{
-114,
-44,
94,
95,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.SByte[4]
{
61,
0,
-67,
-23,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 13,
    Value = 
new System.SByte[4]
{
122,
-63,
-86,
-119,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.SByte[3]
{
-39,
117,
65,
},
    NullableValue = 
new System.SByte[3]
{
-4,
-75,
4,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 17,
    Value = 
new System.SByte[4]
{
-50,
-115,
107,
-47,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.SByte[3]
{
-15,
47,
56,
},
    NullableValue = 
new System.SByte[4]
{
-85,
-115,
-118,
8,
},
},
    NullableValue = 
new System.SByte[3]
{
33,
-109,
53,
},
},
            new SByteMArrayD1E1M
{
    Id = 26,
    Value = 
new System.SByte[4]
{
14,
87,
13,
-109,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.SByte[4]
{
33,
41,
-85,
-114,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
83,
-82,
-104,
10,
},
},
            new SByteMArrayD1E1M
{
    Id = 35,
    Value = 
new System.SByte[4]
{
-67,
114,
-95,
-4,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.SByte[3]
{
8,
82,
-12,
},
    NullableValue = 
new System.SByte[3]
{
120,
-13,
14,
},
},
    NullableValue = 
new System.SByte[4]
{
25,
95,
5,
-101,
},
},
            new SByteMArrayD1E1M
{
    Id = 44,
    Value = 
new System.SByte[4]
{
-74,
-80,
-37,
28,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.SByte[3]
{
84,
4,
21,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 53,
    Value = 
new System.SByte[3]
{
99,
13,
24,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.SByte[4]
{
24,
93,
3,
95,
},
    NullableValue = 
new System.SByte[4]
{
-75,
16,
-103,
-36,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 59,
    Value = 
new System.SByte[4]
{
-66,
58,
21,
-18,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.SByte[4]
{
-65,
76,
107,
36,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-84,
2,
24,
-65,
},
},
            new SByteMArrayD1E1M
{
    Id = 66,
    Value = 
new System.SByte[3]
{
-99,
85,
-88,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.SByte[4]
{
58,
103,
14,
103,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 71,
    Value = 
new System.SByte[4]
{
27,
-102,
-63,
9,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.SByte[4]
{
-119,
-11,
100,
36,
},
    NullableValue = 
new System.SByte[4]
{
-80,
-90,
38,
89,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 77,
    Value = 
new System.SByte[3]
{
27,
56,
-21,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.SByte[3]
{
-46,
-2,
71,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 80,
    Value = 
new System.SByte[4]
{
-76,
-49,
104,
-61,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.SByte[4]
{
-52,
-70,
16,
-63,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-39,
69,
-34,
43,
},
},
            new SByteMArrayD1E1M
{
    Id = 82,
    Value = 
new System.SByte[4]
{
-92,
109,
-64,
-3,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.SByte[4]
{
122,
-63,
-50,
48,
},
    NullableValue = 
new System.SByte[4]
{
-104,
113,
-22,
90,
},
},
    NullableValue = 
new System.SByte[3]
{
76,
30,
122,
},
},
            new SByteMArrayD1E1M
{
    Id = 90,
    Value = 
new System.SByte[4]
{
-99,
-99,
18,
98,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.SByte[4]
{
-75,
110,
-68,
-9,
},
    NullableValue = 
new System.SByte[4]
{
-39,
-39,
87,
22,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 92,
    Value = 
new System.SByte[4]
{
-58,
-100,
-120,
-110,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.SByte[3]
{
-49,
71,
121,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 96,
    Value = 
new System.SByte[3]
{
-108,
24,
23,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.SByte[4]
{
11,
66,
-105,
97,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
63,
92,
64,
7,
},
},
            new SByteMArrayD1E1M
{
    Id = 100,
    Value = 
new System.SByte[3]
{
-12,
31,
-13,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.SByte[4]
{
-75,
-67,
114,
93,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 101,
    Value = 
new System.SByte[3]
{
32,
-80,
94,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.SByte[4]
{
7,
-100,
17,
-54,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 109,
    Value = 
new System.SByte[3]
{
-40,
3,
74,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.SByte[4]
{
5,
-61,
-16,
-78,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 117,
    Value = 
new System.SByte[4]
{
-25,
45,
-97,
-29,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.SByte[3]
{
-89,
-89,
47,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 126,
    Value = 
new System.SByte[3]
{
12,
-34,
-65,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.SByte[3]
{
-14,
-19,
51,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 130,
    Value = 
new System.SByte[3]
{
-14,
-67,
28,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.SByte[4]
{
57,
-79,
99,
-37,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-58,
-61,
-39,
},
},
            new SByteMArrayD1E1M
{
    Id = 137,
    Value = 
new System.SByte[4]
{
-123,
-74,
52,
79,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 115,
    Value = 
new System.SByte[3]
{
4,
-95,
-27,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 139,
    Value = 
new System.SByte[4]
{
88,
-18,
7,
110,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 123,
    Value = 
new System.SByte[3]
{
61,
-89,
65,
},
    NullableValue = 
new System.SByte[3]
{
-3,
-41,
-9,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 148,
    Value = 
new System.SByte[3]
{
86,
2,
-49,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.SByte[3]
{
73,
97,
66,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
20,
50,
-67,
},
},
            new SByteMArrayD1E1M
{
    Id = 155,
    Value = 
new System.SByte[4]
{
-110,
16,
55,
-3,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.SByte[3]
{
12,
-5,
102,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 159,
    Value = 
new System.SByte[3]
{
28,
0,
32,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 130,
    Value = 
new System.SByte[3]
{
-7,
24,
75,
},
    NullableValue = 
new System.SByte[4]
{
54,
-97,
-56,
-70,
},
},
    NullableValue = 
new System.SByte[3]
{
83,
1,
-69,
},
},
            new SByteMArrayD1E1M
{
    Id = 168,
    Value = 
new System.SByte[4]
{
-8,
-4,
116,
66,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 136,
    Value = 
new System.SByte[4]
{
80,
-93,
0,
61,
},
    NullableValue = 
new System.SByte[3]
{
-48,
97,
91,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 173,
    Value = 
new System.SByte[4]
{
17,
-100,
-94,
97,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.SByte[4]
{
-125,
-82,
-56,
-126,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 178,
    Value = 
new System.SByte[4]
{
25,
-44,
56,
-7,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 139,
    Value = 
new System.SByte[4]
{
-47,
-71,
6,
19,
},
    NullableValue = 
new System.SByte[3]
{
109,
22,
51,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 184,
    Value = 
new System.SByte[3]
{
-106,
-5,
-102,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 147,
    Value = 
new System.SByte[4]
{
-41,
62,
-107,
95,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 188,
    Value = 
new System.SByte[3]
{
16,
81,
88,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 150,
    Value = 
new System.SByte[3]
{
-82,
-124,
40,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-15,
-92,
-50,
119,
},
},
            new SByteMArrayD1E1M
{
    Id = 191,
    Value = 
new System.SByte[3]
{
-18,
-124,
55,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.SByte[4]
{
99,
63,
-95,
-70,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 193,
    Value = 
new System.SByte[3]
{
112,
4,
-21,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 160,
    Value = 
new System.SByte[4]
{
17,
-106,
17,
-24,
},
    NullableValue = 
new System.SByte[3]
{
92,
-52,
107,
},
},
    NullableValue = 
new System.SByte[3]
{
65,
-73,
49,
},
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


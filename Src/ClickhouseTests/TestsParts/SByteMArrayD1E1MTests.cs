

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
    Id = 5,
    Value = 
new System.SByte[3]
{
70,
-60,
99,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.SByte[4]
{
76,
45,
-34,
13,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 10,
    Value = 
new System.SByte[4]
{
-24,
-80,
19,
-111,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.SByte[4]
{
40,
-51,
108,
-127,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
118,
34,
-24,
-79,
},
},
            new SByteMArrayD1E1M
{
    Id = 16,
    Value = 
new System.SByte[3]
{
-101,
77,
-64,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.SByte[4]
{
-102,
16,
97,
105,
},
    NullableValue = 
new System.SByte[3]
{
89,
-48,
-47,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 20,
    Value = 
new System.SByte[3]
{
49,
-32,
73,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.SByte[4]
{
77,
-113,
80,
-118,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
36,
-70,
-46,
},
},
            new SByteMArrayD1E1M
{
    Id = 29,
    Value = 
new System.SByte[4]
{
-81,
59,
106,
37,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.SByte[3]
{
41,
32,
-90,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
34,
-66,
-20,
},
},
            new SByteMArrayD1E1M
{
    Id = 37,
    Value = 
new System.SByte[4]
{
-1,
-5,
4,
-128,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.SByte[3]
{
-22,
-81,
-80,
},
    NullableValue = 
new System.SByte[3]
{
59,
-88,
-71,
},
},
    NullableValue = 
new System.SByte[4]
{
22,
96,
-76,
110,
},
},
            new SByteMArrayD1E1M
{
    Id = 40,
    Value = 
new System.SByte[3]
{
-49,
86,
-96,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.SByte[4]
{
21,
6,
99,
-61,
},
    NullableValue = 
new System.SByte[4]
{
-31,
104,
-78,
26,
},
},
    NullableValue = 
new System.SByte[4]
{
105,
58,
-10,
24,
},
},
            new SByteMArrayD1E1M
{
    Id = 45,
    Value = 
new System.SByte[3]
{
62,
-117,
4,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.SByte[4]
{
49,
-62,
-101,
-43,
},
    NullableValue = 
new System.SByte[4]
{
-97,
-103,
46,
48,
},
},
    NullableValue = 
new System.SByte[3]
{
86,
69,
-123,
},
},
            new SByteMArrayD1E1M
{
    Id = 50,
    Value = 
new System.SByte[4]
{
69,
118,
13,
-49,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.SByte[3]
{
82,
93,
-80,
},
    NullableValue = 
new System.SByte[4]
{
67,
-24,
-98,
0,
},
},
    NullableValue = 
new System.SByte[3]
{
-63,
2,
-42,
},
},
            new SByteMArrayD1E1M
{
    Id = 59,
    Value = 
new System.SByte[3]
{
3,
-67,
-15,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.SByte[3]
{
-18,
71,
102,
},
    NullableValue = 
new System.SByte[4]
{
-15,
-54,
112,
-36,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 68,
    Value = 
new System.SByte[4]
{
-108,
-86,
-28,
-24,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.SByte[4]
{
10,
-12,
-41,
-28,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-46,
91,
97,
},
},
            new SByteMArrayD1E1M
{
    Id = 77,
    Value = 
new System.SByte[3]
{
117,
-53,
49,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.SByte[3]
{
74,
63,
112,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-2,
38,
-88,
70,
},
},
            new SByteMArrayD1E1M
{
    Id = 81,
    Value = 
new System.SByte[4]
{
-52,
-55,
71,
18,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.SByte[4]
{
14,
115,
-103,
55,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-114,
-92,
15,
5,
},
},
            new SByteMArrayD1E1M
{
    Id = 85,
    Value = 
new System.SByte[4]
{
115,
91,
119,
-16,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.SByte[4]
{
97,
-57,
27,
8,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
30,
-11,
0,
},
},
            new SByteMArrayD1E1M
{
    Id = 94,
    Value = 
new System.SByte[3]
{
62,
26,
32,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 94,
    Value = 
new System.SByte[4]
{
-94,
13,
-100,
-122,
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
12,
101,
-86,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.SByte[3]
{
-69,
-120,
-75,
},
    NullableValue = 
new System.SByte[3]
{
-84,
12,
-56,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 102,
    Value = 
new System.SByte[3]
{
67,
89,
-115,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 108,
    Value = 
new System.SByte[4]
{
-109,
65,
-104,
-91,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
126,
31,
-37,
22,
},
},
            new SByteMArrayD1E1M
{
    Id = 107,
    Value = 
new System.SByte[3]
{
-61,
8,
90,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 112,
    Value = 
new System.SByte[4]
{
-69,
-112,
80,
109,
},
    NullableValue = 
new System.SByte[4]
{
91,
121,
5,
67,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 113,
    Value = 
new System.SByte[4]
{
68,
-111,
-113,
17,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 120,
    Value = 
new System.SByte[3]
{
50,
91,
-13,
},
    NullableValue = 
new System.SByte[4]
{
114,
0,
-60,
44,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 118,
    Value = 
new System.SByte[4]
{
-94,
77,
6,
88,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.SByte[3]
{
100,
-38,
117,
},
    NullableValue = 
new System.SByte[4]
{
-55,
29,
43,
20,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 124,
    Value = 
new System.SByte[4]
{
-122,
-46,
1,
-43,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 126,
    Value = 
new System.SByte[3]
{
-90,
-61,
-40,
},
    NullableValue = 
new System.SByte[3]
{
110,
-9,
-87,
},
},
    NullableValue = 
new System.SByte[3]
{
-55,
-37,
-65,
},
},
            new SByteMArrayD1E1M
{
    Id = 133,
    Value = 
new System.SByte[3]
{
-66,
-69,
-32,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 129,
    Value = 
new System.SByte[3]
{
-48,
-127,
-72,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
63,
-118,
-42,
-102,
},
},
            new SByteMArrayD1E1M
{
    Id = 138,
    Value = 
new System.SByte[4]
{
91,
-43,
-70,
-43,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.SByte[4]
{
-127,
-54,
88,
-110,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-64,
115,
121,
107,
},
},
            new SByteMArrayD1E1M
{
    Id = 143,
    Value = 
new System.SByte[4]
{
38,
-48,
-61,
117,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 141,
    Value = 
new System.SByte[3]
{
41,
-74,
-46,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 149,
    Value = 
new System.SByte[4]
{
-100,
-75,
-7,
-40,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 147,
    Value = 
new System.SByte[4]
{
-92,
-41,
-19,
-113,
},
    NullableValue = 
new System.SByte[4]
{
-44,
50,
-122,
3,
},
},
    NullableValue = 
new System.SByte[4]
{
-45,
115,
54,
47,
},
},
            new SByteMArrayD1E1M
{
    Id = 152,
    Value = 
new System.SByte[4]
{
110,
-5,
-33,
-78,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 151,
    Value = 
new System.SByte[3]
{
16,
-67,
52,
},
    NullableValue = 
new System.SByte[4]
{
56,
-13,
-107,
30,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 160,
    Value = 
new System.SByte[3]
{
-126,
-35,
66,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 153,
    Value = 
new System.SByte[3]
{
108,
18,
120,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 166,
    Value = 
new System.SByte[3]
{
-117,
-112,
27,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 159,
    Value = 
new System.SByte[3]
{
75,
3,
17,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
85,
-110,
-87,
},
},
            new SByteMArrayD1E1M
{
    Id = 172,
    Value = 
new System.SByte[4]
{
105,
6,
56,
9,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.SByte[3]
{
-66,
112,
29,
},
    NullableValue = 
new System.SByte[3]
{
-2,
-59,
-101,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 180,
    Value = 
new System.SByte[3]
{
-60,
114,
-121,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 173,
    Value = 
new System.SByte[4]
{
106,
-25,
-120,
-116,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 188,
    Value = 
new System.SByte[4]
{
59,
64,
-38,
119,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 182,
    Value = 
new System.SByte[4]
{
-111,
-49,
56,
101,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 192,
    Value = 
new System.SByte[3]
{
-40,
64,
-14,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 186,
    Value = 
new System.SByte[4]
{
26,
80,
102,
78,
},
    NullableValue = 
new System.SByte[3]
{
-95,
44,
6,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 195,
    Value = 
new System.SByte[3]
{
27,
-107,
107,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 192,
    Value = 
new System.SByte[3]
{
-108,
17,
35,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 197,
    Value = 
new System.SByte[3]
{
-46,
95,
-117,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 197,
    Value = 
new System.SByte[3]
{
104,
-107,
-25,
},
    NullableValue = 
new System.SByte[3]
{
81,
32,
35,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 203,
    Value = 
new System.SByte[4]
{
23,
102,
37,
86,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 200,
    Value = 
new System.SByte[3]
{
59,
118,
5,
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




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
    internal partial interface ISByteMArrayMArrayD2
    {
    }
    
    internal partial class SByteMArrayMArrayD2 : ISByteMArrayMArrayD2
    {


#region TestData

        private readonly SByteMArrayD2E1M[] _testData = new SByteMArrayD2E1M[]
        {
            new SByteMArrayD2E1M
{
    Id = 3,
    Value = 
new System.SByte[,] { {
70,
-35, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.SByte[,] { {
4,
-116, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
-113,
-46, } },
},
            new SByteMArrayD2E1M
{
    Id = 10,
    Value = 
new System.SByte[,] { {
-102,
-71, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.SByte[,] { {
18,
-112, } },
    NullableValue = 
new System.SByte[,] { {
-118,
6, } },
},
    NullableValue = 
new System.SByte[,] { {
-42,
13, } },
},
            new SByteMArrayD2E1M
{
    Id = 19,
    Value = 
new System.SByte[,] { {
-6,
46, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.SByte[,] { {
-34,
-81, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
11,
8, } },
},
            new SByteMArrayD2E1M
{
    Id = 21,
    Value = 
new System.SByte[,] { {
-12,
-67, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.SByte[,] { {
-30,
2, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
-6,
-19, } },
},
            new SByteMArrayD2E1M
{
    Id = 30,
    Value = 
new System.SByte[,] { {
16,
-3, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.SByte[,] { {
85,
-22, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
69,
-116, } },
},
            new SByteMArrayD2E1M
{
    Id = 34,
    Value = 
new System.SByte[,] { {
-117,
2, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.SByte[,] { {
43,
-88, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
26,
-2, } },
},
            new SByteMArrayD2E1M
{
    Id = 38,
    Value = 
new System.SByte[,] { {
-28,
37, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.SByte[,] { {
-79,
101, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 42,
    Value = 
new System.SByte[,] { {
124,
15, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.SByte[,] { {
118,
23, } },
    NullableValue = 
new System.SByte[,] { {
89,
-60, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 46,
    Value = 
new System.SByte[,] { {
118,
74, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.SByte[,] { {
-40,
25, } },
    NullableValue = 
new System.SByte[,] { {
-118,
78, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 48,
    Value = 
new System.SByte[,] { {
66,
-70, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.SByte[,] { {
-24,
68, } },
    NullableValue = 
new System.SByte[,] { {
101,
-17, } },
},
    NullableValue = 
new System.SByte[,] { {
119,
39, } },
},
            new SByteMArrayD2E1M
{
    Id = 53,
    Value = 
new System.SByte[,] { {
-2,
78, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.SByte[,] { {
24,
70, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
-82,
-90, } },
},
            new SByteMArrayD2E1M
{
    Id = 54,
    Value = 
new System.SByte[,] { {
124,
-93, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.SByte[,] { {
-15,
75, } },
    NullableValue = 
new System.SByte[,] { {
-41,
-83, } },
},
    NullableValue = 
new System.SByte[,] { {
25,
-48, } },
},
            new SByteMArrayD2E1M
{
    Id = 63,
    Value = 
new System.SByte[,] { {
45,
-126, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.SByte[,] { {
39,
3, } },
    NullableValue = 
new System.SByte[,] { {
84,
59, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 71,
    Value = 
new System.SByte[,] { {
115,
33, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.SByte[,] { {
-26,
-99, } },
    NullableValue = 
new System.SByte[,] { {
69,
-92, } },
},
    NullableValue = 
new System.SByte[,] { {
-56,
87, } },
},
            new SByteMArrayD2E1M
{
    Id = 76,
    Value = 
new System.SByte[,] { {
17,
-25, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.SByte[,] { {
-30,
38, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
43,
2, } },
},
            new SByteMArrayD2E1M
{
    Id = 79,
    Value = 
new System.SByte[,] { {
-119,
-40, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.SByte[,] { {
91,
-96, } },
    NullableValue = 
new System.SByte[,] { {
24,
-53, } },
},
    NullableValue = 
new System.SByte[,] { {
99,
1, } },
},
            new SByteMArrayD2E1M
{
    Id = 81,
    Value = 
new System.SByte[,] { {
4,
-126, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.SByte[,] { {
-125,
51, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
60,
-123, } },
},
            new SByteMArrayD2E1M
{
    Id = 84,
    Value = 
new System.SByte[,] { {
-115,
-110, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.SByte[,] { {
-38,
122, } },
    NullableValue = 
new System.SByte[,] { {
113,
-64, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 85,
    Value = 
new System.SByte[,] { {
13,
58, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.SByte[,] { {
-72,
-122, } },
    NullableValue = 
new System.SByte[,] { {
61,
-37, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 90,
    Value = 
new System.SByte[,] { {
70,
-14, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 90,
    Value = 
new System.SByte[,] { {
104,
8, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 92,
    Value = 
new System.SByte[,] { {
-123,
56, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.SByte[,] { {
-53,
-74, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
57,
-89, } },
},
            new SByteMArrayD2E1M
{
    Id = 101,
    Value = 
new System.SByte[,] { {
89,
-73, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.SByte[,] { {
114,
-128, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
12,
-100, } },
},
            new SByteMArrayD2E1M
{
    Id = 109,
    Value = 
new System.SByte[,] { {
84,
76, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 110,
    Value = 
new System.SByte[,] { {
-34,
-79, } },
    NullableValue = 
new System.SByte[,] { {
-88,
104, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 117,
    Value = 
new System.SByte[,] { {
54,
-83, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 116,
    Value = 
new System.SByte[,] { {
-128,
-100, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
-43,
-46, } },
},
            new SByteMArrayD2E1M
{
    Id = 124,
    Value = 
new System.SByte[,] { {
112,
86, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 125,
    Value = 
new System.SByte[,] { {
-6,
-13, } },
    NullableValue = 
new System.SByte[,] { {
-98,
-75, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 128,
    Value = 
new System.SByte[,] { {
-46,
-93, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 131,
    Value = 
new System.SByte[,] { {
-47,
118, } },
    NullableValue = 
new System.SByte[,] { {
-110,
-30, } },
},
    NullableValue = 
new System.SByte[,] { {
-117,
59, } },
},
            new SByteMArrayD2E1M
{
    Id = 135,
    Value = 
new System.SByte[,] { {
-29,
-122, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.SByte[,] { {
22,
-59, } },
    NullableValue = 
new System.SByte[,] { {
31,
-33, } },
},
    NullableValue = 
new System.SByte[,] { {
-49,
-125, } },
},
            new SByteMArrayD2E1M
{
    Id = 136,
    Value = 
new System.SByte[,] { {
95,
58, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 145,
    Value = 
new System.SByte[,] { {
-121,
70, } },
    NullableValue = 
new System.SByte[,] { {
-8,
122, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 138,
    Value = 
new System.SByte[,] { {
-106,
115, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.SByte[,] { {
114,
64, } },
    NullableValue = 
new System.SByte[,] { {
-25,
38, } },
},
    NullableValue = 
new System.SByte[,] { {
-106,
89, } },
},
            new SByteMArrayD2E1M
{
    Id = 139,
    Value = 
new System.SByte[,] { {
102,
-97, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.SByte[,] { {
87,
123, } },
    NullableValue = 
new System.SByte[,] { {
17,
-20, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 140,
    Value = 
new System.SByte[,] { {
124,
-3, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 164,
    Value = 
new System.SByte[,] { {
-4,
42, } },
    NullableValue = 
new System.SByte[,] { {
41,
119, } },
},
    NullableValue = 
new System.SByte[,] { {
-98,
70, } },
},
            new SByteMArrayD2E1M
{
    Id = 144,
    Value = 
new System.SByte[,] { {
-57,
74, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 168,
    Value = 
new System.SByte[,] { {
49,
-52, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
-89,
12, } },
},
            new SByteMArrayD2E1M
{
    Id = 148,
    Value = 
new System.SByte[,] { {
-116,
80, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 170,
    Value = 
new System.SByte[,] { {
0,
46, } },
    NullableValue = 
new System.SByte[,] { {
-34,
73, } },
},
    NullableValue = 
new System.SByte[,] { {
-13,
18, } },
},
            new SByteMArrayD2E1M
{
    Id = 153,
    Value = 
new System.SByte[,] { {
121,
-87, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 174,
    Value = 
new System.SByte[,] { {
-84,
-99, } },
    NullableValue = 
new System.SByte[,] { {
-38,
117, } },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 161,
    Value = 
new System.SByte[,] { {
74,
-60, } },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 178,
    Value = 
new System.SByte[,] { {
-13,
-127, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
65,
71, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbytemarrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int8))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int8))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte[,]), 
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
                    await ((ISByteMArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((ISByteMArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.sbytemarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArrayMArrayD2)),
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
                    var models = await ((ISByteMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteMArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


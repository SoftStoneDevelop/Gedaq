

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
    internal partial interface ISByteMArrayArrayArrayInt8
    {
    }
    
    internal partial class SByteMArrayArrayArrayInt8 : ISByteMArrayArrayArrayInt8
    {


#region TestData

        private readonly SByteArrayArrayInt8E1M[] _testData = new SByteArrayArrayInt8E1M[]
        {
            new SByteArrayArrayInt8E1M
{
    Id = 6,
    Value = 
new System.SByte[,] { {
-34,
67, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 2,
    Value = 
new System.SByte[,] { {
-28,
11, } },
    NullableValue = 
new System.SByte[,] { {
94,
52, } },
},
    NullableValue = 
new System.SByte[,] { {
-81,
35, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 13,
    Value = 
new System.SByte[,] { {
91,
59, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 8,
    Value = 
new System.SByte[,] { {
-69,
-120, } },
    NullableValue = 
new System.SByte[,] { {
-19,
-53, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 15,
    Value = 
new System.SByte[,] { {
54,
-96, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 14,
    Value = 
new System.SByte[,] { {
21,
115, } },
    NullableValue = 
new System.SByte[,] { {
109,
22, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 20,
    Value = 
new System.SByte[,] { {
-32,
17, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 21,
    Value = 
new System.SByte[,] { {
69,
32, } },
    NullableValue = 
new System.SByte[,] { {
65,
-112, } },
},
    NullableValue = 
new System.SByte[,] { {
-114,
97, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 23,
    Value = 
new System.SByte[,] { {
-72,
-57, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 30,
    Value = 
new System.SByte[,] { {
-97,
-69, } },
    NullableValue = 
new System.SByte[,] { {
75,
98, } },
},
    NullableValue = 
new System.SByte[,] { {
-66,
-125, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 30,
    Value = 
new System.SByte[,] { {
97,
30, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 35,
    Value = 
new System.SByte[,] { {
-92,
32, } },
    NullableValue = 
new System.SByte[,] { {
-13,
113, } },
},
    NullableValue = 
new System.SByte[,] { {
33,
40, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 37,
    Value = 
new System.SByte[,] { {
-33,
73, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 40,
    Value = 
new System.SByte[,] { {
98,
40, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
-61,
-115, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 42,
    Value = 
new System.SByte[,] { {
-66,
-25, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 48,
    Value = 
new System.SByte[,] { {
38,
-39, } },
    NullableValue = 
new System.SByte[,] { {
108,
-55, } },
},
    NullableValue = 
new System.SByte[,] { {
-76,
35, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 48,
    Value = 
new System.SByte[,] { {
81,
-54, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 56,
    Value = 
new System.SByte[,] { {
84,
-113, } },
    NullableValue = 
new System.SByte[,] { {
32,
21, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 51,
    Value = 
new System.SByte[,] { {
-60,
-56, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 63,
    Value = 
new System.SByte[,] { {
1,
-59, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 55,
    Value = 
new System.SByte[,] { {
-63,
-85, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 70,
    Value = 
new System.SByte[,] { {
101,
-105, } },
    NullableValue = 
new System.SByte[,] { {
-123,
-3, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 59,
    Value = 
new System.SByte[,] { {
-77,
52, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 78,
    Value = 
new System.SByte[,] { {
21,
23, } },
    NullableValue = 
new System.SByte[,] { {
51,
-96, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 66,
    Value = 
new System.SByte[,] { {
-4,
30, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 80,
    Value = 
new System.SByte[,] { {
-117,
-36, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 68,
    Value = 
new System.SByte[,] { {
119,
69, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 85,
    Value = 
new System.SByte[,] { {
71,
24, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 70,
    Value = 
new System.SByte[,] { {
-13,
47, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 94,
    Value = 
new System.SByte[,] { {
45,
45, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
87,
-40, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 73,
    Value = 
new System.SByte[,] { {
107,
119, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 102,
    Value = 
new System.SByte[,] { {
-114,
65, } },
    NullableValue = 
new System.SByte[,] { {
63,
-50, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 77,
    Value = 
new System.SByte[,] { {
-63,
-25, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 106,
    Value = 
new System.SByte[,] { {
-96,
-80, } },
    NullableValue = 
new System.SByte[,] { {
-87,
102, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 83,
    Value = 
new System.SByte[,] { {
-4,
126, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 112,
    Value = 
new System.SByte[,] { {
-36,
-49, } },
    NullableValue = 
new System.SByte[,] { {
-2,
27, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 84,
    Value = 
new System.SByte[,] { {
-46,
106, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 119,
    Value = 
new System.SByte[,] { {
-94,
-33, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 87,
    Value = 
new System.SByte[,] { {
32,
94, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 123,
    Value = 
new System.SByte[,] { {
-42,
-14, } },
    NullableValue = 
new System.SByte[,] { {
95,
84, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 92,
    Value = 
new System.SByte[,] { {
-49,
101, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 125,
    Value = 
new System.SByte[,] { {
-123,
105, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
27,
123, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 98,
    Value = 
new System.SByte[,] { {
-55,
-86, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 132,
    Value = 
new System.SByte[,] { {
-87,
105, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
-120,
40, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 105,
    Value = 
new System.SByte[,] { {
-34,
-67, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 139,
    Value = 
new System.SByte[,] { {
81,
-102, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 111,
    Value = 
new System.SByte[,] { {
100,
-61, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 142,
    Value = 
new System.SByte[,] { {
-125,
-33, } },
    NullableValue = 
new System.SByte[,] { {
-51,
43, } },
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 114,
    Value = 
new System.SByte[,] { {
117,
-102, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 151,
    Value = 
new System.SByte[,] { {
107,
71, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 123,
    Value = 
new System.SByte[,] { {
-33,
82, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 159,
    Value = 
new System.SByte[,] { {
20,
117, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
76,
104, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 130,
    Value = 
new System.SByte[,] { {
120,
-127, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 166,
    Value = 
new System.SByte[,] { {
-95,
-12, } },
    NullableValue = 
new System.SByte[,] { {
1,
104, } },
},
    NullableValue = 
new System.SByte[,] { {
71,
30, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 139,
    Value = 
new System.SByte[,] { {
11,
3, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 172,
    Value = 
new System.SByte[,] { {
-39,
-107, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
119,
123, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 141,
    Value = 
new System.SByte[,] { {
112,
74, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 175,
    Value = 
new System.SByte[,] { {
21,
59, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteArrayArrayInt8E1M
{
    Id = 150,
    Value = 
new System.SByte[,] { {
49,
-7, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 176,
    Value = 
new System.SByte[,] { {
38,
-36, } },
    NullableValue = 
new System.SByte[,] { {
-113,
81, } },
},
    NullableValue = 
new System.SByte[,] { {
85,
80, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 154,
    Value = 
new System.SByte[,] { {
111,
67, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 183,
    Value = 
new System.SByte[,] { {
-24,
-73, } },
    NullableValue = 
new System.SByte[,] { {
114,
17, } },
},
    NullableValue = 
new System.SByte[,] { {
-101,
29, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 157,
    Value = 
new System.SByte[,] { {
-69,
27, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 187,
    Value = 
new System.SByte[,] { {
-44,
-13, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
48,
91, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 165,
    Value = 
new System.SByte[,] { {
-63,
-5, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 190,
    Value = 
new System.SByte[,] { {
-39,
-14, } },
    NullableValue = 
new System.SByte[,] { {
-66,
126, } },
},
    NullableValue = 
new System.SByte[,] { {
-33,
31, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 170,
    Value = 
new System.SByte[,] { {
-104,
-44, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 197,
    Value = 
new System.SByte[,] { {
-14,
90, } },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { {
-36,
-11, } },
},
            new SByteArrayArrayInt8E1M
{
    Id = 174,
    Value = 
new System.SByte[,] { {
-30,
110, } },
    ModelInner = new SByteArrayArrayInt81MI
{
    Id = 203,
    Value = 
new System.SByte[,] { {
71,
-127, } },
    NullableValue = 
new System.SByte[,] { {
-53,
8, } },
},
    NullableValue = 
new System.SByte[,] { {
-116,
104, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbytearrayarrayint8e1m(
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
            asPartInterface: typeof(ISByteMArrayArrayArrayInt8)),
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
                    await ((ISByteMArrayArrayArrayInt8)this).InsertModelDbConnectionAsync(
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
                     ((ISByteMArrayArrayArrayInt8)this).InsertModelDbConnection(
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
FROM gedaqtests.sbytearrayarrayint8e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteArrayArrayInt8E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArrayArrayArrayInt8)),
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
                    var models = await ((ISByteMArrayArrayArrayInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteArrayArrayInt8E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteMArrayArrayArrayInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteArrayArrayInt8E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


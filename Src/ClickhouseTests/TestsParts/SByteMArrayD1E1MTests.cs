

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
    Id = 9,
    Value = 
new System.SByte[3]
{
-64,
-60,
15,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.SByte[4]
{
27,
-113,
9,
13,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
25,
65,
9,
},
},
            new SByteMArrayD1E1M
{
    Id = 16,
    Value = 
new System.SByte[4]
{
57,
57,
-61,
111,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.SByte[3]
{
39,
-52,
-119,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
59,
28,
-70,
},
},
            new SByteMArrayD1E1M
{
    Id = 17,
    Value = 
new System.SByte[3]
{
-72,
62,
74,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.SByte[3]
{
32,
3,
-67,
},
    NullableValue = 
new System.SByte[4]
{
-124,
-92,
-55,
-109,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 19,
    Value = 
new System.SByte[4]
{
112,
101,
29,
-81,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.SByte[3]
{
14,
79,
-86,
},
    NullableValue = 
new System.SByte[4]
{
53,
88,
24,
-79,
},
},
    NullableValue = 
new System.SByte[3]
{
-91,
-108,
39,
},
},
            new SByteMArrayD1E1M
{
    Id = 28,
    Value = 
new System.SByte[4]
{
6,
101,
49,
101,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.SByte[4]
{
-31,
100,
-19,
76,
},
    NullableValue = 
new System.SByte[4]
{
32,
10,
20,
78,
},
},
    NullableValue = 
new System.SByte[3]
{
-65,
125,
-34,
},
},
            new SByteMArrayD1E1M
{
    Id = 33,
    Value = 
new System.SByte[3]
{
124,
-40,
45,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.SByte[3]
{
-58,
-19,
72,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 34,
    Value = 
new System.SByte[4]
{
-107,
77,
35,
-27,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.SByte[3]
{
-59,
-52,
23,
},
    NullableValue = 
new System.SByte[4]
{
-42,
74,
-10,
-86,
},
},
    NullableValue = 
new System.SByte[4]
{
-69,
-50,
47,
63,
},
},
            new SByteMArrayD1E1M
{
    Id = 43,
    Value = 
new System.SByte[4]
{
88,
121,
-121,
-33,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.SByte[3]
{
-32,
88,
-113,
},
    NullableValue = 
new System.SByte[3]
{
-87,
-37,
-6,
},
},
    NullableValue = 
new System.SByte[4]
{
-20,
85,
26,
66,
},
},
            new SByteMArrayD1E1M
{
    Id = 47,
    Value = 
new System.SByte[4]
{
-86,
-86,
-11,
-37,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.SByte[3]
{
-38,
5,
-90,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
36,
17,
71,
},
},
            new SByteMArrayD1E1M
{
    Id = 52,
    Value = 
new System.SByte[4]
{
-81,
79,
-9,
9,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.SByte[3]
{
-54,
-38,
-127,
},
    NullableValue = 
new System.SByte[4]
{
3,
110,
69,
-128,
},
},
    NullableValue = 
new System.SByte[3]
{
-8,
92,
-91,
},
},
            new SByteMArrayD1E1M
{
    Id = 59,
    Value = 
new System.SByte[4]
{
-39,
86,
-121,
-1,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.SByte[3]
{
-90,
62,
55,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 63,
    Value = 
new System.SByte[3]
{
100,
-1,
15,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.SByte[4]
{
-4,
-26,
-30,
2,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 67,
    Value = 
new System.SByte[4]
{
-89,
-123,
-102,
-26,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.SByte[3]
{
-13,
19,
15,
},
    NullableValue = 
new System.SByte[3]
{
49,
25,
113,
},
},
    NullableValue = 
new System.SByte[4]
{
32,
30,
98,
99,
},
},
            new SByteMArrayD1E1M
{
    Id = 71,
    Value = 
new System.SByte[3]
{
105,
-122,
10,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.SByte[3]
{
17,
-124,
120,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 76,
    Value = 
new System.SByte[4]
{
31,
90,
50,
-112,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.SByte[3]
{
-16,
-124,
35,
},
    NullableValue = 
new System.SByte[4]
{
-44,
-48,
-42,
22,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 83,
    Value = 
new System.SByte[3]
{
-16,
-122,
-51,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.SByte[3]
{
4,
71,
10,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 86,
    Value = 
new System.SByte[3]
{
108,
-72,
-36,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.SByte[4]
{
7,
-56,
46,
-106,
},
    NullableValue = 
new System.SByte[4]
{
75,
45,
-71,
-83,
},
},
    NullableValue = 
new System.SByte[4]
{
-13,
30,
-75,
28,
},
},
            new SByteMArrayD1E1M
{
    Id = 90,
    Value = 
new System.SByte[3]
{
24,
26,
79,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.SByte[4]
{
-15,
16,
126,
-57,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 91,
    Value = 
new System.SByte[3]
{
-11,
72,
40,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.SByte[3]
{
3,
117,
-95,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 98,
    Value = 
new System.SByte[3]
{
-114,
114,
-101,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.SByte[4]
{
-17,
69,
37,
5,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 105,
    Value = 
new System.SByte[4]
{
88,
109,
-5,
2,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 93,
    Value = 
new System.SByte[4]
{
-21,
0,
-16,
66,
},
    NullableValue = 
new System.SByte[4]
{
-39,
-30,
-116,
-94,
},
},
    NullableValue = 
new System.SByte[3]
{
76,
30,
-76,
},
},
            new SByteMArrayD1E1M
{
    Id = 108,
    Value = 
new System.SByte[4]
{
108,
-120,
124,
50,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 94,
    Value = 
new System.SByte[3]
{
73,
-83,
-53,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-114,
29,
117,
-47,
},
},
            new SByteMArrayD1E1M
{
    Id = 112,
    Value = 
new System.SByte[4]
{
-42,
48,
-48,
-71,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.SByte[4]
{
-57,
11,
-46,
-76,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
31,
-14,
-46,
},
},
            new SByteMArrayD1E1M
{
    Id = 118,
    Value = 
new System.SByte[3]
{
-81,
87,
8,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.SByte[4]
{
-101,
3,
-40,
59,
},
    NullableValue = 
new System.SByte[3]
{
-119,
-61,
-25,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 121,
    Value = 
new System.SByte[3]
{
96,
-81,
27,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.SByte[4]
{
63,
72,
84,
109,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-4,
124,
91,
},
},
            new SByteMArrayD1E1M
{
    Id = 125,
    Value = 
new System.SByte[4]
{
79,
-68,
-63,
-9,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 112,
    Value = 
new System.SByte[3]
{
-74,
-76,
35,
},
    NullableValue = 
new System.SByte[3]
{
-113,
36,
42,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 133,
    Value = 
new System.SByte[3]
{
32,
106,
-2,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 115,
    Value = 
new System.SByte[4]
{
-5,
-88,
-43,
31,
},
    NullableValue = 
new System.SByte[4]
{
88,
108,
-105,
84,
},
},
    NullableValue = 
new System.SByte[4]
{
-111,
106,
20,
102,
},
},
            new SByteMArrayD1E1M
{
    Id = 141,
    Value = 
new System.SByte[3]
{
-54,
110,
-50,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 117,
    Value = 
new System.SByte[4]
{
91,
-22,
-79,
94,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
114,
41,
4,
},
},
            new SByteMArrayD1E1M
{
    Id = 145,
    Value = 
new System.SByte[4]
{
122,
59,
-106,
-108,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 122,
    Value = 
new System.SByte[3]
{
47,
38,
14,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-109,
-10,
14,
},
},
            new SByteMArrayD1E1M
{
    Id = 148,
    Value = 
new System.SByte[4]
{
-114,
123,
-127,
52,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.SByte[4]
{
-114,
94,
-94,
4,
},
    NullableValue = 
new System.SByte[3]
{
105,
41,
71,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 151,
    Value = 
new System.SByte[3]
{
-60,
68,
-100,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 133,
    Value = 
new System.SByte[3]
{
-110,
-30,
-60,
},
    NullableValue = 
new System.SByte[4]
{
111,
56,
71,
18,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 156,
    Value = 
new System.SByte[4]
{
-122,
10,
108,
-109,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.SByte[4]
{
16,
63,
73,
71,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
35,
-71,
-51,
51,
},
},
            new SByteMArrayD1E1M
{
    Id = 157,
    Value = 
new System.SByte[3]
{
88,
-82,
46,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 136,
    Value = 
new System.SByte[4]
{
119,
-27,
-106,
-122,
},
    NullableValue = 
new System.SByte[3]
{
-14,
-116,
75,
},
},
    NullableValue = 
new System.SByte[3]
{
-128,
-128,
-100,
},
},
            new SByteMArrayD1E1M
{
    Id = 161,
    Value = 
new System.SByte[4]
{
6,
-3,
36,
89,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 140,
    Value = 
new System.SByte[4]
{
-119,
75,
66,
-81,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
55,
-63,
-60,
},
},
            new SByteMArrayD1E1M
{
    Id = 170,
    Value = 
new System.SByte[4]
{
90,
-51,
-31,
-92,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.SByte[3]
{
26,
-55,
59,
},
    NullableValue = 
new System.SByte[3]
{
-105,
14,
53,
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


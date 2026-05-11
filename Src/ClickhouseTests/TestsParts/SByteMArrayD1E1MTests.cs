

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
58,
-45,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.SByte[4]
{
71,
29,
-103,
61,
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
-79,
-86,
-81,
-84,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.SByte[4]
{
60,
58,
-86,
117,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
99,
87,
24,
},
},
            new SByteMArrayD1E1M
{
    Id = 14,
    Value = 
new System.SByte[4]
{
42,
95,
102,
57,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.SByte[4]
{
6,
115,
-55,
-32,
},
    NullableValue = 
new System.SByte[4]
{
-5,
-69,
-73,
60,
},
},
    NullableValue = 
new System.SByte[4]
{
25,
-123,
68,
-31,
},
},
            new SByteMArrayD1E1M
{
    Id = 22,
    Value = 
new System.SByte[4]
{
71,
-110,
-106,
7,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.SByte[3]
{
41,
-9,
74,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
81,
119,
117,
54,
},
},
            new SByteMArrayD1E1M
{
    Id = 23,
    Value = 
new System.SByte[3]
{
108,
-122,
59,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.SByte[4]
{
45,
86,
67,
-86,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
90,
77,
-43,
},
},
            new SByteMArrayD1E1M
{
    Id = 26,
    Value = 
new System.SByte[3]
{
18,
-63,
23,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.SByte[4]
{
-62,
62,
-6,
79,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 30,
    Value = 
new System.SByte[4]
{
120,
-38,
46,
-101,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.SByte[4]
{
70,
-20,
43,
92,
},
    NullableValue = 
new System.SByte[3]
{
-108,
-78,
5,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 35,
    Value = 
new System.SByte[4]
{
72,
70,
0,
-112,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.SByte[3]
{
85,
-118,
-48,
},
    NullableValue = 
new System.SByte[4]
{
67,
-57,
92,
18,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 41,
    Value = 
new System.SByte[3]
{
47,
111,
90,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.SByte[3]
{
-58,
3,
-9,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-29,
-60,
-52,
},
},
            new SByteMArrayD1E1M
{
    Id = 50,
    Value = 
new System.SByte[3]
{
-64,
-108,
-42,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.SByte[3]
{
-58,
-62,
80,
},
    NullableValue = 
new System.SByte[4]
{
68,
33,
61,
-59,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 57,
    Value = 
new System.SByte[4]
{
13,
85,
-109,
62,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.SByte[4]
{
112,
-108,
-53,
102,
},
    NullableValue = 
new System.SByte[4]
{
-104,
106,
47,
-113,
},
},
    NullableValue = 
new System.SByte[3]
{
-68,
72,
89,
},
},
            new SByteMArrayD1E1M
{
    Id = 63,
    Value = 
new System.SByte[3]
{
54,
82,
23,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.SByte[3]
{
17,
-66,
-96,
},
    NullableValue = 
new System.SByte[4]
{
-66,
-38,
-118,
117,
},
},
    NullableValue = 
new System.SByte[4]
{
-94,
11,
121,
30,
},
},
            new SByteMArrayD1E1M
{
    Id = 69,
    Value = 
new System.SByte[3]
{
61,
80,
-6,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.SByte[4]
{
-82,
-60,
-103,
121,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-53,
3,
8,
},
},
            new SByteMArrayD1E1M
{
    Id = 74,
    Value = 
new System.SByte[4]
{
-39,
6,
52,
49,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.SByte[3]
{
-126,
42,
-11,
},
    NullableValue = 
new System.SByte[4]
{
1,
47,
97,
29,
},
},
    NullableValue = 
new System.SByte[4]
{
-9,
-45,
-55,
25,
},
},
            new SByteMArrayD1E1M
{
    Id = 76,
    Value = 
new System.SByte[3]
{
-22,
16,
-11,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.SByte[4]
{
-64,
-122,
-68,
90,
},
    NullableValue = 
new System.SByte[4]
{
40,
-83,
22,
-24,
},
},
    NullableValue = 
new System.SByte[3]
{
8,
60,
25,
},
},
            new SByteMArrayD1E1M
{
    Id = 84,
    Value = 
new System.SByte[3]
{
77,
-87,
-113,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.SByte[3]
{
24,
-109,
34,
},
    NullableValue = 
new System.SByte[4]
{
84,
26,
50,
-43,
},
},
    NullableValue = 
new System.SByte[4]
{
54,
-86,
-117,
-37,
},
},
            new SByteMArrayD1E1M
{
    Id = 87,
    Value = 
new System.SByte[4]
{
-114,
-118,
107,
-32,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.SByte[3]
{
3,
-70,
118,
},
    NullableValue = 
new System.SByte[3]
{
98,
-83,
44,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 91,
    Value = 
new System.SByte[4]
{
-21,
27,
-118,
-24,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.SByte[3]
{
-61,
15,
89,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
86,
37,
-111,
121,
},
},
            new SByteMArrayD1E1M
{
    Id = 94,
    Value = 
new System.SByte[4]
{
120,
102,
-31,
-100,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.SByte[3]
{
-30,
76,
-69,
},
    NullableValue = 
new System.SByte[4]
{
-96,
-119,
-42,
67,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 95,
    Value = 
new System.SByte[3]
{
111,
-74,
60,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.SByte[3]
{
100,
105,
60,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
37,
87,
-92,
},
},
            new SByteMArrayD1E1M
{
    Id = 97,
    Value = 
new System.SByte[3]
{
-14,
-79,
28,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.SByte[4]
{
114,
77,
-108,
75,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-97,
42,
15,
},
},
            new SByteMArrayD1E1M
{
    Id = 101,
    Value = 
new System.SByte[3]
{
56,
-22,
15,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.SByte[4]
{
99,
87,
24,
59,
},
    NullableValue = 
new System.SByte[4]
{
29,
114,
-121,
35,
},
},
    NullableValue = 
new System.SByte[3]
{
-30,
-55,
-71,
},
},
            new SByteMArrayD1E1M
{
    Id = 102,
    Value = 
new System.SByte[4]
{
103,
96,
70,
-63,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.SByte[4]
{
67,
-21,
56,
-116,
},
    NullableValue = 
new System.SByte[3]
{
34,
-33,
68,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 107,
    Value = 
new System.SByte[4]
{
18,
37,
93,
113,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 110,
    Value = 
new System.SByte[3]
{
-29,
-114,
1,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 112,
    Value = 
new System.SByte[4]
{
20,
64,
-111,
69,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 118,
    Value = 
new System.SByte[4]
{
40,
84,
-101,
-6,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 116,
    Value = 
new System.SByte[3]
{
-76,
56,
63,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.SByte[4]
{
31,
-13,
-20,
-62,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
20,
-82,
-90,
},
},
            new SByteMArrayD1E1M
{
    Id = 121,
    Value = 
new System.SByte[3]
{
104,
17,
-112,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.SByte[3]
{
-82,
-97,
32,
},
    NullableValue = 
new System.SByte[3]
{
-57,
76,
-35,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 125,
    Value = 
new System.SByte[3]
{
-103,
-33,
-18,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 136,
    Value = 
new System.SByte[4]
{
-41,
-33,
-65,
24,
},
    NullableValue = 
new System.SByte[4]
{
49,
-55,
-66,
62,
},
},
    NullableValue = 
new System.SByte[4]
{
107,
-10,
-88,
-97,
},
},
            new SByteMArrayD1E1M
{
    Id = 133,
    Value = 
new System.SByte[3]
{
27,
27,
-22,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.SByte[3]
{
-53,
70,
-85,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-23,
113,
57,
},
},
            new SByteMArrayD1E1M
{
    Id = 138,
    Value = 
new System.SByte[3]
{
54,
-55,
-104,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 148,
    Value = 
new System.SByte[3]
{
77,
103,
65,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 146,
    Value = 
new System.SByte[4]
{
-72,
-67,
-125,
-59,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 156,
    Value = 
new System.SByte[3]
{
-104,
-65,
-32,
},
    NullableValue = 
new System.SByte[3]
{
-95,
118,
-81,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 148,
    Value = 
new System.SByte[4]
{
-27,
-74,
-28,
122,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 158,
    Value = 
new System.SByte[3]
{
-63,
-100,
34,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 157,
    Value = 
new System.SByte[4]
{
125,
-47,
8,
66,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.SByte[4]
{
118,
-27,
125,
58,
},
    NullableValue = 
new System.SByte[4]
{
12,
75,
17,
-60,
},
},
    NullableValue = 
new System.SByte[3]
{
-66,
-28,
-16,
},
},
            new SByteMArrayD1E1M
{
    Id = 165,
    Value = 
new System.SByte[3]
{
-123,
105,
-88,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 165,
    Value = 
new System.SByte[4]
{
-100,
-65,
111,
76,
},
    NullableValue = 
new System.SByte[4]
{
118,
-65,
-67,
12,
},
},
    NullableValue = 
new System.SByte[3]
{
-7,
-10,
14,
},
},
            new SByteMArrayD1E1M
{
    Id = 173,
    Value = 
new System.SByte[4]
{
-52,
-79,
29,
-7,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 168,
    Value = 
new System.SByte[3]
{
-50,
43,
34,
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


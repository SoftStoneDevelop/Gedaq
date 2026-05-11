

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
    Id = 3,
    Value = 
new System.SByte[4]
{
122,
-35,
-52,
123,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.SByte[4]
{
-31,
-92,
-46,
58,
},
    NullableValue = 
new System.SByte[3]
{
78,
23,
61,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 7,
    Value = 
new System.SByte[3]
{
46,
93,
-29,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.SByte[3]
{
-53,
-107,
66,
},
    NullableValue = 
new System.SByte[3]
{
-95,
94,
-80,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 15,
    Value = 
new System.SByte[4]
{
11,
67,
21,
115,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.SByte[3]
{
115,
23,
-115,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
8,
-99,
-32,
-66,
},
},
            new SByteMArrayD1E1M
{
    Id = 23,
    Value = 
new System.SByte[4]
{
61,
-65,
70,
47,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.SByte[3]
{
82,
-99,
125,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-57,
38,
88,
10,
},
},
            new SByteMArrayD1E1M
{
    Id = 29,
    Value = 
new System.SByte[4]
{
69,
91,
66,
-106,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.SByte[4]
{
-126,
62,
5,
79,
},
    NullableValue = 
new System.SByte[3]
{
5,
-128,
-60,
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
-104,
74,
62,
-51,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.SByte[3]
{
-69,
121,
106,
},
    NullableValue = 
new System.SByte[3]
{
-35,
-85,
-86,
},
},
    NullableValue = 
new System.SByte[4]
{
63,
116,
-23,
-82,
},
},
            new SByteMArrayD1E1M
{
    Id = 44,
    Value = 
new System.SByte[4]
{
-7,
-117,
48,
72,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.SByte[4]
{
-116,
59,
-90,
-94,
},
    NullableValue = 
new System.SByte[4]
{
-12,
-92,
-37,
26,
},
},
    NullableValue = 
new System.SByte[3]
{
-54,
-52,
23,
},
},
            new SByteMArrayD1E1M
{
    Id = 50,
    Value = 
new System.SByte[3]
{
11,
114,
27,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.SByte[3]
{
93,
-45,
30,
},
    NullableValue = 
new System.SByte[4]
{
-86,
10,
-4,
103,
},
},
    NullableValue = 
new System.SByte[3]
{
-61,
52,
49,
},
},
            new SByteMArrayD1E1M
{
    Id = 52,
    Value = 
new System.SByte[4]
{
-78,
95,
-6,
-50,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.SByte[4]
{
44,
-24,
-28,
79,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-72,
34,
105,
},
},
            new SByteMArrayD1E1M
{
    Id = 54,
    Value = 
new System.SByte[4]
{
-115,
-123,
-106,
40,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.SByte[3]
{
32,
42,
4,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
101,
76,
-120,
},
},
            new SByteMArrayD1E1M
{
    Id = 62,
    Value = 
new System.SByte[4]
{
46,
-72,
36,
-99,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.SByte[3]
{
63,
-84,
62,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 66,
    Value = 
new System.SByte[3]
{
-16,
-94,
109,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.SByte[4]
{
-103,
37,
-89,
114,
},
    NullableValue = 
new System.SByte[4]
{
-101,
62,
124,
12,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 71,
    Value = 
new System.SByte[3]
{
18,
-7,
-22,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.SByte[3]
{
65,
15,
41,
},
    NullableValue = 
new System.SByte[3]
{
49,
-126,
-112,
},
},
    NullableValue = 
new System.SByte[3]
{
-72,
96,
55,
},
},
            new SByteMArrayD1E1M
{
    Id = 76,
    Value = 
new System.SByte[3]
{
-128,
-21,
-53,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.SByte[4]
{
9,
98,
44,
96,
},
    NullableValue = 
new System.SByte[3]
{
-22,
-60,
-19,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 83,
    Value = 
new System.SByte[4]
{
-14,
84,
-101,
103,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.SByte[4]
{
-34,
1,
39,
52,
},
    NullableValue = 
new System.SByte[4]
{
-67,
111,
96,
14,
},
},
    NullableValue = 
new System.SByte[4]
{
96,
8,
14,
-92,
},
},
            new SByteMArrayD1E1M
{
    Id = 87,
    Value = 
new System.SByte[4]
{
-101,
81,
78,
27,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.SByte[4]
{
-68,
-10,
92,
89,
},
    NullableValue = 
new System.SByte[4]
{
64,
20,
-126,
2,
},
},
    NullableValue = 
new System.SByte[4]
{
89,
21,
8,
-11,
},
},
            new SByteMArrayD1E1M
{
    Id = 94,
    Value = 
new System.SByte[3]
{
-16,
-6,
95,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.SByte[3]
{
-37,
-13,
42,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-34,
-95,
-20,
},
},
            new SByteMArrayD1E1M
{
    Id = 101,
    Value = 
new System.SByte[3]
{
97,
51,
-9,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.SByte[4]
{
12,
-117,
80,
55,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-34,
-53,
67,
},
},
            new SByteMArrayD1E1M
{
    Id = 106,
    Value = 
new System.SByte[3]
{
88,
24,
-88,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.SByte[3]
{
-25,
-91,
-10,
},
    NullableValue = 
new System.SByte[3]
{
119,
94,
-44,
},
},
    NullableValue = 
new System.SByte[4]
{
119,
5,
54,
104,
},
},
            new SByteMArrayD1E1M
{
    Id = 114,
    Value = 
new System.SByte[3]
{
-60,
-32,
-93,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.SByte[4]
{
21,
-5,
87,
119,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-58,
29,
83,
-76,
},
},
            new SByteMArrayD1E1M
{
    Id = 122,
    Value = 
new System.SByte[3]
{
-106,
-24,
-79,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.SByte[4]
{
-34,
-39,
-70,
-27,
},
    NullableValue = 
new System.SByte[3]
{
-45,
103,
-25,
},
},
    NullableValue = 
new System.SByte[4]
{
-59,
-35,
85,
51,
},
},
            new SByteMArrayD1E1M
{
    Id = 130,
    Value = 
new System.SByte[4]
{
24,
70,
-125,
49,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.SByte[4]
{
108,
124,
-81,
104,
},
    NullableValue = 
new System.SByte[4]
{
-3,
-74,
-98,
29,
},
},
    NullableValue = 
new System.SByte[3]
{
-56,
-70,
-128,
},
},
            new SByteMArrayD1E1M
{
    Id = 139,
    Value = 
new System.SByte[4]
{
22,
6,
-29,
4,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 116,
    Value = 
new System.SByte[3]
{
8,
-95,
-87,
},
    NullableValue = 
new System.SByte[4]
{
-20,
105,
-40,
-16,
},
},
    NullableValue = 
new System.SByte[4]
{
-128,
108,
82,
-3,
},
},
            new SByteMArrayD1E1M
{
    Id = 144,
    Value = 
new System.SByte[4]
{
-116,
-70,
116,
55,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.SByte[3]
{
-31,
84,
57,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 146,
    Value = 
new System.SByte[3]
{
-65,
75,
-50,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 129,
    Value = 
new System.SByte[4]
{
-62,
87,
-112,
46,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-128,
8,
-46,
},
},
            new SByteMArrayD1E1M
{
    Id = 152,
    Value = 
new System.SByte[4]
{
-4,
99,
-55,
122,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 135,
    Value = 
new System.SByte[3]
{
-35,
39,
-42,
},
    NullableValue = 
new System.SByte[4]
{
-75,
51,
103,
-85,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 155,
    Value = 
new System.SByte[4]
{
-111,
-99,
-66,
-27,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.SByte[4]
{
42,
-90,
18,
71,
},
    NullableValue = 
new System.SByte[4]
{
72,
-92,
80,
-15,
},
},
    NullableValue = 
new System.SByte[3]
{
-11,
15,
-71,
},
},
            new SByteMArrayD1E1M
{
    Id = 162,
    Value = 
new System.SByte[4]
{
62,
-5,
42,
-84,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.SByte[4]
{
-9,
111,
-26,
13,
},
    NullableValue = 
new System.SByte[3]
{
91,
-15,
24,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 169,
    Value = 
new System.SByte[3]
{
64,
-118,
-38,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 149,
    Value = 
new System.SByte[4]
{
72,
-98,
-28,
-7,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 173,
    Value = 
new System.SByte[4]
{
-95,
-76,
36,
78,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.SByte[4]
{
41,
19,
-88,
123,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-118,
68,
-27,
-114,
},
},
            new SByteMArrayD1E1M
{
    Id = 179,
    Value = 
new System.SByte[4]
{
-60,
-37,
-57,
-78,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.SByte[4]
{
-77,
8,
-107,
-42,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 187,
    Value = 
new System.SByte[3]
{
-8,
25,
97,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 170,
    Value = 
new System.SByte[4]
{
62,
104,
120,
-68,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-18,
-42,
120,
},
},
            new SByteMArrayD1E1M
{
    Id = 194,
    Value = 
new System.SByte[3]
{
39,
46,
3,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 177,
    Value = 
new System.SByte[3]
{
-92,
73,
15,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-98,
-46,
-20,
},
},
            new SByteMArrayD1E1M
{
    Id = 195,
    Value = 
new System.SByte[4]
{
-53,
-46,
76,
101,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 181,
    Value = 
new System.SByte[3]
{
60,
-98,
54,
},
    NullableValue = 
new System.SByte[3]
{
26,
52,
5,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 202,
    Value = 
new System.SByte[4]
{
-24,
-105,
-123,
122,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 187,
    Value = 
new System.SByte[3]
{
121,
-36,
107,
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


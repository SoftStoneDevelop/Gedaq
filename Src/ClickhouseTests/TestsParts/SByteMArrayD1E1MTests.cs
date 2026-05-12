

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
    Id = 2,
    Value = 
new System.SByte[3]
{
118,
-117,
72,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.SByte[3]
{
14,
97,
-95,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 10,
    Value = 
new System.SByte[3]
{
122,
83,
-128,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.SByte[3]
{
-98,
-90,
-62,
},
    NullableValue = 
new System.SByte[4]
{
87,
-3,
-65,
60,
},
},
    NullableValue = 
new System.SByte[3]
{
28,
-87,
98,
},
},
            new SByteMArrayD1E1M
{
    Id = 14,
    Value = 
new System.SByte[4]
{
2,
83,
113,
122,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.SByte[3]
{
30,
70,
59,
},
    NullableValue = 
new System.SByte[3]
{
49,
-29,
118,
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
-14,
81,
14,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.SByte[4]
{
-60,
-44,
8,
-66,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-100,
-76,
-28,
78,
},
},
            new SByteMArrayD1E1M
{
    Id = 22,
    Value = 
new System.SByte[3]
{
22,
82,
-94,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.SByte[3]
{
-74,
-75,
14,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 27,
    Value = 
new System.SByte[4]
{
87,
110,
-100,
-98,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.SByte[3]
{
1,
-69,
102,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 28,
    Value = 
new System.SByte[3]
{
110,
-9,
98,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.SByte[3]
{
-88,
100,
85,
},
    NullableValue = 
new System.SByte[4]
{
115,
-60,
-78,
123,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 36,
    Value = 
new System.SByte[4]
{
-15,
-48,
26,
60,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.SByte[4]
{
-21,
60,
59,
-73,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-28,
-32,
2,
},
},
            new SByteMArrayD1E1M
{
    Id = 45,
    Value = 
new System.SByte[3]
{
110,
111,
-57,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.SByte[4]
{
3,
-40,
65,
20,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-16,
27,
-122,
},
},
            new SByteMArrayD1E1M
{
    Id = 53,
    Value = 
new System.SByte[3]
{
6,
-30,
-115,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.SByte[3]
{
13,
48,
-86,
},
    NullableValue = 
new System.SByte[3]
{
116,
52,
9,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 59,
    Value = 
new System.SByte[3]
{
77,
-11,
20,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.SByte[4]
{
-29,
-73,
-108,
-50,
},
    NullableValue = 
new System.SByte[3]
{
-52,
-36,
-42,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 66,
    Value = 
new System.SByte[3]
{
-57,
2,
13,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.SByte[4]
{
-1,
38,
40,
54,
},
    NullableValue = 
new System.SByte[3]
{
2,
-128,
33,
},
},
    NullableValue = 
new System.SByte[3]
{
-104,
125,
26,
},
},
            new SByteMArrayD1E1M
{
    Id = 74,
    Value = 
new System.SByte[4]
{
-8,
39,
25,
-98,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.SByte[4]
{
-24,
41,
110,
72,
},
    NullableValue = 
new System.SByte[4]
{
-74,
-15,
-106,
94,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 78,
    Value = 
new System.SByte[3]
{
-113,
57,
60,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.SByte[3]
{
81,
-49,
-25,
},
    NullableValue = 
new System.SByte[3]
{
24,
107,
-9,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 80,
    Value = 
new System.SByte[3]
{
-87,
121,
-96,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.SByte[4]
{
-57,
48,
83,
12,
},
    NullableValue = 
new System.SByte[4]
{
24,
2,
-51,
94,
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
-65,
-75,
72,
55,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 86,
    Value = 
new System.SByte[4]
{
-24,
-57,
-36,
-27,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 92,
    Value = 
new System.SByte[4]
{
21,
111,
119,
28,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 94,
    Value = 
new System.SByte[4]
{
124,
-50,
-32,
117,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 97,
    Value = 
new System.SByte[3]
{
121,
-76,
-30,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.SByte[4]
{
-43,
-107,
-54,
96,
},
    NullableValue = 
new System.SByte[3]
{
92,
-89,
-5,
},
},
    NullableValue = 
new System.SByte[4]
{
83,
109,
120,
-13,
},
},
            new SByteMArrayD1E1M
{
    Id = 99,
    Value = 
new System.SByte[3]
{
-111,
-122,
-127,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.SByte[4]
{
-44,
99,
125,
-78,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 101,
    Value = 
new System.SByte[4]
{
5,
93,
66,
74,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 108,
    Value = 
new System.SByte[4]
{
-100,
-7,
-55,
48,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 110,
    Value = 
new System.SByte[4]
{
-128,
66,
12,
-69,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 113,
    Value = 
new System.SByte[3]
{
38,
111,
-63,
},
    NullableValue = 
new System.SByte[4]
{
-32,
17,
-112,
102,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 117,
    Value = 
new System.SByte[4]
{
52,
64,
34,
22,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 117,
    Value = 
new System.SByte[4]
{
-31,
-109,
111,
6,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 123,
    Value = 
new System.SByte[3]
{
-122,
-70,
79,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 119,
    Value = 
new System.SByte[3]
{
-62,
-4,
111,
},
    NullableValue = 
new System.SByte[4]
{
65,
-68,
0,
123,
},
},
    NullableValue = 
new System.SByte[4]
{
104,
51,
86,
-91,
},
},
            new SByteMArrayD1E1M
{
    Id = 129,
    Value = 
new System.SByte[4]
{
-81,
88,
-109,
-106,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.SByte[4]
{
-99,
36,
-26,
117,
},
    NullableValue = 
new System.SByte[4]
{
-128,
-78,
110,
-19,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 138,
    Value = 
new System.SByte[3]
{
-12,
124,
-21,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 136,
    Value = 
new System.SByte[4]
{
-47,
-50,
-87,
-8,
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
80,
110,
89,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.SByte[4]
{
-48,
62,
41,
72,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 153,
    Value = 
new System.SByte[3]
{
21,
-60,
-65,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 151,
    Value = 
new System.SByte[4]
{
-39,
121,
100,
-36,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 158,
    Value = 
new System.SByte[4]
{
125,
0,
-128,
-113,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.SByte[3]
{
52,
-33,
-10,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 165,
    Value = 
new System.SByte[3]
{
-4,
102,
1,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.SByte[3]
{
-101,
-111,
-104,
},
    NullableValue = 
new System.SByte[4]
{
-88,
-52,
113,
68,
},
},
    NullableValue = 
new System.SByte[3]
{
89,
-14,
-30,
},
},
            new SByteMArrayD1E1M
{
    Id = 168,
    Value = 
new System.SByte[4]
{
-93,
-101,
-14,
84,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 166,
    Value = 
new System.SByte[4]
{
83,
-6,
49,
39,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 171,
    Value = 
new System.SByte[4]
{
-128,
-37,
-45,
-112,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 175,
    Value = 
new System.SByte[3]
{
-91,
115,
41,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
34,
70,
93,
105,
},
},
            new SByteMArrayD1E1M
{
    Id = 173,
    Value = 
new System.SByte[4]
{
-72,
-101,
65,
-100,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 179,
    Value = 
new System.SByte[4]
{
99,
-36,
-94,
-83,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 181,
    Value = 
new System.SByte[3]
{
-74,
-64,
12,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 180,
    Value = 
new System.SByte[4]
{
35,
-62,
-85,
-75,
},
    NullableValue = 
new System.SByte[3]
{
5,
-72,
-30,
},
},
    NullableValue = null,
},
            new SByteMArrayD1E1M
{
    Id = 185,
    Value = 
new System.SByte[3]
{
-39,
125,
-81,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 184,
    Value = 
new System.SByte[3]
{
-102,
69,
-38,
},
    NullableValue = 
new System.SByte[4]
{
99,
125,
68,
57,
},
},
    NullableValue = 
new System.SByte[4]
{
116,
82,
122,
-60,
},
},
            new SByteMArrayD1E1M
{
    Id = 187,
    Value = 
new System.SByte[3]
{
-117,
-96,
-125,
},
    ModelInner = new SByteMArrayD1E1MI
{
    Id = 189,
    Value = 
new System.SByte[3]
{
-104,
85,
94,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-115,
-20,
94,
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


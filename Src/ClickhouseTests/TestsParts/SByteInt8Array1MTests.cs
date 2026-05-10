

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
    internal partial interface ISByteArrayInt8Array
    {
    }
    
    internal partial class SByteArrayInt8Array : ISByteArrayInt8Array
    {


#region TestData

        private readonly SByteInt8Array1M[] _testData = new SByteInt8Array1M[]
        {
            new SByteInt8Array1M
{
    Id = 1,
    Value = 
new System.SByte[4]
{
-8,
-111,
39,
98,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 4,
    Value = 
new System.SByte[4]
{
-75,
-5,
112,
88,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 9,
    Value = 
new System.SByte[3]
{
-24,
79,
-1,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 7,
    Value = 
new System.SByte[3]
{
-68,
33,
55,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
10,
115,
43,
},
},
            new SByteInt8Array1M
{
    Id = 13,
    Value = 
new System.SByte[3]
{
96,
21,
-65,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 15,
    Value = 
new System.SByte[4]
{
22,
-91,
60,
-66,
},
    NullableValue = 
new System.SByte[4]
{
-20,
14,
-5,
-78,
},
},
    NullableValue = 
new System.SByte[3]
{
-75,
-4,
12,
},
},
            new SByteInt8Array1M
{
    Id = 16,
    Value = 
new System.SByte[4]
{
-40,
-117,
-54,
0,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 17,
    Value = 
new System.SByte[3]
{
-123,
-64,
-93,
},
    NullableValue = 
new System.SByte[4]
{
-27,
-100,
-3,
-94,
},
},
    NullableValue = 
new System.SByte[3]
{
123,
-64,
65,
},
},
            new SByteInt8Array1M
{
    Id = 25,
    Value = 
new System.SByte[3]
{
-96,
30,
-15,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 22,
    Value = 
new System.SByte[4]
{
-10,
13,
42,
98,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 27,
    Value = 
new System.SByte[4]
{
113,
-114,
40,
32,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 24,
    Value = 
new System.SByte[3]
{
-111,
17,
-117,
},
    NullableValue = 
new System.SByte[4]
{
88,
56,
-51,
-29,
},
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 29,
    Value = 
new System.SByte[3]
{
98,
-28,
7,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 33,
    Value = 
new System.SByte[3]
{
-81,
51,
-112,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
65,
18,
52,
40,
},
},
            new SByteInt8Array1M
{
    Id = 32,
    Value = 
new System.SByte[3]
{
-93,
-14,
109,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 34,
    Value = 
new System.SByte[3]
{
-98,
1,
-69,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 33,
    Value = 
new System.SByte[4]
{
37,
74,
66,
-33,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 37,
    Value = 
new System.SByte[4]
{
93,
89,
52,
42,
},
    NullableValue = 
new System.SByte[3]
{
-10,
-31,
22,
},
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 34,
    Value = 
new System.SByte[4]
{
-51,
94,
37,
27,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 40,
    Value = 
new System.SByte[4]
{
-87,
74,
-67,
42,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 35,
    Value = 
new System.SByte[4]
{
-69,
-80,
-51,
20,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 46,
    Value = 
new System.SByte[4]
{
55,
36,
1,
52,
},
    NullableValue = 
new System.SByte[3]
{
-10,
-93,
-122,
},
},
    NullableValue = 
new System.SByte[4]
{
-6,
46,
-26,
-62,
},
},
            new SByteInt8Array1M
{
    Id = 42,
    Value = 
new System.SByte[3]
{
82,
62,
-61,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 53,
    Value = 
new System.SByte[4]
{
74,
-68,
80,
-101,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-60,
-1,
80,
},
},
            new SByteInt8Array1M
{
    Id = 49,
    Value = 
new System.SByte[4]
{
16,
29,
-2,
-34,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 62,
    Value = 
new System.SByte[4]
{
-88,
43,
-108,
-66,
},
    NullableValue = 
new System.SByte[4]
{
-62,
30,
-83,
-35,
},
},
    NullableValue = 
new System.SByte[4]
{
-70,
-120,
-65,
-74,
},
},
            new SByteInt8Array1M
{
    Id = 54,
    Value = 
new System.SByte[3]
{
107,
-22,
38,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 69,
    Value = 
new System.SByte[4]
{
90,
69,
47,
85,
},
    NullableValue = 
new System.SByte[3]
{
-54,
-84,
-42,
},
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 62,
    Value = 
new System.SByte[4]
{
-108,
-111,
25,
-122,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 72,
    Value = 
new System.SByte[3]
{
-30,
-63,
-114,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 65,
    Value = 
new System.SByte[4]
{
-94,
6,
94,
-97,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 79,
    Value = 
new System.SByte[3]
{
-18,
-94,
0,
},
    NullableValue = 
new System.SByte[4]
{
-49,
-4,
8,
-58,
},
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 72,
    Value = 
new System.SByte[4]
{
111,
-127,
90,
69,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 86,
    Value = 
new System.SByte[4]
{
115,
7,
27,
13,
},
    NullableValue = 
new System.SByte[4]
{
78,
-42,
-113,
-98,
},
},
    NullableValue = 
new System.SByte[3]
{
-62,
6,
-98,
},
},
            new SByteInt8Array1M
{
    Id = 74,
    Value = 
new System.SByte[3]
{
37,
54,
-106,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 88,
    Value = 
new System.SByte[3]
{
-120,
-54,
119,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 81,
    Value = 
new System.SByte[3]
{
-99,
8,
-3,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 97,
    Value = 
new System.SByte[4]
{
-109,
-98,
-8,
-20,
},
    NullableValue = 
new System.SByte[4]
{
23,
-43,
99,
-10,
},
},
    NullableValue = 
new System.SByte[3]
{
-35,
12,
-7,
},
},
            new SByteInt8Array1M
{
    Id = 87,
    Value = 
new System.SByte[4]
{
44,
-24,
-32,
-61,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 98,
    Value = 
new System.SByte[4]
{
44,
26,
15,
9,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
111,
85,
-9,
-102,
},
},
            new SByteInt8Array1M
{
    Id = 88,
    Value = 
new System.SByte[3]
{
-58,
-39,
-18,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 104,
    Value = 
new System.SByte[3]
{
-14,
-53,
108,
},
    NullableValue = 
new System.SByte[4]
{
-38,
38,
93,
79,
},
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 91,
    Value = 
new System.SByte[3]
{
109,
91,
-48,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 111,
    Value = 
new System.SByte[3]
{
93,
-20,
26,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
109,
-77,
43,
-7,
},
},
            new SByteInt8Array1M
{
    Id = 97,
    Value = 
new System.SByte[3]
{
62,
-47,
91,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 117,
    Value = 
new System.SByte[3]
{
11,
-50,
119,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 106,
    Value = 
new System.SByte[3]
{
-124,
114,
14,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 125,
    Value = 
new System.SByte[3]
{
-127,
-105,
42,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 113,
    Value = 
new System.SByte[3]
{
101,
8,
119,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 133,
    Value = 
new System.SByte[4]
{
75,
115,
-38,
-11,
},
    NullableValue = 
new System.SByte[4]
{
125,
105,
6,
-9,
},
},
    NullableValue = 
new System.SByte[3]
{
14,
74,
-87,
},
},
            new SByteInt8Array1M
{
    Id = 117,
    Value = 
new System.SByte[3]
{
119,
-120,
-31,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 138,
    Value = 
new System.SByte[4]
{
-110,
116,
-42,
-38,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 125,
    Value = 
new System.SByte[3]
{
-74,
40,
-39,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 145,
    Value = 
new System.SByte[3]
{
2,
-75,
-40,
},
    NullableValue = 
new System.SByte[3]
{
-102,
-75,
-48,
},
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 128,
    Value = 
new System.SByte[4]
{
-80,
20,
70,
42,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 148,
    Value = 
new System.SByte[3]
{
16,
58,
6,
},
    NullableValue = 
new System.SByte[4]
{
-117,
13,
79,
-14,
},
},
    NullableValue = 
new System.SByte[3]
{
36,
71,
48,
},
},
            new SByteInt8Array1M
{
    Id = 136,
    Value = 
new System.SByte[3]
{
-21,
-50,
-33,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 154,
    Value = 
new System.SByte[3]
{
-128,
25,
23,
},
    NullableValue = 
new System.SByte[3]
{
-107,
74,
9,
},
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 141,
    Value = 
new System.SByte[4]
{
-104,
79,
115,
-46,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 157,
    Value = 
new System.SByte[3]
{
-100,
86,
-111,
},
    NullableValue = 
new System.SByte[3]
{
46,
-1,
94,
},
},
    NullableValue = 
new System.SByte[3]
{
-13,
59,
35,
},
},
            new SByteInt8Array1M
{
    Id = 144,
    Value = 
new System.SByte[3]
{
-125,
106,
-100,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 163,
    Value = 
new System.SByte[4]
{
-113,
-40,
44,
106,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 153,
    Value = 
new System.SByte[4]
{
38,
-55,
-82,
73,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 165,
    Value = 
new System.SByte[4]
{
11,
-112,
114,
79,
},
    NullableValue = 
new System.SByte[3]
{
-63,
40,
59,
},
},
    NullableValue = 
new System.SByte[3]
{
36,
-91,
-62,
},
},
            new SByteInt8Array1M
{
    Id = 155,
    Value = 
new System.SByte[3]
{
-61,
104,
-61,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 173,
    Value = 
new System.SByte[4]
{
-39,
5,
-24,
81,
},
    NullableValue = 
new System.SByte[4]
{
-125,
102,
115,
-126,
},
},
    NullableValue = 
new System.SByte[3]
{
108,
-96,
51,
},
},
            new SByteInt8Array1M
{
    Id = 162,
    Value = 
new System.SByte[3]
{
-35,
-23,
47,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 177,
    Value = 
new System.SByte[3]
{
-97,
20,
30,
},
    NullableValue = 
new System.SByte[4]
{
-62,
9,
-78,
-102,
},
},
    NullableValue = null,
},
            new SByteInt8Array1M
{
    Id = 169,
    Value = 
new System.SByte[4]
{
-64,
7,
-96,
-25,
},
    ModelInner = new SByteInt8Array1MI
{
    Id = 181,
    Value = 
new System.SByte[4]
{
-52,
115,
8,
68,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-101,
-118,
95,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbyteint8array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int8[]}, 
    {mi_id:Int32},
    {mi_value:Int8[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArrayInt8Array)),
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
                    await ((ISByteArrayInt8Array)this).InsertModelDbConnectionAsync(
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
                     ((ISByteArrayInt8Array)this).InsertModelDbConnection(
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
FROM gedaqtests.sbyteint8array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteInt8Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArrayInt8Array)),
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
                    var models = await ((ISByteArrayInt8Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteInt8Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteArrayInt8Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteInt8Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


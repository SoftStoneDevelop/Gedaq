

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
    internal partial interface IInt16MArrayMArrayD1
    {
    }
    
    internal partial class Int16MArrayMArrayD1 : IInt16MArrayMArrayD1
    {


#region TestData

        private readonly Int16MArrayD1E1M[] _testData = new Int16MArrayD1E1M[]
        {
            new Int16MArrayD1E1M
{
    Id = 1,
    Value = 
new System.Int16[4]
{
32307,
27253,
4710,
13760,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Int16[4]
{
15806,
9066,
31889,
19147,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 7,
    Value = 
new System.Int16[3]
{
16716,
93,
22298,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int16[4]
{
3353,
8318,
11456,
19610,
},
    NullableValue = 
new System.Int16[4]
{
3982,
27715,
14993,
8255,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int16[3]
{
30259,
18713,
19985,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Int16[3]
{
29819,
3405,
18895,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 16,
    Value = 
new System.Int16[4]
{
26819,
23289,
29645,
12098,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Int16[3]
{
17603,
13362,
13167,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int16[3]
{
8387,
26211,
13974,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int16[4]
{
9114,
8041,
24024,
22311,
},
    NullableValue = 
new System.Int16[4]
{
18592,
11841,
12996,
624,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int16[3]
{
13637,
30485,
5248,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int16[4]
{
13183,
28451,
9110,
30027,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 34,
    Value = 
new System.Int16[4]
{
27464,
27695,
3385,
21498,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Int16[3]
{
26869,
3618,
7161,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
15868,
31601,
25645,
},
},
            new Int16MArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int16[3]
{
10676,
22120,
3075,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Int16[4]
{
31274,
26846,
12345,
11957,
},
    NullableValue = 
new System.Int16[3]
{
26786,
21174,
2601,
},
},
    NullableValue = 
new System.Int16[4]
{
4090,
833,
19603,
3713,
},
},
            new Int16MArrayD1E1M
{
    Id = 45,
    Value = 
new System.Int16[4]
{
21377,
30143,
24964,
11241,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int16[4]
{
25203,
10457,
16947,
754,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int16[3]
{
9591,
19563,
3415,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Int16[4]
{
25843,
22620,
6935,
20240,
},
    NullableValue = 
new System.Int16[4]
{
1970,
28507,
26296,
26755,
},
},
    NullableValue = 
new System.Int16[4]
{
709,
30017,
26575,
7428,
},
},
            new Int16MArrayD1E1M
{
    Id = 57,
    Value = 
new System.Int16[3]
{
5364,
25773,
23412,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Int16[3]
{
12753,
14573,
2690,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 58,
    Value = 
new System.Int16[3]
{
24540,
9856,
7506,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Int16[4]
{
2179,
18437,
14578,
25956,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
24468,
10266,
2088,
},
},
            new Int16MArrayD1E1M
{
    Id = 61,
    Value = 
new System.Int16[4]
{
13933,
25843,
429,
15295,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Int16[4]
{
1428,
27968,
21835,
26827,
},
    NullableValue = 
new System.Int16[3]
{
20679,
24272,
18559,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int16[4]
{
5395,
32444,
32765,
30941,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Int16[4]
{
16759,
28686,
24835,
13600,
},
    NullableValue = 
new System.Int16[3]
{
18109,
19268,
26496,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 73,
    Value = 
new System.Int16[3]
{
5237,
16064,
17101,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Int16[3]
{
13454,
18215,
10215,
},
    NullableValue = 
new System.Int16[4]
{
14370,
27442,
30151,
13989,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 78,
    Value = 
new System.Int16[3]
{
7124,
15046,
27313,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int16[3]
{
13818,
12961,
21623,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
24675,
2977,
31658,
6372,
},
},
            new Int16MArrayD1E1M
{
    Id = 81,
    Value = 
new System.Int16[3]
{
1558,
32487,
3188,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Int16[4]
{
29674,
9811,
4375,
25500,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 87,
    Value = 
new System.Int16[4]
{
29969,
7864,
3318,
13784,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.Int16[4]
{
12548,
32701,
26857,
156,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 89,
    Value = 
new System.Int16[3]
{
22848,
25290,
2840,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Int16[3]
{
11313,
2461,
24576,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 97,
    Value = 
new System.Int16[3]
{
32004,
24484,
20708,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Int16[3]
{
10339,
6287,
2400,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 100,
    Value = 
new System.Int16[4]
{
1956,
32228,
24829,
24205,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 115,
    Value = 
new System.Int16[4]
{
498,
18233,
10132,
13763,
},
    NullableValue = 
new System.Int16[3]
{
2131,
5584,
32356,
},
},
    NullableValue = 
new System.Int16[3]
{
25273,
31026,
24290,
},
},
            new Int16MArrayD1E1M
{
    Id = 104,
    Value = 
new System.Int16[3]
{
7007,
13476,
16601,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Int16[4]
{
3670,
10523,
28584,
844,
},
    NullableValue = 
new System.Int16[4]
{
8672,
22794,
24416,
10637,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int16[3]
{
19814,
31435,
23716,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Int16[3]
{
31283,
28609,
15331,
},
    NullableValue = 
new System.Int16[3]
{
15435,
20840,
26691,
},
},
    NullableValue = 
new System.Int16[4]
{
28075,
5962,
30776,
20682,
},
},
            new Int16MArrayD1E1M
{
    Id = 119,
    Value = 
new System.Int16[4]
{
20163,
11034,
2858,
27498,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Int16[3]
{
24949,
24846,
11871,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 125,
    Value = 
new System.Int16[4]
{
20591,
1411,
7180,
4029,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Int16[3]
{
19391,
3607,
8148,
},
    NullableValue = 
new System.Int16[3]
{
21896,
12806,
27455,
},
},
    NullableValue = 
new System.Int16[4]
{
8606,
6914,
30991,
21133,
},
},
            new Int16MArrayD1E1M
{
    Id = 132,
    Value = 
new System.Int16[3]
{
4980,
31247,
11206,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Int16[3]
{
17639,
20321,
15614,
},
    NullableValue = 
new System.Int16[3]
{
2511,
12582,
13854,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int16[4]
{
24019,
30524,
8376,
27206,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Int16[4]
{
20145,
14,
16061,
17612,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
9000,
29940,
25265,
},
},
            new Int16MArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int16[3]
{
26569,
5863,
14470,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Int16[4]
{
3880,
26398,
14011,
27018,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
25940,
14089,
23337,
30850,
},
},
            new Int16MArrayD1E1M
{
    Id = 143,
    Value = 
new System.Int16[4]
{
20196,
8200,
31555,
22479,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Int16[3]
{
11969,
26576,
17137,
},
    NullableValue = 
new System.Int16[3]
{
31959,
19391,
3430,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 150,
    Value = 
new System.Int16[3]
{
26213,
17097,
834,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 165,
    Value = 
new System.Int16[3]
{
23954,
2798,
23409,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 158,
    Value = 
new System.Int16[3]
{
4327,
2602,
20474,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Int16[3]
{
9002,
26971,
6863,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 163,
    Value = 
new System.Int16[4]
{
26202,
17588,
25725,
4513,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 174,
    Value = 
new System.Int16[4]
{
25530,
30733,
31565,
32759,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
12400,
18282,
4240,
},
},
            new Int16MArrayD1E1M
{
    Id = 172,
    Value = 
new System.Int16[4]
{
32469,
5139,
3122,
26118,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 176,
    Value = 
new System.Int16[3]
{
22799,
24068,
9771,
},
    NullableValue = 
new System.Int16[4]
{
22135,
4115,
2844,
20114,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 178,
    Value = 
new System.Int16[4]
{
9370,
3296,
30524,
8183,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 180,
    Value = 
new System.Int16[3]
{
21532,
16513,
32646,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 181,
    Value = 
new System.Int16[3]
{
16291,
11796,
12832,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 185,
    Value = 
new System.Int16[4]
{
31872,
13644,
7164,
16458,
},
    NullableValue = 
new System.Int16[3]
{
19006,
3178,
15107,
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
INSERT INTO gedaqtests.int16marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int16)}, 
    {mi_id:Int32},
    {mi_value:Array(Int16)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
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
                    await ((IInt16MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IInt16MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.int16marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayMArrayD1)),
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
                    var models = await ((IInt16MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


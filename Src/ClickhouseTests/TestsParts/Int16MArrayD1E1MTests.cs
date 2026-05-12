

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
    Id = 6,
    Value = 
new System.Int16[3]
{
6940,
11600,
19803,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Int16[3]
{
5228,
27020,
17937,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
22274,
15504,
31695,
7439,
},
},
            new Int16MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int16[4]
{
6994,
22418,
3647,
32726,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Int16[4]
{
12983,
6001,
16447,
12848,
},
    NullableValue = 
new System.Int16[4]
{
26906,
22128,
27674,
10418,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 12,
    Value = 
new System.Int16[4]
{
28719,
22210,
25405,
4721,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Int16[3]
{
18909,
29449,
4074,
},
    NullableValue = 
new System.Int16[4]
{
24443,
16019,
22072,
25576,
},
},
    NullableValue = 
new System.Int16[3]
{
9484,
7876,
31520,
},
},
            new Int16MArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int16[4]
{
2945,
1972,
10348,
11218,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Int16[4]
{
12,
21317,
3943,
4164,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
22145,
5760,
13216,
},
},
            new Int16MArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int16[4]
{
27522,
21710,
12036,
5037,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Int16[4]
{
17955,
9782,
25687,
18688,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
20858,
22156,
7826,
},
},
            new Int16MArrayD1E1M
{
    Id = 23,
    Value = 
new System.Int16[3]
{
4041,
27614,
9715,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Int16[3]
{
22103,
22055,
9556,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
15773,
13542,
16386,
22995,
},
},
            new Int16MArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int16[3]
{
14559,
20476,
2394,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int16[4]
{
12230,
15266,
29603,
14769,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
23852,
12711,
10144,
},
},
            new Int16MArrayD1E1M
{
    Id = 33,
    Value = 
new System.Int16[3]
{
26855,
30311,
27210,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Int16[4]
{
2301,
23013,
3590,
29955,
},
    NullableValue = 
new System.Int16[3]
{
19435,
32698,
24915,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 39,
    Value = 
new System.Int16[4]
{
6450,
14072,
29833,
20142,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Int16[3]
{
6640,
9281,
22376,
},
    NullableValue = 
new System.Int16[4]
{
25525,
9610,
9777,
27683,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 43,
    Value = 
new System.Int16[3]
{
19236,
22317,
16681,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Int16[4]
{
21501,
31311,
18396,
26965,
},
    NullableValue = 
new System.Int16[3]
{
14525,
11374,
14432,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 44,
    Value = 
new System.Int16[4]
{
6986,
17866,
32157,
21987,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Int16[3]
{
16105,
29029,
25001,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
9408,
12951,
8964,
10313,
},
},
            new Int16MArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int16[4]
{
10926,
16937,
11876,
9846,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int16[4]
{
2670,
5508,
22255,
8574,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 56,
    Value = 
new System.Int16[3]
{
31763,
3379,
18106,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Int16[4]
{
24463,
28789,
17110,
11897,
},
    NullableValue = 
new System.Int16[3]
{
1570,
24852,
6028,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int16[3]
{
26253,
28642,
27680,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Int16[3]
{
22194,
9512,
12626,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
23483,
8503,
21712,
29265,
},
},
            new Int16MArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int16[3]
{
24117,
2640,
5414,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Int16[3]
{
8165,
22358,
2627,
},
    NullableValue = 
new System.Int16[4]
{
22774,
8289,
32764,
23686,
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
27721,
17085,
2991,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Int16[4]
{
32385,
20043,
18057,
27782,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 79,
    Value = 
new System.Int16[3]
{
27324,
10091,
21181,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Int16[3]
{
9415,
16585,
22663,
},
    NullableValue = 
new System.Int16[3]
{
10717,
10151,
23832,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 86,
    Value = 
new System.Int16[4]
{
25325,
22190,
24538,
5038,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Int16[3]
{
18067,
19623,
8941,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
29492,
32241,
14446,
5674,
},
},
            new Int16MArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int16[3]
{
7228,
3522,
6594,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Int16[3]
{
13154,
10943,
5338,
},
    NullableValue = 
new System.Int16[4]
{
25014,
29941,
30960,
16871,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 101,
    Value = 
new System.Int16[3]
{
31946,
21511,
7048,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.Int16[3]
{
16565,
29162,
20251,
},
    NullableValue = 
new System.Int16[3]
{
7614,
32140,
18453,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 102,
    Value = 
new System.Int16[3]
{
3085,
23718,
2198,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Int16[4]
{
8029,
24790,
3843,
5322,
},
    NullableValue = 
new System.Int16[3]
{
27005,
22617,
18285,
},
},
    NullableValue = 
new System.Int16[3]
{
24381,
20401,
6527,
},
},
            new Int16MArrayD1E1M
{
    Id = 108,
    Value = 
new System.Int16[3]
{
15842,
7505,
20912,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Int16[4]
{
25544,
21254,
5644,
11073,
},
    NullableValue = 
new System.Int16[3]
{
13266,
10711,
22630,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 112,
    Value = 
new System.Int16[3]
{
9577,
15939,
6675,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Int16[4]
{
24515,
11116,
28660,
347,
},
    NullableValue = 
new System.Int16[3]
{
24006,
32275,
6521,
},
},
    NullableValue = 
new System.Int16[3]
{
16459,
22441,
29544,
},
},
            new Int16MArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int16[3]
{
30474,
9206,
4524,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Int16[4]
{
339,
22079,
16802,
20047,
},
    NullableValue = 
new System.Int16[3]
{
1713,
13445,
20875,
},
},
    NullableValue = 
new System.Int16[3]
{
16589,
7630,
5075,
},
},
            new Int16MArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int16[4]
{
26969,
24028,
9092,
5673,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 131,
    Value = 
new System.Int16[3]
{
20086,
3773,
29363,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
1017,
8720,
5958,
},
},
            new Int16MArrayD1E1M
{
    Id = 127,
    Value = 
new System.Int16[3]
{
4348,
13787,
27899,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Int16[3]
{
25080,
15020,
15266,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
30923,
29821,
25455,
},
},
            new Int16MArrayD1E1M
{
    Id = 131,
    Value = 
new System.Int16[3]
{
11612,
25805,
5192,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 146,
    Value = 
new System.Int16[4]
{
15261,
18312,
29313,
18631,
},
    NullableValue = 
new System.Int16[4]
{
15461,
12950,
15486,
1805,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 137,
    Value = 
new System.Int16[3]
{
6249,
31444,
16198,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Int16[4]
{
26555,
19669,
16346,
4795,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 145,
    Value = 
new System.Int16[3]
{
20119,
2001,
5839,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Int16[3]
{
13903,
17035,
23261,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 149,
    Value = 
new System.Int16[3]
{
705,
26737,
25055,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 160,
    Value = 
new System.Int16[3]
{
21607,
12857,
16113,
},
    NullableValue = 
new System.Int16[4]
{
3091,
27087,
26330,
3984,
},
},
    NullableValue = 
new System.Int16[4]
{
2630,
21096,
9972,
1565,
},
},
            new Int16MArrayD1E1M
{
    Id = 150,
    Value = 
new System.Int16[3]
{
31023,
17145,
8223,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Int16[3]
{
9614,
32369,
25927,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 152,
    Value = 
new System.Int16[4]
{
22344,
12036,
10981,
8491,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 171,
    Value = 
new System.Int16[4]
{
26929,
25059,
32299,
6444,
},
    NullableValue = 
new System.Int16[4]
{
2229,
25385,
1488,
31865,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 156,
    Value = 
new System.Int16[3]
{
23096,
26024,
51,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 178,
    Value = 
new System.Int16[3]
{
25774,
29294,
7193,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 161,
    Value = 
new System.Int16[3]
{
26992,
6317,
11770,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 185,
    Value = 
new System.Int16[3]
{
29216,
28537,
20656,
},
    NullableValue = 
new System.Int16[4]
{
28402,
9800,
28169,
22862,
},
},
    NullableValue = 
new System.Int16[4]
{
27859,
1045,
31623,
19503,
},
},
            new Int16MArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int16[3]
{
23184,
2658,
9313,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 187,
    Value = 
new System.Int16[3]
{
7078,
32302,
28325,
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


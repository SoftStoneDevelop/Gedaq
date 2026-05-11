

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
    Id = 4,
    Value = 
new System.Int16[4]
{
21329,
8853,
18638,
17922,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Int16[4]
{
20703,
4013,
17908,
22657,
},
    NullableValue = 
new System.Int16[3]
{
17500,
3708,
17195,
},
},
    NullableValue = 
new System.Int16[4]
{
28133,
24519,
13174,
7806,
},
},
            new Int16MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int16[3]
{
29695,
18614,
19865,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Int16[3]
{
3849,
10534,
9699,
},
    NullableValue = 
new System.Int16[4]
{
8618,
26957,
31737,
27119,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 14,
    Value = 
new System.Int16[4]
{
20321,
15225,
23561,
15237,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Int16[4]
{
16074,
1358,
7621,
8323,
},
    NullableValue = 
new System.Int16[4]
{
11519,
16863,
23328,
6023,
},
},
    NullableValue = 
new System.Int16[3]
{
23502,
29896,
25198,
},
},
            new Int16MArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int16[4]
{
20030,
15811,
10115,
8347,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Int16[3]
{
26387,
11081,
9602,
},
    NullableValue = 
new System.Int16[4]
{
15601,
20279,
766,
28681,
},
},
    NullableValue = 
new System.Int16[3]
{
5538,
32421,
29886,
},
},
            new Int16MArrayD1E1M
{
    Id = 16,
    Value = 
new System.Int16[3]
{
16993,
28862,
3957,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Int16[4]
{
21871,
3529,
24642,
11958,
},
    NullableValue = 
new System.Int16[3]
{
12050,
22084,
22912,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int16[3]
{
8087,
23566,
27299,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int16[4]
{
2429,
22847,
19116,
21289,
},
    NullableValue = 
new System.Int16[3]
{
26831,
30569,
21318,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 30,
    Value = 
new System.Int16[4]
{
23539,
3253,
2547,
14524,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Int16[4]
{
6802,
9119,
24289,
14874,
},
    NullableValue = 
new System.Int16[4]
{
14535,
2844,
5675,
18907,
},
},
    NullableValue = 
new System.Int16[3]
{
16845,
25703,
11201,
},
},
            new Int16MArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int16[4]
{
32117,
2450,
25229,
13782,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int16[3]
{
26955,
14283,
18510,
},
    NullableValue = 
new System.Int16[3]
{
10163,
2725,
7055,
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
17913,
15753,
19771,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Int16[4]
{
7423,
1683,
7720,
1066,
},
    NullableValue = 
new System.Int16[3]
{
13035,
19874,
8089,
},
},
    NullableValue = 
new System.Int16[4]
{
29634,
5211,
3777,
12794,
},
},
            new Int16MArrayD1E1M
{
    Id = 49,
    Value = 
new System.Int16[3]
{
23842,
8650,
15034,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Int16[4]
{
19333,
9969,
18237,
27364,
},
    NullableValue = 
new System.Int16[3]
{
26629,
13511,
7764,
},
},
    NullableValue = 
new System.Int16[3]
{
16138,
18263,
27233,
},
},
            new Int16MArrayD1E1M
{
    Id = 58,
    Value = 
new System.Int16[3]
{
10794,
5840,
16966,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int16[3]
{
19544,
6526,
31802,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 60,
    Value = 
new System.Int16[3]
{
9457,
8568,
13789,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Int16[3]
{
30513,
28650,
16543,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int16[4]
{
29987,
18497,
1161,
8601,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int16[4]
{
11118,
11582,
14111,
4718,
},
    NullableValue = 
new System.Int16[3]
{
7549,
24601,
32754,
},
},
    NullableValue = 
new System.Int16[3]
{
3096,
12213,
23951,
},
},
            new Int16MArrayD1E1M
{
    Id = 74,
    Value = 
new System.Int16[3]
{
12894,
24023,
30699,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int16[3]
{
10644,
6276,
15353,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
21069,
28367,
7182,
},
},
            new Int16MArrayD1E1M
{
    Id = 81,
    Value = 
new System.Int16[4]
{
4488,
32088,
17381,
26538,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Int16[4]
{
29574,
32728,
14302,
23971,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 83,
    Value = 
new System.Int16[3]
{
5720,
11999,
26308,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Int16[4]
{
5868,
30460,
31205,
20312,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int16[4]
{
24028,
30795,
16966,
25376,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Int16[4]
{
25538,
269,
28831,
77,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
31644,
2,
32426,
},
},
            new Int16MArrayD1E1M
{
    Id = 97,
    Value = 
new System.Int16[3]
{
28873,
4871,
30421,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Int16[4]
{
8779,
12921,
11689,
1645,
},
    NullableValue = 
new System.Int16[3]
{
21942,
24012,
30332,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 103,
    Value = 
new System.Int16[4]
{
9452,
21637,
30291,
13727,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Int16[4]
{
20984,
26410,
22465,
29471,
},
    NullableValue = 
new System.Int16[4]
{
3085,
21944,
24943,
13196,
},
},
    NullableValue = 
new System.Int16[3]
{
3858,
17686,
16884,
},
},
            new Int16MArrayD1E1M
{
    Id = 110,
    Value = 
new System.Int16[3]
{
8081,
12403,
19575,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Int16[4]
{
24446,
23409,
12266,
28736,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int16[3]
{
6548,
19964,
32364,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Int16[3]
{
32466,
3669,
14389,
},
    NullableValue = 
new System.Int16[3]
{
14730,
5938,
13659,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 112,
    Value = 
new System.Int16[4]
{
15022,
18100,
6491,
546,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Int16[3]
{
13438,
26568,
25113,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 120,
    Value = 
new System.Int16[4]
{
630,
608,
25581,
17792,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 97,
    Value = 
new System.Int16[3]
{
28411,
31144,
2534,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 128,
    Value = 
new System.Int16[3]
{
3712,
18255,
5598,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 101,
    Value = 
new System.Int16[4]
{
24159,
32207,
15535,
7454,
},
    NullableValue = 
new System.Int16[3]
{
19857,
4435,
1822,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int16[4]
{
31729,
28388,
4148,
2440,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Int16[4]
{
24727,
10184,
3325,
7696,
},
    NullableValue = 
new System.Int16[3]
{
14100,
3709,
19596,
},
},
    NullableValue = 
new System.Int16[4]
{
13741,
21010,
16929,
24283,
},
},
            new Int16MArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int16[4]
{
13394,
13849,
14074,
2515,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Int16[4]
{
29490,
18464,
1571,
7938,
},
    NullableValue = 
new System.Int16[3]
{
32548,
32393,
14803,
},
},
    NullableValue = 
new System.Int16[4]
{
28823,
30360,
2943,
23615,
},
},
            new Int16MArrayD1E1M
{
    Id = 142,
    Value = 
new System.Int16[3]
{
22132,
9846,
2040,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 117,
    Value = 
new System.Int16[3]
{
30902,
4576,
1366,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
20657,
15886,
25133,
6698,
},
},
            new Int16MArrayD1E1M
{
    Id = 150,
    Value = 
new System.Int16[4]
{
29742,
29739,
144,
16945,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Int16[3]
{
3564,
24411,
17249,
},
    NullableValue = 
new System.Int16[3]
{
14852,
6056,
11293,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int16[4]
{
21963,
24948,
31255,
13385,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Int16[4]
{
32264,
15575,
29948,
7785,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 156,
    Value = 
new System.Int16[3]
{
28660,
21950,
22419,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Int16[3]
{
9042,
19089,
18375,
},
    NullableValue = 
new System.Int16[3]
{
24574,
28226,
17194,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 158,
    Value = 
new System.Int16[4]
{
11327,
12501,
1462,
9114,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 141,
    Value = 
new System.Int16[3]
{
26059,
25992,
11487,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
13929,
6572,
29268,
},
},
            new Int16MArrayD1E1M
{
    Id = 159,
    Value = 
new System.Int16[3]
{
14138,
16212,
14701,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Int16[4]
{
3117,
5433,
31310,
18940,
},
    NullableValue = 
new System.Int16[3]
{
20334,
31533,
32135,
},
},
    NullableValue = 
new System.Int16[4]
{
3140,
12766,
12002,
24441,
},
},
            new Int16MArrayD1E1M
{
    Id = 161,
    Value = 
new System.Int16[4]
{
29987,
16369,
6974,
31212,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Int16[4]
{
22994,
3698,
30382,
27800,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
14203,
21086,
19550,
28361,
},
},
            new Int16MArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int16[3]
{
22950,
10394,
6557,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Int16[3]
{
9018,
32575,
17510,
},
    NullableValue = 
new System.Int16[3]
{
32761,
25781,
11865,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 173,
    Value = 
new System.Int16[4]
{
27084,
30336,
22993,
26772,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Int16[3]
{
10062,
6093,
2248,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
24635,
21962,
12151,
},
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


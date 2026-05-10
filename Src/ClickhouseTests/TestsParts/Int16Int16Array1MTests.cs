

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
    internal partial interface IInt16ArrayInt16Array
    {
    }
    
    internal partial class Int16ArrayInt16Array : IInt16ArrayInt16Array
    {


#region TestData

        private readonly Int16Int16Array1M[] _testData = new Int16Int16Array1M[]
        {
            new Int16Int16Array1M
{
    Id = 7,
    Value = 
new System.Int16[3]
{
4015,
7690,
5546,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 4,
    Value = 
new System.Int16[4]
{
16684,
5173,
29656,
8315,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 10,
    Value = 
new System.Int16[3]
{
12661,
29169,
13050,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 12,
    Value = 
new System.Int16[4]
{
4869,
14673,
11360,
25907,
},
    NullableValue = 
new System.Int16[4]
{
4203,
25758,
14192,
25288,
},
},
    NullableValue = 
new System.Int16[4]
{
16462,
28121,
14330,
26538,
},
},
            new Int16Int16Array1M
{
    Id = 13,
    Value = 
new System.Int16[3]
{
9526,
27923,
30967,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 20,
    Value = 
new System.Int16[4]
{
24396,
30644,
18182,
7583,
},
    NullableValue = 
new System.Int16[4]
{
29830,
22601,
1423,
2866,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 19,
    Value = 
new System.Int16[4]
{
4103,
26618,
29252,
22128,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 21,
    Value = 
new System.Int16[3]
{
25120,
10335,
22397,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
21264,
7856,
2963,
30050,
},
},
            new Int16Int16Array1M
{
    Id = 25,
    Value = 
new System.Int16[3]
{
6318,
1711,
12036,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 24,
    Value = 
new System.Int16[3]
{
19085,
31105,
23586,
},
    NullableValue = 
new System.Int16[3]
{
4899,
23884,
5919,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 34,
    Value = 
new System.Int16[3]
{
20619,
17642,
22825,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 25,
    Value = 
new System.Int16[3]
{
32269,
29362,
13235,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 39,
    Value = 
new System.Int16[3]
{
16476,
4790,
8588,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 33,
    Value = 
new System.Int16[3]
{
20749,
29243,
30469,
},
    NullableValue = 
new System.Int16[3]
{
10071,
16262,
31987,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 44,
    Value = 
new System.Int16[3]
{
23538,
8288,
9668,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 34,
    Value = 
new System.Int16[4]
{
5132,
6699,
15558,
29211,
},
    NullableValue = 
new System.Int16[4]
{
13830,
3484,
25127,
7018,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 47,
    Value = 
new System.Int16[3]
{
2736,
21022,
32270,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 37,
    Value = 
new System.Int16[4]
{
7500,
3353,
5098,
26438,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 48,
    Value = 
new System.Int16[4]
{
32334,
17095,
7304,
11411,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 41,
    Value = 
new System.Int16[4]
{
26762,
3909,
13923,
25530,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
23132,
21268,
288,
9542,
},
},
            new Int16Int16Array1M
{
    Id = 52,
    Value = 
new System.Int16[4]
{
8919,
19261,
24298,
20681,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 50,
    Value = 
new System.Int16[3]
{
23666,
14162,
17355,
},
    NullableValue = 
new System.Int16[3]
{
13593,
25475,
8778,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 54,
    Value = 
new System.Int16[3]
{
13592,
13251,
18677,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 52,
    Value = 
new System.Int16[3]
{
17309,
25818,
2890,
},
    NullableValue = 
new System.Int16[3]
{
23681,
21565,
3797,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 55,
    Value = 
new System.Int16[4]
{
5697,
11650,
21433,
24018,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 56,
    Value = 
new System.Int16[4]
{
11148,
837,
32354,
476,
},
    NullableValue = 
new System.Int16[3]
{
1301,
11323,
9520,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 61,
    Value = 
new System.Int16[3]
{
28915,
32500,
20736,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 63,
    Value = 
new System.Int16[3]
{
30969,
10963,
8758,
},
    NullableValue = 
new System.Int16[3]
{
32190,
28417,
1893,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 70,
    Value = 
new System.Int16[4]
{
7429,
21614,
4940,
9575,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 69,
    Value = 
new System.Int16[4]
{
4422,
2897,
17731,
21490,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
24057,
14561,
17038,
},
},
            new Int16Int16Array1M
{
    Id = 74,
    Value = 
new System.Int16[3]
{
23488,
3266,
24188,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 70,
    Value = 
new System.Int16[4]
{
25996,
32140,
16597,
32164,
},
    NullableValue = 
new System.Int16[3]
{
22904,
4612,
944,
},
},
    NullableValue = 
new System.Int16[4]
{
31859,
32105,
4129,
12986,
},
},
            new Int16Int16Array1M
{
    Id = 79,
    Value = 
new System.Int16[4]
{
23427,
10799,
26274,
7542,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 77,
    Value = 
new System.Int16[4]
{
4061,
11044,
5766,
17622,
},
    NullableValue = 
new System.Int16[4]
{
25773,
26201,
11357,
25199,
},
},
    NullableValue = 
new System.Int16[3]
{
19168,
25681,
9057,
},
},
            new Int16Int16Array1M
{
    Id = 86,
    Value = 
new System.Int16[3]
{
32763,
21148,
20733,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 78,
    Value = 
new System.Int16[4]
{
12775,
2605,
26641,
20678,
},
    NullableValue = 
new System.Int16[3]
{
2466,
32350,
25030,
},
},
    NullableValue = 
new System.Int16[4]
{
25065,
22531,
13138,
30524,
},
},
            new Int16Int16Array1M
{
    Id = 92,
    Value = 
new System.Int16[4]
{
20696,
2765,
28293,
2431,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 87,
    Value = 
new System.Int16[4]
{
27713,
30496,
4432,
2134,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
29897,
23752,
10216,
},
},
            new Int16Int16Array1M
{
    Id = 101,
    Value = 
new System.Int16[4]
{
27655,
2962,
17088,
12366,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 88,
    Value = 
new System.Int16[3]
{
18420,
14377,
22917,
},
    NullableValue = 
new System.Int16[4]
{
25625,
8514,
25734,
9871,
},
},
    NullableValue = 
new System.Int16[3]
{
16488,
12367,
10597,
},
},
            new Int16Int16Array1M
{
    Id = 107,
    Value = 
new System.Int16[4]
{
31485,
27253,
8137,
32711,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 97,
    Value = 
new System.Int16[3]
{
32405,
3460,
14815,
},
    NullableValue = 
new System.Int16[3]
{
13081,
32607,
22605,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 115,
    Value = 
new System.Int16[4]
{
549,
19445,
19919,
20928,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 102,
    Value = 
new System.Int16[4]
{
10250,
4979,
18049,
29244,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
24823,
8817,
5926,
},
},
            new Int16Int16Array1M
{
    Id = 120,
    Value = 
new System.Int16[3]
{
9471,
17175,
30887,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 109,
    Value = 
new System.Int16[4]
{
22798,
11934,
7851,
32393,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
28907,
26749,
6718,
},
},
            new Int16Int16Array1M
{
    Id = 122,
    Value = 
new System.Int16[4]
{
20500,
26067,
18189,
17097,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 111,
    Value = 
new System.Int16[3]
{
17937,
16927,
4198,
},
    NullableValue = 
new System.Int16[4]
{
25285,
23621,
23872,
23340,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 123,
    Value = 
new System.Int16[4]
{
30095,
14704,
11478,
12611,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 112,
    Value = 
new System.Int16[3]
{
30907,
32335,
29667,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
6184,
11875,
3781,
12064,
},
},
            new Int16Int16Array1M
{
    Id = 126,
    Value = 
new System.Int16[3]
{
25971,
19049,
11472,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 120,
    Value = 
new System.Int16[4]
{
8711,
14784,
20936,
13856,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 135,
    Value = 
new System.Int16[3]
{
19520,
11841,
18690,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 122,
    Value = 
new System.Int16[3]
{
15825,
25478,
18426,
},
    NullableValue = 
new System.Int16[3]
{
31071,
22269,
1864,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 141,
    Value = 
new System.Int16[4]
{
6075,
11647,
18895,
1597,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 129,
    Value = 
new System.Int16[4]
{
8327,
17797,
9124,
30002,
},
    NullableValue = 
new System.Int16[3]
{
15099,
2912,
23474,
},
},
    NullableValue = 
new System.Int16[4]
{
28050,
29392,
3804,
6407,
},
},
            new Int16Int16Array1M
{
    Id = 149,
    Value = 
new System.Int16[3]
{
29422,
15967,
10934,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 134,
    Value = 
new System.Int16[3]
{
22569,
3354,
16945,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 153,
    Value = 
new System.Int16[4]
{
6175,
29871,
15259,
12310,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 139,
    Value = 
new System.Int16[4]
{
19728,
30750,
19467,
9071,
},
    NullableValue = 
new System.Int16[3]
{
10248,
20989,
19921,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 157,
    Value = 
new System.Int16[3]
{
24154,
15082,
8574,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 147,
    Value = 
new System.Int16[3]
{
15336,
21210,
29030,
},
    NullableValue = 
new System.Int16[3]
{
29599,
20463,
10601,
},
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 160,
    Value = 
new System.Int16[4]
{
25659,
10238,
18409,
23646,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 153,
    Value = 
new System.Int16[3]
{
24896,
11755,
28285,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16Array1M
{
    Id = 161,
    Value = 
new System.Int16[3]
{
15152,
24788,
13864,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 161,
    Value = 
new System.Int16[3]
{
28858,
14512,
16925,
},
    NullableValue = 
new System.Int16[4]
{
20853,
29886,
29567,
27380,
},
},
    NullableValue = 
new System.Int16[4]
{
482,
25816,
13460,
17076,
},
},
            new Int16Int16Array1M
{
    Id = 163,
    Value = 
new System.Int16[4]
{
10977,
28508,
22592,
21005,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 168,
    Value = 
new System.Int16[4]
{
31023,
5641,
30457,
14483,
},
    NullableValue = 
new System.Int16[4]
{
29253,
23744,
24314,
16946,
},
},
    NullableValue = 
new System.Int16[4]
{
8816,
10865,
20865,
28208,
},
},
            new Int16Int16Array1M
{
    Id = 166,
    Value = 
new System.Int16[4]
{
23789,
14316,
29320,
6202,
},
    ModelInner = new Int16Int16Array1MI
{
    Id = 173,
    Value = 
new System.Int16[4]
{
3953,
29655,
28156,
25429,
},
    NullableValue = 
new System.Int16[4]
{
16303,
1635,
16273,
10563,
},
},
    NullableValue = 
new System.Int16[4]
{
6975,
16492,
7598,
25678,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16int16array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int16[]}, 
    {mi_id:Int32},
    {mi_value:Int16[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArrayInt16Array)),
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
                    await ((IInt16ArrayInt16Array)this).InsertModelDbConnectionAsync(
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
                     ((IInt16ArrayInt16Array)this).InsertModelDbConnection(
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
FROM gedaqtests.int16int16array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16Int16Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArrayInt16Array)),
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
                    var models = await ((IInt16ArrayInt16Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16Int16Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16ArrayInt16Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16Int16Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


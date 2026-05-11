

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
    internal partial interface IUInt16MArrayMArrayD1
    {
    }
    
    internal partial class UInt16MArrayMArrayD1 : IUInt16MArrayMArrayD1
    {


#region TestData

        private readonly UInt16MArrayD1E1M[] _testData = new UInt16MArrayD1E1M[]
        {
            new UInt16MArrayD1E1M
{
    Id = 6,
    Value = 
new System.UInt16[4]
{
38613,
4333,
8517,
43474,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.UInt16[4]
{
58618,
64025,
2460,
4035,
},
    NullableValue = 
new System.UInt16[3]
{
39515,
58199,
19981,
},
},
    NullableValue = 
new System.UInt16[3]
{
22660,
1973,
3866,
},
},
            new UInt16MArrayD1E1M
{
    Id = 8,
    Value = 
new System.UInt16[4]
{
7728,
20036,
65384,
19584,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 10,
    Value = 
new System.UInt16[4]
{
7415,
7974,
53485,
25698,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
46249,
21455,
36876,
678,
},
},
            new UInt16MArrayD1E1M
{
    Id = 14,
    Value = 
new System.UInt16[4]
{
28318,
12063,
37282,
51812,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.UInt16[3]
{
2068,
8807,
43724,
},
    NullableValue = 
new System.UInt16[3]
{
57920,
23322,
8018,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 19,
    Value = 
new System.UInt16[3]
{
27482,
33108,
60238,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.UInt16[3]
{
53644,
36023,
30604,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
44421,
11783,
37443,
},
},
            new UInt16MArrayD1E1M
{
    Id = 21,
    Value = 
new System.UInt16[4]
{
2135,
46108,
16219,
64877,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.UInt16[3]
{
63872,
12666,
36204,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 22,
    Value = 
new System.UInt16[4]
{
22495,
19142,
88,
53669,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.UInt16[4]
{
39087,
16502,
64632,
34687,
},
    NullableValue = 
new System.UInt16[3]
{
11488,
53982,
14957,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 31,
    Value = 
new System.UInt16[3]
{
35426,
8796,
13050,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.UInt16[4]
{
18161,
27629,
31320,
29101,
},
    NullableValue = 
new System.UInt16[3]
{
25150,
15876,
60813,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 38,
    Value = 
new System.UInt16[4]
{
51390,
33817,
29288,
14851,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.UInt16[3]
{
22364,
15658,
60505,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
9108,
4109,
28554,
},
},
            new UInt16MArrayD1E1M
{
    Id = 42,
    Value = 
new System.UInt16[3]
{
2026,
57938,
54009,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.UInt16[3]
{
55709,
36203,
16216,
},
    NullableValue = 
new System.UInt16[3]
{
5487,
37087,
46140,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 44,
    Value = 
new System.UInt16[4]
{
51660,
835,
24420,
30632,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 46,
    Value = 
new System.UInt16[3]
{
49346,
6777,
56357,
},
    NullableValue = 
new System.UInt16[4]
{
20405,
26304,
18354,
55609,
},
},
    NullableValue = 
new System.UInt16[4]
{
63408,
19133,
50737,
63381,
},
},
            new UInt16MArrayD1E1M
{
    Id = 49,
    Value = 
new System.UInt16[4]
{
53137,
45971,
37119,
34615,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 55,
    Value = 
new System.UInt16[4]
{
59731,
15726,
41110,
4025,
},
    NullableValue = 
new System.UInt16[3]
{
6655,
21943,
52266,
},
},
    NullableValue = 
new System.UInt16[3]
{
29085,
27945,
61999,
},
},
            new UInt16MArrayD1E1M
{
    Id = 51,
    Value = 
new System.UInt16[4]
{
18210,
9996,
50317,
43625,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 63,
    Value = 
new System.UInt16[3]
{
48202,
55090,
17979,
},
    NullableValue = 
new System.UInt16[4]
{
42638,
3500,
42018,
65240,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 60,
    Value = 
new System.UInt16[3]
{
38573,
28946,
10080,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 71,
    Value = 
new System.UInt16[4]
{
20142,
51334,
28496,
40706,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 64,
    Value = 
new System.UInt16[4]
{
25104,
25700,
28584,
57554,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.UInt16[3]
{
17477,
39893,
13439,
},
    NullableValue = 
new System.UInt16[4]
{
36744,
61001,
57958,
36970,
},
},
    NullableValue = 
new System.UInt16[3]
{
17618,
63068,
24577,
},
},
            new UInt16MArrayD1E1M
{
    Id = 71,
    Value = 
new System.UInt16[3]
{
8426,
11415,
7144,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.UInt16[3]
{
19277,
10413,
2987,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
4241,
15135,
24354,
},
},
            new UInt16MArrayD1E1M
{
    Id = 74,
    Value = 
new System.UInt16[3]
{
53234,
64916,
14371,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.UInt16[4]
{
41501,
25088,
34399,
57867,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
57540,
39089,
22613,
},
},
            new UInt16MArrayD1E1M
{
    Id = 77,
    Value = 
new System.UInt16[3]
{
11901,
12777,
38202,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.UInt16[3]
{
50695,
20380,
43953,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 86,
    Value = 
new System.UInt16[3]
{
62840,
19559,
16574,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.UInt16[4]
{
26122,
24110,
21691,
26794,
},
    NullableValue = 
new System.UInt16[3]
{
60438,
14805,
24240,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 94,
    Value = 
new System.UInt16[4]
{
40908,
22105,
47991,
23646,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.UInt16[4]
{
31029,
6157,
22956,
32993,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 102,
    Value = 
new System.UInt16[3]
{
8960,
8055,
54898,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.UInt16[3]
{
17297,
40766,
63433,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 107,
    Value = 
new System.UInt16[3]
{
33322,
15574,
21925,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 111,
    Value = 
new System.UInt16[4]
{
51485,
26628,
25182,
12112,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
11338,
21324,
24491,
},
},
            new UInt16MArrayD1E1M
{
    Id = 110,
    Value = 
new System.UInt16[3]
{
5967,
12641,
64028,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 116,
    Value = 
new System.UInt16[4]
{
65302,
63570,
4706,
36422,
},
    NullableValue = 
new System.UInt16[4]
{
63074,
8051,
49872,
39740,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 118,
    Value = 
new System.UInt16[3]
{
26639,
406,
62020,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.UInt16[3]
{
39209,
14762,
55493,
},
    NullableValue = 
new System.UInt16[3]
{
8057,
61364,
28966,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 119,
    Value = 
new System.UInt16[4]
{
52336,
27405,
61465,
19742,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 122,
    Value = 
new System.UInt16[4]
{
43592,
52190,
35909,
3948,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
11458,
48528,
9513,
14535,
},
},
            new UInt16MArrayD1E1M
{
    Id = 126,
    Value = 
new System.UInt16[3]
{
43397,
30821,
18572,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.UInt16[4]
{
23884,
18407,
61086,
6773,
},
    NullableValue = 
new System.UInt16[4]
{
26120,
21085,
44748,
46649,
},
},
    NullableValue = 
new System.UInt16[4]
{
5082,
24746,
42692,
13238,
},
},
            new UInt16MArrayD1E1M
{
    Id = 129,
    Value = 
new System.UInt16[4]
{
16798,
29420,
14322,
33696,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 132,
    Value = 
new System.UInt16[4]
{
33663,
2282,
40403,
11086,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
64246,
58467,
52063,
},
},
            new UInt16MArrayD1E1M
{
    Id = 132,
    Value = 
new System.UInt16[3]
{
33769,
56877,
15453,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.UInt16[3]
{
63367,
62065,
12409,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
23677,
39573,
52879,
14547,
},
},
            new UInt16MArrayD1E1M
{
    Id = 140,
    Value = 
new System.UInt16[4]
{
53668,
9608,
45492,
28387,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 145,
    Value = 
new System.UInt16[4]
{
15840,
1979,
9219,
17368,
},
    NullableValue = 
new System.UInt16[4]
{
27440,
39610,
46533,
49564,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 149,
    Value = 
new System.UInt16[4]
{
10314,
35739,
2258,
46057,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 146,
    Value = 
new System.UInt16[4]
{
51344,
32258,
6537,
28607,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
59523,
45222,
19891,
38924,
},
},
            new UInt16MArrayD1E1M
{
    Id = 154,
    Value = 
new System.UInt16[4]
{
37693,
26932,
17426,
14752,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.UInt16[4]
{
16969,
39997,
33891,
46903,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
14533,
47035,
6264,
27304,
},
},
            new UInt16MArrayD1E1M
{
    Id = 161,
    Value = 
new System.UInt16[3]
{
16749,
55839,
31085,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 158,
    Value = 
new System.UInt16[4]
{
64828,
7984,
7932,
7819,
},
    NullableValue = 
new System.UInt16[4]
{
64065,
17915,
45463,
37238,
},
},
    NullableValue = 
new System.UInt16[4]
{
35045,
59953,
37012,
52211,
},
},
            new UInt16MArrayD1E1M
{
    Id = 163,
    Value = 
new System.UInt16[4]
{
51121,
59198,
55153,
10803,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.UInt16[3]
{
34755,
6525,
55799,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 171,
    Value = 
new System.UInt16[4]
{
49809,
521,
60490,
3149,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.UInt16[3]
{
6498,
64308,
58499,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 174,
    Value = 
new System.UInt16[4]
{
4385,
32076,
40139,
26624,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 170,
    Value = 
new System.UInt16[4]
{
39280,
5003,
353,
15672,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 179,
    Value = 
new System.UInt16[3]
{
34072,
24093,
62266,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 177,
    Value = 
new System.UInt16[3]
{
28804,
58249,
56472,
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
INSERT INTO gedaqtests.uint16marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt16)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt16)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[]), 
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
                    await ((IUInt16MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayMArrayD1)),
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
                    var models = await ((IUInt16MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


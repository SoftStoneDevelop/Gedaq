

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
    Id = 8,
    Value = 
new System.UInt16[3]
{
1291,
10185,
4259,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.UInt16[3]
{
17795,
27626,
38910,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 11,
    Value = 
new System.UInt16[4]
{
35626,
48192,
52326,
63537,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.UInt16[4]
{
24833,
40070,
60148,
3013,
},
    NullableValue = 
new System.UInt16[4]
{
42220,
19677,
5809,
20753,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 16,
    Value = 
new System.UInt16[4]
{
27540,
12505,
64119,
50207,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.UInt16[4]
{
11130,
35104,
39593,
47630,
},
    NullableValue = 
new System.UInt16[3]
{
52615,
50259,
26198,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 18,
    Value = 
new System.UInt16[3]
{
48904,
54649,
49381,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.UInt16[4]
{
34610,
1739,
37930,
48549,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 24,
    Value = 
new System.UInt16[3]
{
57963,
2447,
57999,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 15,
    Value = 
new System.UInt16[4]
{
41241,
38307,
31431,
21623,
},
    NullableValue = 
new System.UInt16[4]
{
969,
19617,
16002,
61519,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 29,
    Value = 
new System.UInt16[3]
{
52051,
46178,
28253,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.UInt16[3]
{
2809,
65492,
25020,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 36,
    Value = 
new System.UInt16[4]
{
13815,
15007,
25180,
18130,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.UInt16[4]
{
29950,
32089,
18287,
49179,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
680,
42059,
50332,
40479,
},
},
            new UInt16MArrayD1E1M
{
    Id = 45,
    Value = 
new System.UInt16[3]
{
34341,
50239,
36292,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 31,
    Value = 
new System.UInt16[4]
{
41250,
2166,
2122,
25197,
},
    NullableValue = 
new System.UInt16[3]
{
60320,
3812,
41580,
},
},
    NullableValue = 
new System.UInt16[4]
{
55478,
2425,
17664,
13992,
},
},
            new UInt16MArrayD1E1M
{
    Id = 51,
    Value = 
new System.UInt16[4]
{
20617,
35031,
53781,
40065,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.UInt16[4]
{
27953,
31634,
24279,
52532,
},
    NullableValue = 
new System.UInt16[4]
{
4014,
28562,
9336,
27952,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 55,
    Value = 
new System.UInt16[4]
{
7913,
36148,
1255,
7247,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.UInt16[3]
{
18786,
18919,
2571,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 56,
    Value = 
new System.UInt16[3]
{
48458,
12958,
2838,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.UInt16[3]
{
31970,
15002,
40342,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 60,
    Value = 
new System.UInt16[4]
{
58112,
27265,
43167,
23568,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 41,
    Value = 
new System.UInt16[4]
{
5728,
54492,
22048,
63375,
},
    NullableValue = 
new System.UInt16[3]
{
41713,
11780,
128,
},
},
    NullableValue = 
new System.UInt16[3]
{
6960,
26752,
36133,
},
},
            new UInt16MArrayD1E1M
{
    Id = 61,
    Value = 
new System.UInt16[4]
{
12754,
3088,
21589,
44247,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.UInt16[4]
{
3826,
58271,
42659,
53640,
},
    NullableValue = 
new System.UInt16[4]
{
60408,
13251,
55816,
23196,
},
},
    NullableValue = 
new System.UInt16[4]
{
61425,
33347,
45372,
39649,
},
},
            new UInt16MArrayD1E1M
{
    Id = 65,
    Value = 
new System.UInt16[3]
{
1735,
20535,
46333,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.UInt16[3]
{
31291,
62249,
34041,
},
    NullableValue = 
new System.UInt16[3]
{
61612,
52444,
17162,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 71,
    Value = 
new System.UInt16[3]
{
54334,
56398,
46584,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.UInt16[4]
{
25862,
10969,
17025,
24073,
},
    NullableValue = 
new System.UInt16[4]
{
18354,
32811,
3953,
60878,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 80,
    Value = 
new System.UInt16[3]
{
15027,
39152,
16183,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.UInt16[4]
{
62209,
37344,
2761,
14046,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
58303,
14438,
4139,
10529,
},
},
            new UInt16MArrayD1E1M
{
    Id = 89,
    Value = 
new System.UInt16[4]
{
57368,
793,
65487,
7297,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.UInt16[4]
{
36501,
11779,
47621,
16534,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 97,
    Value = 
new System.UInt16[4]
{
17423,
34861,
32546,
13406,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.UInt16[4]
{
30461,
21229,
45083,
62562,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
19342,
21511,
23028,
},
},
            new UInt16MArrayD1E1M
{
    Id = 106,
    Value = 
new System.UInt16[3]
{
20895,
65322,
8465,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.UInt16[4]
{
41163,
29833,
22568,
17187,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
17030,
16886,
61999,
43331,
},
},
            new UInt16MArrayD1E1M
{
    Id = 108,
    Value = 
new System.UInt16[3]
{
34633,
54739,
29053,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 85,
    Value = 
new System.UInt16[4]
{
51635,
19687,
61167,
21884,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
48101,
17235,
63844,
},
},
            new UInt16MArrayD1E1M
{
    Id = 109,
    Value = 
new System.UInt16[4]
{
52609,
27775,
28278,
26825,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 90,
    Value = 
new System.UInt16[4]
{
43022,
46021,
61347,
15357,
},
    NullableValue = 
new System.UInt16[3]
{
1569,
38245,
14658,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 115,
    Value = 
new System.UInt16[4]
{
8200,
59833,
20076,
59407,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.UInt16[3]
{
49253,
52383,
25309,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 119,
    Value = 
new System.UInt16[3]
{
64344,
16705,
56101,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.UInt16[4]
{
43312,
37067,
15707,
55940,
},
    NullableValue = 
new System.UInt16[4]
{
30303,
51370,
39580,
42402,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 127,
    Value = 
new System.UInt16[3]
{
34893,
12151,
11583,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 102,
    Value = 
new System.UInt16[4]
{
58780,
57695,
37245,
24273,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 129,
    Value = 
new System.UInt16[3]
{
24204,
11108,
54430,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.UInt16[3]
{
24058,
27657,
13099,
},
    NullableValue = 
new System.UInt16[4]
{
58815,
40054,
38489,
42050,
},
},
    NullableValue = 
new System.UInt16[3]
{
46928,
41040,
4277,
},
},
            new UInt16MArrayD1E1M
{
    Id = 138,
    Value = 
new System.UInt16[3]
{
62315,
18917,
41643,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.UInt16[4]
{
6564,
45148,
29151,
14334,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
7869,
14048,
19843,
25767,
},
},
            new UInt16MArrayD1E1M
{
    Id = 143,
    Value = 
new System.UInt16[4]
{
32722,
52694,
48470,
48103,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 115,
    Value = 
new System.UInt16[3]
{
3001,
6383,
28203,
},
    NullableValue = 
new System.UInt16[3]
{
7479,
62333,
25455,
},
},
    NullableValue = 
new System.UInt16[4]
{
1852,
1224,
43266,
42103,
},
},
            new UInt16MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt16[4]
{
20354,
36394,
1297,
33334,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 122,
    Value = 
new System.UInt16[4]
{
1140,
60041,
29853,
49134,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
47494,
23660,
17960,
64684,
},
},
            new UInt16MArrayD1E1M
{
    Id = 155,
    Value = 
new System.UInt16[3]
{
3218,
53824,
50393,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.UInt16[4]
{
28424,
13416,
57033,
41928,
},
    NullableValue = 
new System.UInt16[4]
{
63533,
13145,
8203,
57123,
},
},
    NullableValue = 
new System.UInt16[4]
{
55813,
2043,
5661,
18243,
},
},
            new UInt16MArrayD1E1M
{
    Id = 163,
    Value = 
new System.UInt16[4]
{
51549,
1686,
59393,
54165,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 137,
    Value = 
new System.UInt16[4]
{
17858,
35051,
35668,
25073,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
22586,
46369,
35872,
},
},
            new UInt16MArrayD1E1M
{
    Id = 169,
    Value = 
new System.UInt16[4]
{
59995,
15899,
65086,
54412,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 138,
    Value = 
new System.UInt16[4]
{
46916,
5841,
19248,
55264,
},
    NullableValue = 
new System.UInt16[3]
{
50483,
21501,
49352,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 175,
    Value = 
new System.UInt16[3]
{
21955,
62323,
37430,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.UInt16[3]
{
19792,
5860,
23869,
},
    NullableValue = 
new System.UInt16[3]
{
39124,
41103,
16387,
},
},
    NullableValue = 
new System.UInt16[3]
{
23809,
49269,
22727,
},
},
            new UInt16MArrayD1E1M
{
    Id = 183,
    Value = 
new System.UInt16[4]
{
12113,
24358,
45625,
5640,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 150,
    Value = 
new System.UInt16[4]
{
32653,
9568,
9983,
49292,
},
    NullableValue = 
new System.UInt16[4]
{
55231,
26629,
51896,
11734,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 185,
    Value = 
new System.UInt16[4]
{
10224,
14161,
61697,
13224,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 159,
    Value = 
new System.UInt16[3]
{
2962,
23220,
1660,
},
    NullableValue = 
new System.UInt16[4]
{
20796,
65402,
5838,
46542,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 192,
    Value = 
new System.UInt16[3]
{
43874,
25999,
25339,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 165,
    Value = 
new System.UInt16[3]
{
43296,
22021,
44931,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
17466,
16278,
32643,
42411,
},
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


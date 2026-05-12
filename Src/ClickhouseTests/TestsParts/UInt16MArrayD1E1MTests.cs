

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
new System.UInt16[4]
{
52534,
46492,
9400,
35661,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 5,
    Value = 
new System.UInt16[3]
{
60625,
37810,
31591,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
279,
14150,
5046,
},
},
            new UInt16MArrayD1E1M
{
    Id = 11,
    Value = 
new System.UInt16[4]
{
10886,
56165,
40554,
21701,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.UInt16[3]
{
49031,
4315,
7535,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 12,
    Value = 
new System.UInt16[3]
{
10534,
5879,
53913,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.UInt16[4]
{
10881,
48696,
1431,
65244,
},
    NullableValue = 
new System.UInt16[3]
{
53154,
17756,
46393,
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
59306,
7954,
30333,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 12,
    Value = 
new System.UInt16[4]
{
52648,
55927,
51889,
34070,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 26,
    Value = 
new System.UInt16[3]
{
58190,
50024,
45283,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.UInt16[3]
{
29840,
25695,
24840,
},
    NullableValue = 
new System.UInt16[4]
{
40880,
6668,
22563,
26225,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 30,
    Value = 
new System.UInt16[4]
{
26291,
35534,
36143,
55380,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.UInt16[4]
{
9707,
52574,
56869,
47382,
},
    NullableValue = 
new System.UInt16[3]
{
11397,
54026,
54977,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 34,
    Value = 
new System.UInt16[3]
{
62155,
19725,
44455,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.UInt16[4]
{
14306,
41964,
4169,
42872,
},
    NullableValue = 
new System.UInt16[4]
{
2668,
56742,
63815,
42373,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 41,
    Value = 
new System.UInt16[3]
{
44807,
60684,
32047,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt16[4]
{
23548,
15739,
16082,
16131,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 46,
    Value = 
new System.UInt16[4]
{
43262,
24604,
58666,
15614,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 45,
    Value = 
new System.UInt16[3]
{
13469,
14569,
14686,
},
    NullableValue = 
new System.UInt16[3]
{
57976,
32739,
20083,
},
},
    NullableValue = 
new System.UInt16[3]
{
25304,
28743,
14842,
},
},
            new UInt16MArrayD1E1M
{
    Id = 53,
    Value = 
new System.UInt16[3]
{
17658,
47249,
28263,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 46,
    Value = 
new System.UInt16[4]
{
8104,
5322,
15970,
59275,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 54,
    Value = 
new System.UInt16[3]
{
47594,
10717,
2062,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt16[4]
{
26530,
33459,
36517,
20752,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
55622,
24423,
21887,
45637,
},
},
            new UInt16MArrayD1E1M
{
    Id = 63,
    Value = 
new System.UInt16[3]
{
9323,
8564,
34806,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.UInt16[3]
{
31585,
62879,
47610,
},
    NullableValue = 
new System.UInt16[4]
{
49626,
29991,
27054,
54504,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 69,
    Value = 
new System.UInt16[4]
{
25180,
50436,
39501,
23306,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.UInt16[4]
{
21019,
35105,
38162,
24938,
},
    NullableValue = 
new System.UInt16[3]
{
59439,
7155,
10988,
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
35634,
32566,
43282,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 72,
    Value = 
new System.UInt16[3]
{
4907,
41384,
26699,
},
    NullableValue = 
new System.UInt16[3]
{
29202,
47001,
55874,
},
},
    NullableValue = 
new System.UInt16[4]
{
25897,
13679,
11522,
14509,
},
},
            new UInt16MArrayD1E1M
{
    Id = 77,
    Value = 
new System.UInt16[4]
{
29917,
25216,
6625,
49225,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 73,
    Value = 
new System.UInt16[3]
{
59643,
56994,
19939,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
41131,
41049,
30043,
},
},
            new UInt16MArrayD1E1M
{
    Id = 83,
    Value = 
new System.UInt16[3]
{
18272,
14345,
25494,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.UInt16[4]
{
17109,
44628,
4083,
12817,
},
    NullableValue = 
new System.UInt16[4]
{
65224,
15682,
22776,
56844,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 90,
    Value = 
new System.UInt16[4]
{
55218,
53203,
5537,
63757,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.UInt16[3]
{
38554,
33846,
1260,
},
    NullableValue = 
new System.UInt16[4]
{
27623,
65384,
27261,
51893,
},
},
    NullableValue = 
new System.UInt16[4]
{
2786,
11031,
24443,
28370,
},
},
            new UInt16MArrayD1E1M
{
    Id = 98,
    Value = 
new System.UInt16[3]
{
9521,
23349,
25186,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.UInt16[3]
{
64522,
37569,
19463,
},
    NullableValue = 
new System.UInt16[4]
{
42410,
16640,
43180,
1007,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 102,
    Value = 
new System.UInt16[4]
{
11760,
36975,
32374,
25439,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.UInt16[3]
{
39559,
8513,
39119,
},
    NullableValue = 
new System.UInt16[4]
{
16599,
40609,
39029,
51001,
},
},
    NullableValue = 
new System.UInt16[4]
{
593,
62818,
53120,
45606,
},
},
            new UInt16MArrayD1E1M
{
    Id = 109,
    Value = 
new System.UInt16[3]
{
23905,
40543,
56113,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.UInt16[3]
{
30122,
54831,
15274,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
47873,
13955,
35744,
52744,
},
},
            new UInt16MArrayD1E1M
{
    Id = 117,
    Value = 
new System.UInt16[4]
{
51900,
21217,
1958,
13379,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 102,
    Value = 
new System.UInt16[3]
{
9654,
25015,
34792,
},
    NullableValue = 
new System.UInt16[4]
{
60159,
4524,
65031,
57954,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 126,
    Value = 
new System.UInt16[3]
{
20738,
644,
34732,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.UInt16[3]
{
31539,
55488,
61534,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 130,
    Value = 
new System.UInt16[3]
{
5799,
56608,
58663,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 113,
    Value = 
new System.UInt16[4]
{
12806,
20010,
29348,
60787,
},
    NullableValue = 
new System.UInt16[4]
{
3286,
57398,
60693,
4449,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 137,
    Value = 
new System.UInt16[4]
{
29022,
14659,
46198,
47338,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 119,
    Value = 
new System.UInt16[3]
{
21721,
33236,
27188,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
14565,
44245,
42055,
14796,
},
},
            new UInt16MArrayD1E1M
{
    Id = 145,
    Value = 
new System.UInt16[4]
{
12287,
50702,
28832,
14120,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.UInt16[4]
{
59541,
23396,
48970,
34663,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
6177,
28034,
60301,
40466,
},
},
            new UInt16MArrayD1E1M
{
    Id = 146,
    Value = 
new System.UInt16[4]
{
55153,
44696,
9134,
29671,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 126,
    Value = 
new System.UInt16[3]
{
11577,
30711,
27781,
},
    NullableValue = 
new System.UInt16[3]
{
18930,
11407,
7531,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 154,
    Value = 
new System.UInt16[3]
{
32549,
35825,
60117,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.UInt16[4]
{
26308,
21618,
22286,
9714,
},
    NullableValue = 
new System.UInt16[3]
{
43691,
60606,
7076,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 156,
    Value = 
new System.UInt16[3]
{
28238,
10367,
4556,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.UInt16[4]
{
27364,
53100,
8950,
62567,
},
    NullableValue = 
new System.UInt16[4]
{
59693,
32540,
26575,
22415,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 165,
    Value = 
new System.UInt16[3]
{
46483,
12937,
18415,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.UInt16[3]
{
53046,
3937,
62247,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
16384,
56223,
22274,
22807,
},
},
            new UInt16MArrayD1E1M
{
    Id = 170,
    Value = 
new System.UInt16[3]
{
42190,
41145,
11812,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.UInt16[3]
{
323,
3099,
5523,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 177,
    Value = 
new System.UInt16[4]
{
907,
51513,
19630,
4673,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.UInt16[3]
{
5966,
59109,
9004,
},
    NullableValue = 
new System.UInt16[3]
{
9583,
4896,
62250,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 179,
    Value = 
new System.UInt16[4]
{
37151,
7138,
7437,
11745,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 159,
    Value = 
new System.UInt16[3]
{
35386,
28967,
52611,
},
    NullableValue = 
new System.UInt16[4]
{
12613,
60851,
9306,
48887,
},
},
    NullableValue = 
new System.UInt16[4]
{
62162,
25645,
30481,
45695,
},
},
            new UInt16MArrayD1E1M
{
    Id = 183,
    Value = 
new System.UInt16[3]
{
42359,
2117,
21309,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.UInt16[3]
{
610,
34903,
48990,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
60900,
47548,
35994,
},
},
            new UInt16MArrayD1E1M
{
    Id = 190,
    Value = 
new System.UInt16[4]
{
11763,
33342,
18780,
43594,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 168,
    Value = 
new System.UInt16[3]
{
38334,
37133,
59162,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 198,
    Value = 
new System.UInt16[3]
{
27003,
16759,
1970,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 174,
    Value = 
new System.UInt16[3]
{
7632,
62001,
23051,
},
    NullableValue = 
new System.UInt16[3]
{
19231,
56649,
56433,
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




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
    Id = 9,
    Value = 
new System.Int16[4]
{
18002,
14623,
1648,
5983,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Int16[4]
{
30761,
28086,
10656,
8438,
},
    NullableValue = 
new System.Int16[4]
{
11961,
32571,
24580,
15472,
},
},
    NullableValue = 
new System.Int16[3]
{
9064,
28800,
30799,
},
},
            new Int16MArrayD1E1M
{
    Id = 16,
    Value = 
new System.Int16[3]
{
16017,
4134,
6010,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Int16[4]
{
13163,
17619,
2169,
10393,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int16[3]
{
21938,
5471,
24779,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Int16[3]
{
10206,
22390,
16847,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
13690,
13821,
12282,
31347,
},
},
            new Int16MArrayD1E1M
{
    Id = 27,
    Value = 
new System.Int16[4]
{
3562,
23627,
6468,
13753,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Int16[3]
{
26873,
27125,
20666,
},
    NullableValue = 
new System.Int16[4]
{
14567,
20912,
1862,
21794,
},
},
    NullableValue = 
new System.Int16[4]
{
13883,
18114,
28489,
3932,
},
},
            new Int16MArrayD1E1M
{
    Id = 36,
    Value = 
new System.Int16[4]
{
16935,
5097,
25759,
31744,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int16[3]
{
15726,
32682,
2537,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
21550,
18337,
8529,
},
},
            new Int16MArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int16[3]
{
30793,
3075,
31629,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Int16[4]
{
13771,
5964,
29289,
20596,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
10694,
257,
14862,
26153,
},
},
            new Int16MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int16[4]
{
31267,
5371,
24158,
13496,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Int16[3]
{
29318,
24078,
20996,
},
    NullableValue = 
new System.Int16[4]
{
15040,
17568,
26826,
2777,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 50,
    Value = 
new System.Int16[4]
{
30675,
26493,
11460,
13295,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Int16[4]
{
18037,
14484,
17685,
32617,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 59,
    Value = 
new System.Int16[4]
{
14732,
20880,
19711,
6859,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int16[4]
{
32743,
12228,
13331,
5780,
},
    NullableValue = 
new System.Int16[4]
{
6062,
16989,
4074,
17153,
},
},
    NullableValue = 
new System.Int16[3]
{
3902,
29101,
1499,
},
},
            new Int16MArrayD1E1M
{
    Id = 63,
    Value = 
new System.Int16[3]
{
6986,
8012,
27603,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Int16[4]
{
2795,
327,
17041,
7163,
},
    NullableValue = 
new System.Int16[4]
{
11557,
6151,
8887,
6155,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 69,
    Value = 
new System.Int16[4]
{
30012,
30978,
25365,
6037,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Int16[3]
{
14259,
28734,
13814,
},
    NullableValue = 
new System.Int16[4]
{
20975,
13219,
22218,
16009,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 77,
    Value = 
new System.Int16[4]
{
12010,
5555,
28339,
31246,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int16[4]
{
6763,
22721,
20414,
5274,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
4597,
23441,
25779,
23607,
},
},
            new Int16MArrayD1E1M
{
    Id = 80,
    Value = 
new System.Int16[4]
{
21983,
7695,
22235,
30147,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Int16[3]
{
14242,
2554,
21340,
},
    NullableValue = 
new System.Int16[3]
{
3680,
16696,
4719,
},
},
    NullableValue = 
new System.Int16[4]
{
31836,
2317,
14085,
3424,
},
},
            new Int16MArrayD1E1M
{
    Id = 89,
    Value = 
new System.Int16[3]
{
12893,
23177,
12533,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Int16[4]
{
27239,
10005,
16132,
19490,
},
    NullableValue = 
new System.Int16[4]
{
26944,
20818,
27676,
16402,
},
},
    NullableValue = 
new System.Int16[4]
{
10331,
18259,
15177,
23204,
},
},
            new Int16MArrayD1E1M
{
    Id = 96,
    Value = 
new System.Int16[3]
{
3356,
9824,
1621,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Int16[4]
{
30053,
22365,
24071,
19263,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 104,
    Value = 
new System.Int16[3]
{
7624,
15929,
32017,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Int16[3]
{
10920,
32556,
9868,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 108,
    Value = 
new System.Int16[4]
{
2645,
21008,
21093,
22773,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Int16[3]
{
19152,
18860,
1567,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 114,
    Value = 
new System.Int16[3]
{
21060,
23962,
11881,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 105,
    Value = 
new System.Int16[3]
{
10324,
24464,
54,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
27764,
20220,
4379,
13959,
},
},
            new Int16MArrayD1E1M
{
    Id = 122,
    Value = 
new System.Int16[3]
{
10389,
276,
6925,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Int16[3]
{
8562,
13352,
29723,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 124,
    Value = 
new System.Int16[3]
{
32179,
11429,
22034,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 119,
    Value = 
new System.Int16[3]
{
9227,
25122,
8965,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
14145,
31461,
30528,
26652,
},
},
            new Int16MArrayD1E1M
{
    Id = 125,
    Value = 
new System.Int16[4]
{
10307,
6175,
32235,
20924,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Int16[3]
{
22404,
10171,
5519,
},
    NullableValue = 
new System.Int16[3]
{
4503,
8266,
19773,
},
},
    NullableValue = 
new System.Int16[3]
{
21702,
16402,
16439,
},
},
            new Int16MArrayD1E1M
{
    Id = 132,
    Value = 
new System.Int16[3]
{
18163,
23676,
10261,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Int16[4]
{
8182,
30399,
16445,
23131,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int16[3]
{
19635,
16766,
15820,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Int16[4]
{
24567,
7858,
7067,
26795,
},
    NullableValue = 
new System.Int16[3]
{
28647,
764,
3075,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 149,
    Value = 
new System.Int16[3]
{
27032,
17591,
7117,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 146,
    Value = 
new System.Int16[4]
{
10576,
867,
6622,
28643,
},
    NullableValue = 
new System.Int16[3]
{
29280,
31050,
12021,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int16[4]
{
3190,
22343,
24874,
21301,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Int16[4]
{
16373,
2367,
14458,
17705,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 156,
    Value = 
new System.Int16[4]
{
6718,
2317,
20957,
7275,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 158,
    Value = 
new System.Int16[4]
{
8068,
30509,
22565,
3545,
},
    NullableValue = 
new System.Int16[3]
{
2869,
1962,
13453,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 164,
    Value = 
new System.Int16[4]
{
27411,
23861,
11767,
2174,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 160,
    Value = 
new System.Int16[3]
{
15005,
27303,
17719,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
13726,
4735,
29776,
},
},
            new Int16MArrayD1E1M
{
    Id = 167,
    Value = 
new System.Int16[4]
{
19914,
20584,
1706,
15243,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 165,
    Value = 
new System.Int16[3]
{
4438,
20083,
28079,
},
    NullableValue = 
new System.Int16[4]
{
20729,
6953,
16110,
13612,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 170,
    Value = 
new System.Int16[4]
{
25920,
27783,
591,
30422,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 168,
    Value = 
new System.Int16[4]
{
29107,
16342,
18638,
8259,
},
    NullableValue = 
new System.Int16[4]
{
26671,
15789,
9971,
12005,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 174,
    Value = 
new System.Int16[3]
{
22466,
22173,
26025,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 171,
    Value = 
new System.Int16[4]
{
22466,
13784,
10414,
26706,
},
    NullableValue = 
new System.Int16[3]
{
7870,
26873,
32596,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 177,
    Value = 
new System.Int16[3]
{
6385,
7964,
19285,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 173,
    Value = 
new System.Int16[4]
{
26151,
7047,
14433,
1913,
},
    NullableValue = 
new System.Int16[3]
{
13500,
22269,
25742,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 179,
    Value = 
new System.Int16[4]
{
154,
16607,
735,
4608,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 179,
    Value = 
new System.Int16[4]
{
3297,
28614,
16634,
2088,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 180,
    Value = 
new System.Int16[4]
{
30310,
22762,
1901,
13720,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 186,
    Value = 
new System.Int16[3]
{
8472,
23957,
20387,
},
    NullableValue = 
new System.Int16[4]
{
31654,
28745,
1678,
5180,
},
},
    NullableValue = 
new System.Int16[4]
{
23435,
5148,
538,
30152,
},
},
            new Int16MArrayD1E1M
{
    Id = 186,
    Value = 
new System.Int16[3]
{
8210,
13727,
19347,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 190,
    Value = 
new System.Int16[4]
{
12561,
3311,
22851,
29935,
},
    NullableValue = 
new System.Int16[3]
{
7308,
21951,
28595,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 195,
    Value = 
new System.Int16[4]
{
31011,
5180,
9973,
4683,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 199,
    Value = 
new System.Int16[4]
{
13478,
658,
29775,
18035,
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


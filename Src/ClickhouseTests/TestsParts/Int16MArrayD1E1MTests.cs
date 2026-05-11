

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
1351,
22356,
27045,
23669,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int16[3]
{
28407,
8140,
1843,
},
    NullableValue = 
new System.Int16[3]
{
18694,
15091,
4853,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int16[3]
{
18874,
15159,
8080,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Int16[3]
{
16722,
15152,
18281,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int16[3]
{
13090,
30876,
15248,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Int16[4]
{
27552,
21420,
9365,
31665,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int16[4]
{
18338,
11366,
11899,
27812,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int16[4]
{
21712,
23539,
15776,
318,
},
    NullableValue = 
new System.Int16[4]
{
4821,
13186,
21489,
13369,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int16[4]
{
12147,
21694,
7307,
4025,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int16[3]
{
993,
11806,
4502,
},
    NullableValue = 
new System.Int16[4]
{
7148,
21199,
20249,
32322,
},
},
    NullableValue = 
new System.Int16[3]
{
13410,
4235,
19863,
},
},
            new Int16MArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int16[4]
{
12695,
25742,
28806,
9890,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int16[4]
{
8340,
24642,
30054,
8494,
},
    NullableValue = 
new System.Int16[3]
{
948,
13284,
15625,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 38,
    Value = 
new System.Int16[3]
{
24194,
22811,
8702,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Int16[4]
{
20028,
6992,
20626,
6735,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int16[4]
{
28282,
31813,
32288,
860,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Int16[4]
{
12863,
490,
30386,
31145,
},
    NullableValue = 
new System.Int16[3]
{
3,
16663,
20363,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 41,
    Value = 
new System.Int16[4]
{
18726,
10483,
873,
27902,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Int16[3]
{
11741,
6580,
3285,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
2553,
1269,
10883,
31861,
},
},
            new Int16MArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int16[4]
{
27761,
27408,
22845,
20665,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Int16[3]
{
21093,
28879,
16157,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 50,
    Value = 
new System.Int16[3]
{
9487,
3224,
16899,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Int16[3]
{
32541,
30640,
27022,
},
    NullableValue = 
new System.Int16[3]
{
5524,
28288,
23891,
},
},
    NullableValue = 
new System.Int16[3]
{
30186,
27974,
15316,
},
},
            new Int16MArrayD1E1M
{
    Id = 58,
    Value = 
new System.Int16[3]
{
26837,
202,
19164,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int16[3]
{
385,
29413,
27386,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 61,
    Value = 
new System.Int16[3]
{
18553,
22207,
28703,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Int16[3]
{
20793,
10360,
5374,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int16[3]
{
12007,
32522,
1267,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Int16[4]
{
11165,
7198,
10720,
5187,
},
    NullableValue = 
new System.Int16[4]
{
4243,
6298,
24169,
831,
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
7147,
6013,
13591,
12444,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Int16[4]
{
19117,
29896,
21373,
15908,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
30065,
8055,
10583,
6466,
},
},
            new Int16MArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int16[3]
{
20841,
14249,
20972,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Int16[4]
{
10232,
10016,
11580,
12252,
},
    NullableValue = 
new System.Int16[3]
{
17751,
15170,
3964,
},
},
    NullableValue = 
new System.Int16[3]
{
4346,
10332,
23189,
},
},
            new Int16MArrayD1E1M
{
    Id = 82,
    Value = 
new System.Int16[4]
{
32568,
15027,
29141,
30309,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Int16[4]
{
19103,
13624,
28892,
26371,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
25573,
21561,
24399,
2599,
},
},
            new Int16MArrayD1E1M
{
    Id = 83,
    Value = 
new System.Int16[4]
{
20607,
13668,
10828,
13136,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Int16[3]
{
1397,
27479,
10101,
},
    NullableValue = 
new System.Int16[3]
{
2009,
32722,
26049,
},
},
    NullableValue = 
new System.Int16[4]
{
27775,
25452,
27804,
1818,
},
},
            new Int16MArrayD1E1M
{
    Id = 84,
    Value = 
new System.Int16[4]
{
23709,
5891,
11794,
18062,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Int16[3]
{
27670,
18127,
6676,
},
    NullableValue = 
new System.Int16[3]
{
21961,
15158,
22232,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int16[3]
{
6401,
29083,
26080,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Int16[3]
{
27458,
31190,
27323,
},
    NullableValue = 
new System.Int16[3]
{
2821,
3033,
11417,
},
},
    NullableValue = 
new System.Int16[3]
{
13270,
3709,
27955,
},
},
            new Int16MArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int16[3]
{
28714,
20528,
28301,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Int16[4]
{
11139,
18107,
17740,
31831,
},
    NullableValue = 
new System.Int16[3]
{
11849,
10179,
1346,
},
},
    NullableValue = 
new System.Int16[4]
{
30096,
18591,
18673,
7592,
},
},
            new Int16MArrayD1E1M
{
    Id = 107,
    Value = 
new System.Int16[3]
{
17062,
18661,
31400,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.Int16[4]
{
7101,
22845,
20651,
24926,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
25674,
24968,
29170,
},
},
            new Int16MArrayD1E1M
{
    Id = 116,
    Value = 
new System.Int16[4]
{
24391,
27096,
1078,
6805,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.Int16[4]
{
20042,
26730,
7773,
11426,
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
7908,
7540,
22595,
26981,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Int16[4]
{
23896,
3687,
13962,
7001,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
22992,
5147,
24044,
},
},
            new Int16MArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int16[4]
{
22706,
14278,
17847,
17009,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Int16[4]
{
8182,
20438,
19158,
1156,
},
    NullableValue = 
new System.Int16[3]
{
17822,
3432,
5971,
},
},
    NullableValue = 
new System.Int16[3]
{
19056,
31699,
27127,
},
},
            new Int16MArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int16[4]
{
26371,
516,
6416,
14398,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Int16[3]
{
9102,
27085,
15458,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 148,
    Value = 
new System.Int16[4]
{
24384,
26415,
7826,
1517,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Int16[3]
{
23468,
22547,
28158,
},
    NullableValue = 
new System.Int16[4]
{
7525,
26313,
485,
26500,
},
},
    NullableValue = 
new System.Int16[4]
{
27697,
26597,
26209,
29058,
},
},
            new Int16MArrayD1E1M
{
    Id = 152,
    Value = 
new System.Int16[4]
{
30340,
16080,
12851,
29541,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Int16[3]
{
32683,
14708,
860,
},
    NullableValue = 
new System.Int16[3]
{
13773,
32347,
16586,
},
},
    NullableValue = 
new System.Int16[3]
{
18271,
11558,
6025,
},
},
            new Int16MArrayD1E1M
{
    Id = 161,
    Value = 
new System.Int16[4]
{
19019,
32423,
32645,
22180,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Int16[4]
{
32467,
10042,
369,
17883,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
11048,
3843,
1574,
7909,
},
},
            new Int16MArrayD1E1M
{
    Id = 170,
    Value = 
new System.Int16[3]
{
13890,
13924,
27492,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 141,
    Value = 
new System.Int16[3]
{
29768,
12618,
9608,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 171,
    Value = 
new System.Int16[3]
{
31689,
9023,
20964,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Int16[3]
{
16940,
13658,
28534,
},
    NullableValue = 
new System.Int16[4]
{
13698,
3830,
5253,
10812,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 180,
    Value = 
new System.Int16[3]
{
19165,
18314,
4560,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 156,
    Value = 
new System.Int16[3]
{
13527,
18269,
2805,
},
    NullableValue = 
new System.Int16[3]
{
7552,
32403,
3115,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 189,
    Value = 
new System.Int16[4]
{
19342,
8732,
12353,
25858,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 160,
    Value = 
new System.Int16[3]
{
7668,
14476,
16796,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
30481,
11697,
13498,
},
},
            new Int16MArrayD1E1M
{
    Id = 190,
    Value = 
new System.Int16[4]
{
26706,
2127,
11824,
2843,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 168,
    Value = 
new System.Int16[3]
{
5189,
5505,
1586,
},
    NullableValue = 
new System.Int16[3]
{
31055,
26241,
8187,
},
},
    NullableValue = 
new System.Int16[3]
{
31054,
11563,
19144,
},
},
            new Int16MArrayD1E1M
{
    Id = 193,
    Value = 
new System.Int16[3]
{
10809,
25774,
29775,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 172,
    Value = 
new System.Int16[4]
{
7171,
11294,
26155,
16523,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
28165,
5180,
31453,
22928,
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


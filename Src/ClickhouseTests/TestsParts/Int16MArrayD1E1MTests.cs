

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
new System.Int16[4]
{
12986,
3680,
29778,
7996,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Int16[3]
{
9612,
29383,
16899,
},
    NullableValue = 
new System.Int16[3]
{
20756,
3523,
7425,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int16[4]
{
2703,
30824,
1522,
5745,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Int16[3]
{
8516,
9878,
31704,
},
    NullableValue = 
new System.Int16[4]
{
23385,
26689,
29737,
5857,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 13,
    Value = 
new System.Int16[4]
{
22128,
26149,
30690,
13556,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Int16[3]
{
25002,
22486,
13470,
},
    NullableValue = 
new System.Int16[4]
{
21766,
16726,
3640,
5016,
},
},
    NullableValue = 
new System.Int16[4]
{
9256,
22774,
5949,
25387,
},
},
            new Int16MArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int16[3]
{
10963,
5785,
7075,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Int16[3]
{
2471,
20883,
7523,
},
    NullableValue = 
new System.Int16[4]
{
9474,
59,
20328,
15420,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int16[4]
{
23653,
2296,
20710,
18071,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Int16[3]
{
19213,
28744,
2125,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
14395,
8311,
20777,
12473,
},
},
            new Int16MArrayD1E1M
{
    Id = 29,
    Value = 
new System.Int16[3]
{
21758,
17906,
32468,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int16[3]
{
23231,
644,
24472,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
9774,
18343,
17420,
},
},
            new Int16MArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int16[3]
{
14004,
27941,
20036,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int16[4]
{
12824,
23128,
20573,
5758,
},
    NullableValue = 
new System.Int16[3]
{
26982,
15419,
12859,
},
},
    NullableValue = 
new System.Int16[4]
{
29800,
28748,
15255,
7425,
},
},
            new Int16MArrayD1E1M
{
    Id = 34,
    Value = 
new System.Int16[4]
{
25955,
23401,
10201,
3242,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Int16[3]
{
10236,
20877,
889,
},
    NullableValue = 
new System.Int16[3]
{
23021,
19562,
6105,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int16[4]
{
16003,
32357,
23587,
30766,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Int16[3]
{
27700,
20383,
19428,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 43,
    Value = 
new System.Int16[3]
{
22231,
22630,
904,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Int16[4]
{
2830,
15469,
23940,
32235,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
4259,
5949,
20080,
},
},
            new Int16MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int16[3]
{
31640,
25798,
8465,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Int16[4]
{
31416,
9073,
19812,
7579,
},
    NullableValue = 
new System.Int16[3]
{
25788,
31391,
13684,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 50,
    Value = 
new System.Int16[3]
{
8359,
8934,
8338,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Int16[3]
{
6606,
607,
17022,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
21422,
242,
28349,
},
},
            new Int16MArrayD1E1M
{
    Id = 53,
    Value = 
new System.Int16[4]
{
2404,
8310,
1428,
15213,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Int16[3]
{
26916,
20212,
18059,
},
    NullableValue = 
new System.Int16[4]
{
28398,
15362,
14716,
24582,
},
},
    NullableValue = 
new System.Int16[4]
{
1732,
23285,
4549,
15434,
},
},
            new Int16MArrayD1E1M
{
    Id = 57,
    Value = 
new System.Int16[3]
{
30323,
24231,
26721,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Int16[4]
{
12834,
20188,
27555,
3793,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
17702,
11112,
12927,
18376,
},
},
            new Int16MArrayD1E1M
{
    Id = 65,
    Value = 
new System.Int16[3]
{
17720,
39,
12936,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Int16[3]
{
18041,
16237,
2634,
},
    NullableValue = 
new System.Int16[3]
{
5556,
6442,
26802,
},
},
    NullableValue = 
new System.Int16[4]
{
17195,
9591,
2055,
14391,
},
},
            new Int16MArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int16[3]
{
13157,
25864,
28895,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Int16[4]
{
7802,
1647,
32422,
28586,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 78,
    Value = 
new System.Int16[4]
{
28086,
28399,
12185,
27268,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Int16[4]
{
29510,
4765,
10849,
20164,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 84,
    Value = 
new System.Int16[3]
{
16876,
23301,
15340,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Int16[4]
{
18678,
6362,
27370,
535,
},
    NullableValue = 
new System.Int16[3]
{
17032,
12450,
7525,
},
},
    NullableValue = 
new System.Int16[3]
{
9373,
18989,
15985,
},
},
            new Int16MArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int16[4]
{
31286,
8943,
15612,
24471,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Int16[4]
{
17163,
4258,
425,
12607,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
30450,
31012,
13972,
27246,
},
},
            new Int16MArrayD1E1M
{
    Id = 97,
    Value = 
new System.Int16[3]
{
15089,
15814,
24194,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Int16[4]
{
22709,
15738,
22493,
17910,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
13430,
9256,
27322,
},
},
            new Int16MArrayD1E1M
{
    Id = 101,
    Value = 
new System.Int16[4]
{
24967,
15856,
17412,
20683,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Int16[3]
{
11455,
6341,
18020,
},
    NullableValue = 
new System.Int16[3]
{
7305,
7029,
9521,
},
},
    NullableValue = 
new System.Int16[4]
{
30117,
14348,
3673,
2111,
},
},
            new Int16MArrayD1E1M
{
    Id = 108,
    Value = 
new System.Int16[3]
{
20238,
6119,
25114,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Int16[3]
{
25982,
31402,
13886,
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
4538,
20536,
20478,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Int16[4]
{
24593,
5940,
3531,
24663,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 115,
    Value = 
new System.Int16[4]
{
16241,
17843,
18131,
7820,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 105,
    Value = 
new System.Int16[4]
{
24673,
22272,
24310,
27725,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
10185,
24379,
11999,
10554,
},
},
            new Int16MArrayD1E1M
{
    Id = 122,
    Value = 
new System.Int16[4]
{
6805,
22536,
5797,
6219,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Int16[4]
{
9190,
18490,
17721,
4724,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 130,
    Value = 
new System.Int16[3]
{
19005,
11084,
18705,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Int16[3]
{
2452,
2217,
22304,
},
    NullableValue = 
new System.Int16[3]
{
9828,
30118,
3279,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 139,
    Value = 
new System.Int16[4]
{
21113,
10514,
17506,
30936,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Int16[4]
{
2879,
23306,
22903,
25512,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
59,
21906,
4507,
20388,
},
},
            new Int16MArrayD1E1M
{
    Id = 140,
    Value = 
new System.Int16[4]
{
3286,
3614,
28611,
8920,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 131,
    Value = 
new System.Int16[4]
{
2923,
11521,
3259,
25976,
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
30862,
1865,
1301,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Int16[3]
{
21091,
5851,
8683,
},
    NullableValue = 
new System.Int16[4]
{
11078,
3296,
30727,
7073,
},
},
    NullableValue = 
new System.Int16[4]
{
20687,
27857,
14460,
20437,
},
},
            new Int16MArrayD1E1M
{
    Id = 144,
    Value = 
new System.Int16[3]
{
9395,
27129,
25173,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Int16[3]
{
20278,
12325,
27412,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
25205,
12932,
12063,
29002,
},
},
            new Int16MArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int16[3]
{
28860,
544,
22760,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 148,
    Value = 
new System.Int16[3]
{
3162,
7009,
31622,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
26263,
6249,
23291,
29729,
},
},
            new Int16MArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int16[3]
{
3102,
26432,
18322,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Int16[3]
{
11585,
22874,
27612,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 157,
    Value = 
new System.Int16[3]
{
19834,
31828,
2622,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Int16[4]
{
282,
21709,
5618,
15659,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 159,
    Value = 
new System.Int16[3]
{
8158,
17244,
23785,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Int16[3]
{
1481,
29757,
19513,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 167,
    Value = 
new System.Int16[3]
{
21763,
11191,
25792,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 177,
    Value = 
new System.Int16[4]
{
12656,
322,
4075,
12218,
},
    NullableValue = 
new System.Int16[3]
{
18361,
18418,
5778,
},
},
    NullableValue = 
new System.Int16[4]
{
14573,
12973,
949,
17921,
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


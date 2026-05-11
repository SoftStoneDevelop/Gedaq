

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
    Id = 5,
    Value = 
new System.UInt16[4]
{
40823,
7512,
38489,
24075,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 2,
    Value = 
new System.UInt16[3]
{
48349,
23821,
55131,
},
    NullableValue = 
new System.UInt16[3]
{
61799,
59112,
29960,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 14,
    Value = 
new System.UInt16[3]
{
31070,
40807,
63600,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.UInt16[4]
{
30009,
11251,
41596,
49338,
},
    NullableValue = 
new System.UInt16[3]
{
3881,
10091,
25496,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 23,
    Value = 
new System.UInt16[3]
{
40733,
52507,
32474,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.UInt16[4]
{
37125,
9802,
21752,
37862,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 28,
    Value = 
new System.UInt16[4]
{
26971,
1427,
14054,
9421,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.UInt16[4]
{
30821,
48817,
43795,
5972,
},
    NullableValue = 
new System.UInt16[3]
{
41224,
41163,
23501,
},
},
    NullableValue = 
new System.UInt16[3]
{
8057,
5149,
12228,
},
},
            new UInt16MArrayD1E1M
{
    Id = 34,
    Value = 
new System.UInt16[4]
{
37890,
47257,
9167,
43567,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 23,
    Value = 
new System.UInt16[3]
{
10487,
54594,
25941,
},
    NullableValue = 
new System.UInt16[3]
{
26475,
21588,
65086,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 39,
    Value = 
new System.UInt16[3]
{
52392,
4588,
54883,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.UInt16[3]
{
54089,
62596,
16114,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 47,
    Value = 
new System.UInt16[4]
{
11625,
42654,
41451,
3050,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.UInt16[4]
{
44522,
63077,
3324,
19446,
},
    NullableValue = 
new System.UInt16[3]
{
27944,
14143,
28268,
},
},
    NullableValue = 
new System.UInt16[3]
{
20073,
12436,
52928,
},
},
            new UInt16MArrayD1E1M
{
    Id = 56,
    Value = 
new System.UInt16[4]
{
32220,
45722,
8274,
4159,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.UInt16[3]
{
38200,
38588,
41659,
},
    NullableValue = 
new System.UInt16[4]
{
58503,
13826,
13546,
1171,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 64,
    Value = 
new System.UInt16[3]
{
9025,
52492,
22828,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.UInt16[4]
{
58649,
55190,
13509,
38367,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 67,
    Value = 
new System.UInt16[3]
{
25611,
1652,
33302,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt16[4]
{
24758,
25783,
53980,
46059,
},
    NullableValue = 
new System.UInt16[4]
{
6002,
25110,
18785,
27827,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 72,
    Value = 
new System.UInt16[3]
{
28862,
45180,
26291,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 48,
    Value = 
new System.UInt16[4]
{
51755,
15576,
56984,
13814,
},
    NullableValue = 
new System.UInt16[4]
{
45606,
36678,
31794,
51410,
},
},
    NullableValue = 
new System.UInt16[3]
{
14208,
7058,
34334,
},
},
            new UInt16MArrayD1E1M
{
    Id = 81,
    Value = 
new System.UInt16[4]
{
55291,
46659,
29305,
51682,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.UInt16[4]
{
32734,
57287,
21504,
57533,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
36442,
59173,
47225,
25731,
},
},
            new UInt16MArrayD1E1M
{
    Id = 86,
    Value = 
new System.UInt16[4]
{
30989,
28726,
17042,
56170,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 56,
    Value = 
new System.UInt16[3]
{
8972,
57795,
31861,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
18761,
58160,
34351,
307,
},
},
            new UInt16MArrayD1E1M
{
    Id = 88,
    Value = 
new System.UInt16[4]
{
61725,
63124,
5361,
11377,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.UInt16[4]
{
38087,
32354,
6595,
46997,
},
    NullableValue = 
new System.UInt16[4]
{
733,
13328,
46073,
35654,
},
},
    NullableValue = 
new System.UInt16[3]
{
22659,
21849,
18379,
},
},
            new UInt16MArrayD1E1M
{
    Id = 96,
    Value = 
new System.UInt16[4]
{
55853,
47366,
58869,
37040,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 72,
    Value = 
new System.UInt16[4]
{
30902,
20250,
43901,
9531,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 105,
    Value = 
new System.UInt16[4]
{
18967,
11752,
62870,
63431,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.UInt16[4]
{
12251,
44712,
29533,
58728,
},
    NullableValue = 
new System.UInt16[4]
{
34011,
5737,
24351,
57356,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 110,
    Value = 
new System.UInt16[4]
{
32150,
34719,
25618,
22109,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.UInt16[4]
{
10701,
48237,
54684,
27831,
},
    NullableValue = 
new System.UInt16[4]
{
5418,
14892,
46153,
30190,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 111,
    Value = 
new System.UInt16[3]
{
32941,
59795,
56316,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.UInt16[4]
{
2527,
44791,
60245,
44130,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 116,
    Value = 
new System.UInt16[4]
{
48719,
17621,
26797,
54158,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 85,
    Value = 
new System.UInt16[4]
{
25756,
17682,
19286,
19306,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 117,
    Value = 
new System.UInt16[4]
{
25889,
42969,
20037,
30795,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 87,
    Value = 
new System.UInt16[3]
{
29039,
11951,
64210,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
17504,
36400,
23214,
},
},
            new UInt16MArrayD1E1M
{
    Id = 122,
    Value = 
new System.UInt16[3]
{
38783,
35031,
25945,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.UInt16[4]
{
3381,
16108,
1035,
2261,
},
    NullableValue = 
new System.UInt16[4]
{
6762,
32439,
52365,
36271,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 125,
    Value = 
new System.UInt16[3]
{
26106,
20688,
63019,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.UInt16[4]
{
29343,
18865,
1335,
10331,
},
    NullableValue = 
new System.UInt16[3]
{
19681,
59081,
715,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 133,
    Value = 
new System.UInt16[3]
{
384,
36814,
26673,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 101,
    Value = 
new System.UInt16[3]
{
18274,
3093,
39988,
},
    NullableValue = 
new System.UInt16[4]
{
53511,
10699,
48391,
47899,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 139,
    Value = 
new System.UInt16[3]
{
32088,
44766,
18025,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.UInt16[3]
{
27689,
24740,
8509,
},
    NullableValue = 
new System.UInt16[4]
{
59757,
42213,
64783,
12943,
},
},
    NullableValue = 
new System.UInt16[3]
{
18560,
12903,
47739,
},
},
            new UInt16MArrayD1E1M
{
    Id = 143,
    Value = 
new System.UInt16[4]
{
17323,
54585,
23014,
62492,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.UInt16[3]
{
65238,
43803,
30020,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
39706,
52785,
2606,
63918,
},
},
            new UInt16MArrayD1E1M
{
    Id = 148,
    Value = 
new System.UInt16[3]
{
40616,
62251,
10524,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 113,
    Value = 
new System.UInt16[4]
{
29488,
27793,
64334,
24974,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 151,
    Value = 
new System.UInt16[3]
{
60026,
39312,
23387,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 119,
    Value = 
new System.UInt16[3]
{
24336,
24915,
51346,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt16[3]
{
60869,
62126,
1054,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.UInt16[4]
{
41701,
39913,
48172,
44880,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 159,
    Value = 
new System.UInt16[4]
{
41525,
17611,
54903,
30505,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.UInt16[3]
{
58521,
60432,
30704,
},
    NullableValue = 
new System.UInt16[3]
{
49294,
27295,
27965,
},
},
    NullableValue = 
new System.UInt16[4]
{
4381,
55626,
60734,
59076,
},
},
            new UInt16MArrayD1E1M
{
    Id = 166,
    Value = 
new System.UInt16[3]
{
54817,
43351,
60274,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.UInt16[4]
{
48686,
50350,
8539,
6367,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 171,
    Value = 
new System.UInt16[3]
{
5550,
61481,
61521,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.UInt16[4]
{
31928,
7020,
28387,
9516,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
20651,
46776,
47986,
12655,
},
},
            new UInt16MArrayD1E1M
{
    Id = 178,
    Value = 
new System.UInt16[4]
{
47169,
25602,
58633,
43881,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 152,
    Value = 
new System.UInt16[4]
{
13713,
58476,
40592,
21544,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 183,
    Value = 
new System.UInt16[3]
{
39819,
62260,
39138,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.UInt16[4]
{
60531,
56247,
40578,
41472,
},
    NullableValue = 
new System.UInt16[3]
{
33638,
65308,
31891,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 187,
    Value = 
new System.UInt16[4]
{
48353,
18591,
2562,
27772,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.UInt16[4]
{
15339,
43400,
53277,
61648,
},
    NullableValue = 
new System.UInt16[4]
{
48671,
40856,
46707,
54078,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 193,
    Value = 
new System.UInt16[4]
{
19239,
44369,
7429,
12097,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 159,
    Value = 
new System.UInt16[3]
{
34132,
22692,
12805,
},
    NullableValue = 
new System.UInt16[3]
{
61412,
25835,
22780,
},
},
    NullableValue = 
new System.UInt16[3]
{
25328,
3830,
48236,
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


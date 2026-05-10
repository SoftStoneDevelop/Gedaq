

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
    internal partial interface IUInt16ArrayUInt16Array
    {
    }
    
    internal partial class UInt16ArrayUInt16Array : IUInt16ArrayUInt16Array
    {


#region TestData

        private readonly UInt16UInt16Array1M[] _testData = new UInt16UInt16Array1M[]
        {
            new UInt16UInt16Array1M
{
    Id = 9,
    Value = 
new System.UInt16[3]
{
1358,
18021,
57015,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 8,
    Value = 
new System.UInt16[3]
{
59002,
53331,
10572,
},
    NullableValue = 
new System.UInt16[4]
{
49522,
39637,
51084,
20496,
},
},
    NullableValue = 
new System.UInt16[4]
{
21891,
52577,
7126,
19387,
},
},
            new UInt16UInt16Array1M
{
    Id = 10,
    Value = 
new System.UInt16[4]
{
49536,
62151,
2908,
25519,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 10,
    Value = 
new System.UInt16[4]
{
21276,
29536,
12148,
843,
},
    NullableValue = 
new System.UInt16[4]
{
30304,
53144,
60398,
38017,
},
},
    NullableValue = 
new System.UInt16[3]
{
38416,
12516,
11636,
},
},
            new UInt16UInt16Array1M
{
    Id = 18,
    Value = 
new System.UInt16[3]
{
41147,
57345,
51118,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 12,
    Value = 
new System.UInt16[4]
{
43109,
50631,
46719,
1149,
},
    NullableValue = 
new System.UInt16[4]
{
41550,
64741,
1806,
21378,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 24,
    Value = 
new System.UInt16[3]
{
33247,
17730,
25594,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 15,
    Value = 
new System.UInt16[3]
{
4179,
22745,
53021,
},
    NullableValue = 
new System.UInt16[4]
{
42837,
24893,
4884,
39724,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 30,
    Value = 
new System.UInt16[3]
{
58486,
59789,
57575,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 23,
    Value = 
new System.UInt16[3]
{
62868,
3628,
43432,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
7215,
31561,
17995,
3579,
},
},
            new UInt16UInt16Array1M
{
    Id = 39,
    Value = 
new System.UInt16[4]
{
58681,
11297,
20044,
18730,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 30,
    Value = 
new System.UInt16[4]
{
51929,
9984,
11238,
60946,
},
    NullableValue = 
new System.UInt16[4]
{
53306,
8421,
52615,
16367,
},
},
    NullableValue = 
new System.UInt16[3]
{
13454,
50286,
14927,
},
},
            new UInt16UInt16Array1M
{
    Id = 41,
    Value = 
new System.UInt16[3]
{
31102,
62007,
18852,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 36,
    Value = 
new System.UInt16[4]
{
1426,
52143,
31401,
64346,
},
    NullableValue = 
new System.UInt16[3]
{
9983,
11702,
14879,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 45,
    Value = 
new System.UInt16[4]
{
895,
59081,
32767,
38167,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 42,
    Value = 
new System.UInt16[3]
{
14421,
31230,
29021,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 53,
    Value = 
new System.UInt16[3]
{
536,
3848,
60897,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 49,
    Value = 
new System.UInt16[3]
{
22798,
61932,
7568,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
4658,
59629,
14836,
37566,
},
},
            new UInt16UInt16Array1M
{
    Id = 54,
    Value = 
new System.UInt16[3]
{
36792,
63261,
18865,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 56,
    Value = 
new System.UInt16[3]
{
13991,
58944,
61063,
},
    NullableValue = 
new System.UInt16[4]
{
34715,
15033,
26377,
1023,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 55,
    Value = 
new System.UInt16[4]
{
14697,
3362,
57636,
14759,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 64,
    Value = 
new System.UInt16[4]
{
52263,
7489,
1866,
2808,
},
    NullableValue = 
new System.UInt16[3]
{
29326,
31329,
64822,
},
},
    NullableValue = 
new System.UInt16[3]
{
44977,
48000,
44052,
},
},
            new UInt16UInt16Array1M
{
    Id = 58,
    Value = 
new System.UInt16[3]
{
57231,
22360,
4552,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 66,
    Value = 
new System.UInt16[3]
{
53054,
54131,
50870,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 59,
    Value = 
new System.UInt16[3]
{
57795,
55093,
49753,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 67,
    Value = 
new System.UInt16[3]
{
64448,
58160,
47567,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
64801,
12400,
49194,
},
},
            new UInt16UInt16Array1M
{
    Id = 65,
    Value = 
new System.UInt16[4]
{
49317,
40059,
275,
38480,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 71,
    Value = 
new System.UInt16[4]
{
42685,
1389,
11084,
32200,
},
    NullableValue = 
new System.UInt16[3]
{
33568,
47605,
53265,
},
},
    NullableValue = 
new System.UInt16[4]
{
53883,
3257,
37448,
5479,
},
},
            new UInt16UInt16Array1M
{
    Id = 66,
    Value = 
new System.UInt16[3]
{
30348,
28762,
57711,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 77,
    Value = 
new System.UInt16[4]
{
9535,
11171,
7858,
38494,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 75,
    Value = 
new System.UInt16[4]
{
64430,
14288,
34387,
522,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 81,
    Value = 
new System.UInt16[4]
{
56929,
57358,
18944,
64080,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
44894,
54978,
18186,
},
},
            new UInt16UInt16Array1M
{
    Id = 77,
    Value = 
new System.UInt16[3]
{
40019,
6010,
55071,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 85,
    Value = 
new System.UInt16[4]
{
48253,
48644,
23845,
16544,
},
    NullableValue = 
new System.UInt16[3]
{
33664,
48175,
1407,
},
},
    NullableValue = 
new System.UInt16[4]
{
7038,
23567,
14095,
5631,
},
},
            new UInt16UInt16Array1M
{
    Id = 79,
    Value = 
new System.UInt16[4]
{
49514,
40021,
17190,
63245,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 91,
    Value = 
new System.UInt16[3]
{
40505,
35712,
17917,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 82,
    Value = 
new System.UInt16[4]
{
48325,
58659,
6613,
2186,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 97,
    Value = 
new System.UInt16[3]
{
60802,
59113,
16749,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 83,
    Value = 
new System.UInt16[3]
{
53741,
193,
6335,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 99,
    Value = 
new System.UInt16[3]
{
21677,
28452,
57218,
},
    NullableValue = 
new System.UInt16[4]
{
31815,
42334,
2113,
39023,
},
},
    NullableValue = 
new System.UInt16[3]
{
3708,
41503,
2220,
},
},
            new UInt16UInt16Array1M
{
    Id = 84,
    Value = 
new System.UInt16[3]
{
37553,
11660,
3916,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 102,
    Value = 
new System.UInt16[4]
{
1860,
10329,
22107,
43527,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 85,
    Value = 
new System.UInt16[3]
{
39425,
65501,
15707,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 107,
    Value = 
new System.UInt16[4]
{
29385,
46907,
41031,
48171,
},
    NullableValue = 
new System.UInt16[4]
{
34943,
1501,
10926,
46173,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 89,
    Value = 
new System.UInt16[3]
{
45146,
9511,
16417,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 112,
    Value = 
new System.UInt16[3]
{
40566,
35814,
36571,
},
    NullableValue = 
new System.UInt16[4]
{
34179,
26944,
4171,
31354,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 92,
    Value = 
new System.UInt16[3]
{
61718,
5606,
49912,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 120,
    Value = 
new System.UInt16[4]
{
45814,
6515,
27442,
2597,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
54119,
11053,
33424,
},
},
            new UInt16UInt16Array1M
{
    Id = 101,
    Value = 
new System.UInt16[4]
{
9012,
17249,
57671,
49095,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 128,
    Value = 
new System.UInt16[4]
{
50806,
38743,
4408,
60273,
},
    NullableValue = 
new System.UInt16[4]
{
41113,
50117,
1331,
23693,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 110,
    Value = 
new System.UInt16[4]
{
50264,
32428,
56148,
20423,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 130,
    Value = 
new System.UInt16[3]
{
54847,
46932,
4731,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
44803,
16091,
54435,
30625,
},
},
            new UInt16UInt16Array1M
{
    Id = 112,
    Value = 
new System.UInt16[3]
{
49611,
34918,
3121,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 131,
    Value = 
new System.UInt16[4]
{
16217,
40794,
15335,
64078,
},
    NullableValue = 
new System.UInt16[3]
{
35454,
23024,
8962,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 119,
    Value = 
new System.UInt16[4]
{
12801,
34121,
9146,
12852,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 133,
    Value = 
new System.UInt16[4]
{
14718,
59036,
62855,
24736,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 128,
    Value = 
new System.UInt16[4]
{
3611,
59195,
14638,
36612,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 142,
    Value = 
new System.UInt16[4]
{
44538,
31888,
6093,
1292,
},
    NullableValue = 
new System.UInt16[4]
{
59362,
42535,
36578,
7705,
},
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 137,
    Value = 
new System.UInt16[3]
{
867,
21529,
55490,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 147,
    Value = 
new System.UInt16[4]
{
61424,
63213,
53121,
48479,
},
    NullableValue = 
new System.UInt16[4]
{
12560,
50219,
45958,
60023,
},
},
    NullableValue = 
new System.UInt16[4]
{
11185,
8764,
55726,
21372,
},
},
            new UInt16UInt16Array1M
{
    Id = 139,
    Value = 
new System.UInt16[4]
{
16670,
48721,
55749,
63979,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 152,
    Value = 
new System.UInt16[3]
{
44691,
2507,
15655,
},
    NullableValue = 
new System.UInt16[3]
{
5927,
22644,
48043,
},
},
    NullableValue = 
new System.UInt16[3]
{
38024,
47122,
32893,
},
},
            new UInt16UInt16Array1M
{
    Id = 142,
    Value = 
new System.UInt16[3]
{
58139,
52417,
5806,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 155,
    Value = 
new System.UInt16[3]
{
28169,
16158,
17615,
},
    NullableValue = 
new System.UInt16[4]
{
12583,
44896,
40339,
58356,
},
},
    NullableValue = 
new System.UInt16[3]
{
23524,
27554,
63611,
},
},
            new UInt16UInt16Array1M
{
    Id = 150,
    Value = 
new System.UInt16[4]
{
26267,
21483,
18544,
40853,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 161,
    Value = 
new System.UInt16[3]
{
48468,
9936,
8152,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
60868,
38321,
51014,
26564,
},
},
            new UInt16UInt16Array1M
{
    Id = 154,
    Value = 
new System.UInt16[4]
{
45294,
19844,
6346,
5627,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 162,
    Value = 
new System.UInt16[3]
{
37597,
14044,
55708,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16Array1M
{
    Id = 163,
    Value = 
new System.UInt16[4]
{
58770,
32978,
37043,
17776,
},
    ModelInner = new UInt16UInt16Array1MI
{
    Id = 169,
    Value = 
new System.UInt16[3]
{
49965,
28708,
53813,
},
    NullableValue = 
new System.UInt16[4]
{
40544,
27470,
3245,
48024,
},
},
    NullableValue = 
new System.UInt16[3]
{
10127,
26201,
1648,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16uint16array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt16[]}, 
    {mi_id:Int32},
    {mi_value:UInt16[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16ArrayUInt16Array)),
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
                    await ((IUInt16ArrayUInt16Array)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16ArrayUInt16Array)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16uint16array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16UInt16Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16ArrayUInt16Array)),
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
                    var models = await ((IUInt16ArrayUInt16Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt16Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16ArrayUInt16Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt16Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


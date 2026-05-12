

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
    Id = 4,
    Value = 
new System.UInt16[3]
{
15279,
10395,
14794,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.UInt16[4]
{
10708,
52356,
7489,
41031,
},
    NullableValue = 
new System.UInt16[4]
{
30356,
58014,
50226,
46833,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 12,
    Value = 
new System.UInt16[3]
{
5735,
33116,
1528,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.UInt16[3]
{
8948,
62897,
37782,
},
    NullableValue = 
new System.UInt16[3]
{
8044,
34499,
52664,
},
},
    NullableValue = 
new System.UInt16[4]
{
13671,
14169,
1754,
45533,
},
},
            new UInt16MArrayD1E1M
{
    Id = 18,
    Value = 
new System.UInt16[3]
{
39728,
18167,
16268,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.UInt16[3]
{
53097,
21664,
51357,
},
    NullableValue = 
new System.UInt16[3]
{
16756,
23591,
7111,
},
},
    NullableValue = 
new System.UInt16[4]
{
29573,
52932,
53385,
13993,
},
},
            new UInt16MArrayD1E1M
{
    Id = 23,
    Value = 
new System.UInt16[4]
{
13632,
32702,
13976,
1909,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.UInt16[4]
{
1409,
56172,
58415,
2426,
},
    NullableValue = 
new System.UInt16[4]
{
10686,
38376,
64949,
60389,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 25,
    Value = 
new System.UInt16[3]
{
47613,
9615,
53603,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 25,
    Value = 
new System.UInt16[3]
{
2417,
55164,
62182,
},
    NullableValue = 
new System.UInt16[4]
{
50641,
24783,
59145,
44937,
},
},
    NullableValue = 
new System.UInt16[4]
{
31084,
48455,
62033,
6816,
},
},
            new UInt16MArrayD1E1M
{
    Id = 30,
    Value = 
new System.UInt16[4]
{
19373,
38338,
42906,
43449,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.UInt16[4]
{
14804,
62781,
60307,
33519,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 37,
    Value = 
new System.UInt16[4]
{
12074,
1325,
32390,
32412,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.UInt16[3]
{
33085,
61525,
36725,
},
    NullableValue = 
new System.UInt16[4]
{
58784,
1164,
8203,
20878,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 42,
    Value = 
new System.UInt16[4]
{
31938,
45228,
34655,
13417,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.UInt16[4]
{
9314,
35761,
16351,
18716,
},
    NullableValue = 
new System.UInt16[3]
{
8328,
14804,
61973,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 44,
    Value = 
new System.UInt16[3]
{
50216,
24274,
50131,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt16[4]
{
136,
61050,
40887,
61856,
},
    NullableValue = 
new System.UInt16[3]
{
56865,
9873,
40188,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 51,
    Value = 
new System.UInt16[4]
{
52751,
49473,
2795,
5967,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt16[3]
{
30530,
56378,
43761,
},
    NullableValue = 
new System.UInt16[4]
{
55901,
34084,
34657,
18537,
},
},
    NullableValue = 
new System.UInt16[3]
{
11484,
9271,
34296,
},
},
            new UInt16MArrayD1E1M
{
    Id = 58,
    Value = 
new System.UInt16[3]
{
17721,
25811,
46763,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.UInt16[3]
{
5613,
36217,
56677,
},
    NullableValue = 
new System.UInt16[3]
{
38970,
61461,
57560,
},
},
    NullableValue = 
new System.UInt16[3]
{
31663,
44755,
51673,
},
},
            new UInt16MArrayD1E1M
{
    Id = 64,
    Value = 
new System.UInt16[4]
{
27577,
9770,
37843,
6413,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.UInt16[4]
{
43834,
47813,
8945,
53050,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 71,
    Value = 
new System.UInt16[3]
{
15301,
56065,
52227,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.UInt16[4]
{
50600,
60837,
21221,
57696,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 79,
    Value = 
new System.UInt16[3]
{
2522,
65124,
17780,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 73,
    Value = 
new System.UInt16[3]
{
65312,
48592,
64422,
},
    NullableValue = 
new System.UInt16[4]
{
30660,
13858,
29225,
26578,
},
},
    NullableValue = 
new System.UInt16[3]
{
56425,
52981,
26115,
},
},
            new UInt16MArrayD1E1M
{
    Id = 82,
    Value = 
new System.UInt16[3]
{
10895,
51965,
57608,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.UInt16[4]
{
48690,
31985,
46184,
51964,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
24089,
30525,
49259,
},
},
            new UInt16MArrayD1E1M
{
    Id = 86,
    Value = 
new System.UInt16[4]
{
36124,
5035,
61360,
14464,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.UInt16[4]
{
4301,
11512,
38110,
34451,
},
    NullableValue = 
new System.UInt16[3]
{
49443,
27589,
51629,
},
},
    NullableValue = 
new System.UInt16[4]
{
58277,
39163,
26247,
55991,
},
},
            new UInt16MArrayD1E1M
{
    Id = 94,
    Value = 
new System.UInt16[3]
{
49397,
14763,
27277,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 90,
    Value = 
new System.UInt16[3]
{
7552,
41471,
62710,
},
    NullableValue = 
new System.UInt16[3]
{
49348,
43280,
57572,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 99,
    Value = 
new System.UInt16[3]
{
23222,
22949,
24615,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.UInt16[3]
{
62320,
58614,
46454,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
38327,
14638,
2364,
10682,
},
},
            new UInt16MArrayD1E1M
{
    Id = 102,
    Value = 
new System.UInt16[3]
{
32360,
61952,
30579,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 101,
    Value = 
new System.UInt16[4]
{
3716,
4719,
30589,
37325,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 107,
    Value = 
new System.UInt16[4]
{
11626,
29763,
61796,
44886,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.UInt16[4]
{
26808,
47934,
51615,
49375,
},
    NullableValue = 
new System.UInt16[3]
{
2924,
36039,
7960,
},
},
    NullableValue = 
new System.UInt16[4]
{
12007,
4518,
61693,
62020,
},
},
            new UInt16MArrayD1E1M
{
    Id = 112,
    Value = 
new System.UInt16[3]
{
44768,
55642,
254,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 116,
    Value = 
new System.UInt16[3]
{
40606,
1781,
17627,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 121,
    Value = 
new System.UInt16[3]
{
63052,
38877,
11928,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.UInt16[3]
{
56391,
24548,
2908,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
13143,
37606,
31791,
13893,
},
},
            new UInt16MArrayD1E1M
{
    Id = 127,
    Value = 
new System.UInt16[3]
{
2924,
4401,
20664,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 126,
    Value = 
new System.UInt16[3]
{
45947,
14639,
18381,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
11733,
21770,
15490,
},
},
            new UInt16MArrayD1E1M
{
    Id = 133,
    Value = 
new System.UInt16[3]
{
31371,
56594,
49288,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.UInt16[3]
{
12231,
33665,
11298,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
716,
60962,
50800,
6555,
},
},
            new UInt16MArrayD1E1M
{
    Id = 135,
    Value = 
new System.UInt16[3]
{
34403,
46553,
39180,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.UInt16[3]
{
24890,
57158,
44600,
},
    NullableValue = 
new System.UInt16[3]
{
51642,
13764,
10529,
},
},
    NullableValue = 
new System.UInt16[4]
{
39782,
43311,
22856,
60455,
},
},
            new UInt16MArrayD1E1M
{
    Id = 141,
    Value = 
new System.UInt16[3]
{
43154,
45835,
64930,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 144,
    Value = 
new System.UInt16[3]
{
11237,
62780,
17205,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
37489,
428,
62112,
51940,
},
},
            new UInt16MArrayD1E1M
{
    Id = 144,
    Value = 
new System.UInt16[4]
{
60470,
8350,
57647,
56788,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.UInt16[4]
{
9591,
26804,
36483,
52321,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
63370,
21340,
37302,
2799,
},
},
            new UInt16MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt16[3]
{
31417,
6675,
57842,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 148,
    Value = 
new System.UInt16[3]
{
10101,
27519,
55219,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
32471,
26861,
13880,
},
},
            new UInt16MArrayD1E1M
{
    Id = 159,
    Value = 
new System.UInt16[4]
{
17682,
40948,
17441,
58316,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 151,
    Value = 
new System.UInt16[3]
{
24310,
15948,
40578,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
26493,
58718,
19472,
55591,
},
},
            new UInt16MArrayD1E1M
{
    Id = 163,
    Value = 
new System.UInt16[3]
{
24109,
62018,
58561,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.UInt16[3]
{
57347,
6322,
41457,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
57145,
4288,
62751,
},
},
            new UInt16MArrayD1E1M
{
    Id = 168,
    Value = 
new System.UInt16[4]
{
42045,
27742,
12628,
8560,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.UInt16[3]
{
24762,
24331,
836,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
64532,
19346,
54942,
22121,
},
},
            new UInt16MArrayD1E1M
{
    Id = 169,
    Value = 
new System.UInt16[3]
{
30865,
55262,
15234,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.UInt16[3]
{
61474,
38609,
24918,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
11815,
56370,
26864,
},
},
            new UInt16MArrayD1E1M
{
    Id = 170,
    Value = 
new System.UInt16[3]
{
54821,
14239,
53388,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.UInt16[3]
{
53149,
60653,
14108,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 176,
    Value = 
new System.UInt16[4]
{
13165,
59364,
25137,
61662,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 167,
    Value = 
new System.UInt16[4]
{
58143,
29730,
13622,
721,
},
    NullableValue = 
new System.UInt16[4]
{
2458,
14101,
42410,
24237,
},
},
    NullableValue = 
new System.UInt16[4]
{
35337,
7362,
44792,
19766,
},
},
            new UInt16MArrayD1E1M
{
    Id = 183,
    Value = 
new System.UInt16[4]
{
36638,
34623,
14582,
54418,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 172,
    Value = 
new System.UInt16[4]
{
57718,
4836,
26170,
46943,
},
    NullableValue = 
new System.UInt16[4]
{
10056,
1764,
34767,
63292,
},
},
    NullableValue = 
new System.UInt16[4]
{
22949,
12828,
3421,
11653,
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


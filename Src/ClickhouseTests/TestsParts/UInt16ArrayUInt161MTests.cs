

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
    internal partial interface IUInt16ArrayArrayUInt16
    {
    }
    
    internal partial class UInt16ArrayArrayUInt16 : IUInt16ArrayArrayUInt16
    {


#region TestData

        private readonly UInt16ArrayUInt161M[] _testData = new UInt16ArrayUInt161M[]
        {
            new UInt16ArrayUInt161M
{
    Id = 9,
    Value = 
new System.UInt16[3]
{
28588,
41856,
1286,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 1,
    Value = 
new System.UInt16[3]
{
26924,
53109,
63659,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 11,
    Value = 
new System.UInt16[3]
{
35290,
3062,
1161,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 2,
    Value = 
new System.UInt16[3]
{
7476,
13442,
34403,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 19,
    Value = 
new System.UInt16[4]
{
58813,
50216,
21336,
48553,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 7,
    Value = 
new System.UInt16[4]
{
30074,
47367,
41374,
42798,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
6498,
15863,
31673,
},
},
            new UInt16ArrayUInt161M
{
    Id = 26,
    Value = 
new System.UInt16[3]
{
60629,
32461,
35453,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 12,
    Value = 
new System.UInt16[4]
{
4258,
16994,
44541,
36355,
},
    NullableValue = 
new System.UInt16[4]
{
23616,
13345,
27687,
57726,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 34,
    Value = 
new System.UInt16[4]
{
45406,
22862,
17379,
40749,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 13,
    Value = 
new System.UInt16[4]
{
49314,
29816,
11104,
12834,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 37,
    Value = 
new System.UInt16[4]
{
52593,
41384,
30017,
43382,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 18,
    Value = 
new System.UInt16[3]
{
59654,
212,
59650,
},
    NullableValue = 
new System.UInt16[3]
{
13690,
64343,
35946,
},
},
    NullableValue = 
new System.UInt16[4]
{
45572,
7245,
4057,
39109,
},
},
            new UInt16ArrayUInt161M
{
    Id = 46,
    Value = 
new System.UInt16[3]
{
61930,
38251,
65307,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 23,
    Value = 
new System.UInt16[3]
{
28236,
53323,
58136,
},
    NullableValue = 
new System.UInt16[3]
{
24041,
23756,
49807,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 53,
    Value = 
new System.UInt16[3]
{
52915,
22621,
53598,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 32,
    Value = 
new System.UInt16[4]
{
38441,
61909,
9327,
12932,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 55,
    Value = 
new System.UInt16[4]
{
61564,
60942,
23976,
16584,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 33,
    Value = 
new System.UInt16[3]
{
32943,
43507,
44505,
},
    NullableValue = 
new System.UInt16[3]
{
40614,
60865,
18503,
},
},
    NullableValue = 
new System.UInt16[3]
{
42965,
61481,
19798,
},
},
            new UInt16ArrayUInt161M
{
    Id = 64,
    Value = 
new System.UInt16[4]
{
14127,
10294,
4949,
4486,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 34,
    Value = 
new System.UInt16[4]
{
32216,
36187,
49923,
19475,
},
    NullableValue = 
new System.UInt16[3]
{
20014,
52200,
2582,
},
},
    NullableValue = 
new System.UInt16[3]
{
61695,
13956,
32891,
},
},
            new UInt16ArrayUInt161M
{
    Id = 71,
    Value = 
new System.UInt16[4]
{
12639,
27264,
38995,
63923,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 42,
    Value = 
new System.UInt16[4]
{
27484,
41362,
16295,
27722,
},
    NullableValue = 
new System.UInt16[4]
{
13057,
32628,
42542,
8329,
},
},
    NullableValue = 
new System.UInt16[4]
{
32668,
55132,
38426,
58375,
},
},
            new UInt16ArrayUInt161M
{
    Id = 80,
    Value = 
new System.UInt16[4]
{
36265,
49132,
16373,
46488,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 51,
    Value = 
new System.UInt16[4]
{
57444,
41038,
24865,
61834,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
3433,
45740,
47154,
45976,
},
},
            new UInt16ArrayUInt161M
{
    Id = 87,
    Value = 
new System.UInt16[3]
{
63863,
27604,
53651,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 57,
    Value = 
new System.UInt16[3]
{
34896,
34059,
49465,
},
    NullableValue = 
new System.UInt16[4]
{
24424,
25180,
44252,
1277,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 92,
    Value = 
new System.UInt16[3]
{
7133,
28487,
39337,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 62,
    Value = 
new System.UInt16[3]
{
12469,
36434,
39138,
},
    NullableValue = 
new System.UInt16[4]
{
61922,
60511,
48394,
19784,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 101,
    Value = 
new System.UInt16[3]
{
29985,
31791,
58093,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 68,
    Value = 
new System.UInt16[3]
{
42002,
54211,
12724,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 109,
    Value = 
new System.UInt16[4]
{
40040,
53282,
36519,
21169,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 77,
    Value = 
new System.UInt16[3]
{
7165,
19837,
46106,
},
    NullableValue = 
new System.UInt16[4]
{
1173,
60432,
46554,
64772,
},
},
    NullableValue = 
new System.UInt16[4]
{
6958,
48542,
60390,
52321,
},
},
            new UInt16ArrayUInt161M
{
    Id = 115,
    Value = 
new System.UInt16[3]
{
40732,
48768,
46856,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 83,
    Value = 
new System.UInt16[4]
{
51066,
52508,
46669,
44715,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
28170,
10709,
5599,
59888,
},
},
            new UInt16ArrayUInt161M
{
    Id = 120,
    Value = 
new System.UInt16[3]
{
9990,
32492,
60204,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 86,
    Value = 
new System.UInt16[3]
{
59115,
3965,
46667,
},
    NullableValue = 
new System.UInt16[4]
{
11291,
53928,
8144,
42117,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 122,
    Value = 
new System.UInt16[3]
{
48503,
50618,
13767,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 94,
    Value = 
new System.UInt16[3]
{
51131,
51135,
40563,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
15742,
14449,
32324,
35249,
},
},
            new UInt16ArrayUInt161M
{
    Id = 125,
    Value = 
new System.UInt16[3]
{
23043,
48685,
23938,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 101,
    Value = 
new System.UInt16[3]
{
20976,
32953,
21861,
},
    NullableValue = 
new System.UInt16[3]
{
19552,
62061,
3123,
},
},
    NullableValue = 
new System.UInt16[3]
{
10317,
49189,
50983,
},
},
            new UInt16ArrayUInt161M
{
    Id = 132,
    Value = 
new System.UInt16[4]
{
22855,
47084,
47612,
39510,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 106,
    Value = 
new System.UInt16[3]
{
16933,
52679,
2373,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
53515,
14528,
28383,
4057,
},
},
            new UInt16ArrayUInt161M
{
    Id = 134,
    Value = 
new System.UInt16[3]
{
61215,
45770,
8200,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 114,
    Value = 
new System.UInt16[3]
{
290,
36990,
15882,
},
    NullableValue = 
new System.UInt16[4]
{
64826,
29351,
37624,
61924,
},
},
    NullableValue = 
new System.UInt16[3]
{
26782,
24117,
18014,
},
},
            new UInt16ArrayUInt161M
{
    Id = 143,
    Value = 
new System.UInt16[4]
{
14521,
51315,
38981,
25749,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 115,
    Value = 
new System.UInt16[3]
{
53866,
585,
17563,
},
    NullableValue = 
new System.UInt16[4]
{
11332,
1616,
53124,
64505,
},
},
    NullableValue = 
new System.UInt16[4]
{
58156,
4430,
12471,
26157,
},
},
            new UInt16ArrayUInt161M
{
    Id = 147,
    Value = 
new System.UInt16[3]
{
56275,
43910,
28607,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 121,
    Value = 
new System.UInt16[3]
{
49638,
50935,
62873,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
64919,
50154,
19424,
},
},
            new UInt16ArrayUInt161M
{
    Id = 149,
    Value = 
new System.UInt16[4]
{
20624,
18267,
39249,
35527,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 130,
    Value = 
new System.UInt16[4]
{
51327,
47598,
10149,
27424,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
34236,
25171,
40574,
},
},
            new UInt16ArrayUInt161M
{
    Id = 150,
    Value = 
new System.UInt16[4]
{
17772,
21594,
35706,
28681,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 139,
    Value = 
new System.UInt16[4]
{
2295,
64688,
18157,
62559,
},
    NullableValue = 
new System.UInt16[4]
{
14222,
36403,
27447,
46063,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 156,
    Value = 
new System.UInt16[3]
{
3917,
46807,
9431,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 142,
    Value = 
new System.UInt16[3]
{
9558,
30340,
3646,
},
    NullableValue = 
new System.UInt16[4]
{
14197,
21033,
15101,
19656,
},
},
    NullableValue = 
new System.UInt16[4]
{
52090,
27892,
58159,
18906,
},
},
            new UInt16ArrayUInt161M
{
    Id = 165,
    Value = 
new System.UInt16[4]
{
51315,
33467,
24324,
48473,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 147,
    Value = 
new System.UInt16[3]
{
49880,
21187,
43976,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
6215,
16528,
2848,
63616,
},
},
            new UInt16ArrayUInt161M
{
    Id = 173,
    Value = 
new System.UInt16[4]
{
7451,
49136,
30134,
30982,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 150,
    Value = 
new System.UInt16[4]
{
32451,
51329,
17279,
62634,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
17911,
22762,
31851,
7387,
},
},
            new UInt16ArrayUInt161M
{
    Id = 182,
    Value = 
new System.UInt16[3]
{
83,
37112,
61530,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 156,
    Value = 
new System.UInt16[4]
{
24403,
20288,
24663,
9160,
},
    NullableValue = 
new System.UInt16[3]
{
37372,
4599,
15346,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 183,
    Value = 
new System.UInt16[4]
{
55059,
36217,
26201,
35038,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 165,
    Value = 
new System.UInt16[4]
{
2570,
47248,
55038,
23172,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 191,
    Value = 
new System.UInt16[3]
{
14904,
38927,
32562,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 166,
    Value = 
new System.UInt16[4]
{
65173,
55786,
55923,
29706,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt161M
{
    Id = 194,
    Value = 
new System.UInt16[3]
{
15533,
13126,
1875,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 170,
    Value = 
new System.UInt16[3]
{
58850,
26796,
57578,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
39570,
29259,
5800,
},
},
            new UInt16ArrayUInt161M
{
    Id = 202,
    Value = 
new System.UInt16[3]
{
9705,
58138,
38305,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 176,
    Value = 
new System.UInt16[3]
{
42437,
55991,
38529,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
25190,
42564,
11503,
12346,
},
},
            new UInt16ArrayUInt161M
{
    Id = 208,
    Value = 
new System.UInt16[4]
{
62721,
56086,
11176,
3487,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 179,
    Value = 
new System.UInt16[4]
{
25295,
39044,
63801,
60091,
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
INSERT INTO gedaqtests.uint16arrayuint161m(
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
            asPartInterface: typeof(IUInt16ArrayArrayUInt16)),
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
                    await ((IUInt16ArrayArrayUInt16)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16ArrayArrayUInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16arrayuint161m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16ArrayUInt161M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16ArrayArrayUInt16)),
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
                    var models = await ((IUInt16ArrayArrayUInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16ArrayUInt161M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16ArrayArrayUInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16ArrayUInt161M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


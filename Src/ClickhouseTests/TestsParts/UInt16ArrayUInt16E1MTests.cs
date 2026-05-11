

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
    internal partial interface IUInt16MArrayArrayUInt16
    {
    }
    
    internal partial class UInt16MArrayArrayUInt16 : IUInt16MArrayArrayUInt16
    {


#region TestData

        private readonly UInt16ArrayUInt16E1M[] _testData = new UInt16ArrayUInt16E1M[]
        {
            new UInt16ArrayUInt16E1M
{
    Id = 5,
    Value = 
new System.UInt16[3]
{
49872,
35965,
5179,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 2,
    Value = 
new System.UInt16[3]
{
41243,
39963,
24483,
},
    NullableValue = 
new System.UInt16[3]
{
60832,
49963,
58587,
},
},
    NullableValue = 
new System.UInt16[3]
{
58861,
25421,
7706,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 13,
    Value = 
new System.UInt16[4]
{
10833,
29455,
4877,
27564,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 10,
    Value = 
new System.UInt16[4]
{
24431,
22164,
56495,
46265,
},
    NullableValue = 
new System.UInt16[3]
{
64298,
48730,
21722,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 21,
    Value = 
new System.UInt16[4]
{
13181,
10376,
57582,
2024,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 18,
    Value = 
new System.UInt16[4]
{
12291,
45862,
6454,
10320,
},
    NullableValue = 
new System.UInt16[4]
{
27201,
42871,
55305,
23521,
},
},
    NullableValue = 
new System.UInt16[3]
{
58456,
45918,
8825,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 26,
    Value = 
new System.UInt16[3]
{
61247,
16160,
9299,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 24,
    Value = 
new System.UInt16[4]
{
44444,
8515,
44576,
47587,
},
    NullableValue = 
new System.UInt16[3]
{
7607,
49720,
56092,
},
},
    NullableValue = 
new System.UInt16[4]
{
50784,
10755,
36832,
54402,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 32,
    Value = 
new System.UInt16[4]
{
35293,
28892,
42111,
25035,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 28,
    Value = 
new System.UInt16[3]
{
33616,
64650,
56431,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
41229,
9676,
12869,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 41,
    Value = 
new System.UInt16[3]
{
37134,
23348,
47901,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 31,
    Value = 
new System.UInt16[4]
{
31843,
65196,
37698,
3,
},
    NullableValue = 
new System.UInt16[4]
{
24748,
9744,
31051,
50221,
},
},
    NullableValue = 
new System.UInt16[3]
{
39737,
23600,
13012,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 46,
    Value = 
new System.UInt16[4]
{
25134,
28813,
10015,
7850,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 38,
    Value = 
new System.UInt16[4]
{
36622,
48472,
39359,
16288,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 51,
    Value = 
new System.UInt16[4]
{
12740,
29994,
60783,
33057,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 47,
    Value = 
new System.UInt16[4]
{
17372,
14885,
46671,
43437,
},
    NullableValue = 
new System.UInt16[3]
{
40652,
53761,
48547,
},
},
    NullableValue = 
new System.UInt16[4]
{
14859,
19489,
41011,
37671,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 59,
    Value = 
new System.UInt16[4]
{
49238,
38065,
45718,
29331,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 52,
    Value = 
new System.UInt16[3]
{
47198,
52101,
7199,
},
    NullableValue = 
new System.UInt16[3]
{
4570,
6520,
20127,
},
},
    NullableValue = 
new System.UInt16[4]
{
2480,
63957,
42676,
53748,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 68,
    Value = 
new System.UInt16[3]
{
41050,
2768,
7256,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 56,
    Value = 
new System.UInt16[3]
{
43599,
42713,
20156,
},
    NullableValue = 
new System.UInt16[3]
{
34137,
2714,
57266,
},
},
    NullableValue = 
new System.UInt16[4]
{
55139,
27692,
53175,
6164,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 71,
    Value = 
new System.UInt16[4]
{
8179,
51435,
12251,
49382,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 63,
    Value = 
new System.UInt16[4]
{
3841,
43072,
23059,
29594,
},
    NullableValue = 
new System.UInt16[4]
{
47438,
25963,
34256,
37990,
},
},
    NullableValue = 
new System.UInt16[3]
{
13450,
64987,
26080,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 75,
    Value = 
new System.UInt16[4]
{
28506,
54690,
20877,
63948,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 70,
    Value = 
new System.UInt16[3]
{
26613,
41053,
38131,
},
    NullableValue = 
new System.UInt16[4]
{
10645,
5692,
58241,
49759,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 76,
    Value = 
new System.UInt16[3]
{
34592,
58022,
12372,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 78,
    Value = 
new System.UInt16[4]
{
49781,
31465,
54635,
51691,
},
    NullableValue = 
new System.UInt16[4]
{
15252,
3242,
46224,
9623,
},
},
    NullableValue = 
new System.UInt16[4]
{
50534,
18229,
9404,
30248,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 85,
    Value = 
new System.UInt16[3]
{
49411,
55083,
59076,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 85,
    Value = 
new System.UInt16[3]
{
56029,
5220,
43154,
},
    NullableValue = 
new System.UInt16[4]
{
14409,
49541,
57639,
46432,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 92,
    Value = 
new System.UInt16[4]
{
25494,
34932,
42540,
47472,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 89,
    Value = 
new System.UInt16[3]
{
19206,
63977,
15904,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 100,
    Value = 
new System.UInt16[4]
{
50643,
17414,
50769,
13030,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 91,
    Value = 
new System.UInt16[4]
{
25575,
61810,
55012,
528,
},
    NullableValue = 
new System.UInt16[4]
{
3287,
30596,
23620,
64124,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 104,
    Value = 
new System.UInt16[3]
{
41354,
2099,
53907,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 92,
    Value = 
new System.UInt16[4]
{
43292,
58831,
14302,
47601,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 107,
    Value = 
new System.UInt16[3]
{
36178,
48173,
35291,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 97,
    Value = 
new System.UInt16[3]
{
15476,
34183,
47924,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 108,
    Value = 
new System.UInt16[4]
{
38677,
42738,
57583,
15143,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 99,
    Value = 
new System.UInt16[4]
{
62271,
46123,
21943,
21059,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
44610,
45062,
65418,
24255,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 113,
    Value = 
new System.UInt16[4]
{
34935,
24090,
64295,
24789,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 101,
    Value = 
new System.UInt16[4]
{
64087,
268,
4233,
45969,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
19495,
23814,
51617,
43777,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 116,
    Value = 
new System.UInt16[4]
{
196,
61797,
52940,
45687,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 103,
    Value = 
new System.UInt16[3]
{
12875,
58166,
3359,
},
    NullableValue = 
new System.UInt16[3]
{
38803,
11345,
21756,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 119,
    Value = 
new System.UInt16[4]
{
5269,
50920,
25365,
53751,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 110,
    Value = 
new System.UInt16[3]
{
45141,
44295,
24702,
},
    NullableValue = 
new System.UInt16[3]
{
27643,
19690,
3947,
},
},
    NullableValue = 
new System.UInt16[3]
{
29933,
53744,
49032,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 124,
    Value = 
new System.UInt16[4]
{
38893,
36590,
22863,
44619,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 115,
    Value = 
new System.UInt16[4]
{
29687,
53266,
57587,
20236,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
20689,
38633,
2416,
21393,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 131,
    Value = 
new System.UInt16[3]
{
29123,
50833,
49604,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 123,
    Value = 
new System.UInt16[4]
{
31053,
57644,
49528,
44469,
},
    NullableValue = 
new System.UInt16[4]
{
56706,
16221,
57962,
24050,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 134,
    Value = 
new System.UInt16[3]
{
62860,
60371,
57875,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 131,
    Value = 
new System.UInt16[4]
{
11611,
54671,
22725,
24670,
},
    NullableValue = 
new System.UInt16[4]
{
41105,
38148,
57001,
57978,
},
},
    NullableValue = 
new System.UInt16[3]
{
42847,
35952,
10257,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 141,
    Value = 
new System.UInt16[4]
{
40023,
49490,
36362,
36364,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 136,
    Value = 
new System.UInt16[3]
{
57918,
52188,
15798,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 150,
    Value = 
new System.UInt16[4]
{
46019,
26174,
36045,
18850,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 138,
    Value = 
new System.UInt16[4]
{
64526,
65214,
41788,
61285,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
25077,
2425,
47448,
1841,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 153,
    Value = 
new System.UInt16[3]
{
24485,
17339,
27347,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 145,
    Value = 
new System.UInt16[4]
{
52066,
24369,
28614,
23943,
},
    NullableValue = 
new System.UInt16[4]
{
58934,
9635,
52226,
43043,
},
},
    NullableValue = 
new System.UInt16[3]
{
46493,
30453,
25379,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 156,
    Value = 
new System.UInt16[3]
{
45380,
20314,
49860,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 154,
    Value = 
new System.UInt16[4]
{
6026,
48519,
52395,
6158,
},
    NullableValue = 
new System.UInt16[3]
{
25171,
49922,
23647,
},
},
    NullableValue = 
new System.UInt16[3]
{
38161,
38474,
5749,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 162,
    Value = 
new System.UInt16[3]
{
39483,
11427,
26059,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 158,
    Value = 
new System.UInt16[3]
{
52291,
21314,
65325,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 167,
    Value = 
new System.UInt16[4]
{
30516,
17461,
30050,
6506,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 165,
    Value = 
new System.UInt16[4]
{
33893,
37683,
2741,
7287,
},
    NullableValue = 
new System.UInt16[3]
{
14308,
63891,
50119,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 174,
    Value = 
new System.UInt16[3]
{
63232,
63726,
17201,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 171,
    Value = 
new System.UInt16[3]
{
28479,
49093,
53679,
},
    NullableValue = 
new System.UInt16[3]
{
63033,
12911,
42157,
},
},
    NullableValue = null,
},
            new UInt16ArrayUInt16E1M
{
    Id = 176,
    Value = 
new System.UInt16[4]
{
9990,
54393,
58333,
14680,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 172,
    Value = 
new System.UInt16[4]
{
21761,
50312,
24013,
122,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
7274,
45388,
48074,
52968,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 181,
    Value = 
new System.UInt16[4]
{
46895,
63395,
28095,
42696,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 173,
    Value = 
new System.UInt16[4]
{
20506,
59914,
11157,
62104,
},
    NullableValue = 
new System.UInt16[3]
{
29581,
61484,
7135,
},
},
    NullableValue = 
new System.UInt16[3]
{
46763,
13521,
28248,
},
},
            new UInt16ArrayUInt16E1M
{
    Id = 189,
    Value = 
new System.UInt16[4]
{
34858,
38106,
44401,
39469,
},
    ModelInner = new UInt16ArrayUInt161MI
{
    Id = 180,
    Value = 
new System.UInt16[4]
{
36185,
64460,
35816,
37286,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
61352,
10150,
10142,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16arrayuint16e1m(
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
            asPartInterface: typeof(IUInt16MArrayArrayUInt16)),
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
                    await ((IUInt16MArrayArrayUInt16)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16MArrayArrayUInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16arrayuint16e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16ArrayUInt16E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayArrayUInt16)),
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
                    var models = await ((IUInt16MArrayArrayUInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16ArrayUInt16E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16MArrayArrayUInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16ArrayUInt16E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


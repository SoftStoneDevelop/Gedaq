

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
    internal partial interface IInt32MArrayMArrayD1
    {
    }
    
    internal partial class Int32MArrayMArrayD1 : IInt32MArrayMArrayD1
    {


#region TestData

        private readonly Int32MArrayD1E1M[] _testData = new Int32MArrayD1E1M[]
        {
            new Int32MArrayD1E1M
{
    Id = 2,
    Value = 
new System.Int32[4]
{
2079240444,
1747854315,
98885006,
278976201,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Int32[4]
{
1871886978,
311631993,
2144315065,
1920036125,
},
    NullableValue = 
new System.Int32[3]
{
1391922352,
773965411,
596560534,
},
},
    NullableValue = 
new System.Int32[4]
{
409019864,
723113298,
944869462,
175041888,
},
},
            new Int32MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int32[3]
{
402205561,
891441730,
77765864,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Int32[3]
{
1090024776,
916397920,
903539574,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 14,
    Value = 
new System.Int32[4]
{
1893287429,
242872443,
970436094,
769209566,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Int32[4]
{
147107845,
1412851890,
579174473,
975841239,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
13489989,
969734550,
3881287,
27297580,
},
},
            new Int32MArrayD1E1M
{
    Id = 21,
    Value = 
new System.Int32[3]
{
285235589,
869256801,
186779058,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Int32[4]
{
65756760,
3647362,
937548695,
1615769360,
},
    NullableValue = 
new System.Int32[3]
{
95131661,
1743530688,
1858124708,
},
},
    NullableValue = 
new System.Int32[4]
{
1856342725,
912845980,
922283456,
755116524,
},
},
            new Int32MArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int32[4]
{
747365165,
1198237129,
1335353650,
333373074,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Int32[4]
{
326771464,
2049428198,
463184870,
510591982,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 29,
    Value = 
new System.Int32[3]
{
71787891,
2084921352,
105104775,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Int32[3]
{
989408305,
1060427637,
1465521566,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int32[4]
{
1136656206,
1041447810,
930037566,
253189556,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int32[4]
{
1050220808,
1219697871,
711693602,
1620283639,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1685534511,
1284283084,
476541522,
946217442,
},
},
            new Int32MArrayD1E1M
{
    Id = 41,
    Value = 
new System.Int32[4]
{
618896872,
1465625016,
1513280609,
241670987,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Int32[3]
{
903615986,
592510582,
1256230416,
},
    NullableValue = 
new System.Int32[3]
{
978838483,
1131323589,
1054703305,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int32[3]
{
1180330415,
888650469,
1537311634,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int32[4]
{
643893346,
1976255668,
1775987686,
1947759582,
},
    NullableValue = 
new System.Int32[4]
{
930881439,
1767730662,
2082080799,
832255863,
},
},
    NullableValue = 
new System.Int32[3]
{
1827432967,
2014293095,
1071317476,
},
},
            new Int32MArrayD1E1M
{
    Id = 50,
    Value = 
new System.Int32[3]
{
713314836,
703975546,
886158195,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Int32[3]
{
876839674,
417308524,
1487322412,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1202077606,
109830192,
1979036267,
},
},
            new Int32MArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int32[4]
{
1173949800,
1638332450,
760295358,
1777141710,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Int32[4]
{
1478737612,
112278104,
1344900553,
2071198408,
},
    NullableValue = 
new System.Int32[3]
{
244321621,
86137213,
277717963,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 59,
    Value = 
new System.Int32[3]
{
738236948,
1643054341,
1934200507,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Int32[3]
{
2067523347,
1724995402,
1805305051,
},
    NullableValue = 
new System.Int32[4]
{
861503380,
1065743703,
1301303641,
1581741787,
},
},
    NullableValue = 
new System.Int32[3]
{
122055122,
2085465537,
640396324,
},
},
            new Int32MArrayD1E1M
{
    Id = 63,
    Value = 
new System.Int32[4]
{
1062572937,
1463387384,
1867239447,
433987866,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int32[4]
{
575915452,
1175258270,
592072717,
1508958948,
},
    NullableValue = 
new System.Int32[3]
{
359566639,
1350212891,
282518874,
},
},
    NullableValue = 
new System.Int32[3]
{
2023441856,
478630656,
1781003128,
},
},
            new Int32MArrayD1E1M
{
    Id = 69,
    Value = 
new System.Int32[3]
{
1177103375,
108799309,
573028296,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Int32[4]
{
841161298,
571992457,
1092254020,
692821002,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 70,
    Value = 
new System.Int32[4]
{
1908935988,
279737211,
2141671596,
1434393647,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Int32[4]
{
934650291,
1106427653,
1568638652,
1147085653,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int32[4]
{
1482298845,
420352163,
908285683,
762249636,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int32[3]
{
1392162855,
579764579,
318500954,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
163502403,
1734033301,
650356567,
},
},
            new Int32MArrayD1E1M
{
    Id = 77,
    Value = 
new System.Int32[3]
{
1796257982,
66997954,
734297394,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Int32[3]
{
74596057,
1254446098,
728952225,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 84,
    Value = 
new System.Int32[3]
{
41172924,
1014510051,
745557537,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Int32[4]
{
522717227,
1026050270,
419802595,
361412174,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1789565929,
25558002,
264260198,
},
},
            new Int32MArrayD1E1M
{
    Id = 86,
    Value = 
new System.Int32[4]
{
442375920,
1957486789,
66325096,
286614421,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int32[4]
{
2065241744,
1379382271,
848823744,
1619779065,
},
    NullableValue = 
new System.Int32[3]
{
1426334916,
2005174857,
584291989,
},
},
    NullableValue = 
new System.Int32[4]
{
566656162,
454196467,
1431601716,
1889074532,
},
},
            new Int32MArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int32[3]
{
965665713,
544433667,
2061332630,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Int32[3]
{
960483889,
1508843015,
890379394,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int32[3]
{
364093156,
1347075146,
1057259045,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Int32[4]
{
47779456,
1365097313,
411567763,
2040508967,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int32[3]
{
2013827453,
532751393,
2044313260,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Int32[4]
{
556334799,
337022346,
495905209,
1206113475,
},
    NullableValue = 
new System.Int32[4]
{
1636687834,
1527347081,
322182490,
1544678010,
},
},
    NullableValue = 
new System.Int32[3]
{
75049393,
119516456,
516387537,
},
},
            new Int32MArrayD1E1M
{
    Id = 107,
    Value = 
new System.Int32[3]
{
604966261,
598660058,
1496456936,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Int32[3]
{
1517531403,
1562079254,
1001810478,
},
    NullableValue = 
new System.Int32[4]
{
984012828,
939893701,
79402212,
177025706,
},
},
    NullableValue = 
new System.Int32[3]
{
1287155578,
734014230,
1047201004,
},
},
            new Int32MArrayD1E1M
{
    Id = 115,
    Value = 
new System.Int32[3]
{
1823536332,
511139157,
1514587340,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Int32[3]
{
1225921401,
498463790,
1645492624,
},
    NullableValue = 
new System.Int32[4]
{
415842405,
305486002,
1006405092,
597898,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 117,
    Value = 
new System.Int32[4]
{
161180792,
451000380,
548269722,
1427937813,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.Int32[3]
{
2013186706,
1757558509,
517705882,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1402792798,
921645395,
530082519,
},
},
            new Int32MArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int32[4]
{
756768688,
597423464,
1108616104,
1824146828,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.Int32[4]
{
370073475,
670614563,
2108739627,
360427338,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int32[4]
{
477998342,
1851362582,
1785867724,
1755285527,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 112,
    Value = 
new System.Int32[4]
{
1295442322,
217743941,
1326598940,
1389333217,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1132145964,
1692972818,
1547408952,
1992756224,
},
},
            new Int32MArrayD1E1M
{
    Id = 136,
    Value = 
new System.Int32[3]
{
371869902,
896495889,
1656010405,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Int32[3]
{
1979069004,
1812194015,
472765478,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1686637670,
1007073418,
1451514868,
1860789536,
},
},
            new Int32MArrayD1E1M
{
    Id = 137,
    Value = 
new System.Int32[4]
{
1105363515,
1227106697,
1726571394,
1955617726,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Int32[3]
{
1904909377,
1842357713,
1510619976,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int32[3]
{
449910630,
991905370,
122469090,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Int32[4]
{
495327562,
1117598986,
1812948857,
1783920795,
},
    NullableValue = 
new System.Int32[3]
{
917142680,
1032624100,
1061144649,
},
},
    NullableValue = 
new System.Int32[3]
{
585279932,
1857598546,
345155024,
},
},
            new Int32MArrayD1E1M
{
    Id = 143,
    Value = 
new System.Int32[4]
{
1475927787,
270143011,
1707018502,
210151335,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Int32[3]
{
1041980595,
748415947,
1423018645,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
470870249,
1027483570,
1007090475,
},
},
            new Int32MArrayD1E1M
{
    Id = 150,
    Value = 
new System.Int32[3]
{
1464345976,
1423583662,
2032654920,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Int32[4]
{
1600019139,
2123267571,
30521051,
1139002928,
},
    NullableValue = 
new System.Int32[3]
{
186179530,
2044455830,
964631496,
},
},
    NullableValue = 
new System.Int32[3]
{
525191874,
972306083,
113323763,
},
},
            new Int32MArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int32[3]
{
1551758811,
565860515,
604853863,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Int32[4]
{
72339383,
210223534,
368936854,
107513779,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 157,
    Value = 
new System.Int32[4]
{
1208875039,
325828710,
2024561778,
1442154981,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Int32[4]
{
1464952970,
1558086498,
1835180928,
2047052689,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1118010042,
1379381031,
1377054050,
866464416,
},
},
            new Int32MArrayD1E1M
{
    Id = 163,
    Value = 
new System.Int32[4]
{
923015622,
1152729182,
124195334,
2017654171,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.Int32[4]
{
314180165,
1425878474,
1145173891,
1190766570,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
10284447,
500077151,
963538637,
493835052,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int32)}, 
    {mi_id:Int32},
    {mi_value:Array(Int32)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
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
                    await ((IInt32MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IInt32MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.int32marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayMArrayD1)),
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
                    var models = await ((IInt32MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


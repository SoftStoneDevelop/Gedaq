

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
    internal partial interface IInt32MArrayArrayInt32
    {
    }
    
    internal partial class Int32MArrayArrayInt32 : IInt32MArrayArrayInt32
    {


#region TestData

        private readonly Int32ArrayInt32E1M[] _testData = new Int32ArrayInt32E1M[]
        {
            new Int32ArrayInt32E1M
{
    Id = 8,
    Value = 
new System.Int32[4]
{
271133535,
855348106,
1039845875,
1288848191,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 4,
    Value = 
new System.Int32[3]
{
1543694525,
733817649,
741200243,
},
    NullableValue = 
new System.Int32[3]
{
396762825,
1602543117,
1858922236,
},
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 11,
    Value = 
new System.Int32[3]
{
688618581,
1351589670,
1932525813,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 10,
    Value = 
new System.Int32[3]
{
476987548,
141890787,
708919696,
},
    NullableValue = 
new System.Int32[4]
{
1574095000,
1399032347,
1733488775,
1148789131,
},
},
    NullableValue = 
new System.Int32[3]
{
1307058398,
1242272168,
1742167963,
},
},
            new Int32ArrayInt32E1M
{
    Id = 19,
    Value = 
new System.Int32[3]
{
195468279,
242596189,
1652327984,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 11,
    Value = 
new System.Int32[3]
{
1181726560,
668550329,
35664122,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1100589693,
350233283,
1050551417,
1971044188,
},
},
            new Int32ArrayInt32E1M
{
    Id = 24,
    Value = 
new System.Int32[3]
{
1787002985,
1732449042,
1708013656,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 20,
    Value = 
new System.Int32[4]
{
536575669,
2019733563,
1345172100,
698036293,
},
    NullableValue = 
new System.Int32[3]
{
1560767058,
1018416170,
873253020,
},
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 25,
    Value = 
new System.Int32[3]
{
1959454500,
1568846516,
497695639,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 26,
    Value = 
new System.Int32[3]
{
50827764,
841057024,
817234133,
},
    NullableValue = 
new System.Int32[3]
{
272461856,
969688766,
1270605032,
},
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 32,
    Value = 
new System.Int32[3]
{
761606404,
958194564,
1742104621,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 34,
    Value = 
new System.Int32[3]
{
809758570,
1541237093,
37372242,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 36,
    Value = 
new System.Int32[3]
{
320098258,
892626052,
911906820,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 35,
    Value = 
new System.Int32[4]
{
961738202,
992035251,
317010623,
1755270934,
},
    NullableValue = 
new System.Int32[3]
{
328106482,
1667322196,
346735705,
},
},
    NullableValue = 
new System.Int32[4]
{
435580543,
1486680328,
621538291,
443240913,
},
},
            new Int32ArrayInt32E1M
{
    Id = 37,
    Value = 
new System.Int32[3]
{
801246254,
880545847,
783316167,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 40,
    Value = 
new System.Int32[4]
{
1966713796,
2023580498,
1972878520,
813773539,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1403567660,
1828908498,
792364139,
},
},
            new Int32ArrayInt32E1M
{
    Id = 45,
    Value = 
new System.Int32[4]
{
1135620550,
1453550947,
299596143,
945746248,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 46,
    Value = 
new System.Int32[3]
{
202083991,
1280045899,
1133869824,
},
    NullableValue = 
new System.Int32[3]
{
182585978,
2013351685,
916896940,
},
},
    NullableValue = 
new System.Int32[4]
{
1217957194,
555701765,
1242768493,
2059453748,
},
},
            new Int32ArrayInt32E1M
{
    Id = 49,
    Value = 
new System.Int32[3]
{
117292261,
507789092,
1247465851,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 55,
    Value = 
new System.Int32[3]
{
839549766,
1113508994,
204533218,
},
    NullableValue = 
new System.Int32[4]
{
1456669698,
1938784362,
1788538741,
96583139,
},
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 54,
    Value = 
new System.Int32[3]
{
387676975,
829014847,
1560872306,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 57,
    Value = 
new System.Int32[4]
{
1126953273,
687760661,
2088853544,
1133687733,
},
    NullableValue = 
new System.Int32[3]
{
1957434036,
150925119,
172514985,
},
},
    NullableValue = 
new System.Int32[4]
{
1413642279,
124376014,
2038904403,
526620031,
},
},
            new Int32ArrayInt32E1M
{
    Id = 63,
    Value = 
new System.Int32[3]
{
823763000,
507723394,
1900462290,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 61,
    Value = 
new System.Int32[3]
{
403464263,
600462499,
1062697834,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1980364652,
87563260,
1105728288,
949993148,
},
},
            new Int32ArrayInt32E1M
{
    Id = 65,
    Value = 
new System.Int32[4]
{
1651470457,
2123525606,
2060819218,
790391402,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 69,
    Value = 
new System.Int32[3]
{
325971452,
626050288,
469708388,
},
    NullableValue = 
new System.Int32[4]
{
1856174797,
283345286,
741745979,
1081871763,
},
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 69,
    Value = 
new System.Int32[4]
{
844610987,
1049694473,
1724719458,
820618352,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 75,
    Value = 
new System.Int32[3]
{
1351120622,
1225274237,
611388048,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 70,
    Value = 
new System.Int32[3]
{
784158593,
590467794,
413581833,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 77,
    Value = 
new System.Int32[4]
{
812136242,
664000947,
1742744126,
1554697786,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 76,
    Value = 
new System.Int32[4]
{
289718375,
1499897732,
1121057416,
2106309190,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 81,
    Value = 
new System.Int32[4]
{
1114403827,
1575404745,
173107573,
1607374710,
},
    NullableValue = 
new System.Int32[4]
{
1911428870,
320003963,
1331428599,
150936434,
},
},
    NullableValue = 
new System.Int32[4]
{
45954065,
1287395641,
1275782787,
1804184443,
},
},
            new Int32ArrayInt32E1M
{
    Id = 81,
    Value = 
new System.Int32[4]
{
1181021393,
1204497721,
774950811,
1326735737,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 83,
    Value = 
new System.Int32[4]
{
1943307726,
1115165431,
1488388480,
2072463189,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 88,
    Value = 
new System.Int32[3]
{
1727185690,
981544240,
804746813,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 86,
    Value = 
new System.Int32[3]
{
119419086,
1465419202,
324368050,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 92,
    Value = 
new System.Int32[4]
{
520363828,
463915197,
987313778,
1603720514,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 92,
    Value = 
new System.Int32[4]
{
267122810,
2119162831,
599731537,
143718251,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
352781357,
426908018,
1366377166,
221534761,
},
},
            new Int32ArrayInt32E1M
{
    Id = 94,
    Value = 
new System.Int32[4]
{
126016876,
1101875372,
1852718513,
1387504390,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 98,
    Value = 
new System.Int32[3]
{
905855438,
1915212692,
693250110,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 95,
    Value = 
new System.Int32[3]
{
1930530739,
1289206770,
643396380,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 106,
    Value = 
new System.Int32[4]
{
254916984,
1445599771,
2026451947,
907912391,
},
    NullableValue = 
new System.Int32[3]
{
1416935016,
1585944862,
1191904655,
},
},
    NullableValue = 
new System.Int32[3]
{
1165805100,
1702981082,
536253969,
},
},
            new Int32ArrayInt32E1M
{
    Id = 103,
    Value = 
new System.Int32[4]
{
1678418390,
1418228553,
1000905844,
117103755,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 109,
    Value = 
new System.Int32[4]
{
110511321,
2051581075,
2041300989,
513456300,
},
    NullableValue = 
new System.Int32[4]
{
2146807898,
1061643784,
428714440,
1060079694,
},
},
    NullableValue = 
new System.Int32[4]
{
389554078,
421988622,
856709588,
2032493600,
},
},
            new Int32ArrayInt32E1M
{
    Id = 107,
    Value = 
new System.Int32[3]
{
275041456,
1947405671,
1187513817,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 110,
    Value = 
new System.Int32[3]
{
1663002840,
729594587,
1282460992,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 108,
    Value = 
new System.Int32[3]
{
359949999,
2031099797,
1311612356,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 112,
    Value = 
new System.Int32[4]
{
888947829,
799934296,
185091459,
2127310752,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
2142109033,
1958857776,
353832072,
745224221,
},
},
            new Int32ArrayInt32E1M
{
    Id = 113,
    Value = 
new System.Int32[4]
{
156191968,
392089609,
1951369014,
477287506,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 115,
    Value = 
new System.Int32[3]
{
1991605444,
1799287316,
818662579,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 115,
    Value = 
new System.Int32[3]
{
759036431,
1495349465,
537713594,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 116,
    Value = 
new System.Int32[4]
{
1300283294,
943253350,
1343048221,
1599363637,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1997810416,
2078241357,
412525754,
888620763,
},
},
            new Int32ArrayInt32E1M
{
    Id = 124,
    Value = 
new System.Int32[4]
{
1583732312,
531473377,
1741767385,
1844027127,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 124,
    Value = 
new System.Int32[4]
{
698481120,
1435680506,
208333068,
215479890,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1969930872,
2002151972,
1237358180,
1188612604,
},
},
            new Int32ArrayInt32E1M
{
    Id = 132,
    Value = 
new System.Int32[3]
{
110889456,
475498619,
1329986463,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 126,
    Value = 
new System.Int32[3]
{
2146459260,
1392363175,
1808926362,
},
    NullableValue = 
new System.Int32[3]
{
124705541,
1872418742,
1345793708,
},
},
    NullableValue = 
new System.Int32[3]
{
1502024242,
1788686568,
1883888066,
},
},
            new Int32ArrayInt32E1M
{
    Id = 134,
    Value = 
new System.Int32[3]
{
1470004456,
1121801614,
488471515,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 127,
    Value = 
new System.Int32[4]
{
480334415,
1442253072,
1119828383,
1210381188,
},
    NullableValue = 
new System.Int32[4]
{
124950585,
1411033356,
2118152992,
281819807,
},
},
    NullableValue = 
new System.Int32[3]
{
840777811,
1291312907,
1945993273,
},
},
            new Int32ArrayInt32E1M
{
    Id = 141,
    Value = 
new System.Int32[3]
{
923179873,
1233029356,
1660409529,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 135,
    Value = 
new System.Int32[4]
{
2027660877,
1021911409,
91329632,
708593733,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt32E1M
{
    Id = 146,
    Value = 
new System.Int32[4]
{
1664799079,
1740139580,
1519408044,
113959547,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 140,
    Value = 
new System.Int32[3]
{
1490209447,
392453494,
178858434,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1552066591,
1170713457,
2097316365,
501324164,
},
},
            new Int32ArrayInt32E1M
{
    Id = 150,
    Value = 
new System.Int32[4]
{
1255027410,
863119922,
590780865,
269452381,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 141,
    Value = 
new System.Int32[4]
{
196678711,
840011757,
718230614,
1364763232,
},
    NullableValue = 
new System.Int32[3]
{
963592767,
807582485,
1758913139,
},
},
    NullableValue = 
new System.Int32[4]
{
944731049,
1268431773,
1517517613,
696789357,
},
},
            new Int32ArrayInt32E1M
{
    Id = 154,
    Value = 
new System.Int32[3]
{
451577353,
2139246752,
1551070568,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 143,
    Value = 
new System.Int32[3]
{
1891505170,
1406096362,
710920321,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
2067586680,
33414126,
2119120846,
},
},
            new Int32ArrayInt32E1M
{
    Id = 160,
    Value = 
new System.Int32[4]
{
146207581,
925925500,
37357039,
1907163317,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 151,
    Value = 
new System.Int32[3]
{
1288532488,
211879183,
217152968,
},
    NullableValue = 
new System.Int32[3]
{
2141036853,
2077589128,
213464406,
},
},
    NullableValue = 
new System.Int32[4]
{
1363525606,
1337277718,
1143734974,
1611814001,
},
},
            new Int32ArrayInt32E1M
{
    Id = 165,
    Value = 
new System.Int32[3]
{
1724332931,
1135627183,
899818188,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 152,
    Value = 
new System.Int32[3]
{
969141786,
597636146,
1098614500,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
440338135,
1297781017,
2011425860,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32arrayint32e1m(
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
            asPartInterface: typeof(IInt32MArrayArrayInt32)),
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
                    await ((IInt32MArrayArrayInt32)this).InsertModelDbConnectionAsync(
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
                     ((IInt32MArrayArrayInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.int32arrayint32e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32ArrayInt32E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayArrayInt32)),
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
                    var models = await ((IInt32MArrayArrayInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32ArrayInt32E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32MArrayArrayInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32ArrayInt32E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


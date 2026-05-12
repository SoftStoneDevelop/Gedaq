

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
    Id = 7,
    Value = 
new System.Int32[4]
{
776453951,
1468386227,
393563744,
761129446,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Int32[4]
{
16065017,
1223449746,
1911501604,
1113670959,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1777136586,
1434912266,
916540568,
1781528765,
},
},
            new Int32MArrayD1E1M
{
    Id = 11,
    Value = 
new System.Int32[3]
{
493766580,
1425710032,
406435100,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Int32[4]
{
1795654392,
1482401617,
2145293319,
616965878,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
579062361,
1865425164,
459980879,
},
},
            new Int32MArrayD1E1M
{
    Id = 14,
    Value = 
new System.Int32[4]
{
530741790,
428883957,
1968670267,
366584063,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Int32[3]
{
1981154602,
768470487,
518303664,
},
    NullableValue = 
new System.Int32[3]
{
1599858098,
986185734,
1399031103,
},
},
    NullableValue = 
new System.Int32[4]
{
365508767,
1777639315,
1575396813,
1805671389,
},
},
            new Int32MArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int32[3]
{
266579887,
2050528626,
273419584,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Int32[4]
{
1055971166,
223591936,
638896233,
100322729,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
149694493,
1305262540,
1753167023,
1230726857,
},
},
            new Int32MArrayD1E1M
{
    Id = 19,
    Value = 
new System.Int32[4]
{
110461882,
2139745586,
1567353437,
1134540039,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Int32[4]
{
276194863,
1099561766,
2084477634,
119002012,
},
    NullableValue = 
new System.Int32[3]
{
1667691825,
1392457375,
1061265487,
},
},
    NullableValue = 
new System.Int32[4]
{
1303094109,
1622142771,
1732722466,
356292774,
},
},
            new Int32MArrayD1E1M
{
    Id = 27,
    Value = 
new System.Int32[4]
{
725728307,
938027456,
1849720709,
1102152300,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Int32[4]
{
2003690525,
358063929,
244245189,
521613312,
},
    NullableValue = 
new System.Int32[4]
{
1561299108,
1462641159,
1112530866,
96897855,
},
},
    NullableValue = 
new System.Int32[4]
{
1660614101,
137304317,
1001819071,
61728283,
},
},
            new Int32MArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int32[4]
{
726718338,
540365284,
726205794,
2032696684,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int32[4]
{
831992522,
820888994,
1423094878,
943687627,
},
    NullableValue = 
new System.Int32[4]
{
1085120260,
561947903,
1129523863,
1405929747,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 41,
    Value = 
new System.Int32[3]
{
771454578,
1849069855,
425549196,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int32[3]
{
226169419,
1192009040,
492909227,
},
    NullableValue = 
new System.Int32[3]
{
302745575,
111360847,
1715208101,
},
},
    NullableValue = 
new System.Int32[3]
{
864062017,
97861916,
2056931939,
},
},
            new Int32MArrayD1E1M
{
    Id = 49,
    Value = 
new System.Int32[3]
{
1113911948,
417339569,
1595824678,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Int32[4]
{
1205405910,
1759841281,
593564966,
995364781,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
592964783,
389291212,
2090728429,
},
},
            new Int32MArrayD1E1M
{
    Id = 52,
    Value = 
new System.Int32[3]
{
1292542780,
1984096355,
491772517,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int32[3]
{
1816044061,
33790312,
745892624,
},
    NullableValue = 
new System.Int32[3]
{
785398697,
2138367421,
1905069917,
},
},
    NullableValue = 
new System.Int32[4]
{
1259002802,
744864970,
1083463484,
1466642826,
},
},
            new Int32MArrayD1E1M
{
    Id = 61,
    Value = 
new System.Int32[4]
{
1674221163,
706965460,
607311318,
1943496885,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Int32[4]
{
1327109265,
1426847876,
386234444,
1722410939,
},
    NullableValue = 
new System.Int32[3]
{
1818311387,
457884106,
1946137826,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 69,
    Value = 
new System.Int32[3]
{
118562591,
397091465,
1560908013,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Int32[3]
{
172434753,
395147549,
149244229,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
517721710,
1885746567,
1820817963,
716295202,
},
},
            new Int32MArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int32[3]
{
330831424,
1747758360,
412417893,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int32[4]
{
1879505778,
2092102074,
1104502227,
1460559464,
},
    NullableValue = 
new System.Int32[3]
{
1578163223,
1948292832,
639347411,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 81,
    Value = 
new System.Int32[3]
{
209050694,
1708330662,
380807176,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Int32[3]
{
1236968735,
710861567,
1506141104,
},
    NullableValue = 
new System.Int32[4]
{
1999023535,
2057815730,
1454865159,
31990494,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 89,
    Value = 
new System.Int32[4]
{
955875983,
1699145082,
1473882363,
1267428555,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Int32[4]
{
1341614655,
317841264,
1711187725,
1878493929,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
675734926,
781503340,
730941766,
634578474,
},
},
            new Int32MArrayD1E1M
{
    Id = 97,
    Value = 
new System.Int32[4]
{
499284886,
1120833870,
646799059,
75128809,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int32[4]
{
171699489,
1215993221,
595116445,
1833409727,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 100,
    Value = 
new System.Int32[3]
{
1818374660,
2018097677,
188641905,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Int32[3]
{
1098051860,
715847795,
1540621862,
},
    NullableValue = 
new System.Int32[3]
{
992135805,
174671410,
1700069125,
},
},
    NullableValue = 
new System.Int32[3]
{
1116399135,
841092002,
1784092685,
},
},
            new Int32MArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int32[4]
{
1042460656,
169030179,
1443656548,
51865764,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Int32[3]
{
970440922,
828593208,
318076541,
},
    NullableValue = 
new System.Int32[3]
{
1962414670,
1959266253,
1368373702,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int32[3]
{
921647332,
98576088,
851495236,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Int32[4]
{
1398108743,
1222859409,
1853643490,
205413091,
},
    NullableValue = 
new System.Int32[3]
{
840238160,
1012923558,
1381124063,
},
},
    NullableValue = 
new System.Int32[4]
{
2037115368,
1664855276,
129232654,
801742626,
},
},
            new Int32MArrayD1E1M
{
    Id = 116,
    Value = 
new System.Int32[3]
{
979645408,
1730759926,
653263567,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Int32[4]
{
2123231134,
1663838428,
947112655,
375652206,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
275787957,
1832583053,
91589939,
},
},
            new Int32MArrayD1E1M
{
    Id = 120,
    Value = 
new System.Int32[3]
{
2058542918,
469421928,
65110343,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Int32[3]
{
781391815,
457859621,
127005923,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int32[3]
{
95636970,
1709930217,
595868003,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int32[4]
{
123320985,
232488162,
1190562015,
1643408646,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int32[3]
{
1012359301,
1095723046,
849707887,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Int32[3]
{
476949808,
331719132,
1692575881,
},
    NullableValue = 
new System.Int32[4]
{
1559398550,
1064327987,
1827551360,
615925883,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 140,
    Value = 
new System.Int32[3]
{
50756872,
1099069941,
2015140273,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Int32[3]
{
74972505,
1771233113,
1006486739,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
148088698,
599409079,
662251901,
584292859,
},
},
            new Int32MArrayD1E1M
{
    Id = 147,
    Value = 
new System.Int32[3]
{
167262178,
158332967,
259886481,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.Int32[3]
{
1993411856,
1296058219,
2022439084,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 152,
    Value = 
new System.Int32[3]
{
78851452,
396649789,
147806551,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 111,
    Value = 
new System.Int32[3]
{
865180396,
643459371,
571133528,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
103984526,
1313002406,
1691914087,
434089661,
},
},
            new Int32MArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int32[4]
{
1961091503,
420564856,
834203500,
867223676,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Int32[3]
{
1397299422,
1816253396,
728823561,
},
    NullableValue = 
new System.Int32[3]
{
628537298,
1664770593,
477574974,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 162,
    Value = 
new System.Int32[3]
{
1379548901,
1208566138,
1369691962,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 121,
    Value = 
new System.Int32[4]
{
1113875896,
436843201,
1429293028,
327436972,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
874939305,
924997948,
927813420,
1464254825,
},
},
            new Int32MArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int32[4]
{
495277767,
1858097603,
777266474,
1978388624,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Int32[3]
{
178920540,
1759577454,
823215463,
},
    NullableValue = 
new System.Int32[3]
{
2138743959,
672762392,
1139387672,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 170,
    Value = 
new System.Int32[3]
{
1245303761,
262279397,
1028401215,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Int32[4]
{
186051637,
1220443380,
800976564,
817438890,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 173,
    Value = 
new System.Int32[3]
{
1435855877,
139472305,
230325602,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Int32[4]
{
812668934,
2057287337,
2009395829,
1467597959,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
714187423,
1673807892,
1279805205,
},
},
            new Int32MArrayD1E1M
{
    Id = 176,
    Value = 
new System.Int32[4]
{
2099087391,
1270422160,
776996925,
2144777857,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.Int32[4]
{
797052309,
160235956,
587915791,
1716442084,
},
    NullableValue = 
new System.Int32[4]
{
686131981,
836096682,
416259797,
525621578,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 178,
    Value = 
new System.Int32[3]
{
242776878,
12598785,
1617551113,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Int32[4]
{
171341642,
565080209,
1854708097,
714645913,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 182,
    Value = 
new System.Int32[4]
{
578988691,
159150139,
458658472,
347970158,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 151,
    Value = 
new System.Int32[3]
{
1099690768,
1340166809,
1106993663,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1655876457,
2115601687,
1071798909,
},
},
            new Int32MArrayD1E1M
{
    Id = 184,
    Value = 
new System.Int32[4]
{
809757777,
1431410500,
1264004216,
1858127167,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Int32[3]
{
1757273417,
582405312,
1841976268,
},
    NullableValue = 
new System.Int32[3]
{
38128679,
1820751226,
704040481,
},
},
    NullableValue = 
new System.Int32[4]
{
1958776569,
886252834,
831885442,
1531048976,
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




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
    Id = 3,
    Value = 
new System.Int32[4]
{
339849302,
162825807,
1990724378,
2072739061,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int32[4]
{
1875458006,
318690714,
1535811102,
974231253,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 12,
    Value = 
new System.Int32[4]
{
1683620266,
1847969975,
1308383194,
712074039,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Int32[4]
{
1851646046,
1380538102,
30550315,
1064576057,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 19,
    Value = 
new System.Int32[4]
{
628607185,
398549960,
1668207522,
2115830202,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Int32[4]
{
627505095,
1004162189,
1982744636,
1884279043,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
638797238,
634203898,
292592061,
},
},
            new Int32MArrayD1E1M
{
    Id = 28,
    Value = 
new System.Int32[3]
{
1696769631,
1426462774,
1996881128,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int32[3]
{
2072291475,
259975892,
771101292,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1277538983,
157106084,
1238489990,
},
},
            new Int32MArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int32[3]
{
2009147820,
240038630,
465788929,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Int32[4]
{
1361638781,
365213322,
416927298,
810816791,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
512297280,
845706369,
458193136,
},
},
            new Int32MArrayD1E1M
{
    Id = 39,
    Value = 
new System.Int32[4]
{
1269022973,
1711201657,
1882225734,
254763480,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Int32[4]
{
484520390,
1514192455,
1239433408,
1348328815,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int32[4]
{
3244698,
1829048001,
2141134239,
1709877646,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Int32[3]
{
1777393385,
1058374087,
557660569,
},
    NullableValue = 
new System.Int32[4]
{
727951947,
1832448947,
802126664,
2052668840,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 55,
    Value = 
new System.Int32[3]
{
702728493,
1556125319,
1640027318,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int32[3]
{
2147207655,
761220014,
1103817457,
},
    NullableValue = 
new System.Int32[4]
{
340237372,
142120297,
674927351,
232548218,
},
},
    NullableValue = 
new System.Int32[3]
{
13542152,
51989590,
1559835840,
},
},
            new Int32MArrayD1E1M
{
    Id = 62,
    Value = 
new System.Int32[4]
{
232023135,
268617550,
1248327293,
1946290268,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Int32[3]
{
1442933455,
1584188442,
227619978,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
386690214,
1016133375,
1428684774,
},
},
            new Int32MArrayD1E1M
{
    Id = 66,
    Value = 
new System.Int32[4]
{
1456605147,
1245741116,
758329065,
593822658,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int32[3]
{
93897164,
1434510703,
2034555315,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 68,
    Value = 
new System.Int32[4]
{
1857858766,
1506729848,
571188217,
815080116,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Int32[3]
{
630537987,
517856681,
2078473266,
},
    NullableValue = 
new System.Int32[4]
{
85863808,
1269962000,
1404891419,
815260883,
},
},
    NullableValue = 
new System.Int32[3]
{
1052509237,
728155018,
2128830142,
},
},
            new Int32MArrayD1E1M
{
    Id = 77,
    Value = 
new System.Int32[4]
{
314486215,
1734635293,
1297929670,
1879729727,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Int32[3]
{
743740052,
1935011859,
1324695400,
},
    NullableValue = 
new System.Int32[3]
{
1634812787,
1405091566,
1351012988,
},
},
    NullableValue = 
new System.Int32[4]
{
47848988,
893417690,
1266995011,
1889039641,
},
},
            new Int32MArrayD1E1M
{
    Id = 83,
    Value = 
new System.Int32[3]
{
1572917658,
781057970,
772797173,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Int32[3]
{
910611408,
1837040750,
1949486534,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 85,
    Value = 
new System.Int32[4]
{
1544198177,
769764871,
2078992329,
1609442229,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int32[3]
{
1328598570,
832280278,
857200375,
},
    NullableValue = 
new System.Int32[4]
{
1619411734,
654524866,
831692053,
1627004627,
},
},
    NullableValue = 
new System.Int32[3]
{
1635904351,
1330657683,
1466081637,
},
},
            new Int32MArrayD1E1M
{
    Id = 91,
    Value = 
new System.Int32[3]
{
2012308564,
1972909288,
1678672875,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Int32[3]
{
125823963,
2088467542,
1963899640,
},
    NullableValue = 
new System.Int32[3]
{
277169554,
1311651963,
1208036213,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int32[3]
{
2041578395,
287928990,
2053137851,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Int32[4]
{
1441281806,
362957377,
621814777,
1803853859,
},
    NullableValue = 
new System.Int32[4]
{
1058567772,
151704606,
1421952790,
1074847806,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 100,
    Value = 
new System.Int32[3]
{
1009502181,
1863093472,
1610230470,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int32[4]
{
1214343258,
1721975773,
790480394,
837875699,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
226881960,
2047482504,
1590319584,
1602814631,
},
},
            new Int32MArrayD1E1M
{
    Id = 108,
    Value = 
new System.Int32[3]
{
1937624057,
1377245964,
901820524,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Int32[4]
{
1481389352,
1137884133,
1431026509,
1299874458,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
2040700317,
542789503,
1375232366,
},
},
            new Int32MArrayD1E1M
{
    Id = 109,
    Value = 
new System.Int32[3]
{
1025337438,
1331045974,
1718675920,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Int32[3]
{
243039300,
1480206878,
1257857435,
},
    NullableValue = 
new System.Int32[3]
{
1896397393,
570948818,
887830060,
},
},
    NullableValue = 
new System.Int32[3]
{
1899794360,
554234429,
1200801923,
},
},
            new Int32MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int32[4]
{
1224581750,
384163808,
49391343,
649288873,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Int32[4]
{
581972071,
866015845,
269653164,
1861369653,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 113,
    Value = 
new System.Int32[3]
{
584428799,
1327408948,
1313380851,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Int32[3]
{
1314697006,
1434807661,
1002139271,
},
    NullableValue = 
new System.Int32[4]
{
1981404984,
1861357618,
1370554818,
79563157,
},
},
    NullableValue = 
new System.Int32[4]
{
1882603197,
1852918666,
1899906625,
182184175,
},
},
            new Int32MArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int32[3]
{
1440744637,
361071200,
910217310,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Int32[3]
{
386656325,
2068054259,
1857265588,
},
    NullableValue = 
new System.Int32[3]
{
1807139122,
1020621640,
388147773,
},
},
    NullableValue = 
new System.Int32[4]
{
37994277,
1765499293,
2127369775,
321105643,
},
},
            new Int32MArrayD1E1M
{
    Id = 125,
    Value = 
new System.Int32[4]
{
902967949,
1282127147,
200609193,
397680364,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.Int32[3]
{
1703570716,
2018033005,
2090762172,
},
    NullableValue = 
new System.Int32[3]
{
245318197,
1079654697,
34912432,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int32[4]
{
457727274,
844098152,
130577692,
965060574,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 113,
    Value = 
new System.Int32[3]
{
372782636,
1287374164,
2116731374,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
991551340,
1607149249,
348483517,
},
},
            new Int32MArrayD1E1M
{
    Id = 131,
    Value = 
new System.Int32[3]
{
264772232,
1368874328,
480346391,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Int32[4]
{
952487125,
1450513070,
576883549,
1973596276,
},
    NullableValue = 
new System.Int32[3]
{
1795264178,
419442975,
1203604988,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 133,
    Value = 
new System.Int32[4]
{
477596697,
23255011,
990115886,
539761633,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Int32[4]
{
1943595504,
819336905,
678425296,
108113225,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
2065810816,
952418844,
645271792,
904753104,
},
},
            new Int32MArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int32[4]
{
1229510939,
536332143,
760465477,
1258488475,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Int32[3]
{
451016794,
2037039497,
936272773,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1156552798,
886734797,
724838260,
415017922,
},
},
            new Int32MArrayD1E1M
{
    Id = 145,
    Value = 
new System.Int32[4]
{
712039410,
1915985625,
1675250122,
111838378,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Int32[4]
{
1705938067,
677137355,
1953723201,
2000205511,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 148,
    Value = 
new System.Int32[3]
{
1461388840,
1168005666,
784129118,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.Int32[4]
{
663742498,
963904103,
2100489994,
693898156,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 156,
    Value = 
new System.Int32[4]
{
1776239867,
444075570,
1699469877,
1783235164,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 145,
    Value = 
new System.Int32[3]
{
70925036,
1251155560,
1341049514,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1566985616,
1205579259,
1941389676,
},
},
            new Int32MArrayD1E1M
{
    Id = 162,
    Value = 
new System.Int32[3]
{
979438488,
876511051,
939529110,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Int32[4]
{
1118560896,
157207131,
195753364,
1198835651,
},
    NullableValue = 
new System.Int32[4]
{
850920432,
1984265683,
965103475,
741841096,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int32[4]
{
185540414,
622118485,
1952252,
1015304962,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Int32[4]
{
698299824,
1991457123,
1823618528,
1670376050,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
198421997,
922645472,
1446318233,
1461133227,
},
},
            new Int32MArrayD1E1M
{
    Id = 168,
    Value = 
new System.Int32[3]
{
346930924,
603259880,
1231625011,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Int32[3]
{
1732724479,
1680256148,
1578515583,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 175,
    Value = 
new System.Int32[3]
{
1122776741,
707804404,
596107893,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Int32[4]
{
2031769135,
1191720301,
399630782,
1210808713,
},
    NullableValue = 
new System.Int32[4]
{
305662216,
783865293,
1428637088,
1820829406,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 184,
    Value = 
new System.Int32[3]
{
1677685790,
1412429336,
2046976489,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 172,
    Value = 
new System.Int32[4]
{
1704881948,
1146564843,
265123463,
2111682247,
},
    NullableValue = 
new System.Int32[4]
{
134819858,
1843430438,
1182940243,
1406089244,
},
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


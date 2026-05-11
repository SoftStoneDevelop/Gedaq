

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
1144604361,
393813216,
1803232519,
726827477,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Int32[4]
{
1129607384,
1006999203,
2092442415,
1597996127,
},
    NullableValue = 
new System.Int32[4]
{
289673524,
159968632,
521277473,
466555121,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int32[3]
{
1312234324,
2104872192,
1214898333,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Int32[3]
{
1112187925,
920775765,
352206011,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int32[3]
{
1529697184,
2010637734,
9847041,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Int32[4]
{
451791123,
1897059240,
1731537665,
398990834,
},
    NullableValue = 
new System.Int32[4]
{
30238879,
1379489638,
2044754329,
1153677975,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int32[4]
{
1217719452,
2050481532,
214225491,
157880478,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Int32[4]
{
915986474,
813545588,
1774971135,
1830736950,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1789011262,
1144280127,
510226168,
},
},
            new Int32MArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int32[3]
{
639755911,
1306841158,
1036519558,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int32[3]
{
284566044,
368401687,
1014738342,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int32[3]
{
1014642003,
1764749200,
32494663,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int32[4]
{
1169460190,
2091718569,
1943321922,
1497508061,
},
    NullableValue = 
new System.Int32[3]
{
1976914965,
2011429512,
1313622642,
},
},
    NullableValue = 
new System.Int32[3]
{
1767935741,
1975342614,
1137919483,
},
},
            new Int32MArrayD1E1M
{
    Id = 41,
    Value = 
new System.Int32[4]
{
1054546999,
2142226100,
2109784361,
2054243666,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Int32[4]
{
1991306166,
1709985372,
7159576,
1475091932,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 42,
    Value = 
new System.Int32[4]
{
116106969,
2142796187,
1588984025,
1477228716,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Int32[3]
{
2049878855,
173421701,
306066489,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1039080372,
477782786,
882249091,
1046978177,
},
},
            new Int32MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int32[3]
{
1589039527,
1248058913,
366288185,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Int32[3]
{
1216818192,
1988304624,
505909085,
},
    NullableValue = 
new System.Int32[3]
{
1438919095,
334124313,
1842320288,
},
},
    NullableValue = 
new System.Int32[3]
{
2124181888,
1703009647,
1941144593,
},
},
            new Int32MArrayD1E1M
{
    Id = 53,
    Value = 
new System.Int32[4]
{
1458082849,
984120665,
1984110256,
1872222484,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Int32[4]
{
200723111,
29320832,
2047016819,
1286326135,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 62,
    Value = 
new System.Int32[4]
{
559543647,
1482061751,
1907794205,
1030551786,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int32[4]
{
1000041759,
129065314,
1468464117,
1225875404,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
615846783,
1762413133,
1594924988,
},
},
            new Int32MArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int32[4]
{
201558880,
248829889,
1779969155,
251460420,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Int32[4]
{
641571041,
189620459,
1343519079,
2079121222,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 69,
    Value = 
new System.Int32[4]
{
858344759,
1882017351,
1750948737,
467218874,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Int32[3]
{
1198808724,
1986607856,
1710776063,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1332183353,
430794668,
518318670,
},
},
            new Int32MArrayD1E1M
{
    Id = 70,
    Value = 
new System.Int32[3]
{
1979455599,
341923076,
455587561,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Int32[4]
{
1097497962,
2098763933,
932555954,
9242062,
},
    NullableValue = 
new System.Int32[4]
{
744734640,
2112891437,
308720746,
1664976301,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int32[3]
{
969863890,
919713962,
2091443143,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Int32[3]
{
2015051926,
1204131950,
1938914212,
},
    NullableValue = 
new System.Int32[4]
{
1094735067,
226465273,
367995533,
1935151520,
},
},
    NullableValue = 
new System.Int32[3]
{
367741605,
322391485,
12381572,
},
},
            new Int32MArrayD1E1M
{
    Id = 77,
    Value = 
new System.Int32[3]
{
167128435,
1737581966,
1932353699,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Int32[3]
{
1395547415,
1117993177,
1078793321,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 83,
    Value = 
new System.Int32[4]
{
1180979869,
721601829,
1795562710,
1885781783,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Int32[3]
{
18761568,
515973485,
900954742,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1539207527,
1452240072,
1148795057,
},
},
            new Int32MArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int32[3]
{
1095288332,
1627891470,
158694475,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Int32[4]
{
1050437384,
1710338723,
952945630,
855126416,
},
    NullableValue = 
new System.Int32[4]
{
1651781857,
593414698,
494083763,
1955531029,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 91,
    Value = 
new System.Int32[3]
{
720734149,
1480745542,
1398887541,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Int32[4]
{
1828045294,
234951449,
1292605170,
170761447,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
646961464,
433406492,
266177789,
2146841762,
},
},
            new Int32MArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int32[3]
{
2005376652,
930272087,
1307052769,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Int32[4]
{
2135176055,
566032084,
588622644,
1761964868,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1793983345,
1540153269,
1008754570,
271861195,
},
},
            new Int32MArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int32[3]
{
338243476,
1354629508,
547626247,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.Int32[3]
{
1497329370,
927988790,
1349659252,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 102,
    Value = 
new System.Int32[3]
{
1079792161,
1624117314,
426698113,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 112,
    Value = 
new System.Int32[4]
{
1602641283,
831454368,
1010996872,
874341989,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
117962976,
1210099654,
1674150023,
20347863,
},
},
            new Int32MArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int32[4]
{
1465766251,
959862415,
500907047,
1782087541,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.Int32[3]
{
200114563,
1744186129,
1866200363,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 109,
    Value = 
new System.Int32[3]
{
974177615,
403196737,
1736307202,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Int32[4]
{
250958872,
182857292,
597962672,
1136631686,
},
    NullableValue = 
new System.Int32[4]
{
1677878084,
386568810,
1604859476,
69757272,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 110,
    Value = 
new System.Int32[4]
{
1069314418,
2060477683,
548944242,
1821326006,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 126,
    Value = 
new System.Int32[4]
{
1344204636,
1488044337,
1649208359,
1401779416,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 118,
    Value = 
new System.Int32[3]
{
1366616494,
1882700127,
523852838,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Int32[3]
{
75703335,
1827192711,
1684921997,
},
    NullableValue = 
new System.Int32[4]
{
2123217519,
1093066037,
1774751322,
1049931890,
},
},
    NullableValue = 
new System.Int32[3]
{
839160182,
392077748,
1568912222,
},
},
            new Int32MArrayD1E1M
{
    Id = 120,
    Value = 
new System.Int32[3]
{
2040490739,
647888629,
1843549068,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Int32[4]
{
1724257879,
1178129921,
540001342,
1131071165,
},
    NullableValue = 
new System.Int32[4]
{
777808573,
1935011480,
266076406,
323778876,
},
},
    NullableValue = 
new System.Int32[4]
{
1106655421,
1474538934,
1472090055,
1286341489,
},
},
            new Int32MArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int32[4]
{
1132243201,
1815135834,
1278607979,
711307539,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.Int32[4]
{
1487511109,
804695887,
1622887655,
46674853,
},
    NullableValue = 
new System.Int32[3]
{
734902038,
27149346,
2073944655,
},
},
    NullableValue = 
new System.Int32[4]
{
1902438448,
1593058528,
775974999,
1730074089,
},
},
            new Int32MArrayD1E1M
{
    Id = 133,
    Value = 
new System.Int32[4]
{
454102245,
902258916,
299883803,
910039245,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Int32[4]
{
1478512172,
1306598232,
2075360989,
1924830404,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 137,
    Value = 
new System.Int32[4]
{
1623019404,
1623306912,
2076144552,
1214554272,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 146,
    Value = 
new System.Int32[3]
{
1682480361,
470034145,
1240479819,
},
    NullableValue = 
new System.Int32[3]
{
1349784041,
1211921819,
1066358035,
},
},
    NullableValue = 
new System.Int32[3]
{
544766378,
1193819660,
743950865,
},
},
            new Int32MArrayD1E1M
{
    Id = 140,
    Value = 
new System.Int32[4]
{
948461239,
723464070,
1753482912,
1522520512,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Int32[4]
{
1624204662,
521440996,
855158401,
500772913,
},
    NullableValue = 
new System.Int32[4]
{
985806200,
464748346,
2026943846,
1621610601,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 149,
    Value = 
new System.Int32[4]
{
870410180,
1634189064,
588148023,
882582789,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 158,
    Value = 
new System.Int32[4]
{
2130843207,
1337017683,
673709942,
1065122948,
},
    NullableValue = 
new System.Int32[4]
{
1006214822,
421164291,
1183734265,
5697785,
},
},
    NullableValue = 
new System.Int32[4]
{
246895940,
498044237,
1234240593,
582217594,
},
},
            new Int32MArrayD1E1M
{
    Id = 154,
    Value = 
new System.Int32[3]
{
318154683,
1967278654,
612988962,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 159,
    Value = 
new System.Int32[3]
{
468266222,
1742684463,
106808025,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 159,
    Value = 
new System.Int32[4]
{
48834644,
1257842166,
1541275436,
1992796129,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Int32[3]
{
766237327,
473616856,
1839179766,
},
    NullableValue = 
new System.Int32[3]
{
1825920451,
1954663869,
1246408646,
},
},
    NullableValue = 
new System.Int32[3]
{
60418003,
217512311,
886181705,
},
},
            new Int32MArrayD1E1M
{
    Id = 164,
    Value = 
new System.Int32[4]
{
1986525496,
815283041,
806284784,
971476456,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 172,
    Value = 
new System.Int32[3]
{
1526002258,
1837894332,
262748824,
},
    NullableValue = 
new System.Int32[4]
{
1453339847,
1501273135,
271636128,
1055463147,
},
},
    NullableValue = 
new System.Int32[3]
{
50341951,
904448626,
864796650,
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




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
    internal partial interface IUInt32MArrayArrayUInt32
    {
    }
    
    internal partial class UInt32MArrayArrayUInt32 : IUInt32MArrayArrayUInt32
    {


#region TestData

        private readonly UInt32ArrayUInt32E1M[] _testData = new UInt32ArrayUInt32E1M[]
        {
            new UInt32ArrayUInt32E1M
{
    Id = 9,
    Value = 
new System.UInt32[3]
{
1011974564,
514048010,
3728092245,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 2,
    Value = 
new System.UInt32[4]
{
2153935974,
1450520929,
2596829548,
3129115802,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 14,
    Value = 
new System.UInt32[3]
{
2259998696,
3626185672,
2888502575,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 8,
    Value = 
new System.UInt32[3]
{
1300034126,
1716621639,
4227645413,
},
    NullableValue = 
new System.UInt32[4]
{
1884136890,
1624984452,
708052453,
3128898789,
},
},
    NullableValue = 
new System.UInt32[3]
{
3551832152,
1271182813,
4030627928,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 23,
    Value = 
new System.UInt32[4]
{
2528391843,
1209705270,
293642454,
1608429520,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 11,
    Value = 
new System.UInt32[4]
{
3147342878,
642606005,
845403050,
3267935116,
},
    NullableValue = 
new System.UInt32[3]
{
37558926,
3372195677,
2744793676,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 24,
    Value = 
new System.UInt32[4]
{
3887970074,
858342906,
3336403196,
3816134881,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 13,
    Value = 
new System.UInt32[3]
{
3560620322,
4018788782,
1377945897,
},
    NullableValue = 
new System.UInt32[4]
{
2071779516,
3147788942,
4201861630,
160360773,
},
},
    NullableValue = 
new System.UInt32[4]
{
2842050443,
463408879,
2082870318,
3750331265,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 28,
    Value = 
new System.UInt32[3]
{
3608154862,
1630316039,
3430368022,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 20,
    Value = 
new System.UInt32[3]
{
1837458002,
2150082007,
751010769,
},
    NullableValue = 
new System.UInt32[4]
{
2643502137,
3409034357,
1014081808,
2825765410,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 29,
    Value = 
new System.UInt32[3]
{
3259776735,
1548578341,
956175343,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 23,
    Value = 
new System.UInt32[4]
{
3148960719,
1405964094,
2011553848,
677897768,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1058162013,
737780099,
4283866468,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 32,
    Value = 
new System.UInt32[3]
{
727005427,
151616661,
95197381,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 27,
    Value = 
new System.UInt32[3]
{
4064807677,
176672256,
3457777272,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
398198366,
2626023242,
1472749628,
438551860,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 33,
    Value = 
new System.UInt32[3]
{
3020682755,
426614882,
1915468930,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 29,
    Value = 
new System.UInt32[4]
{
532810074,
2372923520,
654785679,
2238852466,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 40,
    Value = 
new System.UInt32[4]
{
2029449269,
3984535173,
4114393170,
88641614,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 30,
    Value = 
new System.UInt32[4]
{
2980715152,
2180205118,
4283817303,
2018587977,
},
    NullableValue = 
new System.UInt32[3]
{
2442305111,
2717553230,
3707433996,
},
},
    NullableValue = 
new System.UInt32[4]
{
1274318744,
1070324912,
777255938,
3099635640,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 47,
    Value = 
new System.UInt32[3]
{
4015090165,
2299794401,
2015978664,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 31,
    Value = 
new System.UInt32[4]
{
1833682420,
2495608565,
1647785396,
2558314801,
},
    NullableValue = 
new System.UInt32[3]
{
170083698,
764408393,
31819040,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 55,
    Value = 
new System.UInt32[3]
{
2072115268,
2056927574,
4086744515,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 38,
    Value = 
new System.UInt32[4]
{
1601911177,
1008167194,
3227662698,
743151434,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 57,
    Value = 
new System.UInt32[3]
{
449799669,
3677255126,
757320559,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 44,
    Value = 
new System.UInt32[3]
{
1635186740,
3228874101,
3472959661,
},
    NullableValue = 
new System.UInt32[3]
{
4120516898,
384453574,
2016801575,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 59,
    Value = 
new System.UInt32[4]
{
2592167250,
2184852828,
472603482,
2241226834,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 51,
    Value = 
new System.UInt32[4]
{
1823259634,
2015166807,
2675586319,
869516341,
},
    NullableValue = 
new System.UInt32[3]
{
1796460140,
1611625724,
1718408377,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 63,
    Value = 
new System.UInt32[3]
{
1467723805,
1358520524,
3216719466,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 57,
    Value = 
new System.UInt32[3]
{
1767371606,
1316324673,
5306604,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2779713826,
2935480593,
675671402,
2124758719,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 68,
    Value = 
new System.UInt32[3]
{
1312580074,
378367482,
601648755,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 58,
    Value = 
new System.UInt32[4]
{
195778226,
3214779722,
629523434,
1690256666,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 71,
    Value = 
new System.UInt32[3]
{
3711246585,
2171738130,
3418097371,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 62,
    Value = 
new System.UInt32[4]
{
1207792613,
2203592611,
2181927223,
1240099834,
},
    NullableValue = 
new System.UInt32[3]
{
667215975,
2725953705,
3518965190,
},
},
    NullableValue = 
new System.UInt32[3]
{
3662350318,
1044727772,
2380622492,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 78,
    Value = 
new System.UInt32[3]
{
461157913,
451630121,
3873159709,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 64,
    Value = 
new System.UInt32[4]
{
2666851426,
4253345973,
2597393134,
3009425543,
},
    NullableValue = 
new System.UInt32[3]
{
2756737957,
1072854339,
3303206628,
},
},
    NullableValue = 
new System.UInt32[3]
{
3116691969,
3949030766,
2242727010,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 82,
    Value = 
new System.UInt32[3]
{
912310988,
2161689774,
719925831,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 65,
    Value = 
new System.UInt32[4]
{
2893104604,
3429279019,
923004548,
2277813035,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 88,
    Value = 
new System.UInt32[3]
{
1857807670,
3868067627,
493316881,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 67,
    Value = 
new System.UInt32[4]
{
2016299046,
828466425,
1445255158,
1220773549,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2042938343,
3467925283,
1159232853,
4236807656,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 90,
    Value = 
new System.UInt32[4]
{
2708627664,
46138178,
1128311710,
2648054821,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 76,
    Value = 
new System.UInt32[4]
{
1580237352,
1771467040,
3371192025,
4210730133,
},
    NullableValue = 
new System.UInt32[4]
{
2438417706,
1522601905,
4105467023,
3973441490,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 92,
    Value = 
new System.UInt32[3]
{
1494151304,
3884207312,
3388218155,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 78,
    Value = 
new System.UInt32[3]
{
2567058440,
1061206215,
2945809032,
},
    NullableValue = 
new System.UInt32[3]
{
2976019965,
2965563001,
3766306976,
},
},
    NullableValue = 
new System.UInt32[4]
{
3261301781,
1968809703,
658951950,
1487561743,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 100,
    Value = 
new System.UInt32[3]
{
2700548536,
1315718443,
296055176,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 85,
    Value = 
new System.UInt32[3]
{
4186713353,
4107758475,
1367870753,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 107,
    Value = 
new System.UInt32[3]
{
2836764954,
1619416032,
2914435976,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 90,
    Value = 
new System.UInt32[3]
{
1653169872,
362431182,
3833688306,
},
    NullableValue = 
new System.UInt32[4]
{
2722385696,
2037895649,
791903189,
266347387,
},
},
    NullableValue = 
new System.UInt32[4]
{
3780891881,
2207198660,
3139530772,
2351928603,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 113,
    Value = 
new System.UInt32[4]
{
3105285366,
180493103,
1783223227,
3388601092,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 96,
    Value = 
new System.UInt32[4]
{
1757287176,
896612473,
1434896480,
3344673143,
},
    NullableValue = 
new System.UInt32[3]
{
2092612894,
1336458823,
2647933170,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 120,
    Value = 
new System.UInt32[3]
{
2814463916,
1816592136,
181424086,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 101,
    Value = 
new System.UInt32[3]
{
1172285058,
2720294575,
1315786222,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 123,
    Value = 
new System.UInt32[3]
{
2293159242,
1125170342,
1166973979,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 102,
    Value = 
new System.UInt32[3]
{
2680735756,
1603115422,
1227466508,
},
    NullableValue = 
new System.UInt32[3]
{
1710791954,
1709221106,
3054426529,
},
},
    NullableValue = 
new System.UInt32[4]
{
1587107504,
2297361577,
2041343840,
2019312686,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 127,
    Value = 
new System.UInt32[3]
{
2438365101,
678241429,
3147570352,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 109,
    Value = 
new System.UInt32[4]
{
714760807,
3135343172,
1686490244,
1465950119,
},
    NullableValue = 
new System.UInt32[4]
{
2594290613,
840988602,
1972488426,
2090529483,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 128,
    Value = 
new System.UInt32[4]
{
2131538158,
2601514780,
1735744746,
1966597722,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 113,
    Value = 
new System.UInt32[3]
{
3780084856,
4079680645,
250978042,
},
    NullableValue = 
new System.UInt32[4]
{
3615904060,
2015718424,
1129283740,
4099914753,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt32E1M
{
    Id = 136,
    Value = 
new System.UInt32[3]
{
3617872010,
4187531019,
3821887677,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 116,
    Value = 
new System.UInt32[3]
{
4161751527,
3590175672,
3391642805,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
11655245,
370297414,
3012234528,
3308616417,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 139,
    Value = 
new System.UInt32[4]
{
1146588797,
967797456,
3181320871,
3935006788,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 121,
    Value = 
new System.UInt32[3]
{
3507265865,
2102052676,
1876644490,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1325553694,
3819006910,
523571242,
2277468532,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 146,
    Value = 
new System.UInt32[4]
{
1906414701,
2905429272,
1774316151,
3806505254,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 129,
    Value = 
new System.UInt32[3]
{
968051977,
1485910021,
2809879820,
},
    NullableValue = 
new System.UInt32[4]
{
3396006117,
2629371099,
1725400303,
2922023071,
},
},
    NullableValue = 
new System.UInt32[4]
{
4207232585,
2997209306,
606475300,
3359951874,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 148,
    Value = 
new System.UInt32[4]
{
262908618,
3366709440,
3364488129,
2421227645,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 138,
    Value = 
new System.UInt32[4]
{
165979784,
129719905,
775725907,
3715897848,
},
    NullableValue = 
new System.UInt32[4]
{
2716474403,
1475767322,
2595842048,
1937189672,
},
},
    NullableValue = 
new System.UInt32[3]
{
1417665413,
1382413379,
3360904177,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 150,
    Value = 
new System.UInt32[4]
{
3637556478,
4158225524,
254235659,
3204864979,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 141,
    Value = 
new System.UInt32[3]
{
2938841221,
3092605602,
1264225057,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
2780306967,
2946882933,
1627636123,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 153,
    Value = 
new System.UInt32[4]
{
1062091029,
2637864813,
295806716,
3261120414,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 148,
    Value = 
new System.UInt32[3]
{
366828301,
3009825149,
126972661,
},
    NullableValue = 
new System.UInt32[3]
{
1468224912,
3893613923,
1140871653,
},
},
    NullableValue = 
new System.UInt32[3]
{
322164760,
1946196857,
170164198,
},
},
            new UInt32ArrayUInt32E1M
{
    Id = 158,
    Value = 
new System.UInt32[3]
{
2540960159,
651499419,
3961338307,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 153,
    Value = 
new System.UInt32[3]
{
4114180951,
84909010,
432804824,
},
    NullableValue = 
new System.UInt32[3]
{
140359920,
1066371861,
4175291426,
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
INSERT INTO gedaqtests.uint32arrayuint32e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt32)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt32)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayArrayUInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32[]), 
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
                    await ((IUInt32MArrayArrayUInt32)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32MArrayArrayUInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32arrayuint32e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32ArrayUInt32E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayArrayUInt32)),
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
                    var models = await ((IUInt32MArrayArrayUInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32ArrayUInt32E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32MArrayArrayUInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32ArrayUInt32E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


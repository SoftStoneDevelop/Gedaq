

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
    internal partial interface IUInt32MArrayMArrayD1
    {
    }
    
    internal partial class UInt32MArrayMArrayD1 : IUInt32MArrayMArrayD1
    {


#region TestData

        private readonly UInt32MArrayD1E1M[] _testData = new UInt32MArrayD1E1M[]
        {
            new UInt32MArrayD1E1M
{
    Id = 9,
    Value = 
new System.UInt32[3]
{
1326117332,
3225628559,
2360108297,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 5,
    Value = 
new System.UInt32[4]
{
3225677303,
1545101739,
2392204688,
1440579585,
},
    NullableValue = 
new System.UInt32[3]
{
3717828316,
3301221641,
1353837752,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 13,
    Value = 
new System.UInt32[4]
{
2933987151,
2228316321,
2379492442,
2299031678,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.UInt32[3]
{
3737678731,
4257564426,
1394825385,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 17,
    Value = 
new System.UInt32[4]
{
494291459,
382144709,
2832683248,
3263152030,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 15,
    Value = 
new System.UInt32[4]
{
3323529374,
1422321114,
4034409814,
1211564022,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 26,
    Value = 
new System.UInt32[4]
{
1509256590,
3984683793,
621698829,
1196309696,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 23,
    Value = 
new System.UInt32[4]
{
190032671,
1159621444,
2432802989,
3836615875,
},
    NullableValue = 
new System.UInt32[4]
{
1149891631,
1499050551,
2496334961,
2611916370,
},
},
    NullableValue = 
new System.UInt32[3]
{
1634583153,
4094554868,
4080561572,
},
},
            new UInt32MArrayD1E1M
{
    Id = 33,
    Value = 
new System.UInt32[4]
{
240406076,
3706009275,
633977398,
1639229381,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.UInt32[4]
{
1596650789,
236427539,
1016865664,
371059021,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1208550299,
3747498103,
953571811,
1540390187,
},
},
            new UInt32MArrayD1E1M
{
    Id = 38,
    Value = 
new System.UInt32[4]
{
1911067384,
2407031473,
4096088333,
1099676354,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.UInt32[4]
{
1986081832,
3998083125,
533627297,
1697660984,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1155646585,
4108952306,
1321284843,
2256171586,
},
},
            new UInt32MArrayD1E1M
{
    Id = 45,
    Value = 
new System.UInt32[3]
{
2439742661,
3342203030,
3674721896,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.UInt32[4]
{
1182050047,
1031346421,
2434428875,
2433538964,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 49,
    Value = 
new System.UInt32[4]
{
2532986401,
2873743544,
811707607,
4069382286,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt32[3]
{
3280366458,
3117817543,
2006508131,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 55,
    Value = 
new System.UInt32[4]
{
3808686706,
1204012208,
701890166,
3514792484,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.UInt32[3]
{
3194628625,
902389349,
895669662,
},
    NullableValue = 
new System.UInt32[3]
{
1181675376,
1849717724,
3622458952,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 63,
    Value = 
new System.UInt32[3]
{
2670439516,
2329839818,
1522562884,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.UInt32[4]
{
2677434067,
406343516,
3294814662,
1260660777,
},
    NullableValue = 
new System.UInt32[4]
{
3318557347,
1370005096,
2223490445,
800768612,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 64,
    Value = 
new System.UInt32[4]
{
675695518,
3721841529,
1951175057,
3085543950,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 61,
    Value = 
new System.UInt32[4]
{
1556331051,
1730870534,
1385556536,
3137320364,
},
    NullableValue = 
new System.UInt32[3]
{
532715179,
3858684742,
4189418498,
},
},
    NullableValue = 
new System.UInt32[3]
{
1036845890,
3624372715,
2448981689,
},
},
            new UInt32MArrayD1E1M
{
    Id = 71,
    Value = 
new System.UInt32[4]
{
1315662357,
1387080605,
1468444421,
93110544,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.UInt32[3]
{
165964056,
442816932,
3100396104,
},
    NullableValue = 
new System.UInt32[3]
{
3978433702,
1580444780,
2499144898,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 80,
    Value = 
new System.UInt32[4]
{
3324297818,
1707571634,
1064311283,
2706837727,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.UInt32[4]
{
1227567808,
2650170096,
2270311101,
314054538,
},
    NullableValue = 
new System.UInt32[4]
{
1638084303,
1124321874,
2768853330,
2312985177,
},
},
    NullableValue = 
new System.UInt32[4]
{
980823510,
274296726,
3630148862,
2970452539,
},
},
            new UInt32MArrayD1E1M
{
    Id = 83,
    Value = 
new System.UInt32[4]
{
693320696,
3015443578,
2068682847,
2655922989,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 68,
    Value = 
new System.UInt32[3]
{
2361943684,
379806125,
2488774629,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 90,
    Value = 
new System.UInt32[3]
{
3688319314,
606564348,
2282047980,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.UInt32[3]
{
2841040162,
405897790,
172265713,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 98,
    Value = 
new System.UInt32[4]
{
4096654144,
3871654446,
1544957610,
2416991397,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.UInt32[3]
{
2009713181,
2813819550,
1846006622,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 103,
    Value = 
new System.UInt32[4]
{
3846264294,
2741370028,
1450545204,
2635218941,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.UInt32[3]
{
4123202594,
823496874,
2650927263,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 104,
    Value = 
new System.UInt32[3]
{
3422970989,
3170834589,
208471279,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.UInt32[3]
{
1410564464,
4941190,
381400891,
},
    NullableValue = 
new System.UInt32[3]
{
3822806543,
2692575118,
325596878,
},
},
    NullableValue = 
new System.UInt32[3]
{
2261918510,
559892956,
3196331530,
},
},
            new UInt32MArrayD1E1M
{
    Id = 107,
    Value = 
new System.UInt32[3]
{
474636650,
814783246,
391520732,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.UInt32[4]
{
2847614359,
345957530,
400783283,
1971540796,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3652789913,
2150640195,
3049299930,
},
},
            new UInt32MArrayD1E1M
{
    Id = 112,
    Value = 
new System.UInt32[4]
{
1214399398,
1901599334,
1086836914,
1264241148,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.UInt32[4]
{
1045323121,
2424790586,
162838984,
3315260313,
},
    NullableValue = 
new System.UInt32[3]
{
1906678543,
3176253899,
1467233054,
},
},
    NullableValue = 
new System.UInt32[4]
{
1021601582,
1745221120,
3190502071,
2308210050,
},
},
            new UInt32MArrayD1E1M
{
    Id = 114,
    Value = 
new System.UInt32[3]
{
1256183547,
991822310,
446918446,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.UInt32[4]
{
532583806,
3138776573,
20518557,
3836992727,
},
    NullableValue = 
new System.UInt32[3]
{
2462780596,
3731302556,
2327222730,
},
},
    NullableValue = 
new System.UInt32[3]
{
1911899306,
3528642350,
3434431819,
},
},
            new UInt32MArrayD1E1M
{
    Id = 121,
    Value = 
new System.UInt32[3]
{
2635270787,
1558820316,
1241844493,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.UInt32[4]
{
861871093,
3356050038,
2806356197,
182727570,
},
    NullableValue = 
new System.UInt32[3]
{
1999565136,
3059646287,
3443246556,
},
},
    NullableValue = 
new System.UInt32[4]
{
1133129595,
1956400424,
419649655,
3164406283,
},
},
            new UInt32MArrayD1E1M
{
    Id = 127,
    Value = 
new System.UInt32[3]
{
3194171447,
3282310580,
2005520079,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 111,
    Value = 
new System.UInt32[3]
{
3588032900,
4223302660,
3101339001,
},
    NullableValue = 
new System.UInt32[4]
{
709355264,
2420121693,
3836670428,
3912652918,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 131,
    Value = 
new System.UInt32[4]
{
849275277,
2380231323,
2099116434,
2858241344,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.UInt32[4]
{
3112213480,
1080658092,
1550957748,
4035368509,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 140,
    Value = 
new System.UInt32[4]
{
4159204221,
2729937597,
2917676264,
4225375392,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.UInt32[3]
{
4110407822,
1071823423,
30216376,
},
    NullableValue = 
new System.UInt32[3]
{
2393548817,
1336016792,
3392795430,
},
},
    NullableValue = 
new System.UInt32[4]
{
80119070,
3558418831,
3372004297,
1694397568,
},
},
            new UInt32MArrayD1E1M
{
    Id = 143,
    Value = 
new System.UInt32[3]
{
2143416446,
2619940534,
4142536035,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 128,
    Value = 
new System.UInt32[3]
{
767825703,
2297678146,
589887982,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 149,
    Value = 
new System.UInt32[3]
{
2560444781,
4163626582,
3420313153,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.UInt32[4]
{
612762425,
958231075,
2738813363,
3339359578,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1423706586,
3654053716,
2480974204,
1833116279,
},
},
            new UInt32MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt32[4]
{
2272738439,
1657417082,
1196483417,
526403222,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 142,
    Value = 
new System.UInt32[4]
{
1536031676,
2424561939,
3376098098,
3630363000,
},
    NullableValue = 
new System.UInt32[4]
{
1848088843,
304527725,
3925031833,
2903915310,
},
},
    NullableValue = 
new System.UInt32[3]
{
616689655,
816849698,
4292307747,
},
},
            new UInt32MArrayD1E1M
{
    Id = 156,
    Value = 
new System.UInt32[3]
{
3071665194,
1577100282,
531321246,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.UInt32[3]
{
1153681229,
1065233113,
2780853072,
},
    NullableValue = 
new System.UInt32[4]
{
4005069323,
3943615945,
2574255819,
3166716948,
},
},
    NullableValue = 
new System.UInt32[4]
{
1137902602,
3448744856,
2874312958,
4199227976,
},
},
            new UInt32MArrayD1E1M
{
    Id = 162,
    Value = 
new System.UInt32[3]
{
3757408704,
4127566831,
2364261825,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.UInt32[4]
{
1371289221,
3392348951,
3482464633,
1641085901,
},
    NullableValue = 
new System.UInt32[3]
{
3068839291,
835397068,
1131202982,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 169,
    Value = 
new System.UInt32[4]
{
1525804318,
1450416407,
1860058736,
4235313580,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 158,
    Value = 
new System.UInt32[3]
{
1009580158,
4124912847,
2566401891,
},
    NullableValue = 
new System.UInt32[3]
{
3709161439,
1360379402,
874809636,
},
},
    NullableValue = 
new System.UInt32[3]
{
3438152360,
2468134289,
481083991,
},
},
            new UInt32MArrayD1E1M
{
    Id = 171,
    Value = 
new System.UInt32[3]
{
2526186573,
903883901,
1236037207,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 167,
    Value = 
new System.UInt32[4]
{
326452250,
2865919515,
340403642,
1069998250,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 172,
    Value = 
new System.UInt32[4]
{
2475901267,
3356048910,
3497417159,
720862063,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 175,
    Value = 
new System.UInt32[3]
{
1884810171,
3331747035,
1811139740,
},
    NullableValue = 
new System.UInt32[3]
{
3577048675,
694234874,
2264344812,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 180,
    Value = 
new System.UInt32[3]
{
4196110461,
1794425798,
1181022093,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 179,
    Value = 
new System.UInt32[3]
{
3576360971,
4259318284,
2936334260,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
2531300260,
1150193945,
3427679038,
},
},
            new UInt32MArrayD1E1M
{
    Id = 189,
    Value = 
new System.UInt32[4]
{
2674719319,
887516696,
2501738842,
484833559,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 182,
    Value = 
new System.UInt32[3]
{
3365803042,
1325204516,
3640848663,
},
    NullableValue = 
new System.UInt32[4]
{
253349924,
1339780601,
675295265,
1085025150,
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
INSERT INTO gedaqtests.uint32marrayd1e1m(
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
            asPartInterface: typeof(IUInt32MArrayMArrayD1)),
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
                    await ((IUInt32MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayMArrayD1)),
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
                    var models = await ((IUInt32MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


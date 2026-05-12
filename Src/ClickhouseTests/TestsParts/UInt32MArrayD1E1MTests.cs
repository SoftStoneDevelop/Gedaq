

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
    Id = 1,
    Value = 
new System.UInt32[3]
{
591674631,
3537686825,
2259220017,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.UInt32[3]
{
45717163,
3447079702,
1087276427,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 9,
    Value = 
new System.UInt32[4]
{
760751651,
237046796,
1880376840,
711760498,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.UInt32[4]
{
1049097532,
253200950,
210833056,
1797730757,
},
    NullableValue = 
new System.UInt32[4]
{
621268064,
2044414510,
1115326496,
1738336306,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 11,
    Value = 
new System.UInt32[4]
{
37402795,
4056570170,
547738112,
55727304,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.UInt32[3]
{
3057815488,
238755078,
3376471401,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
179680344,
4087242864,
1482920313,
2810810605,
},
},
            new UInt32MArrayD1E1M
{
    Id = 16,
    Value = 
new System.UInt32[4]
{
3767899970,
330101065,
506505718,
69384154,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 16,
    Value = 
new System.UInt32[3]
{
2735667908,
3095745549,
2658495079,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3180751997,
3959698194,
2852005097,
},
},
            new UInt32MArrayD1E1M
{
    Id = 20,
    Value = 
new System.UInt32[4]
{
1146201291,
519616158,
887675590,
1247625406,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.UInt32[4]
{
2574446385,
1676343809,
1686055686,
2985031354,
},
    NullableValue = 
new System.UInt32[4]
{
2200853993,
2431539997,
1587437454,
2220988868,
},
},
    NullableValue = 
new System.UInt32[3]
{
2473866057,
2752241731,
454609960,
},
},
            new UInt32MArrayD1E1M
{
    Id = 28,
    Value = 
new System.UInt32[3]
{
2919226870,
2299709253,
1174981886,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.UInt32[3]
{
3865955285,
1994374790,
394235519,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
4036079571,
785216330,
1249247039,
1586025260,
},
},
            new UInt32MArrayD1E1M
{
    Id = 37,
    Value = 
new System.UInt32[4]
{
2932340876,
2664055938,
1133103426,
1061270041,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.UInt32[4]
{
2655586630,
4072957636,
2235444974,
993776554,
},
    NullableValue = 
new System.UInt32[4]
{
3501973772,
1148523822,
3150922263,
2065407228,
},
},
    NullableValue = 
new System.UInt32[4]
{
1324566788,
2114707454,
968289720,
3777003495,
},
},
            new UInt32MArrayD1E1M
{
    Id = 42,
    Value = 
new System.UInt32[4]
{
3112012744,
208335157,
3952840122,
726334914,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 34,
    Value = 
new System.UInt32[3]
{
4067285274,
41372381,
3101357425,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3824717407,
3353208523,
3552868549,
},
},
            new UInt32MArrayD1E1M
{
    Id = 44,
    Value = 
new System.UInt32[4]
{
3419928081,
547808316,
3957385222,
512915983,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.UInt32[3]
{
1547547356,
3969112376,
1985134124,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3504945621,
3546474401,
2978028918,
},
},
            new UInt32MArrayD1E1M
{
    Id = 47,
    Value = 
new System.UInt32[3]
{
1965208672,
2908260990,
2344555728,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.UInt32[4]
{
892104745,
3491911443,
2856804612,
1368866490,
},
    NullableValue = 
new System.UInt32[4]
{
3958474572,
3549583189,
4139598305,
1660318176,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 52,
    Value = 
new System.UInt32[3]
{
4030545427,
3654270455,
4267250210,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 46,
    Value = 
new System.UInt32[4]
{
3123451421,
1781448816,
3309706679,
1149677444,
},
    NullableValue = 
new System.UInt32[4]
{
2474798206,
2093043338,
1145508751,
2571835842,
},
},
    NullableValue = 
new System.UInt32[4]
{
2445137516,
3719178641,
4178413238,
467778425,
},
},
            new UInt32MArrayD1E1M
{
    Id = 61,
    Value = 
new System.UInt32[4]
{
4066045138,
3151624114,
3914779316,
3530167585,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.UInt32[4]
{
2031233217,
3637049559,
1791232330,
1530853009,
},
    NullableValue = 
new System.UInt32[4]
{
1119613110,
346298703,
467777310,
1906977279,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 66,
    Value = 
new System.UInt32[4]
{
1047494502,
2260393840,
1512789828,
1232121680,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 56,
    Value = 
new System.UInt32[3]
{
1657888128,
139154648,
4223699319,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 68,
    Value = 
new System.UInt32[4]
{
3896177691,
3117643003,
4208897531,
1250714076,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 64,
    Value = 
new System.UInt32[4]
{
3432700387,
2459030477,
59798147,
2370057223,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 73,
    Value = 
new System.UInt32[3]
{
3621480127,
987685999,
913681897,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 73,
    Value = 
new System.UInt32[3]
{
933141929,
125637408,
1069126172,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 82,
    Value = 
new System.UInt32[4]
{
1100817867,
1730867155,
627192925,
1925329295,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.UInt32[3]
{
2994826333,
1482498393,
3807805600,
},
    NullableValue = 
new System.UInt32[4]
{
29731890,
2919197086,
2400346086,
182199992,
},
},
    NullableValue = 
new System.UInt32[3]
{
335490776,
4064703267,
864819292,
},
},
            new UInt32MArrayD1E1M
{
    Id = 91,
    Value = 
new System.UInt32[3]
{
2874234127,
1214519086,
4241910948,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 87,
    Value = 
new System.UInt32[3]
{
3131625565,
3690390706,
2709934618,
},
    NullableValue = 
new System.UInt32[4]
{
3457998066,
1876134389,
1804562914,
2960950545,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 96,
    Value = 
new System.UInt32[3]
{
2707943443,
4105558897,
1236684708,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.UInt32[3]
{
1004390095,
4113121748,
4208883423,
},
    NullableValue = 
new System.UInt32[4]
{
1282699809,
2593915520,
2793184439,
1800538328,
},
},
    NullableValue = 
new System.UInt32[3]
{
3127984165,
2010387928,
1243906754,
},
},
            new UInt32MArrayD1E1M
{
    Id = 101,
    Value = 
new System.UInt32[3]
{
331697990,
3920866711,
2634428572,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.UInt32[4]
{
967062766,
3698668465,
2934979985,
843390044,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
708249950,
1464601691,
1814821249,
},
},
            new UInt32MArrayD1E1M
{
    Id = 104,
    Value = 
new System.UInt32[3]
{
2403805852,
2122061254,
211778294,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.UInt32[4]
{
957084992,
4002364629,
3262175365,
1324286496,
},
    NullableValue = 
new System.UInt32[4]
{
3727272999,
3623479615,
3285405358,
2846726272,
},
},
    NullableValue = 
new System.UInt32[4]
{
646187347,
4014171300,
873183605,
1187876023,
},
},
            new UInt32MArrayD1E1M
{
    Id = 105,
    Value = 
new System.UInt32[3]
{
227453108,
4161495034,
4063504483,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.UInt32[4]
{
742985965,
3508307405,
1907446010,
1175183392,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
3293125604,
3980570651,
1084209270,
378453124,
},
},
            new UInt32MArrayD1E1M
{
    Id = 114,
    Value = 
new System.UInt32[4]
{
1882932637,
1630037562,
3893178329,
59928139,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 115,
    Value = 
new System.UInt32[4]
{
2505456782,
1064811362,
4093985865,
914261104,
},
    NullableValue = 
new System.UInt32[3]
{
381832608,
4140832850,
327928331,
},
},
    NullableValue = 
new System.UInt32[4]
{
2062746134,
1131119554,
786599391,
905558414,
},
},
            new UInt32MArrayD1E1M
{
    Id = 123,
    Value = 
new System.UInt32[4]
{
3495265719,
3078628616,
1059930131,
2738059093,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.UInt32[3]
{
2967464060,
1444018189,
3550311544,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 128,
    Value = 
new System.UInt32[3]
{
627976410,
2341985880,
2333334243,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.UInt32[3]
{
4270055809,
1621353458,
731882786,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3818396967,
2395411648,
2033658387,
},
},
            new UInt32MArrayD1E1M
{
    Id = 130,
    Value = 
new System.UInt32[3]
{
512789853,
1068183520,
3541757042,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.UInt32[3]
{
2516750627,
4029728080,
1269904622,
},
    NullableValue = 
new System.UInt32[4]
{
1724927900,
648791637,
1847421234,
3820663089,
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
296565665,
1924598770,
2874670799,
3402470954,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.UInt32[4]
{
1230197283,
2121939997,
1829528076,
3831653273,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 136,
    Value = 
new System.UInt32[3]
{
3877144691,
1108588460,
597052550,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.UInt32[3]
{
3075324977,
1790071498,
706313804,
},
    NullableValue = 
new System.UInt32[3]
{
3954917497,
1454998403,
3882245813,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 139,
    Value = 
new System.UInt32[4]
{
83334200,
3408708498,
2173210733,
3089851697,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.UInt32[4]
{
3385607966,
725877058,
652063190,
404266018,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 144,
    Value = 
new System.UInt32[3]
{
628144352,
4285259810,
2562247110,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 150,
    Value = 
new System.UInt32[3]
{
2843029084,
2614130257,
188862835,
},
    NullableValue = 
new System.UInt32[4]
{
2794322599,
3459484915,
4276896897,
1495747897,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 153,
    Value = 
new System.UInt32[4]
{
3204053869,
3620572957,
2208608048,
2894702087,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.UInt32[3]
{
1186079697,
1900673392,
2107487172,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 161,
    Value = 
new System.UInt32[3]
{
1591824919,
1866008644,
2913822556,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 161,
    Value = 
new System.UInt32[4]
{
2819667731,
581672161,
3098022433,
2857330184,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3153781280,
2618407201,
1578826568,
},
},
            new UInt32MArrayD1E1M
{
    Id = 164,
    Value = 
new System.UInt32[3]
{
1326738251,
1777521596,
2881610150,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.UInt32[3]
{
1725826206,
715669179,
749982548,
},
    NullableValue = 
new System.UInt32[4]
{
199233040,
541753097,
257983303,
90456666,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 172,
    Value = 
new System.UInt32[3]
{
260409120,
392529485,
547456682,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 170,
    Value = 
new System.UInt32[3]
{
855117494,
158486752,
2669387760,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 179,
    Value = 
new System.UInt32[3]
{
2049434899,
3810252215,
973733161,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 177,
    Value = 
new System.UInt32[3]
{
3417026544,
2407090103,
3790051114,
},
    NullableValue = 
new System.UInt32[3]
{
3059719053,
3874318762,
2354607665,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 182,
    Value = 
new System.UInt32[3]
{
2089796278,
3225319369,
1572148624,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 183,
    Value = 
new System.UInt32[3]
{
3503721930,
719606292,
3043728189,
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


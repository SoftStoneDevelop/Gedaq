

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
    Id = 7,
    Value = 
new System.UInt32[4]
{
2539667153,
3274681904,
3988426436,
3337211757,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 2,
    Value = 
new System.UInt32[4]
{
794487474,
3744000276,
3056441655,
2776688551,
},
    NullableValue = 
new System.UInt32[4]
{
3090646522,
3511652537,
902397239,
456322239,
},
},
    NullableValue = 
new System.UInt32[4]
{
3080889914,
234453927,
929232308,
2482717385,
},
},
            new UInt32MArrayD1E1M
{
    Id = 14,
    Value = 
new System.UInt32[4]
{
956447349,
1766348267,
38054931,
683928190,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 10,
    Value = 
new System.UInt32[3]
{
3010682527,
1319579750,
2195499349,
},
    NullableValue = 
new System.UInt32[4]
{
2742914149,
1908001423,
789631732,
2886543511,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 22,
    Value = 
new System.UInt32[4]
{
2815044873,
3908787366,
4095847437,
1249605432,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.UInt32[4]
{
4102427520,
2646297788,
4229795912,
2146354476,
},
    NullableValue = 
new System.UInt32[4]
{
150935942,
2255690736,
3316524631,
2461468567,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 29,
    Value = 
new System.UInt32[4]
{
2070088560,
98503458,
2959878039,
2013165722,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 17,
    Value = 
new System.UInt32[3]
{
1113009872,
1997105919,
4106144957,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 35,
    Value = 
new System.UInt32[3]
{
4217262650,
486030579,
3255216481,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.UInt32[4]
{
350411637,
3682303296,
2366139676,
2541315744,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 42,
    Value = 
new System.UInt32[4]
{
4068155465,
491638368,
723081898,
2957567834,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.UInt32[4]
{
1610024271,
1317738163,
856515049,
1054726447,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 47,
    Value = 
new System.UInt32[4]
{
1369928872,
790281162,
2745116489,
2819140927,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.UInt32[3]
{
123472087,
1962350437,
2901806508,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 56,
    Value = 
new System.UInt32[3]
{
3012493714,
2967508828,
989845896,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.UInt32[4]
{
636517564,
4286658971,
3328669044,
3474183964,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3880282897,
4065194719,
2012186528,
},
},
            new UInt32MArrayD1E1M
{
    Id = 61,
    Value = 
new System.UInt32[3]
{
689287219,
3944069395,
2157683616,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 42,
    Value = 
new System.UInt32[4]
{
1978130259,
653055805,
392056293,
161050096,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 66,
    Value = 
new System.UInt32[3]
{
4196044992,
1757293036,
2402303762,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 45,
    Value = 
new System.UInt32[4]
{
1478995487,
3292813940,
3138812050,
1909021561,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2169643046,
2755472004,
3786756403,
3419863923,
},
},
            new UInt32MArrayD1E1M
{
    Id = 70,
    Value = 
new System.UInt32[3]
{
4214525070,
267014119,
389527192,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 49,
    Value = 
new System.UInt32[4]
{
2035487555,
95050858,
3365143164,
990559034,
},
    NullableValue = 
new System.UInt32[4]
{
886024988,
4096521850,
4030127276,
3021566903,
},
},
    NullableValue = 
new System.UInt32[4]
{
4123269524,
3959996320,
3182162138,
3191932741,
},
},
            new UInt32MArrayD1E1M
{
    Id = 79,
    Value = 
new System.UInt32[3]
{
2142488621,
3164285750,
3009288799,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.UInt32[4]
{
3893866011,
767324917,
2308708443,
556654029,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 85,
    Value = 
new System.UInt32[4]
{
382981488,
2692035447,
512577014,
2633392662,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.UInt32[4]
{
4069810285,
316768627,
3953518392,
2245998854,
},
    NullableValue = 
new System.UInt32[3]
{
2993101700,
1377586881,
1330388082,
},
},
    NullableValue = 
new System.UInt32[3]
{
4089955659,
2574942285,
1233693490,
},
},
            new UInt32MArrayD1E1M
{
    Id = 93,
    Value = 
new System.UInt32[4]
{
4089083109,
1114530189,
3338009216,
430784430,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 75,
    Value = 
new System.UInt32[3]
{
1667242629,
446169713,
2793454541,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
230398189,
1286255537,
618057341,
1476500787,
},
},
            new UInt32MArrayD1E1M
{
    Id = 99,
    Value = 
new System.UInt32[3]
{
1832216214,
1177776675,
1520948366,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.UInt32[3]
{
3258685635,
1270948407,
1320620637,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 104,
    Value = 
new System.UInt32[4]
{
3970853817,
1492422036,
1712065106,
3675961413,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 85,
    Value = 
new System.UInt32[4]
{
944231884,
1294445496,
2961639649,
2388926043,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 111,
    Value = 
new System.UInt32[4]
{
3471917631,
3264550347,
3508048556,
2044648356,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.UInt32[3]
{
1577159358,
2862911792,
3084741554,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 117,
    Value = 
new System.UInt32[3]
{
3793657671,
2597154145,
1298959877,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.UInt32[4]
{
4033117521,
2771412153,
1963863005,
2363426548,
},
    NullableValue = 
new System.UInt32[3]
{
3584251512,
620290424,
1898132761,
},
},
    NullableValue = 
new System.UInt32[4]
{
1315060549,
4247435972,
3212690985,
3949610004,
},
},
            new UInt32MArrayD1E1M
{
    Id = 123,
    Value = 
new System.UInt32[3]
{
3789781484,
1373510304,
3287723715,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.UInt32[3]
{
1868349118,
4125501537,
762239188,
},
    NullableValue = 
new System.UInt32[3]
{
1220966805,
3038797791,
1416126578,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 129,
    Value = 
new System.UInt32[4]
{
1099499335,
1668563898,
646995261,
165570220,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.UInt32[3]
{
947040789,
2109841141,
6104343,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 137,
    Value = 
new System.UInt32[3]
{
1891043656,
1431917570,
3758026686,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 116,
    Value = 
new System.UInt32[3]
{
1760396632,
1790515299,
2411353555,
},
    NullableValue = 
new System.UInt32[4]
{
4148124575,
718700458,
1322889631,
1974509113,
},
},
    NullableValue = 
new System.UInt32[4]
{
2146994899,
52240260,
512352809,
3362624539,
},
},
            new UInt32MArrayD1E1M
{
    Id = 139,
    Value = 
new System.UInt32[3]
{
1588045710,
2149150152,
471680002,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.UInt32[3]
{
3951342970,
3607053686,
1269390397,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
2541798448,
1960537294,
1100451598,
},
},
            new UInt32MArrayD1E1M
{
    Id = 143,
    Value = 
new System.UInt32[4]
{
215976145,
3102293677,
2515299079,
1226200514,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 122,
    Value = 
new System.UInt32[4]
{
713448301,
4186578050,
1691509350,
2804833683,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 151,
    Value = 
new System.UInt32[4]
{
1774628655,
3041623220,
3226700197,
1534918292,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 131,
    Value = 
new System.UInt32[4]
{
1742039606,
3506362221,
3589181650,
3674104048,
},
    NullableValue = 
new System.UInt32[3]
{
4167401612,
488875763,
1840436941,
},
},
    NullableValue = 
new System.UInt32[4]
{
4008345178,
2749488964,
2515152167,
3793862939,
},
},
            new UInt32MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt32[4]
{
2492776600,
1606711200,
2721390065,
943484772,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.UInt32[3]
{
2951659237,
2426041462,
2532169588,
},
    NullableValue = 
new System.UInt32[3]
{
3408971849,
518671867,
1793133930,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 155,
    Value = 
new System.UInt32[3]
{
3476861410,
1906077586,
2873008129,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 138,
    Value = 
new System.UInt32[4]
{
1879508126,
3974035731,
902442366,
1208904362,
},
    NullableValue = 
new System.UInt32[3]
{
1490611143,
2874366494,
1860010086,
},
},
    NullableValue = 
new System.UInt32[4]
{
3716576694,
3550354046,
2907329813,
982149853,
},
},
            new UInt32MArrayD1E1M
{
    Id = 157,
    Value = 
new System.UInt32[4]
{
2028119218,
538187554,
1025419458,
4116232379,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.UInt32[4]
{
1273630167,
3947221471,
3939702249,
2746041276,
},
    NullableValue = 
new System.UInt32[4]
{
3410532217,
1132899575,
495058893,
1185189879,
},
},
    NullableValue = 
new System.UInt32[3]
{
1381025025,
3583986178,
2304445386,
},
},
            new UInt32MArrayD1E1M
{
    Id = 159,
    Value = 
new System.UInt32[4]
{
3211239858,
4039564646,
1770935511,
3667131087,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.UInt32[3]
{
3447869906,
585292554,
1254516227,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
490336918,
3639008752,
1541542663,
4131602678,
},
},
            new UInt32MArrayD1E1M
{
    Id = 160,
    Value = 
new System.UInt32[4]
{
2233308368,
1267279821,
3508278551,
4243041574,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.UInt32[3]
{
4157156286,
1859648168,
498816577,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1714938463,
1780603426,
4134490811,
},
},
            new UInt32MArrayD1E1M
{
    Id = 166,
    Value = 
new System.UInt32[4]
{
3856796931,
920098168,
382499775,
1531592854,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 160,
    Value = 
new System.UInt32[4]
{
1171323372,
3067012198,
4291260727,
2103685486,
},
    NullableValue = 
new System.UInt32[3]
{
2817506402,
3700015976,
2798916006,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 175,
    Value = 
new System.UInt32[4]
{
2705590099,
892769172,
1142092977,
3136500749,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.UInt32[3]
{
2782279709,
169736979,
2352341929,
},
    NullableValue = 
new System.UInt32[4]
{
1977528450,
2487195934,
611892391,
918589059,
},
},
    NullableValue = 
new System.UInt32[4]
{
1885224186,
315310280,
2730555558,
805249036,
},
},
            new UInt32MArrayD1E1M
{
    Id = 183,
    Value = 
new System.UInt32[3]
{
2049467190,
1206795188,
368766829,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 171,
    Value = 
new System.UInt32[3]
{
766981612,
146808686,
2603151735,
},
    NullableValue = 
new System.UInt32[4]
{
4226591778,
2996248177,
2691914835,
768198529,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 187,
    Value = 
new System.UInt32[3]
{
3589200769,
4035872232,
4077388929,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 175,
    Value = 
new System.UInt32[3]
{
875183324,
2997991837,
3501655287,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 188,
    Value = 
new System.UInt32[3]
{
3516264136,
1087899470,
665843829,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 177,
    Value = 
new System.UInt32[3]
{
2687933188,
2146144975,
2582076141,
},
    NullableValue = 
new System.UInt32[3]
{
764221082,
111609709,
3885332018,
},
},
    NullableValue = 
new System.UInt32[3]
{
854572630,
1081349517,
335830793,
},
},
            new UInt32MArrayD1E1M
{
    Id = 195,
    Value = 
new System.UInt32[3]
{
802821238,
2387275106,
2077625960,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 180,
    Value = 
new System.UInt32[3]
{
3300186355,
3990642717,
3920689179,
},
    NullableValue = 
new System.UInt32[3]
{
3987228728,
4010240057,
2746623666,
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


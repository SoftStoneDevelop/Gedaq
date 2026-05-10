

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
    internal partial interface IUInt32ArrayArrayUInt32
    {
    }
    
    internal partial class UInt32ArrayArrayUInt32 : IUInt32ArrayArrayUInt32
    {


#region TestData

        private readonly UInt32ArrayUInt321M[] _testData = new UInt32ArrayUInt321M[]
        {
            new UInt32ArrayUInt321M
{
    Id = 6,
    Value = 
new System.UInt32[3]
{
1302170085,
967767723,
1409307253,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 8,
    Value = 
new System.UInt32[4]
{
3738398298,
2599332743,
2020220642,
2503876187,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3666673257,
397154394,
3858794763,
},
},
            new UInt32ArrayUInt321M
{
    Id = 13,
    Value = 
new System.UInt32[3]
{
4195832456,
1742918423,
2978140345,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 9,
    Value = 
new System.UInt32[4]
{
1726032284,
2358215997,
2993382893,
3756411556,
},
    NullableValue = 
new System.UInt32[4]
{
3915488075,
2791855311,
1289327234,
1099655073,
},
},
    NullableValue = 
new System.UInt32[4]
{
14131203,
1656098794,
3684589884,
1575122808,
},
},
            new UInt32ArrayUInt321M
{
    Id = 19,
    Value = 
new System.UInt32[3]
{
3416891531,
2161820789,
143607602,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 11,
    Value = 
new System.UInt32[3]
{
2033164273,
2082028917,
2967013845,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
3107805915,
3598403483,
1643161631,
2127142448,
},
},
            new UInt32ArrayUInt321M
{
    Id = 28,
    Value = 
new System.UInt32[3]
{
828634952,
3614074607,
285690269,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 15,
    Value = 
new System.UInt32[4]
{
397918130,
189135062,
3470497558,
1576900082,
},
    NullableValue = 
new System.UInt32[3]
{
2172846520,
102513778,
3977429911,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 35,
    Value = 
new System.UInt32[3]
{
941035911,
1927071705,
984954953,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 23,
    Value = 
new System.UInt32[3]
{
1853242491,
500662360,
3196839452,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 41,
    Value = 
new System.UInt32[3]
{
3466061837,
692909750,
4166065573,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 26,
    Value = 
new System.UInt32[4]
{
2740389785,
45600003,
1041427771,
2224066390,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 48,
    Value = 
new System.UInt32[3]
{
3010804907,
584792566,
2975563160,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 29,
    Value = 
new System.UInt32[3]
{
3635831559,
2751619519,
4177203546,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
781329087,
532564462,
2865220961,
},
},
            new UInt32ArrayUInt321M
{
    Id = 56,
    Value = 
new System.UInt32[3]
{
2183794784,
2674487320,
557834856,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 32,
    Value = 
new System.UInt32[4]
{
3760055644,
3542394548,
3377025834,
2378248,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
962705194,
2639560068,
1655033397,
},
},
            new UInt32ArrayUInt321M
{
    Id = 62,
    Value = 
new System.UInt32[3]
{
3763689528,
191974337,
261275362,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 36,
    Value = 
new System.UInt32[4]
{
3695275023,
4146277725,
2438433727,
2954730971,
},
    NullableValue = 
new System.UInt32[4]
{
1225794169,
1420063678,
504955291,
224058503,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 65,
    Value = 
new System.UInt32[3]
{
4008396052,
278952694,
426602971,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 43,
    Value = 
new System.UInt32[4]
{
646490710,
2409520040,
1357607784,
3101959584,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 66,
    Value = 
new System.UInt32[3]
{
949042576,
2752014567,
994775321,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 47,
    Value = 
new System.UInt32[3]
{
2071046621,
1786545783,
4230333855,
},
    NullableValue = 
new System.UInt32[3]
{
535469548,
138741242,
2283791240,
},
},
    NullableValue = 
new System.UInt32[4]
{
3036702434,
2739005981,
1075118622,
90344855,
},
},
            new UInt32ArrayUInt321M
{
    Id = 69,
    Value = 
new System.UInt32[3]
{
4084669732,
3744130886,
771403784,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 56,
    Value = 
new System.UInt32[4]
{
2103590394,
2646583647,
756216899,
3528374273,
},
    NullableValue = 
new System.UInt32[3]
{
3819609252,
1533311698,
1065964703,
},
},
    NullableValue = 
new System.UInt32[4]
{
2648225095,
894124557,
3883729375,
2335955357,
},
},
            new UInt32ArrayUInt321M
{
    Id = 77,
    Value = 
new System.UInt32[3]
{
1897677030,
3847511763,
3753757791,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 65,
    Value = 
new System.UInt32[4]
{
2997651219,
2969628664,
3010796158,
2236658142,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 78,
    Value = 
new System.UInt32[3]
{
1394044822,
2288523256,
2190826119,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 71,
    Value = 
new System.UInt32[3]
{
80640512,
3381619476,
1613637849,
},
    NullableValue = 
new System.UInt32[4]
{
2852799574,
984786621,
4103900466,
320931355,
},
},
    NullableValue = 
new System.UInt32[3]
{
4258204530,
2304926790,
2904563759,
},
},
            new UInt32ArrayUInt321M
{
    Id = 84,
    Value = 
new System.UInt32[3]
{
2892602697,
1006362554,
2500359084,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 78,
    Value = 
new System.UInt32[4]
{
3304231253,
1737211092,
3570848453,
4192989603,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 92,
    Value = 
new System.UInt32[4]
{
4129639673,
1363968863,
830200783,
2840486729,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 85,
    Value = 
new System.UInt32[4]
{
2690563669,
477402899,
2475588114,
1865662145,
},
    NullableValue = 
new System.UInt32[3]
{
3008835767,
1923631026,
2399901128,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 99,
    Value = 
new System.UInt32[4]
{
3796121866,
3117959323,
1656928176,
909831248,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 89,
    Value = 
new System.UInt32[4]
{
1010797744,
1765069355,
807762337,
2577046451,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2986017588,
692198870,
2537779101,
2341179104,
},
},
            new UInt32ArrayUInt321M
{
    Id = 101,
    Value = 
new System.UInt32[4]
{
2984552276,
1921008379,
3651000939,
1968870937,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 94,
    Value = 
new System.UInt32[3]
{
4266398880,
4272524516,
1793471814,
},
    NullableValue = 
new System.UInt32[4]
{
3466967842,
480413575,
648656163,
185555093,
},
},
    NullableValue = 
new System.UInt32[4]
{
234736861,
1161044637,
1237998527,
2760680759,
},
},
            new UInt32ArrayUInt321M
{
    Id = 107,
    Value = 
new System.UInt32[3]
{
1674282629,
3607556062,
3322058281,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 100,
    Value = 
new System.UInt32[3]
{
766186356,
4072553615,
700032087,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
4260554473,
3792333878,
1635663973,
1484393895,
},
},
            new UInt32ArrayUInt321M
{
    Id = 113,
    Value = 
new System.UInt32[4]
{
3226158182,
3080559401,
1604500547,
300584190,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 101,
    Value = 
new System.UInt32[3]
{
4145964428,
425285387,
3580352746,
},
    NullableValue = 
new System.UInt32[3]
{
399330344,
1666761124,
2197676612,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 115,
    Value = 
new System.UInt32[3]
{
124449697,
3101575825,
1555996016,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 106,
    Value = 
new System.UInt32[3]
{
3634117805,
811017206,
3897808457,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
470188075,
419383195,
3304942591,
},
},
            new UInt32ArrayUInt321M
{
    Id = 123,
    Value = 
new System.UInt32[3]
{
532080233,
3305392812,
2139481753,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 113,
    Value = 
new System.UInt32[4]
{
2056039931,
2479822505,
2138211052,
1220586430,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
467923577,
2416332636,
1780180448,
2915685925,
},
},
            new UInt32ArrayUInt321M
{
    Id = 128,
    Value = 
new System.UInt32[4]
{
4270143179,
989117503,
2926756767,
3849344477,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 117,
    Value = 
new System.UInt32[4]
{
3507719968,
3660552763,
4155294280,
850562206,
},
    NullableValue = 
new System.UInt32[4]
{
1500797837,
3160800941,
1337860585,
2109201096,
},
},
    NullableValue = 
new System.UInt32[4]
{
3157102003,
1699400682,
1205477818,
1901238507,
},
},
            new UInt32ArrayUInt321M
{
    Id = 133,
    Value = 
new System.UInt32[3]
{
2567188041,
958054811,
2924549824,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 123,
    Value = 
new System.UInt32[3]
{
3101948474,
1273759038,
2797505741,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2447093755,
2658169188,
2995956938,
3099314904,
},
},
            new UInt32ArrayUInt321M
{
    Id = 136,
    Value = 
new System.UInt32[4]
{
2644294459,
3723097471,
1150341741,
894390874,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 131,
    Value = 
new System.UInt32[4]
{
4214668001,
4063761189,
103300358,
2945867728,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
4116727070,
2185558300,
109250331,
1899919787,
},
},
            new UInt32ArrayUInt321M
{
    Id = 141,
    Value = 
new System.UInt32[4]
{
2842826843,
4064044592,
3309279498,
2856400774,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 138,
    Value = 
new System.UInt32[3]
{
724988456,
1765278593,
294706248,
},
    NullableValue = 
new System.UInt32[4]
{
2812378496,
4047781373,
1308677409,
667102651,
},
},
    NullableValue = 
new System.UInt32[3]
{
1261955283,
4111047715,
1108588886,
},
},
            new UInt32ArrayUInt321M
{
    Id = 148,
    Value = 
new System.UInt32[3]
{
14168818,
501809098,
3127903506,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 142,
    Value = 
new System.UInt32[3]
{
1848173466,
3633881857,
2647643413,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1949329039,
4041127405,
1058536336,
1959403504,
},
},
            new UInt32ArrayUInt321M
{
    Id = 157,
    Value = 
new System.UInt32[4]
{
3066568135,
45906551,
2632184494,
3369776097,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 150,
    Value = 
new System.UInt32[4]
{
157185421,
3747230598,
2067447778,
809742813,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1398049697,
706448416,
939029910,
},
},
            new UInt32ArrayUInt321M
{
    Id = 165,
    Value = 
new System.UInt32[3]
{
2669031007,
3846624423,
4180117502,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 151,
    Value = 
new System.UInt32[4]
{
1050706893,
1580757668,
471871090,
2548888704,
},
    NullableValue = 
new System.UInt32[4]
{
2457909279,
2895355915,
1300900304,
588589480,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 172,
    Value = 
new System.UInt32[4]
{
1528474309,
3607513324,
4108543543,
321962956,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 160,
    Value = 
new System.UInt32[4]
{
2896658595,
3865092564,
3613265954,
2300434367,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 179,
    Value = 
new System.UInt32[4]
{
3812134840,
1251167518,
4222297011,
3443922301,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 165,
    Value = 
new System.UInt32[4]
{
1403241091,
4195478061,
3628344018,
1280991752,
},
    NullableValue = 
new System.UInt32[4]
{
513715604,
3821783606,
3830580904,
2471021408,
},
},
    NullableValue = 
new System.UInt32[4]
{
428948057,
4084240407,
2871794311,
1659194222,
},
},
            new UInt32ArrayUInt321M
{
    Id = 188,
    Value = 
new System.UInt32[4]
{
841358916,
2854449813,
4061147035,
2209977783,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 170,
    Value = 
new System.UInt32[4]
{
422156409,
3310315502,
463262298,
2863030737,
},
    NullableValue = 
new System.UInt32[4]
{
308910543,
2322682176,
3202580723,
1714001628,
},
},
    NullableValue = 
new System.UInt32[4]
{
4015502712,
2923328518,
2139460435,
1392390424,
},
},
            new UInt32ArrayUInt321M
{
    Id = 191,
    Value = 
new System.UInt32[4]
{
556798932,
1189583306,
3017133478,
3008439726,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 172,
    Value = 
new System.UInt32[4]
{
782908342,
1000189228,
3647593541,
674501455,
},
    NullableValue = 
new System.UInt32[4]
{
1986329906,
1295008384,
4026325061,
3815378241,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 194,
    Value = 
new System.UInt32[4]
{
3890360754,
2915053283,
433039270,
2029669064,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 177,
    Value = 
new System.UInt32[3]
{
2418659628,
161258798,
2862164332,
},
    NullableValue = 
new System.UInt32[4]
{
3604741782,
2883654951,
2644239467,
2641714707,
},
},
    NullableValue = null,
},
            new UInt32ArrayUInt321M
{
    Id = 196,
    Value = 
new System.UInt32[4]
{
485419927,
503718439,
1184938572,
3934421232,
},
    ModelInner = new UInt32ArrayUInt321MI
{
    Id = 179,
    Value = 
new System.UInt32[4]
{
588692194,
2862118258,
1395603876,
4074546161,
},
    NullableValue = 
new System.UInt32[3]
{
2915885243,
1008329072,
2567222304,
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
INSERT INTO gedaqtests.uint32arrayuint321m(
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
            asPartInterface: typeof(IUInt32ArrayArrayUInt32)),
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
                    await ((IUInt32ArrayArrayUInt32)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32ArrayArrayUInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32arrayuint321m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32ArrayUInt321M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32ArrayArrayUInt32)),
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
                    var models = await ((IUInt32ArrayArrayUInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32ArrayUInt321M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32ArrayArrayUInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32ArrayUInt321M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


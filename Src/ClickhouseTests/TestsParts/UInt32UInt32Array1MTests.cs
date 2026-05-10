

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
    internal partial interface IUInt32ArrayUInt32Array
    {
    }
    
    internal partial class UInt32ArrayUInt32Array : IUInt32ArrayUInt32Array
    {


#region TestData

        private readonly UInt32UInt32Array1M[] _testData = new UInt32UInt32Array1M[]
        {
            new UInt32UInt32Array1M
{
    Id = 2,
    Value = 
new System.UInt32[3]
{
1211576156,
1709362600,
714325021,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 2,
    Value = 
new System.UInt32[3]
{
1263685365,
617333451,
2419674479,
},
    NullableValue = 
new System.UInt32[4]
{
3814851865,
1816746676,
2780327575,
1319562371,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 9,
    Value = 
new System.UInt32[4]
{
4075291191,
3327628342,
4116478223,
3496172754,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 11,
    Value = 
new System.UInt32[3]
{
165924137,
3939108100,
2422831068,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 16,
    Value = 
new System.UInt32[3]
{
1983595374,
899899524,
1659741090,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 16,
    Value = 
new System.UInt32[3]
{
3571643829,
49607169,
1940890311,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 17,
    Value = 
new System.UInt32[4]
{
869436583,
2369514692,
2149346677,
598647962,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 19,
    Value = 
new System.UInt32[3]
{
1120447713,
2303253455,
1960014998,
},
    NullableValue = 
new System.UInt32[3]
{
3309339734,
3270570694,
862182226,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 25,
    Value = 
new System.UInt32[4]
{
328011074,
3452244318,
4105760067,
4027813068,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 23,
    Value = 
new System.UInt32[3]
{
1697342680,
514159425,
1955897329,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2726645379,
2407744739,
3582594022,
3362722840,
},
},
            new UInt32UInt32Array1M
{
    Id = 34,
    Value = 
new System.UInt32[3]
{
3373859077,
536263462,
722683997,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 27,
    Value = 
new System.UInt32[4]
{
4021663980,
3482508630,
1777520527,
865805535,
},
    NullableValue = 
new System.UInt32[3]
{
550296271,
3561172624,
1327586012,
},
},
    NullableValue = 
new System.UInt32[3]
{
1320904251,
2981796840,
485424596,
},
},
            new UInt32UInt32Array1M
{
    Id = 38,
    Value = 
new System.UInt32[4]
{
783895479,
1633234206,
277259543,
213491286,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 30,
    Value = 
new System.UInt32[3]
{
1160658087,
2369171787,
2859983496,
},
    NullableValue = 
new System.UInt32[3]
{
1351781777,
4009413260,
104693368,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 43,
    Value = 
new System.UInt32[4]
{
974300023,
4211488446,
2434262689,
283983973,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 34,
    Value = 
new System.UInt32[3]
{
749149096,
821349644,
478795171,
},
    NullableValue = 
new System.UInt32[3]
{
698837,
807798388,
370383107,
},
},
    NullableValue = 
new System.UInt32[4]
{
3288005704,
1790093598,
3872706394,
285144824,
},
},
            new UInt32UInt32Array1M
{
    Id = 51,
    Value = 
new System.UInt32[4]
{
2204380163,
2158725583,
4072967827,
696885276,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 35,
    Value = 
new System.UInt32[3]
{
2090464968,
1745403502,
1358051125,
},
    NullableValue = 
new System.UInt32[3]
{
1077208091,
175584753,
188597877,
},
},
    NullableValue = 
new System.UInt32[3]
{
2876495681,
2422333030,
1640300033,
},
},
            new UInt32UInt32Array1M
{
    Id = 59,
    Value = 
new System.UInt32[4]
{
1135818714,
103093833,
1534716172,
3085451078,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 39,
    Value = 
new System.UInt32[4]
{
1701972051,
1072258382,
570701906,
1879225257,
},
    NullableValue = 
new System.UInt32[4]
{
2065111078,
3202491697,
1491657875,
4068104234,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 65,
    Value = 
new System.UInt32[3]
{
3691372871,
4047007658,
4286604369,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 45,
    Value = 
new System.UInt32[4]
{
1463647441,
2700495846,
1009961021,
2733829305,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 72,
    Value = 
new System.UInt32[4]
{
2907228777,
2758520565,
337202657,
3092763246,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 53,
    Value = 
new System.UInt32[4]
{
4119598625,
290027884,
2130097482,
353097485,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 75,
    Value = 
new System.UInt32[3]
{
1446243097,
21658199,
1875099346,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 55,
    Value = 
new System.UInt32[3]
{
438055135,
192312111,
1686400939,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
3484731223,
392443028,
1651179864,
3257568626,
},
},
            new UInt32UInt32Array1M
{
    Id = 83,
    Value = 
new System.UInt32[4]
{
992139162,
3127027010,
2949992408,
1817571463,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 58,
    Value = 
new System.UInt32[4]
{
2847419023,
3184509911,
1808510731,
53441212,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
4233254729,
1906444310,
3963405116,
},
},
            new UInt32UInt32Array1M
{
    Id = 88,
    Value = 
new System.UInt32[3]
{
554284207,
3881658841,
2653518561,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 61,
    Value = 
new System.UInt32[4]
{
2920686546,
934751588,
233541170,
3920435796,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
4171735866,
844852174,
1748944940,
},
},
            new UInt32UInt32Array1M
{
    Id = 94,
    Value = 
new System.UInt32[3]
{
2456288585,
701999602,
3323926017,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 64,
    Value = 
new System.UInt32[3]
{
2894854017,
1876755219,
766825235,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1129291898,
3153019474,
2771148695,
4029962658,
},
},
            new UInt32UInt32Array1M
{
    Id = 97,
    Value = 
new System.UInt32[3]
{
316398175,
3248972831,
141030292,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 70,
    Value = 
new System.UInt32[3]
{
2577570551,
3287303571,
1863105866,
},
    NullableValue = 
new System.UInt32[4]
{
3517785937,
2092646124,
1956964011,
2256436835,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 102,
    Value = 
new System.UInt32[4]
{
1786731213,
4256443888,
933825125,
3121492912,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 78,
    Value = 
new System.UInt32[4]
{
701736466,
440359218,
3653291444,
2944147644,
},
    NullableValue = 
new System.UInt32[3]
{
787127063,
3065335395,
645163854,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 108,
    Value = 
new System.UInt32[3]
{
3276798990,
2333563946,
3345126527,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 84,
    Value = 
new System.UInt32[3]
{
3858808707,
4119201286,
4113750325,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
233280457,
127652855,
3867258025,
},
},
            new UInt32UInt32Array1M
{
    Id = 116,
    Value = 
new System.UInt32[4]
{
3961045775,
1022167935,
3160552985,
3754531061,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 85,
    Value = 
new System.UInt32[4]
{
1274304447,
1102532934,
2146162154,
1597244381,
},
    NullableValue = 
new System.UInt32[4]
{
4275860423,
2468493427,
1312164625,
3238210407,
},
},
    NullableValue = 
new System.UInt32[3]
{
1927590778,
3639054648,
3283772490,
},
},
            new UInt32UInt32Array1M
{
    Id = 121,
    Value = 
new System.UInt32[4]
{
2622499388,
2988395651,
326337440,
3792113222,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 89,
    Value = 
new System.UInt32[3]
{
150463160,
2768682830,
132552580,
},
    NullableValue = 
new System.UInt32[4]
{
3901076961,
546029708,
1065542547,
1421627524,
},
},
    NullableValue = 
new System.UInt32[4]
{
1375409941,
2353171649,
3228238805,
4044102848,
},
},
            new UInt32UInt32Array1M
{
    Id = 124,
    Value = 
new System.UInt32[4]
{
701068478,
3943733506,
735708390,
1308993751,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 94,
    Value = 
new System.UInt32[3]
{
285632650,
3477546451,
278633581,
},
    NullableValue = 
new System.UInt32[4]
{
4233027841,
415352243,
4182698717,
1535158341,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 132,
    Value = 
new System.UInt32[4]
{
725166856,
1578181457,
1254202081,
3451418523,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 95,
    Value = 
new System.UInt32[4]
{
218898901,
3384986324,
3543426027,
3146376077,
},
    NullableValue = 
new System.UInt32[3]
{
1791858789,
2133004169,
465053246,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 139,
    Value = 
new System.UInt32[4]
{
2307968362,
753049743,
2125932296,
3868004475,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 104,
    Value = 
new System.UInt32[3]
{
4166126014,
349177163,
1863791644,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 145,
    Value = 
new System.UInt32[4]
{
1766901503,
1175421899,
751208342,
2565142724,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 108,
    Value = 
new System.UInt32[4]
{
982982539,
3370509428,
3445685995,
2614524578,
},
    NullableValue = 
new System.UInt32[3]
{
2633747667,
1515159454,
3771624601,
},
},
    NullableValue = 
new System.UInt32[4]
{
1960131700,
4286885923,
11433571,
574938035,
},
},
            new UInt32UInt32Array1M
{
    Id = 151,
    Value = 
new System.UInt32[4]
{
2988921241,
4216972273,
3929833569,
1842950961,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 117,
    Value = 
new System.UInt32[4]
{
439071794,
1359568742,
3272029491,
2313970585,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1938701984,
22373419,
782853991,
4072523529,
},
},
            new UInt32UInt32Array1M
{
    Id = 154,
    Value = 
new System.UInt32[3]
{
2173775849,
1242084176,
3456936821,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 124,
    Value = 
new System.UInt32[3]
{
1384146205,
3752842286,
2529352084,
},
    NullableValue = 
new System.UInt32[3]
{
4139358870,
163521013,
2389158388,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 157,
    Value = 
new System.UInt32[4]
{
3495269290,
989567085,
1907375527,
3680751896,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 131,
    Value = 
new System.UInt32[4]
{
2102988758,
3242966826,
2320599761,
333589178,
},
    NullableValue = 
new System.UInt32[3]
{
1167546382,
3332975254,
1730254264,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 163,
    Value = 
new System.UInt32[4]
{
1955776107,
2476462452,
4247039793,
3774628071,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 137,
    Value = 
new System.UInt32[3]
{
1975214346,
1516373400,
2477914356,
},
    NullableValue = 
new System.UInt32[4]
{
2981226411,
3705955263,
950594008,
1555647995,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 169,
    Value = 
new System.UInt32[3]
{
1926294767,
158735062,
3428653123,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 138,
    Value = 
new System.UInt32[4]
{
2260535796,
3684009340,
2983354527,
1822688080,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 175,
    Value = 
new System.UInt32[4]
{
3560506685,
889206142,
3376117173,
3005481345,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 139,
    Value = 
new System.UInt32[3]
{
2436467970,
2751602098,
4110297891,
},
    NullableValue = 
new System.UInt32[3]
{
387934033,
2871831791,
3332059750,
},
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 180,
    Value = 
new System.UInt32[3]
{
1976454133,
1501859481,
1422154325,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 146,
    Value = 
new System.UInt32[4]
{
38515119,
2475460248,
2828154466,
1507113814,
},
    NullableValue = 
new System.UInt32[3]
{
552320251,
1229842564,
2490031918,
},
},
    NullableValue = 
new System.UInt32[3]
{
1932666676,
2028322967,
1250679220,
},
},
            new UInt32UInt32Array1M
{
    Id = 181,
    Value = 
new System.UInt32[3]
{
1977525116,
1671124768,
759155339,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 153,
    Value = 
new System.UInt32[4]
{
3476643297,
1818810375,
156886225,
3337900448,
},
    NullableValue = 
new System.UInt32[4]
{
1360585191,
1466598881,
3114331025,
472807234,
},
},
    NullableValue = 
new System.UInt32[3]
{
291487574,
1346387475,
2878969496,
},
},
            new UInt32UInt32Array1M
{
    Id = 186,
    Value = 
new System.UInt32[4]
{
2745215757,
1988020829,
2152816378,
1192226095,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 162,
    Value = 
new System.UInt32[3]
{
1024906978,
3814339515,
3646351321,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32Array1M
{
    Id = 195,
    Value = 
new System.UInt32[4]
{
2571310418,
2470165128,
1821845846,
3345400941,
},
    ModelInner = new UInt32UInt32Array1MI
{
    Id = 164,
    Value = 
new System.UInt32[4]
{
3808233006,
1325558074,
2423495468,
2144791906,
},
    NullableValue = 
new System.UInt32[3]
{
3266824249,
3853176425,
2187111771,
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
INSERT INTO gedaqtests.uint32uint32array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt32[]}, 
    {mi_id:Int32},
    {mi_value:UInt32[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32ArrayUInt32Array)),
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
                    await ((IUInt32ArrayUInt32Array)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32ArrayUInt32Array)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32uint32array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32UInt32Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32ArrayUInt32Array)),
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
                    var models = await ((IUInt32ArrayUInt32Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt32Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32ArrayUInt32Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt32Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


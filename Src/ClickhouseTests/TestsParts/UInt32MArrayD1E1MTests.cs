

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
    Id = 8,
    Value = 
new System.UInt32[3]
{
1767241566,
912094030,
810457728,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.UInt32[4]
{
2059187826,
4220878377,
4085885017,
170383660,
},
    NullableValue = 
new System.UInt32[4]
{
2923373025,
3407879601,
3649416726,
2995003195,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 15,
    Value = 
new System.UInt32[3]
{
2154296073,
2024746158,
410729800,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 10,
    Value = 
new System.UInt32[3]
{
2536124295,
1742301069,
3093474656,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 22,
    Value = 
new System.UInt32[3]
{
281068168,
2548279028,
2889043103,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.UInt32[3]
{
1003644106,
448070148,
2141012694,
},
    NullableValue = 
new System.UInt32[4]
{
2549573226,
640016551,
3973458672,
2827605281,
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
1751461331,
4043912231,
411949897,
2473024799,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.UInt32[4]
{
1230215446,
202935278,
1248122534,
3159872439,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 30,
    Value = 
new System.UInt32[4]
{
232282994,
534098616,
2801846675,
3745348594,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.UInt32[3]
{
1889905588,
189363398,
3086425252,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 34,
    Value = 
new System.UInt32[4]
{
3052624625,
4047758506,
114361933,
3808841356,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.UInt32[4]
{
2931357259,
339375185,
171100865,
2107209874,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
3307943137,
3655799834,
661420445,
2987082621,
},
},
            new UInt32MArrayD1E1M
{
    Id = 40,
    Value = 
new System.UInt32[3]
{
1331764739,
3705309807,
1507082503,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.UInt32[3]
{
963666903,
981293415,
1607121811,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1842196026,
4161660725,
3482339970,
1229547968,
},
},
            new UInt32MArrayD1E1M
{
    Id = 43,
    Value = 
new System.UInt32[4]
{
588975697,
1014345536,
3518147309,
1148957862,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.UInt32[4]
{
516279293,
2261235970,
695046590,
440173935,
},
    NullableValue = 
new System.UInt32[3]
{
1809585317,
2923986372,
2583948030,
},
},
    NullableValue = 
new System.UInt32[4]
{
1014712059,
1300404687,
3074138005,
3868047098,
},
},
            new UInt32MArrayD1E1M
{
    Id = 44,
    Value = 
new System.UInt32[3]
{
2770058150,
411366838,
2715813094,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 49,
    Value = 
new System.UInt32[4]
{
1567258475,
338223235,
2903354710,
1383084987,
},
    NullableValue = 
new System.UInt32[4]
{
1616745619,
4124737578,
2179670297,
3813541143,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 48,
    Value = 
new System.UInt32[3]
{
3869428710,
2931755964,
4005650306,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.UInt32[4]
{
3579297282,
3193565338,
208766610,
3291122719,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
541073266,
1289138344,
2041360209,
1954507567,
},
},
            new UInt32MArrayD1E1M
{
    Id = 54,
    Value = 
new System.UInt32[4]
{
1841930592,
3276417972,
3062801523,
2174076098,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.UInt32[3]
{
1232225771,
4289549090,
211621049,
},
    NullableValue = 
new System.UInt32[3]
{
3836989569,
3846048419,
1397020334,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 62,
    Value = 
new System.UInt32[3]
{
4015089654,
440315836,
643877469,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 59,
    Value = 
new System.UInt32[4]
{
2999170823,
1182426653,
1521957619,
2516920687,
},
    NullableValue = 
new System.UInt32[3]
{
3573718199,
2427952065,
1197136459,
},
},
    NullableValue = 
new System.UInt32[3]
{
193401982,
211036228,
2592167759,
},
},
            new UInt32MArrayD1E1M
{
    Id = 67,
    Value = 
new System.UInt32[4]
{
3455817982,
3054664216,
4059360207,
1080378505,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.UInt32[4]
{
3331016194,
1909559353,
1949858760,
4291409742,
},
    NullableValue = 
new System.UInt32[4]
{
4168052485,
1093533072,
3058328119,
2999185962,
},
},
    NullableValue = 
new System.UInt32[4]
{
2350955260,
1263220430,
3123441251,
4059870383,
},
},
            new UInt32MArrayD1E1M
{
    Id = 76,
    Value = 
new System.UInt32[4]
{
1556928533,
2277032659,
551240846,
170306953,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 63,
    Value = 
new System.UInt32[4]
{
2376084782,
1715655355,
1137052861,
2666631217,
},
    NullableValue = 
new System.UInt32[4]
{
862576167,
932572388,
3447233805,
3031164198,
},
},
    NullableValue = 
new System.UInt32[3]
{
3302322538,
2186754806,
3035009983,
},
},
            new UInt32MArrayD1E1M
{
    Id = 84,
    Value = 
new System.UInt32[3]
{
2294746644,
1351673241,
2183354999,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.UInt32[3]
{
2799020446,
2311512631,
2109643794,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 86,
    Value = 
new System.UInt32[4]
{
862011240,
244733860,
2921733546,
2594541653,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.UInt32[3]
{
385003177,
2071173573,
1350459519,
},
    NullableValue = 
new System.UInt32[3]
{
1948899032,
2005478419,
2917578064,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 90,
    Value = 
new System.UInt32[4]
{
2028241115,
3142135775,
3732345319,
128906359,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.UInt32[3]
{
3906038343,
3458040798,
1311222665,
},
    NullableValue = 
new System.UInt32[4]
{
3997315074,
4071092562,
1676097748,
2567714740,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 92,
    Value = 
new System.UInt32[4]
{
1943936335,
2769829184,
986866030,
3362277383,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.UInt32[3]
{
2614711057,
4195234362,
3208336380,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1034791337,
1770129738,
1682628178,
3089414430,
},
},
            new UInt32MArrayD1E1M
{
    Id = 93,
    Value = 
new System.UInt32[3]
{
3759913992,
727566972,
2819121526,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.UInt32[4]
{
4126886720,
1781576399,
719041908,
782866527,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 94,
    Value = 
new System.UInt32[3]
{
432079540,
542038289,
311678665,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 97,
    Value = 
new System.UInt32[4]
{
3204269978,
3953000231,
2091391131,
300090077,
},
    NullableValue = 
new System.UInt32[4]
{
165893918,
407140963,
2563216009,
4104364358,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 97,
    Value = 
new System.UInt32[4]
{
785206696,
3994165514,
3570610708,
1989801896,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 105,
    Value = 
new System.UInt32[4]
{
4062242315,
4286439494,
3907436181,
3166332551,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
615751760,
3441008934,
3134990446,
},
},
            new UInt32MArrayD1E1M
{
    Id = 105,
    Value = 
new System.UInt32[4]
{
1968635190,
3319211634,
613278584,
2777077083,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 111,
    Value = 
new System.UInt32[4]
{
755272956,
4178261107,
1758630957,
2864667986,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
848149176,
2643760151,
3507032516,
1965039575,
},
},
            new UInt32MArrayD1E1M
{
    Id = 107,
    Value = 
new System.UInt32[3]
{
3817897556,
400513729,
2799151294,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 112,
    Value = 
new System.UInt32[3]
{
467839814,
3327047930,
183433161,
},
    NullableValue = 
new System.UInt32[4]
{
163766284,
3587288647,
3822184955,
2450016095,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 108,
    Value = 
new System.UInt32[3]
{
3502640777,
2481674117,
4187536342,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 113,
    Value = 
new System.UInt32[3]
{
514397454,
2493329584,
360927143,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
4223509149,
485946389,
1291212323,
},
},
            new UInt32MArrayD1E1M
{
    Id = 116,
    Value = 
new System.UInt32[4]
{
3749774815,
1647874995,
503319922,
1082480640,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 121,
    Value = 
new System.UInt32[4]
{
237199150,
1948399175,
3011334925,
937502595,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1979866370,
2941784254,
3001661829,
3501714350,
},
},
            new UInt32MArrayD1E1M
{
    Id = 121,
    Value = 
new System.UInt32[4]
{
988989789,
388608082,
1781941205,
1487649663,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.UInt32[3]
{
3292026547,
3377231103,
3106781011,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2480449373,
3778060798,
2836016893,
3543851938,
},
},
            new UInt32MArrayD1E1M
{
    Id = 126,
    Value = 
new System.UInt32[3]
{
3164817006,
635903022,
595443276,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.UInt32[3]
{
3600817481,
1519217000,
588270610,
},
    NullableValue = 
new System.UInt32[4]
{
2688532009,
641447138,
1754927398,
3980860234,
},
},
    NullableValue = 
new System.UInt32[3]
{
3013287801,
1565680326,
903333371,
},
},
            new UInt32MArrayD1E1M
{
    Id = 135,
    Value = 
new System.UInt32[4]
{
3976845827,
1690760431,
2064740144,
2868479603,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.UInt32[4]
{
3600603076,
3675204682,
2688138644,
1346973351,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3938773626,
1344954758,
1620927932,
},
},
            new UInt32MArrayD1E1M
{
    Id = 137,
    Value = 
new System.UInt32[3]
{
7420639,
3906725648,
416295150,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.UInt32[4]
{
1730807285,
1774318660,
1934899524,
2285750465,
},
    NullableValue = 
new System.UInt32[3]
{
372425169,
3138666503,
4088021545,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 141,
    Value = 
new System.UInt32[4]
{
773703059,
3788296388,
4244860154,
2130797623,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.UInt32[3]
{
3084538962,
2322514523,
2823766497,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1445205078,
3241439683,
2382013886,
3552500618,
},
},
            new UInt32MArrayD1E1M
{
    Id = 148,
    Value = 
new System.UInt32[4]
{
2814923532,
2076893078,
4287764689,
3679317710,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.UInt32[3]
{
2377651116,
3952781546,
145543611,
},
    NullableValue = 
new System.UInt32[4]
{
3868130406,
4232324992,
2593332433,
3923129020,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 149,
    Value = 
new System.UInt32[4]
{
1279720075,
1493088618,
1296253060,
749766847,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.UInt32[3]
{
582091803,
2007117495,
1477418146,
},
    NullableValue = 
new System.UInt32[3]
{
1100366126,
3406131886,
3009904223,
},
},
    NullableValue = 
new System.UInt32[3]
{
715259342,
2599429066,
1927023533,
},
},
            new UInt32MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt32[4]
{
2172991846,
2318274574,
705593605,
1731534732,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 158,
    Value = 
new System.UInt32[3]
{
1505803995,
4033067340,
336102045,
},
    NullableValue = 
new System.UInt32[4]
{
3689036505,
4169494483,
1544548932,
2064281227,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 158,
    Value = 
new System.UInt32[3]
{
2971835246,
865934950,
1179591216,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 159,
    Value = 
new System.UInt32[4]
{
575027431,
4111155816,
2718409475,
2294628272,
},
    NullableValue = 
new System.UInt32[3]
{
2549129300,
449465518,
2255259083,
},
},
    NullableValue = 
new System.UInt32[4]
{
718692848,
3937082346,
1131661247,
2736439132,
},
},
            new UInt32MArrayD1E1M
{
    Id = 164,
    Value = 
new System.UInt32[3]
{
1169407184,
3069605221,
3899246530,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.UInt32[4]
{
3712810132,
2060330280,
188500381,
2743645476,
},
    NullableValue = 
new System.UInt32[4]
{
3738509384,
2935666273,
4066929169,
4053483460,
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


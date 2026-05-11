

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
new System.UInt32[3]
{
3942021177,
1183892373,
1492460354,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.UInt32[4]
{
3091931444,
1264731862,
3940385168,
1269491672,
},
    NullableValue = 
new System.UInt32[3]
{
947799341,
3892889499,
742529713,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 10,
    Value = 
new System.UInt32[4]
{
1711553897,
1406050834,
790364222,
2534953928,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 15,
    Value = 
new System.UInt32[3]
{
1926237120,
535148343,
1876766482,
},
    NullableValue = 
new System.UInt32[3]
{
2155945849,
519896864,
3796030539,
},
},
    NullableValue = 
new System.UInt32[3]
{
2246356068,
2398386868,
1817990701,
},
},
            new UInt32MArrayD1E1M
{
    Id = 11,
    Value = 
new System.UInt32[3]
{
1207726692,
1777025953,
2486578101,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.UInt32[3]
{
3999499394,
4244240460,
741553169,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
844087202,
1896816785,
741410421,
},
},
            new UInt32MArrayD1E1M
{
    Id = 19,
    Value = 
new System.UInt32[3]
{
2882128897,
3099054301,
575913269,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.UInt32[3]
{
3944184102,
3709635015,
2007892343,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
3847552727,
779626910,
2088057085,
4186820942,
},
},
            new UInt32MArrayD1E1M
{
    Id = 20,
    Value = 
new System.UInt32[3]
{
57672971,
1147930908,
3195233202,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.UInt32[3]
{
1616776427,
1537066786,
2895360602,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 23,
    Value = 
new System.UInt32[4]
{
3673801448,
949402399,
3420862404,
3325430669,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.UInt32[3]
{
1573561415,
2778963614,
4146914431,
},
    NullableValue = 
new System.UInt32[3]
{
3246095510,
3849246522,
402968471,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 30,
    Value = 
new System.UInt32[4]
{
2852596155,
1116410642,
2856861687,
2445194470,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 46,
    Value = 
new System.UInt32[3]
{
1985848359,
2027390069,
1595534480,
},
    NullableValue = 
new System.UInt32[3]
{
820706178,
854293160,
3943083686,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 36,
    Value = 
new System.UInt32[3]
{
4201826818,
2805245447,
3931142056,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt32[4]
{
1715831233,
2803764607,
859046723,
3330769811,
},
    NullableValue = 
new System.UInt32[4]
{
986897245,
3244088536,
554444768,
3928539948,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 44,
    Value = 
new System.UInt32[4]
{
4287509003,
2638025577,
3121746696,
2969294039,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.UInt32[3]
{
1311654039,
2698609295,
1676455309,
},
    NullableValue = 
new System.UInt32[4]
{
2538027731,
3239253964,
2906701874,
342630908,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 53,
    Value = 
new System.UInt32[4]
{
4186185892,
2822394462,
1746382717,
833405272,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.UInt32[4]
{
3879017793,
2407066947,
2675759485,
2620120320,
},
    NullableValue = 
new System.UInt32[4]
{
1549556464,
3733746634,
3032936894,
3884195458,
},
},
    NullableValue = 
new System.UInt32[3]
{
197263313,
3623415305,
894214144,
},
},
            new UInt32MArrayD1E1M
{
    Id = 58,
    Value = 
new System.UInt32[3]
{
919795889,
1350557640,
4212592226,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.UInt32[3]
{
1237394034,
1342558234,
2578860851,
},
    NullableValue = 
new System.UInt32[3]
{
1223414633,
2415985081,
2487401431,
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
11360267,
2217857857,
3890785110,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.UInt32[3]
{
3356016558,
1183298667,
1635697238,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
4029846363,
4034073606,
1818637718,
},
},
            new UInt32MArrayD1E1M
{
    Id = 71,
    Value = 
new System.UInt32[3]
{
1231478021,
1128181310,
3162645226,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.UInt32[3]
{
1561177987,
1260402496,
208230082,
},
    NullableValue = 
new System.UInt32[4]
{
2640840146,
3710133545,
36535723,
2329090205,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 78,
    Value = 
new System.UInt32[4]
{
3573101056,
2621142560,
964082386,
962128921,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.UInt32[4]
{
243869539,
1874032396,
282840966,
394233550,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2890335257,
2326490011,
2838527098,
2266685405,
},
},
            new UInt32MArrayD1E1M
{
    Id = 79,
    Value = 
new System.UInt32[4]
{
1943663643,
1204345241,
2500090305,
1097641729,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 88,
    Value = 
new System.UInt32[3]
{
1715381941,
2492698843,
2979744458,
},
    NullableValue = 
new System.UInt32[4]
{
2819980496,
1626715136,
582520897,
3667148780,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 88,
    Value = 
new System.UInt32[3]
{
4106317505,
3771520253,
459922519,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.UInt32[3]
{
767169315,
1053416174,
2580593911,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1474470323,
2838593931,
2248955264,
},
},
            new UInt32MArrayD1E1M
{
    Id = 91,
    Value = 
new System.UInt32[3]
{
3408376810,
552096203,
2107499958,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.UInt32[3]
{
2856852098,
4239072371,
4121928204,
},
    NullableValue = 
new System.UInt32[4]
{
639236895,
3918133267,
2476069196,
131144739,
},
},
    NullableValue = 
new System.UInt32[4]
{
2818857734,
477952015,
2703363055,
316912616,
},
},
            new UInt32MArrayD1E1M
{
    Id = 96,
    Value = 
new System.UInt32[3]
{
298613575,
952439882,
2996011936,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.UInt32[3]
{
2696112214,
2322876873,
1815916111,
},
    NullableValue = 
new System.UInt32[3]
{
3967208918,
4177375584,
864745045,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 105,
    Value = 
new System.UInt32[4]
{
810300267,
2362581120,
30588688,
3665516768,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 112,
    Value = 
new System.UInt32[3]
{
2307441242,
330670833,
106465065,
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
2978257219,
2096853661,
1102783467,
3712168803,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 121,
    Value = 
new System.UInt32[4]
{
3615808914,
1522650750,
3761659491,
301341363,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1715019490,
4183245077,
470976383,
},
},
            new UInt32MArrayD1E1M
{
    Id = 116,
    Value = 
new System.UInt32[4]
{
736951711,
906251949,
4160353130,
240010074,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.UInt32[4]
{
688657875,
2523996195,
4044502169,
3250941701,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 123,
    Value = 
new System.UInt32[3]
{
188895384,
2638802764,
147935480,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.UInt32[4]
{
1008592638,
1917438920,
2087331460,
2586210222,
},
    NullableValue = 
new System.UInt32[3]
{
1757831643,
1250980561,
1807250617,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 131,
    Value = 
new System.UInt32[3]
{
4148050991,
415190508,
2756313595,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.UInt32[3]
{
4113277847,
1909408257,
3033799015,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
2991626794,
164246314,
3293719429,
},
},
            new UInt32MArrayD1E1M
{
    Id = 137,
    Value = 
new System.UInt32[3]
{
1247996692,
1705546999,
2028965920,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.UInt32[4]
{
2762842836,
563705552,
867008090,
2614559090,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
2073022322,
1658164363,
1950200087,
},
},
            new UInt32MArrayD1E1M
{
    Id = 144,
    Value = 
new System.UInt32[4]
{
1215614063,
1877399040,
1997589572,
2769782111,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 137,
    Value = 
new System.UInt32[4]
{
1295365664,
1144299645,
3423593672,
1935749303,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1506492994,
3090583054,
3091650216,
},
},
            new UInt32MArrayD1E1M
{
    Id = 150,
    Value = 
new System.UInt32[3]
{
45475696,
1369146612,
2289777520,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 141,
    Value = 
new System.UInt32[3]
{
3574622394,
213973453,
3947350489,
},
    NullableValue = 
new System.UInt32[3]
{
391150168,
680781078,
156069308,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 156,
    Value = 
new System.UInt32[3]
{
1293990107,
896919906,
1098891567,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 145,
    Value = 
new System.UInt32[3]
{
3819945454,
3464778419,
2493617083,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 158,
    Value = 
new System.UInt32[3]
{
3767406108,
3107819889,
4003375338,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 148,
    Value = 
new System.UInt32[4]
{
1060208544,
3664282305,
2840333025,
4116139784,
},
    NullableValue = 
new System.UInt32[4]
{
1462978744,
1914952180,
945926203,
3014134465,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 160,
    Value = 
new System.UInt32[3]
{
28131500,
2384606898,
2381375501,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.UInt32[4]
{
809553028,
2091774611,
3937477670,
2909621448,
},
    NullableValue = 
new System.UInt32[3]
{
1254413448,
4208004148,
1329376708,
},
},
    NullableValue = 
new System.UInt32[4]
{
1812703432,
4127514355,
2641064661,
3390712547,
},
},
            new UInt32MArrayD1E1M
{
    Id = 161,
    Value = 
new System.UInt32[4]
{
983831886,
1338848273,
3055313680,
1914214306,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 150,
    Value = 
new System.UInt32[3]
{
279966839,
1677783247,
1484083520,
},
    NullableValue = 
new System.UInt32[3]
{
4104150670,
3143087672,
2111989451,
},
},
    NullableValue = 
new System.UInt32[3]
{
857515977,
43786000,
2265236525,
},
},
            new UInt32MArrayD1E1M
{
    Id = 162,
    Value = 
new System.UInt32[4]
{
3223437429,
671807098,
984575678,
2591483753,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.UInt32[3]
{
2843564856,
1752366933,
3355648387,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 163,
    Value = 
new System.UInt32[4]
{
1755693824,
2840984262,
4054863855,
2524624615,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 165,
    Value = 
new System.UInt32[4]
{
1615184264,
3287027929,
2277113691,
3404712615,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 167,
    Value = 
new System.UInt32[3]
{
4203650588,
3053791977,
780922350,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 166,
    Value = 
new System.UInt32[3]
{
444065993,
1751868535,
2618322614,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 176,
    Value = 
new System.UInt32[3]
{
3254334446,
3964471720,
2950707502,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 175,
    Value = 
new System.UInt32[4]
{
2464691363,
3365745512,
2155496512,
202021717,
},
    NullableValue = 
new System.UInt32[4]
{
4149345572,
3182980486,
3232613668,
2519051405,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 182,
    Value = 
new System.UInt32[4]
{
1583266737,
3405617662,
437205855,
1815543404,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 178,
    Value = 
new System.UInt32[3]
{
502784053,
1971433303,
3991055496,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
324138508,
3074605928,
4169806229,
},
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




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
4095161585,
3436972741,
557518577,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.UInt32[3]
{
804839091,
3497531091,
4021480642,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 10,
    Value = 
new System.UInt32[3]
{
573904134,
428581881,
2562537192,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.UInt32[4]
{
2351670673,
3474237887,
4061615056,
3154867279,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 19,
    Value = 
new System.UInt32[4]
{
2695682924,
2737487137,
1028713849,
2399100575,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.UInt32[4]
{
3508231374,
2680391619,
1805275135,
152139903,
},
    NullableValue = 
new System.UInt32[4]
{
2537144673,
1069178196,
784033634,
3766794892,
},
},
    NullableValue = 
new System.UInt32[3]
{
2396307104,
5558010,
596877406,
},
},
            new UInt32MArrayD1E1M
{
    Id = 28,
    Value = 
new System.UInt32[3]
{
1817885881,
434703576,
2629129505,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.UInt32[4]
{
2123825258,
2816457646,
2686723047,
1982664326,
},
    NullableValue = 
new System.UInt32[3]
{
3576341414,
1239986272,
1664261662,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 36,
    Value = 
new System.UInt32[4]
{
3595208682,
526949225,
798599987,
414980762,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.UInt32[4]
{
1133827826,
3689773118,
1609550861,
2763287954,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 41,
    Value = 
new System.UInt32[4]
{
3505275000,
2931943628,
461814291,
1654738553,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.UInt32[3]
{
471926308,
2660497197,
1843368445,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
419227266,
4271225170,
2712600404,
4007650377,
},
},
            new UInt32MArrayD1E1M
{
    Id = 45,
    Value = 
new System.UInt32[4]
{
3416691295,
3443352696,
2841404411,
2228903053,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.UInt32[4]
{
224840394,
2370822487,
735326484,
619197907,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 54,
    Value = 
new System.UInt32[3]
{
3485420500,
3038891280,
348737801,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 34,
    Value = 
new System.UInt32[3]
{
2162051020,
3167402943,
4151866359,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 57,
    Value = 
new System.UInt32[3]
{
3823760139,
1029829839,
3825470713,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 42,
    Value = 
new System.UInt32[3]
{
141584788,
3891265923,
606909889,
},
    NullableValue = 
new System.UInt32[3]
{
2762704272,
3470879573,
1716526200,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 58,
    Value = 
new System.UInt32[4]
{
3983742176,
3150001271,
685693326,
3333400368,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 43,
    Value = 
new System.UInt32[3]
{
389810245,
1200145961,
2813952105,
},
    NullableValue = 
new System.UInt32[3]
{
138695450,
1964709015,
2149652062,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 62,
    Value = 
new System.UInt32[4]
{
3057817163,
3591866102,
2579125270,
3519161508,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 46,
    Value = 
new System.UInt32[4]
{
1326458318,
2254220087,
4089273023,
1203757536,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1568871744,
2188710702,
2499121965,
},
},
            new UInt32MArrayD1E1M
{
    Id = 68,
    Value = 
new System.UInt32[3]
{
2444547020,
626805926,
1289164827,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.UInt32[3]
{
3194358895,
2635600475,
1223309420,
},
    NullableValue = 
new System.UInt32[4]
{
2976019362,
83013220,
3768160366,
962143602,
},
},
    NullableValue = 
new System.UInt32[4]
{
1831135183,
1237576648,
3854437362,
2851923090,
},
},
            new UInt32MArrayD1E1M
{
    Id = 74,
    Value = 
new System.UInt32[3]
{
1901128772,
2349626717,
1690232862,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.UInt32[3]
{
2489658758,
1655868568,
3419258665,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
2802465796,
2146242015,
3284534279,
1591485569,
},
},
            new UInt32MArrayD1E1M
{
    Id = 77,
    Value = 
new System.UInt32[3]
{
3790607991,
328015988,
3647277487,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.UInt32[4]
{
4129491295,
2842337229,
1484818363,
2897943814,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 85,
    Value = 
new System.UInt32[3]
{
2707703507,
1925318412,
2004895834,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.UInt32[3]
{
4213510312,
1865808243,
2007344802,
},
    NullableValue = 
new System.UInt32[3]
{
4083338940,
1180374917,
2847364216,
},
},
    NullableValue = 
new System.UInt32[3]
{
676142635,
2686250934,
4135003265,
},
},
            new UInt32MArrayD1E1M
{
    Id = 92,
    Value = 
new System.UInt32[4]
{
2348042188,
487820458,
2994735029,
385823915,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 61,
    Value = 
new System.UInt32[4]
{
1231401788,
4060620099,
3381261991,
2672169799,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 100,
    Value = 
new System.UInt32[3]
{
2118197161,
153915154,
2385437585,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.UInt32[3]
{
1683545153,
3239250225,
3113005733,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 109,
    Value = 
new System.UInt32[3]
{
3788283336,
1306398547,
242195633,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.UInt32[4]
{
809201406,
2478746965,
1166517652,
106737096,
},
    NullableValue = 
new System.UInt32[4]
{
2800373059,
1701860234,
578562344,
3894479225,
},
},
    NullableValue = 
new System.UInt32[3]
{
2314852113,
2608722648,
1422898776,
},
},
            new UInt32MArrayD1E1M
{
    Id = 116,
    Value = 
new System.UInt32[4]
{
2475590500,
4105308848,
3481122315,
2599411254,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.UInt32[4]
{
1864670856,
3586019706,
3295743655,
3467757999,
},
    NullableValue = 
new System.UInt32[3]
{
1447051800,
3513596298,
636495639,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 124,
    Value = 
new System.UInt32[4]
{
1826069716,
553665335,
4010214244,
3285450657,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.UInt32[4]
{
1886559849,
1563824257,
3034955089,
492156105,
},
    NullableValue = 
new System.UInt32[4]
{
1365091047,
2189233511,
1731262815,
2899055796,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 125,
    Value = 
new System.UInt32[4]
{
514259868,
3524974344,
3096934681,
2716712957,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.UInt32[4]
{
1643196104,
2227048396,
3222861957,
3081260110,
},
    NullableValue = 
new System.UInt32[3]
{
4155104492,
2601369274,
301916035,
},
},
    NullableValue = 
new System.UInt32[3]
{
2828621411,
928533009,
1174831560,
},
},
            new UInt32MArrayD1E1M
{
    Id = 131,
    Value = 
new System.UInt32[3]
{
3242781953,
273107549,
1359001232,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.UInt32[3]
{
4174937443,
532524856,
2122996939,
},
    NullableValue = 
new System.UInt32[4]
{
2017571512,
3321312223,
3085198910,
688877740,
},
},
    NullableValue = 
new System.UInt32[3]
{
2222988221,
3298624069,
2557236344,
},
},
            new UInt32MArrayD1E1M
{
    Id = 137,
    Value = 
new System.UInt32[4]
{
3099366226,
4252893628,
3354022036,
2804221977,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.UInt32[3]
{
491710010,
933636760,
872238940,
},
    NullableValue = 
new System.UInt32[3]
{
2916824379,
3153689486,
1301137657,
},
},
    NullableValue = 
new System.UInt32[3]
{
4129996305,
4167767666,
2904364365,
},
},
            new UInt32MArrayD1E1M
{
    Id = 138,
    Value = 
new System.UInt32[4]
{
3674410787,
3369064697,
1518424781,
2285887482,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 94,
    Value = 
new System.UInt32[3]
{
3607988073,
3610620912,
2537097085,
},
    NullableValue = 
new System.UInt32[4]
{
3206477608,
936264142,
3442845143,
914918388,
},
},
    NullableValue = 
new System.UInt32[3]
{
1115473750,
2530486430,
3888158477,
},
},
            new UInt32MArrayD1E1M
{
    Id = 142,
    Value = 
new System.UInt32[3]
{
2843456501,
1176047557,
408970408,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.UInt32[3]
{
2753864081,
1557658573,
2989133587,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
2784568135,
3163751372,
3759147861,
},
},
            new UInt32MArrayD1E1M
{
    Id = 145,
    Value = 
new System.UInt32[4]
{
1695965735,
300043212,
2424167015,
1519050555,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 102,
    Value = 
new System.UInt32[3]
{
3063405336,
3314094162,
704397356,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
2850084812,
1378207292,
2293230780,
},
},
            new UInt32MArrayD1E1M
{
    Id = 154,
    Value = 
new System.UInt32[4]
{
1069367722,
3342139869,
50475770,
3738086360,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.UInt32[4]
{
1099821517,
3728595982,
2825508491,
1801928085,
},
    NullableValue = 
new System.UInt32[3]
{
13164146,
2593725211,
4292182002,
},
},
    NullableValue = 
new System.UInt32[4]
{
2570246115,
4058829874,
1546540728,
1805186725,
},
},
            new UInt32MArrayD1E1M
{
    Id = 161,
    Value = 
new System.UInt32[3]
{
1363250820,
318284510,
1827730829,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.UInt32[4]
{
3914976231,
899286061,
1971156745,
2340617027,
},
    NullableValue = 
new System.UInt32[4]
{
2192700726,
3218628966,
2594654518,
4139000508,
},
},
    NullableValue = 
new System.UInt32[3]
{
163971032,
609364840,
4193129740,
},
},
            new UInt32MArrayD1E1M
{
    Id = 170,
    Value = 
new System.UInt32[4]
{
2452997759,
3310629849,
4232559862,
60653512,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 115,
    Value = 
new System.UInt32[3]
{
2480553041,
1892313419,
346025588,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1029275589,
2587335435,
2009948391,
},
},
            new UInt32MArrayD1E1M
{
    Id = 174,
    Value = 
new System.UInt32[3]
{
4272405139,
1510116024,
3532990150,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 117,
    Value = 
new System.UInt32[3]
{
1363360408,
2547032735,
3103143497,
},
    NullableValue = 
new System.UInt32[4]
{
2942965534,
95495704,
4184077944,
2429208385,
},
},
    NullableValue = 
new System.UInt32[3]
{
3111824700,
1748145100,
2298742183,
},
},
            new UInt32MArrayD1E1M
{
    Id = 182,
    Value = 
new System.UInt32[4]
{
619651081,
3272138496,
810980704,
3640983126,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.UInt32[3]
{
552115089,
2044428937,
2694538048,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 183,
    Value = 
new System.UInt32[3]
{
2916016546,
2337809070,
3926388038,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.UInt32[3]
{
622337513,
2599028355,
2035411803,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 187,
    Value = 
new System.UInt32[3]
{
3036269829,
1034112396,
3591565419,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.UInt32[4]
{
428977369,
1784293011,
1557751765,
3189518808,
},
    NullableValue = 
new System.UInt32[3]
{
2028533343,
3123390035,
1317113933,
},
},
    NullableValue = 
new System.UInt32[3]
{
4067579476,
2573497255,
3570080265,
},
},
            new UInt32MArrayD1E1M
{
    Id = 193,
    Value = 
new System.UInt32[3]
{
3659476737,
3119743793,
1028925524,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.UInt32[4]
{
1222349215,
2959615025,
643312306,
3045855523,
},
    NullableValue = 
new System.UInt32[4]
{
863238260,
1161697795,
729396165,
3808542713,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 201,
    Value = 
new System.UInt32[3]
{
2986354182,
576434076,
978226568,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 132,
    Value = 
new System.UInt32[4]
{
2866127998,
1129599105,
4014310079,
2647148362,
},
    NullableValue = 
new System.UInt32[3]
{
1987564861,
3712876679,
2784995459,
},
},
    NullableValue = 
new System.UInt32[3]
{
226621272,
1455180386,
2776733219,
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




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
    internal partial interface IUInt32MArrayMArrayD2
    {
    }
    
    internal partial class UInt32MArrayMArrayD2 : IUInt32MArrayMArrayD2
    {


#region TestData

        private readonly UInt32MArrayD2E1M[] _testData = new UInt32MArrayD2E1M[]
        {
            new UInt32MArrayD2E1M
{
    Id = 4,
    Value = 
new System.UInt32[,] { { 3147924427, 1101808856, }, { 396807059, 810342987, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 4,
    Value = 
new System.UInt32[,] { { 3216694830, 698026732, }, { 41288920, 3998068878, }, },
    NullableValue = 
new System.UInt32[,] { { 3432564713, 669326025, }, { 1916778519, 3637001717, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 11,
    Value = 
new System.UInt32[,] { { 1261917726, 2749828081, }, { 3081999275, 3286218363, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 13,
    Value = 
new System.UInt32[,] { { 2966385420, 810615295, }, { 3524809957, 3419336293, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2064300891, 3184518135, }, { 2429698574, 2936036191, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 13,
    Value = 
new System.UInt32[,] { { 431748340, 3873928376, }, { 1720948968, 3023831184, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.UInt32[,] { { 3058992499, 3154949543, }, { 2005444270, 1128829190, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1505415337, 2788052840, }, { 1962671395, 541910896, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 18,
    Value = 
new System.UInt32[,] { { 2099798048, 678244388, }, { 4141122996, 4093701217, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 20,
    Value = 
new System.UInt32[,] { { 2989000021, 3232651296, }, { 4154206154, 2140368863, }, },
    NullableValue = 
new System.UInt32[,] { { 2732599803, 1232248571, }, { 1778758033, 857400080, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 27,
    Value = 
new System.UInt32[,] { { 2887010981, 1438570865, }, { 317096514, 1366561067, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt32[,] { { 1038665287, 1551541838, }, { 4181849245, 4168450019, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 557194725, 3940473860, }, { 567750018, 3431450258, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 35,
    Value = 
new System.UInt32[,] { { 419590381, 103189662, }, { 4034894922, 334103914, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 26,
    Value = 
new System.UInt32[,] { { 2142135707, 1193070913, }, { 2390560484, 2960613568, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1996605267, 1052989534, }, { 3460812861, 3088070593, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 44,
    Value = 
new System.UInt32[,] { { 1836048334, 2944037758, }, { 3551867523, 1281550813, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.UInt32[,] { { 3685725073, 3996109591, }, { 4048241478, 1970349979, }, },
    NullableValue = 
new System.UInt32[,] { { 3627114588, 3082097459, }, { 3907460034, 4241807458, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1360364914, 1941069791, }, { 98591705, 822466005, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 47,
    Value = 
new System.UInt32[,] { { 3540033162, 1107874824, }, { 278226269, 735138300, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 32,
    Value = 
new System.UInt32[,] { { 3852851713, 1629007830, }, { 3936595552, 1640223154, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1829206505, 3585719891, }, { 862779125, 335989444, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 49,
    Value = 
new System.UInt32[,] { { 2211049199, 2141773101, }, { 1543529790, 3674123522, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.UInt32[,] { { 428749112, 3950790264, }, { 162313140, 3485307165, }, },
    NullableValue = 
new System.UInt32[,] { { 2006864448, 3547243742, }, { 628824714, 1107519727, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt32[,] { { 2054211791, 2496743206, }, { 1577400923, 102817089, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.UInt32[,] { { 3993514205, 3692571210, }, { 572989362, 1790588589, }, },
    NullableValue = 
new System.UInt32[,] { { 463465397, 268711435, }, { 268124377, 4003845578, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1686039053, 400897449, }, { 3078940612, 3664521447, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 58,
    Value = 
new System.UInt32[,] { { 395556182, 424382738, }, { 684382519, 2354570040, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 46,
    Value = 
new System.UInt32[,] { { 2643772237, 2696425727, }, { 3523413661, 612209714, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3879782872, 634758785, }, { 3284026663, 986611449, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 65,
    Value = 
new System.UInt32[,] { { 762221315, 3938857554, }, { 2542413008, 2162661591, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.UInt32[,] { { 1669617239, 1686870860, }, { 4097393756, 1232128567, }, },
    NullableValue = 
new System.UInt32[,] { { 626759361, 1806779517, }, { 2144908975, 4231885885, }, },
},
    NullableValue = 
new System.UInt32[,] { { 477292604, 798855472, }, { 1714425793, 2365170239, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 70,
    Value = 
new System.UInt32[,] { { 3473329984, 1881156868, }, { 304305487, 2619445544, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 53,
    Value = 
new System.UInt32[,] { { 2065125528, 1238210245, }, { 2998111164, 3500048170, }, },
    NullableValue = 
new System.UInt32[,] { { 985449042, 360567940, }, { 3276049695, 2779583101, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 74,
    Value = 
new System.UInt32[,] { { 4034757180, 497172633, }, { 1952729246, 1869134625, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.UInt32[,] { { 390053896, 568644488, }, { 2907276274, 899012512, }, },
    NullableValue = 
new System.UInt32[,] { { 3546839334, 3136563339, }, { 3351660455, 1477696653, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 81,
    Value = 
new System.UInt32[,] { { 1956980590, 776101916, }, { 3088116696, 52242426, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 59,
    Value = 
new System.UInt32[,] { { 3079552269, 1659641841, }, { 3312775622, 2973242605, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3961283068, 1433692767, }, { 272054616, 3602184012, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 86,
    Value = 
new System.UInt32[,] { { 1586650484, 1437992735, }, { 485571977, 3331626470, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 64,
    Value = 
new System.UInt32[,] { { 109117888, 51578319, }, { 2257237752, 445338060, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 90,
    Value = 
new System.UInt32[,] { { 3356989697, 4280896913, }, { 1550299643, 804312478, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 71,
    Value = 
new System.UInt32[,] { { 1469247217, 2127220641, }, { 624600865, 1216514113, }, },
    NullableValue = 
new System.UInt32[,] { { 1579632673, 3006146567, }, { 139970751, 3644685004, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 92,
    Value = 
new System.UInt32[,] { { 2976141091, 1637537096, }, { 2005274791, 372357332, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.UInt32[,] { { 457660276, 3487259631, }, { 3092358321, 2698797125, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 94,
    Value = 
new System.UInt32[,] { { 3539108183, 4179849623, }, { 1428300428, 2867368053, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.UInt32[,] { { 4066861211, 635573432, }, { 2549272365, 2284330091, }, },
    NullableValue = 
new System.UInt32[,] { { 1479967000, 477298328, }, { 3383115441, 2322997726, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 98,
    Value = 
new System.UInt32[,] { { 2139331245, 4009431834, }, { 87955145, 1310552091, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 82,
    Value = 
new System.UInt32[,] { { 3724245345, 586105944, }, { 947637433, 1444744551, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 100,
    Value = 
new System.UInt32[,] { { 1091733406, 2351127167, }, { 2780105089, 1568585367, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.UInt32[,] { { 3601874226, 2453175719, }, { 3560095002, 3815234989, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1513027861, 3716867427, }, { 2660133849, 1632692511, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 106,
    Value = 
new System.UInt32[,] { { 843562658, 3265632247, }, { 225241847, 1433944458, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.UInt32[,] { { 1818042867, 1948799901, }, { 601756998, 3983588574, }, },
    NullableValue = 
new System.UInt32[,] { { 161697339, 2014953613, }, { 1580881362, 2360910466, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 108,
    Value = 
new System.UInt32[,] { { 413587797, 103819727, }, { 2992341172, 1156327715, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 93,
    Value = 
new System.UInt32[,] { { 3517727104, 3540571394, }, { 423489570, 3722330634, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 308572940, 2921929122, }, { 3544321522, 595991620, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 117,
    Value = 
new System.UInt32[,] { { 3381817506, 4069187763, }, { 1746966154, 3004250395, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 99,
    Value = 
new System.UInt32[,] { { 1353130207, 1242404116, }, { 408740975, 640993401, }, },
    NullableValue = 
new System.UInt32[,] { { 1114066277, 3593312901, }, { 1332727580, 1344323874, }, },
},
    NullableValue = 
new System.UInt32[,] { { 746328654, 3000611741, }, { 772736643, 1553942808, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 118,
    Value = 
new System.UInt32[,] { { 714283308, 1116375467, }, { 138540775, 1320491714, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.UInt32[,] { { 3875980003, 3811784744, }, { 2379057468, 3361624999, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 125,
    Value = 
new System.UInt32[,] { { 3899837146, 1272055691, }, { 3755084618, 3948614174, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 116,
    Value = 
new System.UInt32[,] { { 2705922994, 2557045897, }, { 2110234681, 2941429106, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 134,
    Value = 
new System.UInt32[,] { { 3496642223, 752304016, }, { 4083564178, 103049418, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 117,
    Value = 
new System.UInt32[,] { { 3390602450, 509296731, }, { 2858656392, 374808960, }, },
    NullableValue = 
new System.UInt32[,] { { 3808656718, 1896105481, }, { 3124556002, 3893193390, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3051121588, 3394625836, }, { 2245516004, 2198685169, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 139,
    Value = 
new System.UInt32[,] { { 1971829036, 965013579, }, { 2972477776, 177853585, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.UInt32[,] { { 3415114903, 2698553706, }, { 413955949, 2140857205, }, },
    NullableValue = 
new System.UInt32[,] { { 4234882760, 1771124630, }, { 529777436, 2212308218, }, },
},
    NullableValue = 
new System.UInt32[,] { { 84452451, 467376506, }, { 3645801768, 3189564796, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 144,
    Value = 
new System.UInt32[,] { { 2460402548, 1030949377, }, { 3679058653, 1305849981, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 127,
    Value = 
new System.UInt32[,] { { 2302034955, 1915431178, }, { 2370046315, 1275334167, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1244963918, 1296865740, }, { 3239026265, 2192856388, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 152,
    Value = 
new System.UInt32[,] { { 1678235988, 1398279476, }, { 4170964696, 3543473296, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.UInt32[,] { { 2522725588, 3672785328, }, { 2544552832, 3039596428, }, },
    NullableValue = 
new System.UInt32[,] { { 900754496, 3976049386, }, { 2988982300, 1811058279, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1066525337, 1956065783, }, { 1050171587, 448575368, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 157,
    Value = 
new System.UInt32[,] { { 371524110, 1981703283, }, { 543565055, 867183566, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 138,
    Value = 
new System.UInt32[,] { { 360005583, 2626613049, }, { 785697704, 1720160301, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2983576765, 624078577, }, { 1686664933, 1050706772, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 158,
    Value = 
new System.UInt32[,] { { 1130916638, 3181769717, }, { 1283876894, 998474639, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.UInt32[,] { { 3359674930, 1565364128, }, { 2757852537, 3837050487, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 936852032, 2185839780, }, { 1846022390, 2719842946, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 167,
    Value = 
new System.UInt32[,] { { 141650310, 765381509, }, { 3662844829, 4018720519, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.UInt32[,] { { 2739835056, 1980711563, }, { 216145952, 4176378480, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3563964565, 680968203, }, { 835718534, 259597106, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 172,
    Value = 
new System.UInt32[,] { { 2538807464, 3889242867, }, { 2573619166, 3968163196, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.UInt32[,] { { 3750386602, 1431235324, }, { 96152594, 2430393465, }, },
    NullableValue = 
new System.UInt32[,] { { 1427563044, 2364721874, }, { 2915969234, 4198099819, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 174,
    Value = 
new System.UInt32[,] { { 691519845, 3335329755, }, { 52782574, 2193076570, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.UInt32[,] { { 1912894222, 2326170131, }, { 2782745802, 521681367, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3983026994, 1219482159, }, { 3390647938, 73972472, }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint32marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt32))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt32))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32[,]), 
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
                    await ((IUInt32MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayMArrayD2)),
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
                    var models = await ((IUInt32MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


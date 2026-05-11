

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
    Id = 7,
    Value = 
new System.UInt32[,] { { 2889993954, 3646582188, }, { 1679896408, 341127877, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 4,
    Value = 
new System.UInt32[,] { { 3985080074, 3915473498, }, { 480846047, 1086525791, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 10,
    Value = 
new System.UInt32[,] { { 201802594, 3326403741, }, { 3684848841, 2344028668, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.UInt32[,] { { 3790120436, 3067539555, }, { 930287214, 1704336004, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 11,
    Value = 
new System.UInt32[,] { { 3147857129, 2737801479, }, { 3154411213, 502350252, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.UInt32[,] { { 3216738593, 3750510124, }, { 2627317399, 4100629022, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 16,
    Value = 
new System.UInt32[,] { { 3985434889, 3724251125, }, { 3108517637, 2118061729, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.UInt32[,] { { 2238765006, 1771713441, }, { 3115248323, 3416156007, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1689666811, 2660103609, }, { 293587744, 2010756271, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 23,
    Value = 
new System.UInt32[,] { { 4115115761, 3153875365, }, { 579777792, 528286031, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.UInt32[,] { { 183297446, 4194758920, }, { 3818852645, 2436168137, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1838046656, 2866337947, }, { 606112643, 3966965996, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 28,
    Value = 
new System.UInt32[,] { { 2907146932, 3789480986, }, { 3630961355, 1663031348, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.UInt32[,] { { 2875253529, 3980212789, }, { 498089477, 3467218934, }, },
    NullableValue = 
new System.UInt32[,] { { 44318372, 3515036425, }, { 1603936923, 1933079448, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 36,
    Value = 
new System.UInt32[,] { { 1546603419, 2209040527, }, { 1956070646, 905841634, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.UInt32[,] { { 1622984388, 3667541851, }, { 1974877456, 228807313, }, },
    NullableValue = 
new System.UInt32[,] { { 966095135, 1468648452, }, { 928093494, 3557438518, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 38,
    Value = 
new System.UInt32[,] { { 543134007, 2047707051, }, { 1941158254, 1206742241, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.UInt32[,] { { 3489295405, 1207813050, }, { 3045892981, 2592190639, }, },
    NullableValue = 
new System.UInt32[,] { { 3747847680, 4054389679, }, { 1581209132, 2247476753, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3411821810, 260102745, }, { 1625586579, 2330275517, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 47,
    Value = 
new System.UInt32[,] { { 795696215, 2455885738, }, { 3222331921, 693578495, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.UInt32[,] { { 3335620046, 2618870705, }, { 507181757, 807705530, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3119926822, 3737541033, }, { 2721159054, 1732352281, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 56,
    Value = 
new System.UInt32[,] { { 1694580439, 1399491938, }, { 1921378283, 609995350, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.UInt32[,] { { 4180241911, 3846675391, }, { 1030119940, 838079650, }, },
    NullableValue = 
new System.UInt32[,] { { 2517177224, 2088930831, }, { 43989448, 741557375, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt32[,] { { 1889722118, 3904860262, }, { 2190126468, 66680439, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.UInt32[,] { { 2114315190, 2770515238, }, { 1766337086, 3929724572, }, },
    NullableValue = 
new System.UInt32[,] { { 145497913, 1817562540, }, { 1124575786, 3289086290, }, },
},
    NullableValue = 
new System.UInt32[,] { { 2829735606, 413446462, }, { 3786290385, 3540246993, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 62,
    Value = 
new System.UInt32[,] { { 298217465, 71246520, }, { 2533696927, 122477498, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.UInt32[,] { { 3839963197, 2872603413, }, { 2218477748, 620406973, }, },
    NullableValue = 
new System.UInt32[,] { { 1264839823, 1927218248, }, { 3774668596, 703204095, }, },
},
    NullableValue = 
new System.UInt32[,] { { 2685126925, 2735096849, }, { 3579975797, 889485182, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 67,
    Value = 
new System.UInt32[,] { { 2204832286, 4121242461, }, { 3861331255, 216796561, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.UInt32[,] { { 3851640962, 234519509, }, { 3402185401, 3400399195, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1218926328, 2120782881, }, { 3475606240, 2658710311, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 68,
    Value = 
new System.UInt32[,] { { 1024907620, 1899643108, }, { 2188980700, 981349457, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 61,
    Value = 
new System.UInt32[,] { { 452996993, 103763668, }, { 3071756080, 1056905550, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1781844890, 286907709, }, { 2485208006, 167120336, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 77,
    Value = 
new System.UInt32[,] { { 4161039836, 2547065092, }, { 1021042704, 2136560024, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 64,
    Value = 
new System.UInt32[,] { { 2774638169, 1073075593, }, { 3672868519, 1033959606, }, },
    NullableValue = 
new System.UInt32[,] { { 3755005949, 3731621051, }, { 1985151642, 318049603, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 80,
    Value = 
new System.UInt32[,] { { 2604633150, 3870555844, }, { 2875541185, 73813710, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.UInt32[,] { { 2089726081, 1517924651, }, { 3396375000, 2444251582, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3504226497, 3731888812, }, { 419385656, 3653608277, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 89,
    Value = 
new System.UInt32[,] { { 3754871295, 2756615153, }, { 2705788591, 1215652403, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 68,
    Value = 
new System.UInt32[,] { { 967818603, 2386212006, }, { 3493553667, 3310446414, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 90,
    Value = 
new System.UInt32[,] { { 259873639, 2589094817, }, { 857232123, 570735259, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.UInt32[,] { { 2329840743, 2738916725, }, { 1888164489, 1060612047, }, },
    NullableValue = 
new System.UInt32[,] { { 2770957307, 197527101, }, { 713606107, 3633631070, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 96,
    Value = 
new System.UInt32[,] { { 123332239, 2511909644, }, { 3011766149, 3899220523, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.UInt32[,] { { 3816623931, 289294535, }, { 2341432894, 1760780498, }, },
    NullableValue = 
new System.UInt32[,] { { 1925330527, 2152524789, }, { 2719336844, 3386955609, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 103,
    Value = 
new System.UInt32[,] { { 2420104737, 1496201895, }, { 3988196568, 4014542047, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 82,
    Value = 
new System.UInt32[,] { { 228980994, 1623743772, }, { 2711836326, 3492786416, }, },
    NullableValue = 
new System.UInt32[,] { { 1379531812, 1482605652, }, { 3494342655, 2994989374, }, },
},
    NullableValue = 
new System.UInt32[,] { { 557856000, 2585802370, }, { 2189607014, 2489556072, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 109,
    Value = 
new System.UInt32[,] { { 2353320339, 1380076889, }, { 378219764, 335577156, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 89,
    Value = 
new System.UInt32[,] { { 2146765743, 1568102288, }, { 2106927255, 2359220953, }, },
    NullableValue = 
new System.UInt32[,] { { 2002662642, 1251021936, }, { 2213246499, 1928466174, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1553647531, 3302513655, }, { 942730335, 3762576207, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 110,
    Value = 
new System.UInt32[,] { { 2649819197, 25257228, }, { 801956746, 4126505491, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 98,
    Value = 
new System.UInt32[,] { { 1039357993, 1145089103, }, { 3429292846, 3391365109, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 115,
    Value = 
new System.UInt32[,] { { 3206156348, 726849418, }, { 2254855446, 2658950510, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.UInt32[,] { { 1621975782, 3631561519, }, { 48519147, 2543066517, }, },
    NullableValue = 
new System.UInt32[,] { { 3219899446, 2612124078, }, { 194132970, 1665144496, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 124,
    Value = 
new System.UInt32[,] { { 3664735661, 995906412, }, { 51686051, 3952959881, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.UInt32[,] { { 948133690, 1486595145, }, { 3196524762, 1500880017, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 133,
    Value = 
new System.UInt32[,] { { 829234043, 2986772748, }, { 2541182838, 3006461141, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 114,
    Value = 
new System.UInt32[,] { { 3353046781, 3391652253, }, { 2236250450, 4221527306, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 137,
    Value = 
new System.UInt32[,] { { 91055352, 3994271550, }, { 2179192474, 2987386112, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.UInt32[,] { { 3789277078, 1245742183, }, { 463789887, 2415451519, }, },
    NullableValue = 
new System.UInt32[,] { { 2384062814, 3795731289, }, { 2275681057, 859693989, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 139,
    Value = 
new System.UInt32[,] { { 1030777196, 2509735627, }, { 1046910850, 4202992669, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 123,
    Value = 
new System.UInt32[,] { { 36239656, 2274023240, }, { 3626817286, 904858324, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3556953142, 385948020, }, { 4083527248, 2268915320, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 144,
    Value = 
new System.UInt32[,] { { 2920343173, 3871605248, }, { 3089842986, 4294372755, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.UInt32[,] { { 3092139005, 1336007338, }, { 1354762552, 349249063, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 999069716, 880798094, }, { 2519747701, 2744382333, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 147,
    Value = 
new System.UInt32[,] { { 211751743, 2092206697, }, { 1038585820, 221812468, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.UInt32[,] { { 3980754223, 2809385934, }, { 3878300276, 2543772477, }, },
    NullableValue = 
new System.UInt32[,] { { 1173330188, 2184293278, }, { 1126621926, 3140868408, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 151,
    Value = 
new System.UInt32[,] { { 2796169834, 69711181, }, { 3398539021, 216580646, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.UInt32[,] { { 1543076301, 4262590676, }, { 3538941174, 450390316, }, },
    NullableValue = 
new System.UInt32[,] { { 3241482572, 1292800867, }, { 1370984533, 2629541209, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 154,
    Value = 
new System.UInt32[,] { { 460685925, 3045803103, }, { 1624137046, 2223886927, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 150,
    Value = 
new System.UInt32[,] { { 660973777, 3827388264, }, { 2556629882, 50963159, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 159,
    Value = 
new System.UInt32[,] { { 940301023, 2565135415, }, { 2101645579, 1606240840, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.UInt32[,] { { 1184971158, 1439003134, }, { 3369372788, 2340188005, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 957137214, 2076664871, }, { 3421531226, 3753915369, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 163,
    Value = 
new System.UInt32[,] { { 2678887936, 3864509210, }, { 4000071848, 1351062863, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 159,
    Value = 
new System.UInt32[,] { { 3477965116, 718246968, }, { 2614614246, 3763759979, }, },
    NullableValue = 
new System.UInt32[,] { { 1994070762, 3752301670, }, { 1435586385, 557904942, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1262451489, 1291405958, }, { 651047219, 1621122195, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 170,
    Value = 
new System.UInt32[,] { { 3786614724, 2120903337, }, { 4064468427, 3309013656, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.UInt32[,] { { 1048758651, 1517806687, }, { 1843436661, 206677051, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 173,
    Value = 
new System.UInt32[,] { { 3713412728, 244449416, }, { 1593050870, 4043565826, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 169,
    Value = 
new System.UInt32[,] { { 2049639194, 1934995488, }, { 1733573995, 3051475891, }, },
    NullableValue = 
new System.UInt32[,] { { 1850304989, 1567019820, }, { 3177816096, 2169818635, }, },
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


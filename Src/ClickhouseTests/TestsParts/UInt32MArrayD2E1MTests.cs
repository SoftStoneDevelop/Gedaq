

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
new System.UInt32[,] { { 3299856007, 2092683203, }, { 406823058, 1389617176, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 3,
    Value = 
new System.UInt32[,] { { 1662883956, 3931439478, }, { 1791695654, 16412956, }, },
    NullableValue = 
new System.UInt32[,] { { 93069675, 666034110, }, { 2364479932, 475670983, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 12,
    Value = 
new System.UInt32[,] { { 711773290, 3977781690, }, { 2016959291, 1352909235, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.UInt32[,] { { 1618759206, 3960619291, }, { 1051981399, 3070691955, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1051212725, 327544532, }, { 431404666, 2300985383, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 21,
    Value = 
new System.UInt32[,] { { 1831615847, 4139396495, }, { 1259915603, 3730273109, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.UInt32[,] { { 1201133660, 2481457136, }, { 183022786, 4045822849, }, },
    NullableValue = 
new System.UInt32[,] { { 336126188, 1175615183, }, { 1518384243, 2209824945, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 29,
    Value = 
new System.UInt32[,] { { 3672652797, 3408030073, }, { 4140495137, 2673540376, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.UInt32[,] { { 2372339095, 3423138, }, { 1987764547, 761893285, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 36,
    Value = 
new System.UInt32[,] { { 494302999, 1478559942, }, { 1623928585, 2527054061, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.UInt32[,] { { 3985034336, 1679033931, }, { 4164573963, 3017027316, }, },
    NullableValue = 
new System.UInt32[,] { { 4094655815, 25961234, }, { 1733887949, 3075481137, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 38,
    Value = 
new System.UInt32[,] { { 2239078766, 2773826651, }, { 550500996, 1472625802, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.UInt32[,] { { 104033053, 1373448044, }, { 426675102, 3609445352, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 42,
    Value = 
new System.UInt32[,] { { 2216636798, 961676635, }, { 3178587681, 300078428, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.UInt32[,] { { 4012900531, 474146335, }, { 1645820903, 2356712048, }, },
    NullableValue = 
new System.UInt32[,] { { 199869975, 1343415578, }, { 3678798367, 466241118, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3374983371, 4278021216, }, { 1411729805, 1079618206, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 48,
    Value = 
new System.UInt32[,] { { 2540898713, 3877033804, }, { 1653601197, 2506668705, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 32,
    Value = 
new System.UInt32[,] { { 893449414, 2238902194, }, { 2115943056, 2179622713, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt32[,] { { 1901898829, 51873969, }, { 2130818257, 528454314, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.UInt32[,] { { 641558736, 3576036054, }, { 2723507222, 319794657, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3014374442, 1225666719, }, { 3325622304, 3638244957, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 63,
    Value = 
new System.UInt32[,] { { 1016438122, 2437631153, }, { 2144363630, 394753822, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt32[,] { { 2481183873, 1117804502, }, { 728999524, 685984490, }, },
    NullableValue = 
new System.UInt32[,] { { 505574796, 2565488443, }, { 2819167357, 3542106771, }, },
},
    NullableValue = 
new System.UInt32[,] { { 395715873, 49158672, }, { 193121510, 1657913703, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 72,
    Value = 
new System.UInt32[,] { { 87963390, 3087851356, }, { 4265868189, 95140604, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 47,
    Value = 
new System.UInt32[,] { { 2575372978, 3653253000, }, { 2936863229, 1155295532, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 73,
    Value = 
new System.UInt32[,] { { 2856412378, 1849527266, }, { 2809503707, 3342706367, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 52,
    Value = 
new System.UInt32[,] { { 1234179142, 412823016, }, { 3530973482, 3245874181, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 78,
    Value = 
new System.UInt32[,] { { 1104940558, 3806016835, }, { 2512680660, 2693436402, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.UInt32[,] { { 1651960066, 4133563768, }, { 1241404439, 2674912307, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 84,
    Value = 
new System.UInt32[,] { { 4130790697, 4215670058, }, { 3921205491, 1728931592, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.UInt32[,] { { 4204103648, 4022252044, }, { 2156271099, 2259542642, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 87,
    Value = 
new System.UInt32[,] { { 3742043492, 4061573025, }, { 1118600310, 3985126647, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.UInt32[,] { { 1467089799, 3460655410, }, { 3078277090, 2776314899, }, },
    NullableValue = 
new System.UInt32[,] { { 4237782312, 3691311795, }, { 2588149850, 4057083772, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1855338289, 1545696786, }, { 301491193, 2517202007, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 95,
    Value = 
new System.UInt32[,] { { 3083234472, 2525557159, }, { 3951879132, 202206916, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 66,
    Value = 
new System.UInt32[,] { { 2574515048, 3665245228, }, { 2945284464, 303411760, }, },
    NullableValue = 
new System.UInt32[,] { { 2598727663, 2196333698, }, { 1388303767, 885641083, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt32[,] { { 1043227425, 495421157, }, { 3868524023, 4293521013, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 71,
    Value = 
new System.UInt32[,] { { 1596832055, 4219650976, }, { 1453931339, 605413798, }, },
    NullableValue = 
new System.UInt32[,] { { 262042427, 3390633763, }, { 903693790, 3114906667, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1727495561, 4005353797, }, { 3751307069, 3125342777, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 107,
    Value = 
new System.UInt32[,] { { 240435531, 1984865965, }, { 2190528654, 1493050527, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.UInt32[,] { { 3187962209, 1822508040, }, { 3526846060, 735654196, }, },
    NullableValue = 
new System.UInt32[,] { { 263835468, 2334461430, }, { 4014940915, 4238947025, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 111,
    Value = 
new System.UInt32[,] { { 428667276, 2233330390, }, { 1170839297, 3348856018, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.UInt32[,] { { 2429313377, 1826146267, }, { 315480190, 1113733263, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 118,
    Value = 
new System.UInt32[,] { { 1196270680, 3935877569, }, { 2277905553, 957501206, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.UInt32[,] { { 3939131624, 1877932225, }, { 3000151395, 296047507, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 121,
    Value = 
new System.UInt32[,] { { 1495091463, 3870705332, }, { 1479126059, 466431669, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.UInt32[,] { { 2056684968, 429305143, }, { 395721593, 109972851, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 125,
    Value = 
new System.UInt32[,] { { 20428180, 3356473467, }, { 2847576796, 3659502222, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt32[,] { { 493449094, 2258590424, }, { 1270868896, 3979990339, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 294825682, 935288442, }, { 3241585955, 3989650056, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 131,
    Value = 
new System.UInt32[,] { { 114412186, 4212958306, }, { 492095250, 3033765348, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.UInt32[,] { { 1795672620, 3223201819, }, { 2631479327, 931411220, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 133,
    Value = 
new System.UInt32[,] { { 105173916, 2941965210, }, { 764314898, 608170117, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 97,
    Value = 
new System.UInt32[,] { { 1781286748, 2122996958, }, { 3182860745, 1739418727, }, },
    NullableValue = 
new System.UInt32[,] { { 3313502947, 221437936, }, { 3154487598, 4082171283, }, },
},
    NullableValue = 
new System.UInt32[,] { { 901463704, 1303804605, }, { 2899627566, 1430893367, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 140,
    Value = 
new System.UInt32[,] { { 4194770657, 2751186969, }, { 3081088651, 4275875308, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.UInt32[,] { { 2592827530, 2098576784, }, { 124257846, 2698659119, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2375904145, 1044213317, }, { 2520778118, 873953621, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 147,
    Value = 
new System.UInt32[,] { { 2699890126, 2499089377, }, { 2673446060, 1973081816, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 108,
    Value = 
new System.UInt32[,] { { 4043853170, 2666021169, }, { 4038489595, 2702950115, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 151,
    Value = 
new System.UInt32[,] { { 3537665206, 2461766294, }, { 1224704725, 2338613813, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 112,
    Value = 
new System.UInt32[,] { { 2356727856, 2954841432, }, { 1615521786, 3006569784, }, },
    NullableValue = 
new System.UInt32[,] { { 923031799, 1340963292, }, { 2044456424, 1139579086, }, },
},
    NullableValue = 
new System.UInt32[,] { { 741985779, 3807332888, }, { 1809761304, 1784111999, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 155,
    Value = 
new System.UInt32[,] { { 955492427, 2997931075, }, { 1471029380, 3447358145, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 114,
    Value = 
new System.UInt32[,] { { 2174206190, 2763156648, }, { 568118334, 2145199541, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 156,
    Value = 
new System.UInt32[,] { { 2336110506, 3534644883, }, { 3702789661, 136825843, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.UInt32[,] { { 34371588, 492808350, }, { 3621149825, 1419447091, }, },
    NullableValue = 
new System.UInt32[,] { { 2859028744, 3535675405, }, { 3823545407, 4276723997, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 164,
    Value = 
new System.UInt32[,] { { 3515004609, 2388295663, }, { 3826249716, 3798211256, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.UInt32[,] { { 1358429451, 2327224803, }, { 3700190348, 1935811820, }, },
    NullableValue = 
new System.UInt32[,] { { 1938459591, 3269368817, }, { 2101592791, 3111650744, }, },
},
    NullableValue = 
new System.UInt32[,] { { 2513392563, 142767298, }, { 3811303241, 1555546812, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 166,
    Value = 
new System.UInt32[,] { { 3221385066, 295497444, }, { 36410586, 2314943373, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 125,
    Value = 
new System.UInt32[,] { { 940779504, 234178307, }, { 410554235, 3365069278, }, },
    NullableValue = 
new System.UInt32[,] { { 2219610917, 423431338, }, { 1932710321, 2321905106, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 170,
    Value = 
new System.UInt32[,] { { 469752289, 1451812347, }, { 1857894215, 2915312807, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.UInt32[,] { { 1315110328, 3825798118, }, { 854299782, 3873005468, }, },
    NullableValue = 
new System.UInt32[,] { { 1200017229, 3953691450, }, { 4263156042, 1103742601, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1634255216, 450911892, }, { 3025240115, 1277043083, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 176,
    Value = 
new System.UInt32[,] { { 3897735660, 1082876769, }, { 4007363075, 2271285890, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.UInt32[,] { { 552161151, 1570348769, }, { 3770077351, 3198106466, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 177,
    Value = 
new System.UInt32[,] { { 3806467047, 3415454067, }, { 2427010963, 2303424972, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.UInt32[,] { { 3618208108, 242781913, }, { 3741560456, 784710815, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 179,
    Value = 
new System.UInt32[,] { { 2847450310, 328725220, }, { 3062146863, 650611871, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.UInt32[,] { { 1161706268, 1681129398, }, { 768554385, 1283241183, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3553821323, 1333521665, }, { 4120490921, 4252254053, }, },
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


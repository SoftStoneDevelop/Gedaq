

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
    Id = 6,
    Value = 
new System.UInt32[,] { { 3821856855, 301182078, }, { 2344081596, 3584004628, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.UInt32[,] { { 90735910, 839372323, }, { 3488443350, 2129358240, }, },
    NullableValue = 
new System.UInt32[,] { { 294081024, 4049796739, }, { 2306060935, 2262006898, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 12,
    Value = 
new System.UInt32[,] { { 1244547636, 2806589146, }, { 1242699726, 2573261588, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.UInt32[,] { { 803264675, 4097385818, }, { 1901283086, 4035618913, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 20,
    Value = 
new System.UInt32[,] { { 2382543942, 1063620251, }, { 1073620659, 1814783564, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.UInt32[,] { { 2398038059, 825346661, }, { 4076014928, 3340056367, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 24,
    Value = 
new System.UInt32[,] { { 1839366874, 1119242104, }, { 678655195, 4210963616, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt32[,] { { 3914127360, 3580438479, }, { 2126896884, 4288018089, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 25,
    Value = 
new System.UInt32[,] { { 1851944654, 1720957323, }, { 2397047676, 1748120869, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.UInt32[,] { { 587895854, 3890554466, }, { 2558505711, 3734293683, }, },
    NullableValue = 
new System.UInt32[,] { { 2213540184, 3930565748, }, { 295669559, 1612974710, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 33,
    Value = 
new System.UInt32[,] { { 347521344, 1288259565, }, { 65624146, 3178747696, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.UInt32[,] { { 2294169088, 4249140804, }, { 3391483847, 3642373818, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2611824549, 3052209334, }, { 2341017127, 3028643779, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 34,
    Value = 
new System.UInt32[,] { { 2388761766, 2610826657, }, { 3399264342, 1031966599, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 46,
    Value = 
new System.UInt32[,] { { 237312331, 1830670762, }, { 1886829628, 2378060451, }, },
    NullableValue = 
new System.UInt32[,] { { 2505858425, 3006438724, }, { 3301687474, 1537223503, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 38,
    Value = 
new System.UInt32[,] { { 2691695834, 4144869780, }, { 3519193597, 4220379287, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 48,
    Value = 
new System.UInt32[,] { { 4070104046, 4160429467, }, { 408874312, 2780977152, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1183156283, 1761874899, }, { 881692566, 494258527, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 39,
    Value = 
new System.UInt32[,] { { 3660822846, 25895775, }, { 3512232664, 3894980714, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.UInt32[,] { { 3807311502, 931828686, }, { 735266474, 967099371, }, },
    NullableValue = 
new System.UInt32[,] { { 1892266789, 3087873926, }, { 2463593263, 2336905392, }, },
},
    NullableValue = 
new System.UInt32[,] { { 2381810504, 3135994995, }, { 3451488909, 107434130, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 41,
    Value = 
new System.UInt32[,] { { 2447115616, 567099647, }, { 3673812268, 3363544350, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 56,
    Value = 
new System.UInt32[,] { { 3570405833, 1107892787, }, { 1061927437, 471016393, }, },
    NullableValue = 
new System.UInt32[,] { { 4270949292, 3824666429, }, { 4044507777, 3188165647, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1775438081, 3079587875, }, { 749095830, 563592892, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 42,
    Value = 
new System.UInt32[,] { { 699539117, 3753553698, }, { 2501039952, 1472845212, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 61,
    Value = 
new System.UInt32[,] { { 906683919, 3765467937, }, { 2612847875, 683598149, }, },
    NullableValue = 
new System.UInt32[,] { { 2877754688, 2522907539, }, { 834379147, 1556546197, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1792460307, 1462608071, }, { 1511058910, 2435076218, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 45,
    Value = 
new System.UInt32[,] { { 3851184010, 30549511, }, { 3904755549, 2609267750, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.UInt32[,] { { 498049440, 2411296966, }, { 4248812863, 4199996575, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2344244490, 3533774950, }, { 558862503, 4180958312, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 54,
    Value = 
new System.UInt32[,] { { 3410423957, 751765030, }, { 3364947921, 4285483635, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 72,
    Value = 
new System.UInt32[,] { { 470415366, 2610852230, }, { 1057413904, 2385251496, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 60,
    Value = 
new System.UInt32[,] { { 105388831, 1111599323, }, { 805786344, 1310874684, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.UInt32[,] { { 3963739512, 572685034, }, { 501493512, 2498834850, }, },
    NullableValue = 
new System.UInt32[,] { { 1006698579, 2443342526, }, { 1450373557, 1397000024, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 63,
    Value = 
new System.UInt32[,] { { 2044219991, 3142600760, }, { 3415386956, 4254384254, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.UInt32[,] { { 3597628205, 2044870107, }, { 645210602, 44584412, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 829207303, 994744673, }, { 2695651147, 3877454585, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 67,
    Value = 
new System.UInt32[,] { { 380087783, 4194732510, }, { 1605689524, 4250349022, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 91,
    Value = 
new System.UInt32[,] { { 4613474, 1062805780, }, { 1827830336, 3566114418, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 76,
    Value = 
new System.UInt32[,] { { 4121968311, 2266051100, }, { 3838113878, 88315045, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 95,
    Value = 
new System.UInt32[,] { { 1252164409, 2399840857, }, { 3336142038, 497618334, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 866781612, 2233265412, }, { 728349318, 67022519, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 81,
    Value = 
new System.UInt32[,] { { 3364945586, 4211973595, }, { 2926714523, 2325130155, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 98,
    Value = 
new System.UInt32[,] { { 2312687014, 146834352, }, { 1551566207, 1373453865, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 521140914, 3623029403, }, { 885973623, 3111899567, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 88,
    Value = 
new System.UInt32[,] { { 608246138, 4212718379, }, { 587573947, 1014519842, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.UInt32[,] { { 634480724, 825564944, }, { 1971224815, 1943630708, }, },
    NullableValue = 
new System.UInt32[,] { { 365177056, 564775456, }, { 1626743148, 3285990957, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 90,
    Value = 
new System.UInt32[,] { { 2171891162, 3352807356, }, { 3227231341, 2648199203, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.UInt32[,] { { 3305017320, 2685147928, }, { 3569250417, 3936766984, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3762625434, 1810596642, }, { 1490675336, 3373637381, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 91,
    Value = 
new System.UInt32[,] { { 3228218479, 1994488694, }, { 1265640071, 2248767671, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.UInt32[,] { { 3085522215, 3519343812, }, { 1452457154, 3012365664, }, },
    NullableValue = 
new System.UInt32[,] { { 2398447669, 550783226, }, { 4238284511, 1346690072, }, },
},
    NullableValue = 
new System.UInt32[,] { { 245463071, 3806284942, }, { 2036339705, 4098081396, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 96,
    Value = 
new System.UInt32[,] { { 601316949, 3261113906, }, { 2939218656, 3185285460, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.UInt32[,] { { 2485599978, 3081716788, }, { 1939304514, 2154992984, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 103,
    Value = 
new System.UInt32[,] { { 2100397068, 1950003900, }, { 2812081119, 2150840272, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.UInt32[,] { { 232759016, 3665575362, }, { 2244814232, 995465718, }, },
    NullableValue = 
new System.UInt32[,] { { 3784965693, 129811057, }, { 3365427681, 97158382, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 108,
    Value = 
new System.UInt32[,] { { 2490489896, 2969288922, }, { 371081279, 1003757194, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.UInt32[,] { { 1443390063, 2527658605, }, { 3402072737, 334262649, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 116,
    Value = 
new System.UInt32[,] { { 1000630159, 4203984061, }, { 411991968, 467934922, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 133,
    Value = 
new System.UInt32[,] { { 3888310775, 189931166, }, { 1455117000, 597496114, }, },
    NullableValue = 
new System.UInt32[,] { { 436797334, 929161044, }, { 3976020021, 592922365, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 124,
    Value = 
new System.UInt32[,] { { 1711069707, 2686121815, }, { 769223061, 2239039666, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.UInt32[,] { { 453243960, 2281117849, }, { 1879519744, 1511875932, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 989065016, 1574283246, }, { 107697998, 1933023254, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 125,
    Value = 
new System.UInt32[,] { { 2672248790, 3725597849, }, { 1621230189, 4093521928, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.UInt32[,] { { 1304644265, 2522025015, }, { 800312966, 242418991, }, },
    NullableValue = 
new System.UInt32[,] { { 2029524498, 3279399462, }, { 2095895139, 2214002957, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 128,
    Value = 
new System.UInt32[,] { { 2537807454, 1768646796, }, { 1277030277, 941780693, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.UInt32[,] { { 2113000401, 2536006032, }, { 3564124160, 1323547256, }, },
    NullableValue = 
new System.UInt32[,] { { 4283432158, 1476402682, }, { 3106863440, 3486425160, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 132,
    Value = 
new System.UInt32[,] { { 4075459812, 2621754087, }, { 2229815635, 1328577104, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.UInt32[,] { { 3332000925, 2370558431, }, { 3638524889, 819026820, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 136,
    Value = 
new System.UInt32[,] { { 3202593741, 1256089430, }, { 1343249035, 1865415621, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 163,
    Value = 
new System.UInt32[,] { { 3942871103, 1935603359, }, { 1393231661, 770988029, }, },
    NullableValue = 
new System.UInt32[,] { { 3918577512, 1390335702, }, { 2516676398, 3870893249, }, },
},
    NullableValue = 
new System.UInt32[,] { { 321873736, 1830082260, }, { 2859283552, 614714204, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 144,
    Value = 
new System.UInt32[,] { { 783883353, 1658121057, }, { 107509417, 3277640467, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 172,
    Value = 
new System.UInt32[,] { { 1416584884, 3026524715, }, { 2685657830, 3092918005, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 151,
    Value = 
new System.UInt32[,] { { 2356055932, 283293288, }, { 1076286432, 1542527515, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 177,
    Value = 
new System.UInt32[,] { { 3334390088, 2695882214, }, { 1667153831, 2386444160, }, },
    NullableValue = 
new System.UInt32[,] { { 728582949, 3936178388, }, { 2490122514, 2758078887, }, },
},
    NullableValue = 
new System.UInt32[,] { { 4159987805, 573684884, }, { 1605390192, 3585348517, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 154,
    Value = 
new System.UInt32[,] { { 3461467661, 3631076128, }, { 839387937, 2431606638, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 183,
    Value = 
new System.UInt32[,] { { 2283451539, 2922085574, }, { 2665901911, 1113337214, }, },
    NullableValue = 
new System.UInt32[,] { { 218798542, 1332255493, }, { 3434656948, 1455896882, }, },
},
    NullableValue = 
new System.UInt32[,] { { 66054272, 3407691806, }, { 848683368, 876651656, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 158,
    Value = 
new System.UInt32[,] { { 3678460077, 1897816765, }, { 3266903307, 932561547, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 190,
    Value = 
new System.UInt32[,] { { 4044193444, 1746935730, }, { 4238179371, 1195308365, }, },
    NullableValue = 
new System.UInt32[,] { { 915894244, 1907297801, }, { 3386221874, 1010814938, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 162,
    Value = 
new System.UInt32[,] { { 2592063083, 1714524681, }, { 1413654063, 3204590467, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 195,
    Value = 
new System.UInt32[,] { { 4040614811, 4085433191, }, { 1826628534, 1237139453, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3784937303, 3669096309, }, { 2187210071, 1147937897, }, },
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


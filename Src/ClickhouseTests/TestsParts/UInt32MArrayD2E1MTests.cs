

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
    Id = 9,
    Value = 
new System.UInt32[,] { { 3185785284, 3073766257, }, { 465634310, 3634735796, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 5,
    Value = 
new System.UInt32[,] { { 232462324, 4092176509, }, { 198500617, 2001241266, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3182866985, 2117471703, }, { 1542228101, 3598738289, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 12,
    Value = 
new System.UInt32[,] { { 1583845886, 298388694, }, { 2097968693, 118851949, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.UInt32[,] { { 793746175, 2687299840, }, { 3483740036, 3395642879, }, },
    NullableValue = 
new System.UInt32[,] { { 317805762, 2582530006, }, { 2378001418, 261948064, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3251036392, 3696486410, }, { 1432894769, 4104959220, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 15,
    Value = 
new System.UInt32[,] { { 3351747621, 4081818740, }, { 3853999883, 1737287754, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 14,
    Value = 
new System.UInt32[,] { { 2092354420, 1186529679, }, { 3268521389, 2016466306, }, },
    NullableValue = 
new System.UInt32[,] { { 253501102, 2066893189, }, { 1118865894, 469554895, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3159576702, 1770449169, }, { 440287592, 2876134621, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 21,
    Value = 
new System.UInt32[,] { { 1812780159, 1010051, }, { 1410218513, 1006163144, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.UInt32[,] { { 3533639831, 1571322678, }, { 1426693233, 3978381121, }, },
    NullableValue = 
new System.UInt32[,] { { 2154006819, 2983290871, }, { 794689045, 2367278276, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 28,
    Value = 
new System.UInt32[,] { { 1508403421, 4033780777, }, { 991690486, 1140293009, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.UInt32[,] { { 242330121, 3667458076, }, { 2558086108, 1170764721, }, },
    NullableValue = 
new System.UInt32[,] { { 4002847587, 2078764703, }, { 247118710, 4021974423, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 30,
    Value = 
new System.UInt32[,] { { 147852936, 871217485, }, { 2505446976, 915122697, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.UInt32[,] { { 3141246045, 3162898085, }, { 809746165, 4031429004, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 39,
    Value = 
new System.UInt32[,] { { 2245093872, 795141433, }, { 4118403988, 3108300609, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.UInt32[,] { { 3112321761, 47515573, }, { 1882336534, 1346488649, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1212565844, 3471224173, }, { 2051071394, 837339477, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 41,
    Value = 
new System.UInt32[,] { { 3456114722, 2673501448, }, { 930013898, 3766412891, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.UInt32[,] { { 3168872137, 1056253515, }, { 1812617713, 1699069686, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2431502817, 2327487175, }, { 1814477171, 3940498024, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 50,
    Value = 
new System.UInt32[,] { { 1927559628, 4139305989, }, { 1113385650, 2070666949, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt32[,] { { 3635813316, 2605187054, }, { 3360387904, 3294364222, }, },
    NullableValue = 
new System.UInt32[,] { { 2116042214, 637484102, }, { 3942747283, 4172424016, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1567210019, 2567897285, }, { 2923184109, 2386684447, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 53,
    Value = 
new System.UInt32[,] { { 1169477463, 4163752718, }, { 2644986465, 226580962, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.UInt32[,] { { 457718856, 2109516098, }, { 627789649, 2069508942, }, },
    NullableValue = 
new System.UInt32[,] { { 2230331497, 3861156514, }, { 1286691890, 4159509252, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 56,
    Value = 
new System.UInt32[,] { { 964254285, 3938956924, }, { 1572095075, 4284565440, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.UInt32[,] { { 483043127, 754198992, }, { 3764277240, 3382103368, }, },
    NullableValue = 
new System.UInt32[,] { { 621651849, 823638292, }, { 3603714624, 1611689724, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 65,
    Value = 
new System.UInt32[,] { { 2048674021, 764533433, }, { 473504991, 3839649292, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.UInt32[,] { { 2348838620, 2548143433, }, { 3982634688, 2117209220, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 74,
    Value = 
new System.UInt32[,] { { 1284884780, 5278582, }, { 3859214271, 878483428, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 66,
    Value = 
new System.UInt32[,] { { 279836220, 856039102, }, { 3010105144, 959075396, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1064706342, 3485274844, }, { 2454151181, 81410922, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 79,
    Value = 
new System.UInt32[,] { { 261397672, 1545750676, }, { 3360023738, 1754190938, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.UInt32[,] { { 3104596226, 2824172901, }, { 497928540, 2400886807, }, },
    NullableValue = 
new System.UInt32[,] { { 3842222694, 3924943780, }, { 3548380167, 1575089734, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 86,
    Value = 
new System.UInt32[,] { { 1653046643, 371629164, }, { 2993690548, 1702727950, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.UInt32[,] { { 3566544244, 2138622096, }, { 2038250458, 2602245050, }, },
    NullableValue = 
new System.UInt32[,] { { 1630891623, 4111218501, }, { 3579975415, 676816967, }, },
},
    NullableValue = 
new System.UInt32[,] { { 1444857795, 1260444702, }, { 1777313153, 174732864, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 90,
    Value = 
new System.UInt32[,] { { 1456372352, 2833584021, }, { 2543535355, 1363978529, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 72,
    Value = 
new System.UInt32[,] { { 4165541393, 1368587912, }, { 2915353108, 1546080712, }, },
    NullableValue = 
new System.UInt32[,] { { 3292477853, 3063964563, }, { 772598902, 2999023991, }, },
},
    NullableValue = 
new System.UInt32[,] { { 4141595959, 2740078974, }, { 1575622508, 2792773863, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 92,
    Value = 
new System.UInt32[,] { { 79375846, 3342276951, }, { 3573297299, 3316023983, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.UInt32[,] { { 1178257030, 3372674663, }, { 1730214747, 2009008783, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 96,
    Value = 
new System.UInt32[,] { { 2928029755, 803476614, }, { 591918227, 2102742831, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.UInt32[,] { { 1407553995, 642731951, }, { 1618647387, 939325472, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 4215101194, 672074996, }, { 175967920, 77257898, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 99,
    Value = 
new System.UInt32[,] { { 62328854, 2625508044, }, { 3154216531, 120038621, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 89,
    Value = 
new System.UInt32[,] { { 3891045751, 1786781293, }, { 2195256503, 79057275, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1312087796, 3052296005, }, { 3509302078, 3537040349, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt32[,] { { 4199546604, 961165962, }, { 3393792369, 945215844, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt32[,] { { 434954980, 804386523, }, { 2741577895, 3611706191, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1312352302, 1658609019, }, { 3724347040, 762741249, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 113,
    Value = 
new System.UInt32[,] { { 3473571565, 3333252689, }, { 3800106651, 3084239092, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.UInt32[,] { { 2601856569, 1594006310, }, { 2670697936, 2363978733, }, },
    NullableValue = 
new System.UInt32[,] { { 1729174158, 4068831060, }, { 1527842403, 3825130663, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 115,
    Value = 
new System.UInt32[,] { { 2867986003, 1680789068, }, { 199911240, 4242700829, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.UInt32[,] { { 3425536224, 1832673431, }, { 2880916587, 204038494, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 118,
    Value = 
new System.UInt32[,] { { 1050685446, 627945630, }, { 1522097363, 3062074556, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.UInt32[,] { { 202949, 989864720, }, { 1765373749, 1429823624, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 119,
    Value = 
new System.UInt32[,] { { 2056783904, 1328027963, }, { 2245801461, 3176811813, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 117,
    Value = 
new System.UInt32[,] { { 1363233023, 2709416233, }, { 872630649, 3045749933, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 124,
    Value = 
new System.UInt32[,] { { 2158576941, 4057592404, }, { 1658379510, 4209477314, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.UInt32[,] { { 1409585563, 432661313, }, { 3564998499, 185076197, }, },
    NullableValue = 
new System.UInt32[,] { { 3587029851, 4140005296, }, { 3852937645, 1241723999, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 128,
    Value = 
new System.UInt32[,] { { 443240815, 3996490928, }, { 1884886723, 15714102, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 123,
    Value = 
new System.UInt32[,] { { 1198612060, 3316222489, }, { 2788909087, 2809673150, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 12016004, 3359696573, }, { 2101043013, 4074876115, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 131,
    Value = 
new System.UInt32[,] { { 1410605641, 1973780991, }, { 728209715, 354782748, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 125,
    Value = 
new System.UInt32[,] { { 317836376, 2663955317, }, { 2239152296, 924953583, }, },
    NullableValue = 
new System.UInt32[,] { { 4186298521, 265528436, }, { 3406350976, 3066520666, }, },
},
    NullableValue = 
new System.UInt32[,] { { 429965762, 2947847845, }, { 1262724378, 1505043653, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 139,
    Value = 
new System.UInt32[,] { { 1669867883, 3877389496, }, { 278368786, 174191176, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.UInt32[,] { { 1753123281, 500885620, }, { 2610600341, 3393080848, }, },
    NullableValue = 
new System.UInt32[,] { { 662656601, 3071583415, }, { 4211146, 2988895722, }, },
},
    NullableValue = 
new System.UInt32[,] { { 228991085, 3133025182, }, { 3934383465, 2249937360, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 146,
    Value = 
new System.UInt32[,] { { 4280208601, 2442128380, }, { 759105038, 1965593784, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 133,
    Value = 
new System.UInt32[,] { { 2829973921, 2077057998, }, { 1112405105, 613891341, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3534983423, 229334413, }, { 964254334, 1187410166, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 150,
    Value = 
new System.UInt32[,] { { 1023283271, 2765672114, }, { 2027624454, 702504119, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.UInt32[,] { { 3381015499, 4257806764, }, { 2155187714, 49097619, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 159,
    Value = 
new System.UInt32[,] { { 2010281515, 655032203, }, { 2250221962, 1388274280, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.UInt32[,] { { 2488794461, 2748401206, }, { 2538018787, 2345707636, }, },
    NullableValue = 
new System.UInt32[,] { { 4292685777, 1913824642, }, { 2442840476, 1618322910, }, },
},
    NullableValue = 
new System.UInt32[,] { { 2181033871, 2803151649, }, { 1159477732, 71540593, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 160,
    Value = 
new System.UInt32[,] { { 3188524104, 1425055881, }, { 477616790, 2204805607, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.UInt32[,] { { 561519132, 1047707052, }, { 200260246, 114089845, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 162,
    Value = 
new System.UInt32[,] { { 2187672226, 2281365991, }, { 4163850257, 1519202191, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.UInt32[,] { { 4223037158, 1739790046, }, { 3141032022, 1189086423, }, },
    NullableValue = 
new System.UInt32[,] { { 2959132971, 3133789954, }, { 3817675865, 3677223149, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 167,
    Value = 
new System.UInt32[,] { { 3506602770, 3048752871, }, { 1735048747, 2858866750, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.UInt32[,] { { 1143635722, 255135194, }, { 2869934247, 2147118109, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 175,
    Value = 
new System.UInt32[,] { { 1051508170, 609305304, }, { 818508063, 3754240924, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 155,
    Value = 
new System.UInt32[,] { { 4138428914, 3303156118, }, { 3481909191, 3709339702, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3363042378, 3795555747, }, { 2812276224, 58279776, }, },
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


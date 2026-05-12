

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
    Id = 8,
    Value = 
new System.UInt32[,] { { 3327952409, 1267860836, }, { 4067660284, 4050555738, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.UInt32[,] { { 2806508213, 559331587, }, { 526493039, 3812346678, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 1828469024, 1901173318, }, { 835457841, 2077288050, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 10,
    Value = 
new System.UInt32[,] { { 2355577271, 4111920912, }, { 2757643840, 4268792566, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.UInt32[,] { { 2291504101, 1866030168, }, { 4086500949, 1584186704, }, },
    NullableValue = 
new System.UInt32[,] { { 1812974468, 704144035, }, { 2154092855, 3380854094, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 15,
    Value = 
new System.UInt32[,] { { 94235962, 3485003735, }, { 1029937378, 284451680, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 13,
    Value = 
new System.UInt32[,] { { 2893300240, 3319337677, }, { 1356219747, 2014841769, }, },
    NullableValue = 
new System.UInt32[,] { { 1943091798, 2268080162, }, { 1403702373, 39827893, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 19,
    Value = 
new System.UInt32[,] { { 648013898, 359710980, }, { 3056586749, 2134247064, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.UInt32[,] { { 2148787612, 2874330124, }, { 2394321622, 1244163926, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 22,
    Value = 
new System.UInt32[,] { { 710959458, 1234718940, }, { 3082783916, 1266632721, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt32[,] { { 3543941608, 1786923073, }, { 3953028101, 3253340524, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 29,
    Value = 
new System.UInt32[,] { { 4167952736, 88669648, }, { 1248628149, 433132174, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 30,
    Value = 
new System.UInt32[,] { { 140094155, 345664519, }, { 2856123784, 3753862780, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2624276948, 1026409423, }, { 678743874, 810010794, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 38,
    Value = 
new System.UInt32[,] { { 45788719, 1588691164, }, { 1153967295, 1643475427, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 35,
    Value = 
new System.UInt32[,] { { 424384136, 3755869760, }, { 3727440529, 3056519925, }, },
    NullableValue = 
new System.UInt32[,] { { 2943052278, 4282677050, }, { 323353453, 2750829219, }, },
},
    NullableValue = 
new System.UInt32[,] { { 666781286, 1695704512, }, { 1765238739, 1096920821, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 46,
    Value = 
new System.UInt32[,] { { 4284623678, 1587697834, }, { 1300152076, 1745354740, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.UInt32[,] { { 1323227579, 282331767, }, { 3337332563, 4280362702, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 47,
    Value = 
new System.UInt32[,] { { 3263452933, 1612057849, }, { 3611610265, 969650701, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 47,
    Value = 
new System.UInt32[,] { { 3856423500, 900136679, }, { 1369079597, 3016546380, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2176980393, 3286192258, }, { 108716889, 3688415490, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 56,
    Value = 
new System.UInt32[,] { { 2811419292, 3799213434, }, { 2826160871, 1948771204, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 48,
    Value = 
new System.UInt32[,] { { 2420760329, 2095596632, }, { 2826276891, 1090860386, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 59,
    Value = 
new System.UInt32[,] { { 1427866165, 2322024993, }, { 4178237679, 3655449889, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.UInt32[,] { { 3878912657, 3729969462, }, { 316457091, 1752080931, }, },
    NullableValue = 
new System.UInt32[,] { { 1464060164, 2052085395, }, { 3342951483, 2190031139, }, },
},
    NullableValue = 
new System.UInt32[,] { { 2843329085, 2913607487, }, { 3093552323, 3425290521, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 67,
    Value = 
new System.UInt32[,] { { 1937277373, 1696340295, }, { 1170303307, 1318693599, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.UInt32[,] { { 1709597328, 2042219284, }, { 691197877, 3246526444, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 2828520457, 875861121, }, { 2240620224, 4159964916, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 73,
    Value = 
new System.UInt32[,] { { 2365349557, 3690113687, }, { 1576075798, 3857173302, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.UInt32[,] { { 806181506, 3673753816, }, { 1762091283, 1326402191, }, },
    NullableValue = 
new System.UInt32[,] { { 2738878541, 1735025863, }, { 113413884, 1093061789, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3574409985, 1281165417, }, { 3445345866, 4198371596, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 81,
    Value = 
new System.UInt32[,] { { 2330612406, 1970926545, }, { 3622325260, 3432862519, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 63,
    Value = 
new System.UInt32[,] { { 2613130954, 3370628263, }, { 2228225579, 772352560, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 82,
    Value = 
new System.UInt32[,] { { 1780108090, 4216020490, }, { 376213053, 2837394483, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 68,
    Value = 
new System.UInt32[,] { { 1895484304, 1427306978, }, { 2972251618, 1033305840, }, },
    NullableValue = 
new System.UInt32[,] { { 2073097680, 109775370, }, { 3553974931, 1559287927, }, },
},
    NullableValue = 
new System.UInt32[,] { { 513011792, 67173119, }, { 467900313, 106563035, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 89,
    Value = 
new System.UInt32[,] { { 2599367484, 914161383, }, { 2296828613, 466591858, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 73,
    Value = 
new System.UInt32[,] { { 3644899508, 2767524280, }, { 3586773663, 2881579910, }, },
    NullableValue = 
new System.UInt32[,] { { 3720898556, 1308734303, }, { 196595093, 2511100842, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3252288858, 916912604, }, { 342641874, 3299476381, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 90,
    Value = 
new System.UInt32[,] { { 815467215, 916972968, }, { 3524904246, 3191777351, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 78,
    Value = 
new System.UInt32[,] { { 3559444857, 1080504878, }, { 4221485831, 1236576677, }, },
    NullableValue = 
new System.UInt32[,] { { 1347758450, 941635268, }, { 501982591, 3011031897, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 95,
    Value = 
new System.UInt32[,] { { 853374596, 3321117355, }, { 2914065155, 3870748406, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.UInt32[,] { { 3529340647, 3891561865, }, { 4113118568, 1684884644, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 99,
    Value = 
new System.UInt32[,] { { 3889544384, 668243544, }, { 2671939488, 1899194788, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.UInt32[,] { { 1971243245, 2150860518, }, { 896847791, 991771614, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3928931606, 2641415037, }, { 4102502708, 965947127, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 100,
    Value = 
new System.UInt32[,] { { 4115696376, 1345422387, }, { 2808298243, 4106592435, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 89,
    Value = 
new System.UInt32[,] { { 3908223053, 943133104, }, { 3829495813, 852831654, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 108,
    Value = 
new System.UInt32[,] { { 771214249, 3612394853, }, { 2968984602, 1636143928, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.UInt32[,] { { 780937814, 400632155, }, { 2971487006, 386136123, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 116,
    Value = 
new System.UInt32[,] { { 152529969, 3588714750, }, { 3002675113, 1899306481, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.UInt32[,] { { 1539057733, 161834272, }, { 2596986649, 4285912122, }, },
    NullableValue = 
new System.UInt32[,] { { 2140171347, 3940775340, }, { 624824137, 1925684165, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3651949404, 2105232462, }, { 1264574947, 458943259, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 118,
    Value = 
new System.UInt32[,] { { 1838522283, 2859004637, }, { 2787835250, 1781583150, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.UInt32[,] { { 4248561681, 573790779, }, { 403823825, 3976512109, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 121,
    Value = 
new System.UInt32[,] { { 2122171680, 1723461358, }, { 1853586336, 1475519309, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.UInt32[,] { { 3656625375, 1306958481, }, { 3204050634, 1735865716, }, },
    NullableValue = 
new System.UInt32[,] { { 3427505880, 3447135254, }, { 1801578895, 2217865379, }, },
},
    NullableValue = 
new System.UInt32[,] { { 2778860560, 633739594, }, { 918338605, 3253619990, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 122,
    Value = 
new System.UInt32[,] { { 3174289175, 58810098, }, { 972721425, 3922466987, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.UInt32[,] { { 1966014772, 403255505, }, { 3403402629, 967728186, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 678495116, 1036081715, }, { 1950935889, 462488639, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 131,
    Value = 
new System.UInt32[,] { { 824886066, 2379098038, }, { 1994996739, 691058304, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 123,
    Value = 
new System.UInt32[,] { { 1832938917, 586868752, }, { 1176113515, 3479451741, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { { 3393318624, 1136280636, }, { 1105231121, 4207820164, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 132,
    Value = 
new System.UInt32[,] { { 1301802835, 3314483816, }, { 3222636278, 218884207, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.UInt32[,] { { 598453784, 1259258848, }, { 754099694, 924501934, }, },
    NullableValue = 
new System.UInt32[,] { { 3717933050, 1737635081, }, { 478091868, 1393859577, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 135,
    Value = 
new System.UInt32[,] { { 1711505064, 2230704961, }, { 2666139056, 103506973, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.UInt32[,] { { 2006774798, 805798605, }, { 2292749480, 2106894469, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 136,
    Value = 
new System.UInt32[,] { { 2271559336, 2422292742, }, { 3439421803, 4148419966, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.UInt32[,] { { 886413527, 637197057, }, { 1663399312, 2055651405, }, },
    NullableValue = 
new System.UInt32[,] { { 2860224660, 634037408, }, { 2769596482, 37184997, }, },
},
    NullableValue = 
new System.UInt32[,] { { 2905128408, 705808180, }, { 3857436264, 118968082, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 139,
    Value = 
new System.UInt32[,] { { 4014218637, 2224978556, }, { 789257881, 3452013363, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.UInt32[,] { { 3756170937, 3080617400, }, { 2233695261, 3914293730, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 148,
    Value = 
new System.UInt32[,] { { 1090063838, 1379307374, }, { 3637651207, 1877916453, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.UInt32[,] { { 4051474817, 3576339356, }, { 2786715601, 2682697531, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 153,
    Value = 
new System.UInt32[,] { { 2808257956, 1338380949, }, { 3468820445, 1505751067, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 154,
    Value = 
new System.UInt32[,] { { 3043366534, 3770241681, }, { 1645538864, 3359510656, }, },
    NullableValue = 
new System.UInt32[,] { { 4082609602, 1961337109, }, { 2214676593, 380160825, }, },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 157,
    Value = 
new System.UInt32[,] { { 3620145728, 1813332296, }, { 4037840594, 3833693547, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.UInt32[,] { { 1551695943, 2682398982, }, { 1234258978, 254271047, }, },
    NullableValue = 
new System.UInt32[,] { { 3015689462, 3849925353, }, { 229316819, 2660256465, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3010915874, 650435148, }, { 924050492, 1080792985, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 166,
    Value = 
new System.UInt32[,] { { 1423142280, 1674463177, }, { 4058385557, 3333427895, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.UInt32[,] { { 720114440, 3189104453, }, { 3503247056, 3455873411, }, },
    NullableValue = 
new System.UInt32[,] { { 3448241298, 2279980744, }, { 2325030420, 2910613609, }, },
},
    NullableValue = 
new System.UInt32[,] { { 3182082000, 2313034516, }, { 1823862758, 1468868638, }, },
},
            new UInt32MArrayD2E1M
{
    Id = 173,
    Value = 
new System.UInt32[,] { { 2652112200, 3380847648, }, { 3881644104, 3890999686, }, },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 165,
    Value = 
new System.UInt32[,] { { 2184732866, 1445840556, }, { 949400114, 3034241717, }, },
    NullableValue = 
new System.UInt32[,] { { 819356364, 294979449, }, { 1995323775, 1422940334, }, },
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


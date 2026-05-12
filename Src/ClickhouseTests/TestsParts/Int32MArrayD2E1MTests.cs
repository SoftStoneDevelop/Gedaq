

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
    internal partial interface IInt32MArrayMArrayD2
    {
    }
    
    internal partial class Int32MArrayMArrayD2 : IInt32MArrayMArrayD2
    {


#region TestData

        private readonly Int32MArrayD2E1M[] _testData = new Int32MArrayD2E1M[]
        {
            new Int32MArrayD2E1M
{
    Id = 1,
    Value = 
new System.Int32[,] { { 1170677070, 669624966, }, { 1006372026, 657365980, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Int32[,] { { 1883749602, 1316942601, }, { 2099643893, 1061192562, }, },
    NullableValue = 
new System.Int32[,] { { 437917889, 1642757031, }, { 418746150, 1984764315, }, },
},
    NullableValue = 
new System.Int32[,] { { 1966135337, 1733341516, }, { 1406370470, 1692511151, }, },
},
            new Int32MArrayD2E1M
{
    Id = 7,
    Value = 
new System.Int32[,] { { 4451293, 61937601, }, { 1522327057, 1325173132, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Int32[,] { { 231310127, 403991545, }, { 2111181910, 1709505312, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 9,
    Value = 
new System.Int32[,] { { 470222644, 827546640, }, { 945409559, 1755653842, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Int32[,] { { 352675986, 355142302, }, { 1420469544, 1695986742, }, },
    NullableValue = 
new System.Int32[,] { { 2040221569, 235170065, }, { 1990357033, 1386200301, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 12,
    Value = 
new System.Int32[,] { { 949547258, 1033383676, }, { 1601071720, 1301881635, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Int32[,] { { 2071301870, 1479979818, }, { 1571305442, 1019891255, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 18,
    Value = 
new System.Int32[,] { { 1399920134, 466904162, }, { 455114462, 1114333383, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Int32[,] { { 1664826290, 536185481, }, { 2144978777, 1425743471, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1104436005, 1594862800, }, { 1639835424, 1486302045, }, },
},
            new Int32MArrayD2E1M
{
    Id = 25,
    Value = 
new System.Int32[,] { { 1427113979, 1262855665, }, { 1820641280, 86584644, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Int32[,] { { 1406773288, 564208880, }, { 1399384316, 2061602619, }, },
    NullableValue = 
new System.Int32[,] { { 1101221677, 240788872, }, { 2101638066, 125891179, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 31,
    Value = 
new System.Int32[,] { { 1311510455, 127820034, }, { 1015584362, 1764468425, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Int32[,] { { 1558018111, 670132388, }, { 1009306824, 1568408255, }, },
    NullableValue = 
new System.Int32[,] { { 582182158, 1988394889, }, { 434525936, 2091309465, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 37,
    Value = 
new System.Int32[,] { { 2047707193, 959330973, }, { 2108275919, 394177324, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Int32[,] { { 419938794, 1840006562, }, { 2039803513, 626553651, }, },
    NullableValue = 
new System.Int32[,] { { 1846397428, 571349096, }, { 1931022200, 266556983, }, },
},
    NullableValue = 
new System.Int32[,] { { 87832789, 1764708068, }, { 663213077, 622405647, }, },
},
            new Int32MArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int32[,] { { 358293748, 1592520788, }, { 1713625517, 1321604944, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Int32[,] { { 343684528, 1630161, }, { 4847557, 674006724, }, },
    NullableValue = 
new System.Int32[,] { { 2051673898, 812634867, }, { 1861344224, 1195709021, }, },
},
    NullableValue = 
new System.Int32[,] { { 755592996, 1764522070, }, { 1925603757, 411914263, }, },
},
            new Int32MArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int32[,] { { 1077638517, 471988889, }, { 1321233949, 999135745, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Int32[,] { { 1258723119, 1127132750, }, { 697109531, 1619053401, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int32[,] { { 739119226, 1679135978, }, { 1027288889, 1828427903, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int32[,] { { 1809604824, 729128632, }, { 229936689, 847175829, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 51,
    Value = 
new System.Int32[,] { { 43352093, 789125927, }, { 604058842, 1132591432, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Int32[,] { { 580039452, 413720330, }, { 1461494307, 98645340, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 57,
    Value = 
new System.Int32[,] { { 2006685274, 1106290105, }, { 88961889, 1295655028, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Int32[,] { { 176267590, 1516278253, }, { 1228707690, 1604306496, }, },
    NullableValue = 
new System.Int32[,] { { 524842403, 1890166351, }, { 1236748818, 1526817859, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 63,
    Value = 
new System.Int32[,] { { 1653082551, 155252243, }, { 98052156, 1170786177, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int32[,] { { 1950477694, 102016241, }, { 70262193, 849348339, }, },
    NullableValue = 
new System.Int32[,] { { 1884580231, 768396506, }, { 208227569, 847621250, }, },
},
    NullableValue = 
new System.Int32[,] { { 1400720854, 862064037, }, { 1661320558, 1256468980, }, },
},
            new Int32MArrayD2E1M
{
    Id = 69,
    Value = 
new System.Int32[,] { { 304443786, 1319315257, }, { 993288825, 106847024, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int32[,] { { 848948316, 671736031, }, { 946634544, 443927093, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 375581917, 421976871, }, { 1898061707, 2119172396, }, },
},
            new Int32MArrayD2E1M
{
    Id = 78,
    Value = 
new System.Int32[,] { { 1362239683, 2081412388, }, { 1829153349, 561436698, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Int32[,] { { 172992223, 12268617, }, { 508275800, 1429405242, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 79,
    Value = 
new System.Int32[,] { { 1757657568, 1625407294, }, { 26476820, 1126396359, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Int32[,] { { 547799647, 1996638863, }, { 257516912, 769673792, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int32[,] { { 621801669, 490374629, }, { 1889509971, 897867858, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Int32[,] { { 1707703199, 647471972, }, { 1111470748, 753171401, }, },
    NullableValue = 
new System.Int32[,] { { 919991571, 774463052, }, { 1530855550, 905979610, }, },
},
    NullableValue = 
new System.Int32[,] { { 1180779723, 1473794354, }, { 106225001, 1067229565, }, },
},
            new Int32MArrayD2E1M
{
    Id = 95,
    Value = 
new System.Int32[,] { { 1120698844, 1004446012, }, { 501992421, 2131285950, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Int32[,] { { 1392008584, 1574876802, }, { 1195778990, 1259932242, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int32[,] { { 1230995549, 1391783015, }, { 758940660, 1906873728, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 101,
    Value = 
new System.Int32[,] { { 861794653, 454773764, }, { 948624924, 1381506461, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 103,
    Value = 
new System.Int32[,] { { 1779659052, 1466785092, }, { 2068262019, 468056737, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.Int32[,] { { 292063488, 61349765, }, { 873337041, 1204073872, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 6968758, 1502781601, }, { 1583413164, 1544644757, }, },
},
            new Int32MArrayD2E1M
{
    Id = 111,
    Value = 
new System.Int32[,] { { 459056582, 1722711874, }, { 1331169022, 1478816183, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Int32[,] { { 943752429, 1109560776, }, { 1681381032, 1903100733, }, },
    NullableValue = 
new System.Int32[,] { { 694483313, 765379878, }, { 193122384, 1752461068, }, },
},
    NullableValue = 
new System.Int32[,] { { 697325869, 1033037220, }, { 408126582, 2083268160, }, },
},
            new Int32MArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int32[,] { { 982540775, 1193840966, }, { 1032227380, 912917689, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Int32[,] { { 487576251, 1283386528, }, { 1266716883, 1908373093, }, },
    NullableValue = 
new System.Int32[,] { { 3491738, 1110851250, }, { 1068768161, 1989090264, }, },
},
    NullableValue = 
new System.Int32[,] { { 1594701266, 1918102430, }, { 270328553, 268256429, }, },
},
            new Int32MArrayD2E1M
{
    Id = 116,
    Value = 
new System.Int32[,] { { 3793556, 724963117, }, { 604334859, 2007926048, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.Int32[,] { { 116969421, 837548023, }, { 2111032344, 1797807922, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1834559992, 1497255986, }, { 1897669506, 754988191, }, },
},
            new Int32MArrayD2E1M
{
    Id = 124,
    Value = 
new System.Int32[,] { { 646320332, 2071876982, }, { 353760145, 1129374537, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Int32[,] { { 2001823284, 309466173, }, { 749654448, 58571056, }, },
    NullableValue = 
new System.Int32[,] { { 1191847529, 2103767755, }, { 1820272699, 488775054, }, },
},
    NullableValue = 
new System.Int32[,] { { 182609189, 1471593108, }, { 2039988847, 1484935793, }, },
},
            new Int32MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int32[,] { { 1992653566, 258240594, }, { 1950112973, 1520407259, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Int32[,] { { 2126345516, 1205284536, }, { 88145812, 532582534, }, },
    NullableValue = 
new System.Int32[,] { { 2036126878, 728082391, }, { 484344246, 690976389, }, },
},
    NullableValue = 
new System.Int32[,] { { 1288638608, 2121694261, }, { 155320632, 35700092, }, },
},
            new Int32MArrayD2E1M
{
    Id = 137,
    Value = 
new System.Int32[,] { { 486025553, 697647069, }, { 1480207429, 339728209, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Int32[,] { { 994794537, 478137626, }, { 1511594757, 341052619, }, },
    NullableValue = 
new System.Int32[,] { { 1622359788, 1507807394, }, { 128488500, 48274517, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 143,
    Value = 
new System.Int32[,] { { 1442214287, 425250180, }, { 967414392, 835753377, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Int32[,] { { 1297384640, 1539887987, }, { 654696926, 1038951052, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 148,
    Value = 
new System.Int32[,] { { 43531396, 845952814, }, { 814823921, 812078091, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Int32[,] { { 1423425267, 1196757607, }, { 107429615, 535357717, }, },
    NullableValue = 
new System.Int32[,] { { 1305273455, 2114792867, }, { 1820052748, 208028835, }, },
},
    NullableValue = 
new System.Int32[,] { { 596657870, 831098287, }, { 458687474, 1334226705, }, },
},
            new Int32MArrayD2E1M
{
    Id = 151,
    Value = 
new System.Int32[,] { { 1587028157, 1795816240, }, { 2101864479, 811302471, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 154,
    Value = 
new System.Int32[,] { { 749998646, 1602541008, }, { 1333414761, 379202574, }, },
    NullableValue = 
new System.Int32[,] { { 236762475, 537452882, }, { 1288763460, 397698178, }, },
},
    NullableValue = 
new System.Int32[,] { { 862803894, 1798820445, }, { 183840970, 1635118247, }, },
},
            new Int32MArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int32[,] { { 579096949, 69819922, }, { 2074630626, 1767301679, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 157,
    Value = 
new System.Int32[,] { { 1270538498, 267365248, }, { 673254632, 1554005070, }, },
    NullableValue = 
new System.Int32[,] { { 1722320499, 750375782, }, { 1317886746, 1551693357, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 156,
    Value = 
new System.Int32[,] { { 878168815, 1049318060, }, { 1235179273, 1772438198, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Int32[,] { { 1632324219, 1483587179, }, { 955361354, 1290376787, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 157,
    Value = 
new System.Int32[,] { { 659414579, 607376888, }, { 1522903940, 919481323, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 167,
    Value = 
new System.Int32[,] { { 238413322, 1510238650, }, { 598831856, 1915944776, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1097004424, 1521442345, }, { 2107936623, 1147933066, }, },
},
            new Int32MArrayD2E1M
{
    Id = 162,
    Value = 
new System.Int32[,] { { 688054065, 937871212, }, { 1284687289, 1893878402, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Int32[,] { { 1709927060, 729340477, }, { 268422471, 939348701, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 170,
    Value = 
new System.Int32[,] { { 824607175, 533972230, }, { 1281768045, 1646361180, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 180,
    Value = 
new System.Int32[,] { { 2131340635, 350337587, }, { 167082638, 249129305, }, },
    NullableValue = null,
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
INSERT INTO gedaqtests.int32marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int32))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int32))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]), 
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
                    await ((IInt32MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IInt32MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.int32marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayMArrayD2)),
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
                    var models = await ((IInt32MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


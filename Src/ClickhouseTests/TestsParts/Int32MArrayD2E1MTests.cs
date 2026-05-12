

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
    Id = 6,
    Value = 
new System.Int32[,] { { 895749517, 529593911, }, { 1232001463, 1417234086, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Int32[,] { { 996960352, 1531002600, }, { 1241335409, 945828980, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1679240426, 785394843, }, { 264071059, 405581137, }, },
},
            new Int32MArrayD2E1M
{
    Id = 13,
    Value = 
new System.Int32[,] { { 1000705506, 181794645, }, { 1196000182, 926740614, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Int32[,] { { 1003928884, 872205764, }, { 615558515, 773302027, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1902569956, 76457934, }, { 1126727375, 1444853103, }, },
},
            new Int32MArrayD2E1M
{
    Id = 14,
    Value = 
new System.Int32[,] { { 717791677, 1990158787, }, { 876524974, 373580747, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Int32[,] { { 1198963635, 1067217737, }, { 125667693, 1196558735, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1834244223, 851642028, }, { 834538428, 1884490623, }, },
},
            new Int32MArrayD2E1M
{
    Id = 22,
    Value = 
new System.Int32[,] { { 1562015466, 1340261889, }, { 298144349, 466940321, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Int32[,] { { 143215423, 161410739, }, { 1688979330, 44800110, }, },
    NullableValue = 
new System.Int32[,] { { 882417958, 1126175471, }, { 1649810106, 1972856101, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 27,
    Value = 
new System.Int32[,] { { 1037762621, 1417240815, }, { 1508458089, 1678327575, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Int32[,] { { 2135552548, 705627198, }, { 1341242023, 1039487089, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1482618076, 439475341, }, { 2126499399, 27980579, }, },
},
            new Int32MArrayD2E1M
{
    Id = 29,
    Value = 
new System.Int32[,] { { 985546652, 1016652255, }, { 971734899, 1587948140, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Int32[,] { { 514068900, 1946393443, }, { 1990536144, 770841868, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 31,
    Value = 
new System.Int32[,] { { 166569111, 1773841818, }, { 393910739, 663881099, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Int32[,] { { 721107068, 492825530, }, { 1877382878, 1214326415, }, },
    NullableValue = 
new System.Int32[,] { { 2110906877, 474711519, }, { 1033500494, 2004858419, }, },
},
    NullableValue = 
new System.Int32[,] { { 269265931, 332124457, }, { 496929008, 972985008, }, },
},
            new Int32MArrayD2E1M
{
    Id = 39,
    Value = 
new System.Int32[,] { { 979826540, 1199605475, }, { 1123680586, 540081009, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int32[,] { { 793022900, 811947553, }, { 1971935415, 1137685634, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int32[,] { { 135537327, 679481642, }, { 1682877188, 1102859205, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Int32[,] { { 1733513252, 1601790533, }, { 508174095, 745600963, }, },
    NullableValue = 
new System.Int32[,] { { 1419324924, 219748866, }, { 184745519, 910247612, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 54,
    Value = 
new System.Int32[,] { { 130055397, 1581189343, }, { 1833972523, 688324218, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Int32[,] { { 29177541, 1044764972, }, { 463617580, 1443402293, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 56,
    Value = 
new System.Int32[,] { { 502999249, 1438028820, }, { 399023346, 1146813546, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Int32[,] { { 824035401, 205855845, }, { 364894610, 902190185, }, },
    NullableValue = 
new System.Int32[,] { { 1796337595, 200529054, }, { 762234573, 1494592465, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int32[,] { { 1337835494, 1948545101, }, { 1623689639, 1267942017, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int32[,] { { 2081945471, 1075099117, }, { 1021560796, 1212705621, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 71,
    Value = 
new System.Int32[,] { { 199277956, 510995014, }, { 1401263007, 522404139, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Int32[,] { { 2019662132, 2016172629, }, { 230988484, 2105467294, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 78,
    Value = 
new System.Int32[,] { { 1445449417, 1311981713, }, { 1490123804, 1631242166, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Int32[,] { { 883761335, 272274076, }, { 1901087676, 2104687231, }, },
    NullableValue = 
new System.Int32[,] { { 594797361, 233000407, }, { 1120635969, 1612743266, }, },
},
    NullableValue = 
new System.Int32[,] { { 736953265, 324987721, }, { 117612656, 449737837, }, },
},
            new Int32MArrayD2E1M
{
    Id = 87,
    Value = 
new System.Int32[,] { { 313112056, 2038233978, }, { 1436166060, 1425562193, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Int32[,] { { 1958487682, 1624103580, }, { 1325535050, 1132460677, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 691744954, 977093100, }, { 282837902, 11438101, }, },
},
            new Int32MArrayD2E1M
{
    Id = 94,
    Value = 
new System.Int32[,] { { 1248942562, 459595492, }, { 17628215, 1075851993, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Int32[,] { { 733867393, 1139422068, }, { 774281507, 1430828252, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 96,
    Value = 
new System.Int32[,] { { 1711432378, 534422184, }, { 1656060930, 1922131937, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Int32[,] { { 94860935, 993112403, }, { 778578516, 1894022752, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 925009296, 265513578, }, { 955700475, 1456581526, }, },
},
            new Int32MArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int32[,] { { 1610586220, 1015210805, }, { 1937884165, 711357128, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Int32[,] { { 442683620, 1425059035, }, { 243602794, 1428563979, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 777082888, 1278043564, }, { 1508574784, 1159264355, }, },
},
            new Int32MArrayD2E1M
{
    Id = 104,
    Value = 
new System.Int32[,] { { 1078349436, 558058594, }, { 1580890882, 1916214638, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 97,
    Value = 
new System.Int32[,] { { 226809307, 1278074910, }, { 970431308, 1891326403, }, },
    NullableValue = 
new System.Int32[,] { { 1069212494, 1384336818, }, { 855511642, 1920005484, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 108,
    Value = 
new System.Int32[,] { { 1144580057, 1131224244, }, { 1608892756, 1698636258, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 101,
    Value = 
new System.Int32[,] { { 1140830106, 1816674378, }, { 1553089741, 151977489, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 535355486, 1183710367, }, { 682207209, 198898631, }, },
},
            new Int32MArrayD2E1M
{
    Id = 115,
    Value = 
new System.Int32[,] { { 1234561773, 1392296511, }, { 613841150, 1816387076, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Int32[,] { { 1976012303, 1376048776, }, { 1621325608, 344830366, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int32[,] { { 188802628, 1251471507, }, { 1742015920, 555184251, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.Int32[,] { { 1118347764, 1271747116, }, { 914855032, 153571765, }, },
    NullableValue = 
new System.Int32[,] { { 450639881, 646164205, }, { 480737787, 1827449343, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 124,
    Value = 
new System.Int32[,] { { 906797786, 516110859, }, { 148924789, 768552592, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Int32[,] { { 883912885, 290918630, }, { 1461871937, 324445827, }, },
    NullableValue = 
new System.Int32[,] { { 365191276, 1123209177, }, { 855443310, 365390752, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 133,
    Value = 
new System.Int32[,] { { 75543305, 1793714488, }, { 490831985, 847631077, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Int32[,] { { 1302220004, 664913895, }, { 629027034, 848550312, }, },
    NullableValue = 
new System.Int32[,] { { 1904268992, 325515567, }, { 1997894987, 775145383, }, },
},
    NullableValue = 
new System.Int32[,] { { 1201138419, 241931635, }, { 896660896, 1928411539, }, },
},
            new Int32MArrayD2E1M
{
    Id = 134,
    Value = 
new System.Int32[,] { { 1435590150, 1697013898, }, { 2131901722, 148145704, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 121,
    Value = 
new System.Int32[,] { { 2012802787, 539549514, }, { 602699045, 1605967430, }, },
    NullableValue = 
new System.Int32[,] { { 565449792, 1286045149, }, { 116890686, 426100764, }, },
},
    NullableValue = 
new System.Int32[,] { { 1491551017, 2035367414, }, { 1889680886, 287754648, }, },
},
            new Int32MArrayD2E1M
{
    Id = 140,
    Value = 
new System.Int32[,] { { 2018946314, 1517673788, }, { 424342814, 281751067, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.Int32[,] { { 647803281, 446533395, }, { 858197842, 158031927, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int32[,] { { 2084814057, 1611147664, }, { 236658532, 682788815, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Int32[,] { { 1215387815, 341953648, }, { 395692817, 233725752, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 151,
    Value = 
new System.Int32[,] { { 312731348, 2027372714, }, { 832162907, 1534420140, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 138,
    Value = 
new System.Int32[,] { { 1887818868, 378687989, }, { 1973335746, 1741558856, }, },
    NullableValue = 
new System.Int32[,] { { 246814820, 1286006610, }, { 434684301, 15780879, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 154,
    Value = 
new System.Int32[,] { { 1956319569, 542733101, }, { 471604951, 1540361569, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Int32[,] { { 64275944, 1911414020, }, { 1135368008, 1636672724, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 163,
    Value = 
new System.Int32[,] { { 37590880, 1026585653, }, { 73631881, 1173235687, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.Int32[,] { { 375399884, 2065421357, }, { 1913533592, 373024184, }, },
    NullableValue = 
new System.Int32[,] { { 1503918015, 91104535, }, { 1881100870, 1609646316, }, },
},
    NullableValue = 
new System.Int32[,] { { 1254343187, 1432313744, }, { 309208544, 698389184, }, },
},
            new Int32MArrayD2E1M
{
    Id = 165,
    Value = 
new System.Int32[,] { { 392173530, 1046441213, }, { 1905373345, 1680903319, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 155,
    Value = 
new System.Int32[,] { { 1833627760, 102664028, }, { 1550127202, 798056317, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 172,
    Value = 
new System.Int32[,] { { 1095425538, 304761077, }, { 1588355935, 46100548, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Int32[,] { { 1150959114, 202981801, }, { 801301553, 1297322824, }, },
    NullableValue = 
new System.Int32[,] { { 63772984, 1251598657, }, { 1733306501, 2034929071, }, },
},
    NullableValue = 
new System.Int32[,] { { 1907727155, 240475110, }, { 1599592117, 1441953163, }, },
},
            new Int32MArrayD2E1M
{
    Id = 177,
    Value = 
new System.Int32[,] { { 52394332, 1543474091, }, { 1204722205, 1740487972, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 163,
    Value = 
new System.Int32[,] { { 1050612393, 1711431934, }, { 2090211658, 572777732, }, },
    NullableValue = 
new System.Int32[,] { { 472013285, 1903795728, }, { 1292199273, 859238505, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 186,
    Value = 
new System.Int32[,] { { 869913997, 408260939, }, { 1142083770, 822103352, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Int32[,] { { 505525535, 1283174076, }, { 722125278, 1968871533, }, },
    NullableValue = 
new System.Int32[,] { { 1456700081, 449399541, }, { 177397014, 1801854019, }, },
},
    NullableValue = 
new System.Int32[,] { { 355289941, 1750256492, }, { 1422163494, 478597968, }, },
},
            new Int32MArrayD2E1M
{
    Id = 194,
    Value = 
new System.Int32[,] { { 347020375, 1997697978, }, { 1230637844, 566955411, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Int32[,] { { 1495372060, 332395933, }, { 1543961710, 2139367338, }, },
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




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
new System.Int32[,] { { 1604913805, 1434500387, }, { 321068885, 1961609266, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int32[,] { { 1511518238, 668119152, }, { 318633814, 262674733, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 227358598, 1690572444, }, { 973940021, 2101167802, }, },
},
            new Int32MArrayD2E1M
{
    Id = 14,
    Value = 
new System.Int32[,] { { 57694430, 2135230746, }, { 860381576, 638338032, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int32[,] { { 1532020860, 1658142377, }, { 1060167237, 222766231, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 251381899, 1543430280, }, { 1475639995, 378365514, }, },
},
            new Int32MArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int32[,] { { 1969535621, 1718689119, }, { 213628315, 169623589, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Int32[,] { { 718086498, 898869967, }, { 1936309552, 1302416510, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 17,
    Value = 
new System.Int32[,] { { 1382645695, 166980474, }, { 2108988839, 771630317, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int32[,] { { 1824107548, 476604243, }, { 315792274, 681415264, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1248883532, 552103947, }, { 571449119, 2060699459, }, },
},
            new Int32MArrayD2E1M
{
    Id = 21,
    Value = 
new System.Int32[,] { { 1210376150, 598090608, }, { 1430450135, 2007930257, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Int32[,] { { 1088777018, 421928189, }, { 1054820608, 1164730786, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1633496255, 1641166701, }, { 1693814628, 176954443, }, },
},
            new Int32MArrayD2E1M
{
    Id = 24,
    Value = 
new System.Int32[,] { { 998917470, 827866824, }, { 952300068, 490792083, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Int32[,] { { 519256832, 1640149059, }, { 617135038, 485239806, }, },
    NullableValue = 
new System.Int32[,] { { 1925977552, 901632157, }, { 1093403158, 245191409, }, },
},
    NullableValue = 
new System.Int32[,] { { 1120315875, 1187771878, }, { 1826004849, 529433636, }, },
},
            new Int32MArrayD2E1M
{
    Id = 32,
    Value = 
new System.Int32[,] { { 1900589839, 2139404882, }, { 1570598073, 869395881, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Int32[,] { { 1431290821, 1404926426, }, { 935407860, 1624831547, }, },
    NullableValue = 
new System.Int32[,] { { 732125090, 1583999777, }, { 1920561754, 639969071, }, },
},
    NullableValue = 
new System.Int32[,] { { 756180228, 2118516856, }, { 41997565, 212930110, }, },
},
            new Int32MArrayD2E1M
{
    Id = 33,
    Value = 
new System.Int32[,] { { 1790974730, 1729435569, }, { 769816360, 2093259680, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Int32[,] { { 1703356127, 2123573968, }, { 1886138296, 1665141476, }, },
    NullableValue = 
new System.Int32[,] { { 460046251, 1550251606, }, { 2092567363, 1721871497, }, },
},
    NullableValue = 
new System.Int32[,] { { 611844118, 1634380789, }, { 951432130, 1291763575, }, },
},
            new Int32MArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int32[,] { { 608442231, 436601836, }, { 1391086464, 1673343049, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int32[,] { { 60258935, 347548880, }, { 1584555046, 1489334512, }, },
    NullableValue = 
new System.Int32[,] { { 1525042186, 1467579527, }, { 1558451937, 606996543, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int32[,] { { 1969724822, 663100958, }, { 1330868614, 10869264, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Int32[,] { { 397421526, 1500041388, }, { 1006371270, 1889756630, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1292421594, 155385082, }, { 751429859, 1701100798, }, },
},
            new Int32MArrayD2E1M
{
    Id = 52,
    Value = 
new System.Int32[,] { { 1190191492, 278573364, }, { 1981494840, 1508848291, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Int32[,] { { 716338261, 999243564, }, { 678107662, 563887105, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1178454582, 532708755, }, { 1525886064, 1177030068, }, },
},
            new Int32MArrayD2E1M
{
    Id = 55,
    Value = 
new System.Int32[,] { { 733308516, 373141446, }, { 1881770582, 531711000, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Int32[,] { { 1029674138, 1202800538, }, { 1615307789, 945392004, }, },
    NullableValue = 
new System.Int32[,] { { 415099132, 1914303810, }, { 405640970, 825009558, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 58,
    Value = 
new System.Int32[,] { { 1202135488, 837099427, }, { 2007208916, 1080955764, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Int32[,] { { 585505442, 2082080001, }, { 611575699, 210014587, }, },
    NullableValue = 
new System.Int32[,] { { 1687504714, 1816092604, }, { 726459508, 283730561, }, },
},
    NullableValue = 
new System.Int32[,] { { 2000149366, 1433400253, }, { 1485318479, 158555507, }, },
},
            new Int32MArrayD2E1M
{
    Id = 62,
    Value = 
new System.Int32[,] { { 1720051176, 24909072, }, { 801413183, 1275868087, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Int32[,] { { 1162767407, 2069286773, }, { 1975744762, 334516894, }, },
    NullableValue = 
new System.Int32[,] { { 1234059845, 794489502, }, { 1324952097, 1949615156, }, },
},
    NullableValue = 
new System.Int32[,] { { 788770278, 506100344, }, { 1801603444, 1405322675, }, },
},
            new Int32MArrayD2E1M
{
    Id = 63,
    Value = 
new System.Int32[,] { { 1842508420, 2146383549, }, { 1279660923, 1641176047, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Int32[,] { { 999111349, 1803744733, }, { 793272534, 557765162, }, },
    NullableValue = 
new System.Int32[,] { { 789155585, 396137213, }, { 2018315887, 2068180944, }, },
},
    NullableValue = 
new System.Int32[,] { { 1986379189, 166025935, }, { 2048670234, 1467111605, }, },
},
            new Int32MArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int32[,] { { 811491360, 1958750628, }, { 1184015717, 1063415449, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Int32[,] { { 780090993, 874073078, }, { 1588726753, 1476322248, }, },
    NullableValue = 
new System.Int32[,] { { 1059369620, 191147798, }, { 1439450686, 1811822908, }, },
},
    NullableValue = 
new System.Int32[,] { { 1322118209, 15434071, }, { 497308233, 1199632635, }, },
},
            new Int32MArrayD2E1M
{
    Id = 72,
    Value = 
new System.Int32[,] { { 543436279, 2062807599, }, { 682567923, 529687889, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.Int32[,] { { 951827587, 1633807830, }, { 1832440260, 416421806, }, },
    NullableValue = 
new System.Int32[,] { { 1194146713, 1905452317, }, { 429270865, 1762002249, }, },
},
    NullableValue = 
new System.Int32[,] { { 2025339214, 824432222, }, { 1155283047, 917646658, }, },
},
            new Int32MArrayD2E1M
{
    Id = 75,
    Value = 
new System.Int32[,] { { 814802851, 1545079710, }, { 1510290455, 1266890159, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Int32[,] { { 738133930, 1495597529, }, { 298383021, 1449503166, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 83,
    Value = 
new System.Int32[,] { { 275736634, 1990499960, }, { 233640229, 1794809110, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Int32[,] { { 1170695616, 1526068608, }, { 1057647922, 554340542, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 91,
    Value = 
new System.Int32[,] { { 414249112, 299223923, }, { 1303827180, 36432194, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Int32[,] { { 1586950429, 540172283, }, { 1040632377, 148575656, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 2004261597, 1064574261, }, { 967427983, 946649213, }, },
},
            new Int32MArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int32[,] { { 1654970302, 78816645, }, { 2118769669, 914875606, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 125,
    Value = 
new System.Int32[,] { { 1242004164, 395964064, }, { 122149709, 935054993, }, },
    NullableValue = 
new System.Int32[,] { { 386478628, 2024049644, }, { 611867342, 927507904, }, },
},
    NullableValue = 
new System.Int32[,] { { 1376490619, 1165195246, }, { 1508997531, 1231179899, }, },
},
            new Int32MArrayD2E1M
{
    Id = 105,
    Value = 
new System.Int32[,] { { 1986745952, 1437750781, }, { 1635596237, 856211173, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 131,
    Value = 
new System.Int32[,] { { 647382418, 243335018, }, { 1019221003, 157605813, }, },
    NullableValue = 
new System.Int32[,] { { 1631906135, 142828371, }, { 325637391, 806158834, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 108,
    Value = 
new System.Int32[,] { { 635249646, 1695594131, }, { 1398712453, 782818916, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Int32[,] { { 1747132892, 811104020, }, { 1908276475, 1041445201, }, },
    NullableValue = 
new System.Int32[,] { { 1025682035, 2101327463, }, { 702251284, 1458957099, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 111,
    Value = 
new System.Int32[,] { { 1096532151, 1924242451, }, { 1433246150, 602537988, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Int32[,] { { 1441170450, 1605615859, }, { 2008246388, 1822895254, }, },
    NullableValue = 
new System.Int32[,] { { 489334370, 301252945, }, { 375139538, 1188894531, }, },
},
    NullableValue = 
new System.Int32[,] { { 920145842, 2116776958, }, { 2058487460, 211244960, }, },
},
            new Int32MArrayD2E1M
{
    Id = 116,
    Value = 
new System.Int32[,] { { 222150244, 2114131241, }, { 1679071081, 1802798838, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Int32[,] { { 452394144, 1950425838, }, { 1246924490, 813542572, }, },
    NullableValue = 
new System.Int32[,] { { 8538780, 1189364273, }, { 1252990493, 1795072767, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 122,
    Value = 
new System.Int32[,] { { 1391475145, 858599838, }, { 1658512217, 873262380, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.Int32[,] { { 1640672806, 1514382915, }, { 1360428356, 852494182, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 128,
    Value = 
new System.Int32[,] { { 673578633, 1808934419, }, { 1422832791, 2108056897, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 157,
    Value = 
new System.Int32[,] { { 729028696, 1298705276, }, { 1306440642, 1362529276, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int32[,] { { 1665525658, 2134600974, }, { 655249814, 491479708, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 163,
    Value = 
new System.Int32[,] { { 1462192197, 1171770103, }, { 828164524, 1747212273, }, },
    NullableValue = 
new System.Int32[,] { { 1205544997, 1235830366, }, { 972505445, 2143485389, }, },
},
    NullableValue = 
new System.Int32[,] { { 841514627, 1327042654, }, { 535534778, 1417763638, }, },
},
            new Int32MArrayD2E1M
{
    Id = 138,
    Value = 
new System.Int32[,] { { 758867345, 1369890217, }, { 201796873, 488427706, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 172,
    Value = 
new System.Int32[,] { { 919786546, 1393258536, }, { 986494578, 2006241058, }, },
    NullableValue = 
new System.Int32[,] { { 7138546, 2034960071, }, { 1964404054, 1859098929, }, },
},
    NullableValue = 
new System.Int32[,] { { 818229697, 1367737377, }, { 1466196968, 1152589357, }, },
},
            new Int32MArrayD2E1M
{
    Id = 140,
    Value = 
new System.Int32[,] { { 1106670866, 488130390, }, { 960122745, 2034035078, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Int32[,] { { 1738141282, 1398649364, }, { 1673602605, 20184934, }, },
    NullableValue = 
new System.Int32[,] { { 2014592961, 542649184, }, { 2032865219, 1410560646, }, },
},
    NullableValue = 
new System.Int32[,] { { 664001930, 1375385070, }, { 2097106402, 1991940679, }, },
},
            new Int32MArrayD2E1M
{
    Id = 145,
    Value = 
new System.Int32[,] { { 263868156, 1570277317, }, { 1615779023, 2013481673, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 180,
    Value = 
new System.Int32[,] { { 1891818301, 151706145, }, { 667544795, 243646627, }, },
    NullableValue = 
new System.Int32[,] { { 1156530203, 1857620698, }, { 186111392, 508899006, }, },
},
    NullableValue = 
new System.Int32[,] { { 1416824361, 517779414, }, { 912336629, 207456232, }, },
},
            new Int32MArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int32[,] { { 1024404082, 1391628430, }, { 486474364, 1657275263, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 183,
    Value = 
new System.Int32[,] { { 26825119, 1187787596, }, { 1854945962, 916758309, }, },
    NullableValue = 
new System.Int32[,] { { 1956578688, 291995482, }, { 1999787054, 1141156454, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 154,
    Value = 
new System.Int32[,] { { 2006909148, 1433439722, }, { 2040281529, 222151840, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 184,
    Value = 
new System.Int32[,] { { 590658115, 500412836, }, { 1550097603, 784866087, }, },
    NullableValue = 
new System.Int32[,] { { 566131538, 306054833, }, { 322003476, 536499534, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 163,
    Value = 
new System.Int32[,] { { 784370002, 204212285, }, { 1085442116, 85341269, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 186,
    Value = 
new System.Int32[,] { { 908308346, 1776843030, }, { 95116528, 1222451490, }, },
    NullableValue = 
new System.Int32[,] { { 460460391, 535866464, }, { 1275399950, 1033713125, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 167,
    Value = 
new System.Int32[,] { { 126993593, 844109933, }, { 874801367, 1188421062, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 194,
    Value = 
new System.Int32[,] { { 2091069785, 1287393228, }, { 1541194908, 923387741, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 965298901, 46101291, }, { 642903743, 1646990620, }, },
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


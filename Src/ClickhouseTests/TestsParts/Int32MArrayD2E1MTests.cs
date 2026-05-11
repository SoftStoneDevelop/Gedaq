

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
    Id = 5,
    Value = 
new System.Int32[,] { { 970143974, 1092673931, }, { 1995255049, 1056816961, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Int32[,] { { 560504876, 1828491860, }, { 1982331769, 337628644, }, },
    NullableValue = 
new System.Int32[,] { { 1367871229, 812314960, }, { 203651037, 576457170, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 14,
    Value = 
new System.Int32[,] { { 1575360184, 2113962121, }, { 1162878035, 1364897903, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 5,
    Value = 
new System.Int32[,] { { 94082912, 20402717, }, { 598361854, 484845395, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 22,
    Value = 
new System.Int32[,] { { 2127755007, 1449645355, }, { 1675745015, 1047572139, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int32[,] { { 989630841, 700744781, }, { 1719276047, 1890058419, }, },
    NullableValue = 
new System.Int32[,] { { 2079293059, 978018157, }, { 1444403991, 1022106076, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 24,
    Value = 
new System.Int32[,] { { 2105883632, 1654527196, }, { 180721214, 606100036, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Int32[,] { { 1323222767, 454838578, }, { 1213165222, 1277082910, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 29,
    Value = 
new System.Int32[,] { { 768800543, 1521380826, }, { 359524724, 1598209235, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Int32[,] { { 2107770392, 853730688, }, { 801796999, 620059611, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 34,
    Value = 
new System.Int32[,] { { 1021177031, 858479820, }, { 726034260, 1691647889, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Int32[,] { { 435914787, 503295363, }, { 2000501886, 624651260, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 43,
    Value = 
new System.Int32[,] { { 1251381184, 1125595066, }, { 1232680089, 285656628, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int32[,] { { 15986694, 1015120008, }, { 1667917948, 1464586435, }, },
    NullableValue = 
new System.Int32[,] { { 1212405608, 2144310773, }, { 1788868523, 1514073141, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 44,
    Value = 
new System.Int32[,] { { 1148422965, 101556457, }, { 473536, 860390289, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Int32[,] { { 462610866, 2122787778, }, { 1442863547, 266676192, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 48,
    Value = 
new System.Int32[,] { { 429645046, 760100312, }, { 185792463, 1501973451, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Int32[,] { { 443309892, 794074721, }, { 80671846, 437323983, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1636539525, 1927582590, }, { 505786848, 189745600, }, },
},
            new Int32MArrayD2E1M
{
    Id = 52,
    Value = 
new System.Int32[,] { { 2051969085, 443571111, }, { 1038832728, 953456174, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Int32[,] { { 1105352400, 643809077, }, { 2135240753, 286326064, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int32[,] { { 1516956588, 1413040388, }, { 289191527, 1527701096, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Int32[,] { { 1978815861, 1492731649, }, { 899186931, 2089793106, }, },
    NullableValue = 
new System.Int32[,] { { 803565883, 1447924186, }, { 363603812, 382312727, }, },
},
    NullableValue = 
new System.Int32[,] { { 1714467740, 1641002257, }, { 494010428, 1256921905, }, },
},
            new Int32MArrayD2E1M
{
    Id = 54,
    Value = 
new System.Int32[,] { { 1834356171, 26936525, }, { 1376746916, 621793088, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Int32[,] { { 95655290, 1514492248, }, { 208184164, 492130746, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1077221664, 1549092405, }, { 412099464, 244973383, }, },
},
            new Int32MArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int32[,] { { 2134330510, 1089132596, }, { 1362957084, 239242070, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int32[,] { { 1553339953, 1096818416, }, { 138451529, 551457446, }, },
    NullableValue = 
new System.Int32[,] { { 599979002, 1751199413, }, { 2081201024, 155397872, }, },
},
    NullableValue = 
new System.Int32[,] { { 1735532451, 116248917, }, { 1605985196, 1133064291, }, },
},
            new Int32MArrayD2E1M
{
    Id = 66,
    Value = 
new System.Int32[,] { { 848756000, 1159947651, }, { 1704400303, 394641639, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Int32[,] { { 2099680198, 673848623, }, { 2062017430, 851124957, }, },
    NullableValue = 
new System.Int32[,] { { 14825298, 1238073745, }, { 1343467100, 2105687277, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 72,
    Value = 
new System.Int32[,] { { 1631037472, 1758152176, }, { 81534304, 947052067, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int32[,] { { 272232363, 1677922374, }, { 864583179, 909941188, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int32[,] { { 1142147079, 482340818, }, { 1259987602, 312343071, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Int32[,] { { 387301797, 1209832913, }, { 2091163014, 197116645, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 79,
    Value = 
new System.Int32[,] { { 1259703689, 2110370435, }, { 1533236934, 462317425, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Int32[,] { { 179344443, 926131896, }, { 1186253872, 183149052, }, },
    NullableValue = 
new System.Int32[,] { { 998747226, 851876591, }, { 1494365101, 1384414264, }, },
},
    NullableValue = 
new System.Int32[,] { { 2009616492, 957243912, }, { 961664053, 1555189684, }, },
},
            new Int32MArrayD2E1M
{
    Id = 82,
    Value = 
new System.Int32[,] { { 2022965410, 751106749, }, { 1577243456, 1622005918, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Int32[,] { { 1736279405, 1305621345, }, { 100019199, 1258234286, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int32[,] { { 1698923728, 1110546734, }, { 920814327, 2101226979, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Int32[,] { { 1087819958, 805495304, }, { 1183063549, 1772357186, }, },
    NullableValue = 
new System.Int32[,] { { 1818028033, 626172392, }, { 1177594348, 739763746, }, },
},
    NullableValue = 
new System.Int32[,] { { 17255180, 1819843296, }, { 925704514, 559379455, }, },
},
            new Int32MArrayD2E1M
{
    Id = 94,
    Value = 
new System.Int32[,] { { 533879491, 2056375670, }, { 1471064935, 81150277, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 89,
    Value = 
new System.Int32[,] { { 211045936, 1481165037, }, { 279241472, 1868876815, }, },
    NullableValue = 
new System.Int32[,] { { 286079863, 1225139965, }, { 431423408, 1357058274, }, },
},
    NullableValue = 
new System.Int32[,] { { 599491830, 238407177, }, { 153381303, 845924062, }, },
},
            new Int32MArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int32[,] { { 1335490903, 2135184248, }, { 1513300859, 1983023960, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 98,
    Value = 
new System.Int32[,] { { 758584133, 1477541353, }, { 1560961104, 683688147, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 108,
    Value = 
new System.Int32[,] { { 1687023783, 764288454, }, { 750150311, 292465136, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.Int32[,] { { 2001241601, 1141885741, }, { 202710660, 1614378439, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1954904484, 1134699325, }, { 1174673489, 214391703, }, },
},
            new Int32MArrayD2E1M
{
    Id = 114,
    Value = 
new System.Int32[,] { { 1696927278, 768677342, }, { 287684949, 1071929582, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.Int32[,] { { 1717117344, 685333255, }, { 1770964920, 1928706946, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 2113975569, 308567556, }, { 267626019, 1052818277, }, },
},
            new Int32MArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int32[,] { { 1413788327, 87546197, }, { 2060172736, 965181568, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Int32[,] { { 598704047, 659692761, }, { 1149405014, 1180282151, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int32[,] { { 1329269881, 665673839, }, { 907641971, 140719752, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Int32[,] { { 218980932, 658271169, }, { 567272754, 1661962778, }, },
    NullableValue = 
new System.Int32[,] { { 77857921, 1988033424, }, { 1103570746, 420735248, }, },
},
    NullableValue = 
new System.Int32[,] { { 1082032787, 1403572784, }, { 1655733455, 1319429170, }, },
},
            new Int32MArrayD2E1M
{
    Id = 138,
    Value = 
new System.Int32[,] { { 1001120068, 1164556403, }, { 87565412, 411352024, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Int32[,] { { 640651166, 185366896, }, { 321281527, 595786284, }, },
    NullableValue = 
new System.Int32[,] { { 167927059, 1366586087, }, { 1866406541, 776328034, }, },
},
    NullableValue = 
new System.Int32[,] { { 746680989, 188504432, }, { 1808935087, 590090481, }, },
},
            new Int32MArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int32[,] { { 879088336, 1612545431, }, { 2110967327, 202626852, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Int32[,] { { 1384318166, 166721323, }, { 2021824692, 442427395, }, },
    NullableValue = 
new System.Int32[,] { { 407283606, 1511191643, }, { 367503218, 1204298078, }, },
},
    NullableValue = 
new System.Int32[,] { { 955630493, 545002030, }, { 1459662716, 1674487280, }, },
},
            new Int32MArrayD2E1M
{
    Id = 151,
    Value = 
new System.Int32[,] { { 1069367948, 589823990, }, { 394345512, 2145371623, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 125,
    Value = 
new System.Int32[,] { { 1337402520, 1752878918, }, { 1410916947, 428773273, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 923678973, 1062716598, }, { 865724583, 1039177983, }, },
},
            new Int32MArrayD2E1M
{
    Id = 156,
    Value = 
new System.Int32[,] { { 756981416, 907552719, }, { 590536984, 668437962, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Int32[,] { { 1508458633, 1606427160, }, { 1279675825, 384172270, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1513333745, 817625797, }, { 438801186, 987422706, }, },
},
            new Int32MArrayD2E1M
{
    Id = 160,
    Value = 
new System.Int32[,] { { 1209736148, 1344205456, }, { 926507974, 1374996693, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Int32[,] { { 275784938, 2055194397, }, { 1160412475, 1519825305, }, },
    NullableValue = 
new System.Int32[,] { { 1862399775, 1082451669, }, { 833585594, 709610300, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 168,
    Value = 
new System.Int32[,] { { 823595581, 1265789681, }, { 1664969712, 115640544, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Int32[,] { { 906048678, 776198057, }, { 1566249181, 1811831751, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1451142460, 1822045700, }, { 1136233353, 1115542705, }, },
},
            new Int32MArrayD2E1M
{
    Id = 174,
    Value = 
new System.Int32[,] { { 850478445, 771217057, }, { 253355737, 2079871154, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 140,
    Value = 
new System.Int32[,] { { 11692486, 1192959665, }, { 717967038, 1672408032, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 176,
    Value = 
new System.Int32[,] { { 1183514105, 1912706156, }, { 357865300, 693898946, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.Int32[,] { { 1017080117, 1021303428, }, { 1703712016, 1284759846, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 488474523, 705381826, }, { 864676329, 2063670008, }, },
},
            new Int32MArrayD2E1M
{
    Id = 180,
    Value = 
new System.Int32[,] { { 1699381372, 1665669094, }, { 160934413, 562681568, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Int32[,] { { 640011416, 1295003707, }, { 387849300, 882430285, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1751732644, 471400131, }, { 1050563587, 1315638847, }, },
},
            new Int32MArrayD2E1M
{
    Id = 189,
    Value = 
new System.Int32[,] { { 796261351, 992179666, }, { 1553574759, 7186913, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 154,
    Value = 
new System.Int32[,] { { 1146714691, 292875628, }, { 401333943, 189472583, }, },
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


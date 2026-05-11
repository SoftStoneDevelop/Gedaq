

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
new System.Int32[,] { { 233810201, 1121664185, }, { 1288273211, 1159957837, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Int32[,] { { 1762886543, 1522559781, }, { 2142786904, 1657433341, }, },
    NullableValue = 
new System.Int32[,] { { 29891708, 31798762, }, { 1765615403, 1360709899, }, },
},
    NullableValue = 
new System.Int32[,] { { 1361184079, 940362819, }, { 377742508, 368834077, }, },
},
            new Int32MArrayD2E1M
{
    Id = 13,
    Value = 
new System.Int32[,] { { 14412081, 858998723, }, { 1924473951, 360953624, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Int32[,] { { 2055494933, 803466525, }, { 369018387, 1587230953, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1442485611, 488073511, }, { 451094433, 1781961452, }, },
},
            new Int32MArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int32[,] { { 1551518264, 872035213, }, { 1103053214, 124622784, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Int32[,] { { 1016416872, 1571028164, }, { 1035205972, 1197537817, }, },
    NullableValue = 
new System.Int32[,] { { 474321168, 828452068, }, { 156316758, 718054458, }, },
},
    NullableValue = 
new System.Int32[,] { { 1791184577, 1974314852, }, { 1652919051, 2114828207, }, },
},
            new Int32MArrayD2E1M
{
    Id = 18,
    Value = 
new System.Int32[,] { { 2038294439, 1813933949, }, { 1319290625, 700575323, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Int32[,] { { 415684493, 2085344894, }, { 1585895577, 1718503033, }, },
    NullableValue = 
new System.Int32[,] { { 1079248603, 196043335, }, { 341967083, 40229306, }, },
},
    NullableValue = 
new System.Int32[,] { { 1948007668, 590697787, }, { 178869719, 231789460, }, },
},
            new Int32MArrayD2E1M
{
    Id = 23,
    Value = 
new System.Int32[,] { { 282388536, 710479809, }, { 1135838894, 1786018641, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Int32[,] { { 2118283668, 1979100724, }, { 1292722022, 615796670, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 31,
    Value = 
new System.Int32[,] { { 122804891, 177028543, }, { 2102983966, 985377376, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Int32[,] { { 15920379, 2041183108, }, { 1630487194, 1052149779, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 277954288, 511605525, }, { 1879912513, 1603765036, }, },
},
            new Int32MArrayD2E1M
{
    Id = 38,
    Value = 
new System.Int32[,] { { 756922983, 938349197, }, { 1112810796, 1854386446, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Int32[,] { { 940828570, 589747999, }, { 1078713612, 817450982, }, },
    NullableValue = 
new System.Int32[,] { { 2002356731, 1243029519, }, { 1049607445, 283576817, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int32[,] { { 1114852566, 1103443513, }, { 286679737, 501685141, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Int32[,] { { 357125117, 1667371674, }, { 1071919260, 1723643589, }, },
    NullableValue = 
new System.Int32[,] { { 1366722958, 2071449113, }, { 543817361, 233389027, }, },
},
    NullableValue = 
new System.Int32[,] { { 723330393, 877214094, }, { 106022799, 493424368, }, },
},
            new Int32MArrayD2E1M
{
    Id = 50,
    Value = 
new System.Int32[,] { { 1086412315, 769617597, }, { 237000838, 1035934096, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Int32[,] { { 503904480, 31894564, }, { 2141307293, 408292833, }, },
    NullableValue = 
new System.Int32[,] { { 1612701691, 641980450, }, { 1824130729, 1779686420, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 52,
    Value = 
new System.Int32[,] { { 1722164814, 1155804483, }, { 536302419, 633894336, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Int32[,] { { 1855722909, 1831790741, }, { 1076941793, 1925690194, }, },
    NullableValue = 
new System.Int32[,] { { 571911791, 1786780925, }, { 266934324, 766626746, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 59,
    Value = 
new System.Int32[,] { { 107531033, 176091681, }, { 705913132, 136926093, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int32[,] { { 206557543, 2140496828, }, { 1337062853, 1999334739, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1621051523, 2074801940, }, { 2011825606, 1597761028, }, },
},
            new Int32MArrayD2E1M
{
    Id = 65,
    Value = 
new System.Int32[,] { { 841441463, 1760019094, }, { 166147678, 1853976665, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Int32[,] { { 851681866, 638063471, }, { 1567395978, 641351106, }, },
    NullableValue = 
new System.Int32[,] { { 192714127, 775633342, }, { 845326302, 1214835086, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 71,
    Value = 
new System.Int32[,] { { 365872576, 1657988227, }, { 1202883533, 269232418, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Int32[,] { { 1843614304, 751496997, }, { 1244704059, 22172517, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 77,
    Value = 
new System.Int32[,] { { 840267246, 1549940453, }, { 1283594301, 1458939009, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.Int32[,] { { 1291490707, 5529376, }, { 11632984, 971930660, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 2083206870, 2022659833, }, { 1368240305, 342829285, }, },
},
            new Int32MArrayD2E1M
{
    Id = 81,
    Value = 
new System.Int32[,] { { 924340767, 297515846, }, { 951555704, 523590983, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Int32[,] { { 1168006097, 1305451759, }, { 1486954292, 1930266137, }, },
    NullableValue = 
new System.Int32[,] { { 1176317474, 1040151815, }, { 1792831745, 124921227, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 89,
    Value = 
new System.Int32[,] { { 1255961317, 1421280952, }, { 1047124127, 1294026062, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Int32[,] { { 1691793571, 555915768, }, { 2006292442, 1047596966, }, },
    NullableValue = 
new System.Int32[,] { { 1203592947, 1892781844, }, { 2026432368, 1079369152, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 95,
    Value = 
new System.Int32[,] { { 193258060, 431853411, }, { 156326276, 1753694387, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 101,
    Value = 
new System.Int32[,] { { 1686915783, 1146097035, }, { 437054135, 499080349, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 451324506, 403772236, }, { 2071042870, 1654146344, }, },
},
            new Int32MArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int32[,] { { 1241093974, 1102143092, }, { 373962224, 822132094, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.Int32[,] { { 1185506363, 981896664, }, { 1462726443, 57320273, }, },
    NullableValue = 
new System.Int32[,] { { 1726610995, 1383268935, }, { 1658633906, 2072876465, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 103,
    Value = 
new System.Int32[,] { { 1346066209, 1504768730, }, { 2099394277, 682662446, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Int32[,] { { 2108627966, 1664673343, }, { 48159928, 684883737, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 108,
    Value = 
new System.Int32[,] { { 957061347, 1915094163, }, { 217936124, 1546168498, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Int32[,] { { 1615243592, 1901687456, }, { 538911735, 847293241, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int32[,] { { 1088069406, 810805673, }, { 601196810, 152149155, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Int32[,] { { 1728312653, 506099098, }, { 1847298253, 1308807424, }, },
    NullableValue = 
new System.Int32[,] { { 1142855458, 1929762019, }, { 1244063863, 1965349207, }, },
},
    NullableValue = 
new System.Int32[,] { { 1186144311, 323595299, }, { 1563519720, 1091635993, }, },
},
            new Int32MArrayD2E1M
{
    Id = 115,
    Value = 
new System.Int32[,] { { 930645315, 1002093969, }, { 1688089585, 131620941, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Int32[,] { { 1099708037, 616630817, }, { 292429743, 1461099703, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 122,
    Value = 
new System.Int32[,] { { 416759587, 696449582, }, { 2093679757, 660438010, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Int32[,] { { 1593835511, 134146385, }, { 1836663892, 1297919747, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 127,
    Value = 
new System.Int32[,] { { 985714482, 1094651773, }, { 310198523, 768624426, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Int32[,] { { 1769324428, 1496518975, }, { 1186252187, 1879835684, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 131,
    Value = 
new System.Int32[,] { { 595078865, 2041985063, }, { 1655845745, 367901775, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Int32[,] { { 646978958, 66614439, }, { 1475487396, 383645415, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 953258615, 1180462111, }, { 887828116, 1466778570, }, },
},
            new Int32MArrayD2E1M
{
    Id = 139,
    Value = 
new System.Int32[,] { { 339224410, 1328347819, }, { 1333521590, 415690556, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Int32[,] { { 1902674417, 1720046759, }, { 302434267, 1289990126, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 145,
    Value = 
new System.Int32[,] { { 1365078787, 1860532318, }, { 1346068574, 1852779409, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Int32[,] { { 1658940023, 1516590, }, { 1613718451, 1971526901, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int32[,] { { 279884818, 1766845251, }, { 972948420, 1229580884, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 152,
    Value = 
new System.Int32[,] { { 989947134, 1929626661, }, { 1568819321, 783637837, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 154,
    Value = 
new System.Int32[,] { { 1255325998, 1601818907, }, { 1562155707, 2085791174, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Int32[,] { { 2072212201, 1810227371, }, { 890336705, 1092515625, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 34435178, 627169810, }, { 162835856, 1619526353, }, },
},
            new Int32MArrayD2E1M
{
    Id = 157,
    Value = 
new System.Int32[,] { { 54294639, 1368649967, }, { 864182772, 546547518, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Int32[,] { { 1562112404, 1698902333, }, { 1566968239, 1486199287, }, },
    NullableValue = 
new System.Int32[,] { { 2105930893, 297620355, }, { 141203201, 592769155, }, },
},
    NullableValue = 
new System.Int32[,] { { 1653722593, 22628069, }, { 626984473, 1924944939, }, },
},
            new Int32MArrayD2E1M
{
    Id = 163,
    Value = 
new System.Int32[,] { { 1833467451, 1953497781, }, { 1844851091, 1483977245, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Int32[,] { { 1531349044, 2008178398, }, { 855619301, 1690757228, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 783455146, 7081483, }, { 1510351571, 132539552, }, },
},
            new Int32MArrayD2E1M
{
    Id = 171,
    Value = 
new System.Int32[,] { { 1445275177, 219111890, }, { 1198014537, 1775117323, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Int32[,] { { 262512468, 312581268, }, { 325198842, 404431778, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 177,
    Value = 
new System.Int32[,] { { 920691530, 1431426795, }, { 485801359, 715165555, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 173,
    Value = 
new System.Int32[,] { { 109196917, 267616803, }, { 1561904683, 734430607, }, },
    NullableValue = 
new System.Int32[,] { { 99467814, 1990697191, }, { 1000823267, 1155107149, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 181,
    Value = 
new System.Int32[,] { { 1632187602, 523336005, }, { 415368701, 2072772118, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 181,
    Value = 
new System.Int32[,] { { 2090551855, 925300225, }, { 130600060, 1156004029, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1407523698, 7302740, }, { 1545181315, 1801191194, }, },
},
            new Int32MArrayD2E1M
{
    Id = 186,
    Value = 
new System.Int32[,] { { 1147259739, 397688265, }, { 1430952588, 706615798, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 189,
    Value = 
new System.Int32[,] { { 1042452971, 1448295669, }, { 72917380, 427918443, }, },
    NullableValue = 
new System.Int32[,] { { 392586844, 1758493977, }, { 1503373571, 1741413729, }, },
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


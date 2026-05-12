

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
    Id = 4,
    Value = 
new System.Int32[,] { { 85264787, 213549045, }, { 38716641, 1038946170, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Int32[,] { { 1089964460, 577634297, }, { 1878793552, 1796287939, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 9,
    Value = 
new System.Int32[,] { { 478965849, 2017543638, }, { 1953349758, 1007403634, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int32[,] { { 1722145346, 1447889777, }, { 2121031470, 746095495, }, },
    NullableValue = 
new System.Int32[,] { { 1811934538, 1751519963, }, { 245518593, 1269633041, }, },
},
    NullableValue = 
new System.Int32[,] { { 619766834, 2074700126, }, { 1718376835, 1737433798, }, },
},
            new Int32MArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int32[,] { { 1502517383, 422260602, }, { 13426325, 872266654, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Int32[,] { { 14714212, 385824728, }, { 1602353012, 1343839597, }, },
    NullableValue = 
new System.Int32[,] { { 2125523504, 117226010, }, { 113980067, 1138268244, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 18,
    Value = 
new System.Int32[,] { { 24128293, 1020906267, }, { 1427303481, 1650021815, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Int32[,] { { 48809148, 1884972864, }, { 1143776126, 604439796, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 23,
    Value = 
new System.Int32[,] { { 376699120, 1288209299, }, { 1562211359, 852242098, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Int32[,] { { 352647384, 420252329, }, { 357907023, 1654706066, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int32[,] { { 1340452268, 1090177486, }, { 33471095, 1186714135, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Int32[,] { { 408761001, 1893111720, }, { 193012934, 424799718, }, },
    NullableValue = 
new System.Int32[,] { { 935357201, 903573685, }, { 1428397528, 1131825072, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 36,
    Value = 
new System.Int32[,] { { 1005302661, 1315295821, }, { 396158883, 942421911, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Int32[,] { { 1316227387, 1668188003, }, { 1649614202, 389832474, }, },
    NullableValue = 
new System.Int32[,] { { 469007885, 1697750204, }, { 287727823, 1371323698, }, },
},
    NullableValue = 
new System.Int32[,] { { 654210100, 1754158240, }, { 1820564584, 758701636, }, },
},
            new Int32MArrayD2E1M
{
    Id = 40,
    Value = 
new System.Int32[,] { { 983326464, 922218390, }, { 2106393896, 2039099257, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Int32[,] { { 369710351, 1223135114, }, { 716545900, 373680559, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 49,
    Value = 
new System.Int32[,] { { 197772905, 43229092, }, { 328509089, 1155769837, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Int32[,] { { 1641391156, 414166562, }, { 950519892, 710948499, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 50,
    Value = 
new System.Int32[,] { { 481569101, 810877344, }, { 1116380074, 1554922794, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Int32[,] { { 2121503113, 2094571071, }, { 390801619, 2109931214, }, },
    NullableValue = 
new System.Int32[,] { { 379324472, 136436810, }, { 1967127667, 1410443167, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 55,
    Value = 
new System.Int32[,] { { 9286073, 801359482, }, { 576253807, 1599445712, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int32[,] { { 1245580874, 1235852559, }, { 41095081, 434866911, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 57,
    Value = 
new System.Int32[,] { { 727396661, 1904138676, }, { 856716392, 121773567, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Int32[,] { { 1790528460, 1550657287, }, { 106240645, 1656912880, }, },
    NullableValue = 
new System.Int32[,] { { 66652832, 227435631, }, { 1720263487, 758635385, }, },
},
    NullableValue = 
new System.Int32[,] { { 985972943, 544904977, }, { 435089902, 629911107, }, },
},
            new Int32MArrayD2E1M
{
    Id = 58,
    Value = 
new System.Int32[,] { { 156079485, 1383030307, }, { 1042734956, 1523791121, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Int32[,] { { 1988132482, 280251050, }, { 1745862823, 1337146658, }, },
    NullableValue = 
new System.Int32[,] { { 1464400089, 645718061, }, { 925337284, 1222751583, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 59,
    Value = 
new System.Int32[,] { { 1786958470, 2065017097, }, { 52800402, 741893413, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int32[,] { { 1958512999, 1646651315, }, { 671608252, 1312349846, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 61,
    Value = 
new System.Int32[,] { { 690718993, 419762042, }, { 902379568, 683655714, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int32[,] { { 328607301, 418532472, }, { 93286440, 1919522681, }, },
    NullableValue = 
new System.Int32[,] { { 1977098049, 2081655331, }, { 168642898, 1160545100, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int32[,] { { 1237491205, 734093312, }, { 350991506, 430751336, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Int32[,] { { 964579742, 563278352, }, { 139306778, 816874048, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 923951441, 1580508667, }, { 1026718941, 221169961, }, },
},
            new Int32MArrayD2E1M
{
    Id = 72,
    Value = 
new System.Int32[,] { { 1438107015, 1498675364, }, { 209363142, 137498328, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Int32[,] { { 1781066017, 576897797, }, { 2036747562, 1245489564, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 81,
    Value = 
new System.Int32[,] { { 1773269182, 1791818710, }, { 1193249285, 11933085, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Int32[,] { { 1955955675, 1388851706, }, { 1301905106, 1234902479, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 353135990, 953538887, }, { 941419801, 1135442658, }, },
},
            new Int32MArrayD2E1M
{
    Id = 87,
    Value = 
new System.Int32[,] { { 152399492, 833752248, }, { 1451120107, 503021365, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Int32[,] { { 682961130, 2065790914, }, { 1759855161, 1155622905, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 92,
    Value = 
new System.Int32[,] { { 401141522, 558127851, }, { 1863140588, 1866972360, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.Int32[,] { { 242137491, 37034108, }, { 1398812180, 503605217, }, },
    NullableValue = 
new System.Int32[,] { { 2001560689, 276291527, }, { 874095045, 287631851, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 95,
    Value = 
new System.Int32[,] { { 210182267, 1728715152, }, { 178055747, 850613483, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.Int32[,] { { 70666217, 1344295077, }, { 1659731977, 1078825656, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 360613332, 310459269, }, { 1172569421, 20898542, }, },
},
            new Int32MArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int32[,] { { 1451023343, 912732188, }, { 644888598, 1811262997, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Int32[,] { { 1918481186, 1614006563, }, { 802850901, 1831603639, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 106,
    Value = 
new System.Int32[,] { { 949791101, 1351650492, }, { 411271150, 317298086, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Int32[,] { { 1233256176, 1445627700, }, { 1466935084, 1674216846, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 113,
    Value = 
new System.Int32[,] { { 85708966, 1110813797, }, { 1713502190, 230508130, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Int32[,] { { 1632804898, 1741115265, }, { 377967876, 1624546360, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 944428019, 504331045, }, { 1370201106, 1264888569, }, },
},
            new Int32MArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int32[,] { { 1675473999, 2019308689, }, { 824261459, 1342064457, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 127,
    Value = 
new System.Int32[,] { { 336580726, 219415373, }, { 1148133565, 1030514205, }, },
    NullableValue = 
new System.Int32[,] { { 426844017, 526545545, }, { 116092627, 1872689108, }, },
},
    NullableValue = 
new System.Int32[,] { { 353919949, 775926450, }, { 687742833, 1796038953, }, },
},
            new Int32MArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int32[,] { { 1836553158, 918199133, }, { 1623108836, 1895725655, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Int32[,] { { 1045206954, 758984837, }, { 777317869, 1832170500, }, },
    NullableValue = 
new System.Int32[,] { { 74684338, 227487171, }, { 1696459667, 538156338, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 123,
    Value = 
new System.Int32[,] { { 1834989791, 929620739, }, { 684816799, 29237286, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Int32[,] { { 1122842998, 899473804, }, { 1565411891, 1544546171, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 88396135, 880389451, }, { 1849220267, 1734317324, }, },
},
            new Int32MArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int32[,] { { 587651332, 1038022776, }, { 2053431824, 892089957, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 137,
    Value = 
new System.Int32[,] { { 761545356, 266402188, }, { 386776968, 763935061, }, },
    NullableValue = 
new System.Int32[,] { { 1587612088, 1267514678, }, { 929981282, 651785937, }, },
},
    NullableValue = 
new System.Int32[,] { { 1706683001, 1240043548, }, { 205076541, 340492994, }, },
},
            new Int32MArrayD2E1M
{
    Id = 135,
    Value = 
new System.Int32[,] { { 738984525, 386367517, }, { 385648086, 1048177095, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int32[,] { { 1212077155, 968915848, }, { 1169250288, 1318347248, }, },
    NullableValue = 
new System.Int32[,] { { 1134551449, 227514131, }, { 1917148779, 153359177, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 141,
    Value = 
new System.Int32[,] { { 436214529, 18910061, }, { 1018879787, 1008669954, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.Int32[,] { { 1881706788, 1513781964, }, { 511950506, 1729465066, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int32[,] { { 722649301, 277071155, }, { 1086635173, 1675628601, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.Int32[,] { { 2076083637, 2061265876, }, { 1583906625, 4034382, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 149,
    Value = 
new System.Int32[,] { { 339993313, 1545464163, }, { 1889465596, 792234060, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Int32[,] { { 439781357, 868890707, }, { 1716548457, 481540481, }, },
    NullableValue = 
new System.Int32[,] { { 1536930543, 118942427, }, { 6848535, 1869543902, }, },
},
    NullableValue = 
new System.Int32[,] { { 1263247360, 1212843602, }, { 1908246846, 737622472, }, },
},
            new Int32MArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int32[,] { { 2034490650, 249312127, }, { 2019058943, 820896670, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 157,
    Value = 
new System.Int32[,] { { 149948364, 1392901580, }, { 877626487, 926275676, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1606053418, 1879396857, }, { 939246659, 2099462755, }, },
},
            new Int32MArrayD2E1M
{
    Id = 161,
    Value = 
new System.Int32[,] { { 1784940922, 1567139408, }, { 628625371, 1976047405, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Int32[,] { { 1308299253, 425974827, }, { 767465154, 2012647919, }, },
    NullableValue = 
new System.Int32[,] { { 565861652, 1336224773, }, { 1102018768, 656009926, }, },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 164,
    Value = 
new System.Int32[,] { { 2007540072, 1138474630, }, { 418246757, 1376853049, }, },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 172,
    Value = 
new System.Int32[,] { { 524585551, 1349883072, }, { 1279291302, 902001478, }, },
    NullableValue = 
new System.Int32[,] { { 1654010314, 1981109621, }, { 460613943, 702549157, }, },
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


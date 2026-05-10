

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
    internal partial interface IInt32ArrayInt32Array
    {
    }
    
    internal partial class Int32ArrayInt32Array : IInt32ArrayInt32Array
    {


#region TestData

        private readonly Int32Int32Array1M[] _testData = new Int32Int32Array1M[]
        {
            new Int32Int32Array1M
{
    Id = 1,
    Value = 
new System.Int32[3]
{
669266948,
1561262067,
2084178634,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 7,
    Value = 
new System.Int32[4]
{
1073633609,
1270210547,
1290688491,
1124473,
},
    NullableValue = 
new System.Int32[3]
{
442570873,
1366843783,
271012545,
},
},
    NullableValue = 
new System.Int32[4]
{
440825507,
2114553478,
904974581,
410762887,
},
},
            new Int32Int32Array1M
{
    Id = 9,
    Value = 
new System.Int32[4]
{
1297399053,
84374041,
1062546481,
631026568,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 15,
    Value = 
new System.Int32[3]
{
862195307,
1516707842,
769927178,
},
    NullableValue = 
new System.Int32[4]
{
1734841232,
373094847,
365308405,
1677068638,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 15,
    Value = 
new System.Int32[4]
{
1570051558,
1393066572,
1139965591,
1829813351,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 18,
    Value = 
new System.Int32[4]
{
1032239692,
1947456724,
1343121130,
886934048,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 22,
    Value = 
new System.Int32[3]
{
827934997,
890492756,
220774720,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 19,
    Value = 
new System.Int32[3]
{
1617389334,
881941767,
1088999644,
},
    NullableValue = 
new System.Int32[4]
{
1499628930,
389157365,
1133956559,
129876335,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 24,
    Value = 
new System.Int32[4]
{
647662080,
1727174217,
1230234465,
848844417,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 26,
    Value = 
new System.Int32[4]
{
897523238,
1944342265,
68991879,
482852405,
},
    NullableValue = 
new System.Int32[4]
{
1613296726,
10560378,
1518273751,
1663974525,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 27,
    Value = 
new System.Int32[3]
{
1448772237,
24285909,
884456221,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 32,
    Value = 
new System.Int32[4]
{
1930168613,
1749834949,
1307847788,
898296549,
},
    NullableValue = 
new System.Int32[3]
{
275738127,
1624316255,
1948264465,
},
},
    NullableValue = 
new System.Int32[4]
{
1082757666,
1497788429,
116513228,
1696146488,
},
},
            new Int32Int32Array1M
{
    Id = 33,
    Value = 
new System.Int32[4]
{
1362422967,
111204508,
13032937,
362132374,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 39,
    Value = 
new System.Int32[4]
{
302817782,
916448520,
1921200176,
1553212955,
},
    NullableValue = 
new System.Int32[4]
{
1409527486,
758146505,
491196375,
227358519,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 34,
    Value = 
new System.Int32[3]
{
1495634230,
520205197,
449882515,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 48,
    Value = 
new System.Int32[4]
{
807260352,
1882254608,
1251323556,
922029671,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 41,
    Value = 
new System.Int32[3]
{
1167079050,
467440951,
502198429,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 56,
    Value = 
new System.Int32[3]
{
10853656,
356390733,
1770772363,
},
    NullableValue = 
new System.Int32[4]
{
1917763845,
1528120383,
841878539,
455242006,
},
},
    NullableValue = 
new System.Int32[4]
{
320892867,
1734245537,
886278288,
1761761001,
},
},
            new Int32Int32Array1M
{
    Id = 42,
    Value = 
new System.Int32[3]
{
722864223,
402728713,
105286993,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 64,
    Value = 
new System.Int32[4]
{
1681183756,
1209107415,
1894561906,
2121527373,
},
    NullableValue = 
new System.Int32[4]
{
1708552280,
1283075799,
2064152434,
1398121440,
},
},
    NullableValue = 
new System.Int32[4]
{
1277565957,
1564949411,
937313297,
1334728027,
},
},
            new Int32Int32Array1M
{
    Id = 44,
    Value = 
new System.Int32[3]
{
1452013439,
1732293062,
358989254,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 68,
    Value = 
new System.Int32[4]
{
925784396,
641303591,
1990406137,
2126651528,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1000483557,
986454641,
2027203076,
},
},
            new Int32Int32Array1M
{
    Id = 46,
    Value = 
new System.Int32[4]
{
769188163,
48343185,
604488731,
1861885390,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 71,
    Value = 
new System.Int32[4]
{
408915159,
2038548086,
1607502704,
764881234,
},
    NullableValue = 
new System.Int32[3]
{
2118827190,
1102116949,
453117918,
},
},
    NullableValue = 
new System.Int32[4]
{
1698225516,
350197779,
1660875101,
1501209088,
},
},
            new Int32Int32Array1M
{
    Id = 50,
    Value = 
new System.Int32[3]
{
1863030805,
1844028295,
393472035,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 75,
    Value = 
new System.Int32[3]
{
1279162005,
158742337,
347399069,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1646067524,
392017129,
285890062,
2125948605,
},
},
            new Int32Int32Array1M
{
    Id = 54,
    Value = 
new System.Int32[4]
{
434440390,
226231663,
456651615,
1514057656,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 78,
    Value = 
new System.Int32[3]
{
2085430950,
1073007250,
1897092571,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 55,
    Value = 
new System.Int32[4]
{
1024114126,
1187355054,
1799483780,
1307072560,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 85,
    Value = 
new System.Int32[4]
{
54226712,
399203671,
1275635569,
604247173,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
749576349,
158292909,
2043731010,
},
},
            new Int32Int32Array1M
{
    Id = 57,
    Value = 
new System.Int32[4]
{
1478654002,
2055542708,
803250715,
1266678152,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 94,
    Value = 
new System.Int32[3]
{
2014064965,
1014374237,
2027115638,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 60,
    Value = 
new System.Int32[4]
{
689892200,
907583876,
967666506,
1162343887,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 103,
    Value = 
new System.Int32[4]
{
890447183,
215763925,
1022153288,
1073117779,
},
    NullableValue = 
new System.Int32[3]
{
1505081471,
543153561,
898278258,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 64,
    Value = 
new System.Int32[3]
{
240075431,
2077847015,
926285070,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 109,
    Value = 
new System.Int32[3]
{
1860078841,
1747294292,
1943733142,
},
    NullableValue = 
new System.Int32[3]
{
1032218510,
2016149348,
1918827700,
},
},
    NullableValue = 
new System.Int32[3]
{
304092639,
1892404731,
609808752,
},
},
            new Int32Int32Array1M
{
    Id = 69,
    Value = 
new System.Int32[4]
{
2087887197,
52759904,
542570335,
356347723,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 112,
    Value = 
new System.Int32[4]
{
2108010098,
267597837,
1764725166,
1541802860,
},
    NullableValue = 
new System.Int32[3]
{
101300715,
341789876,
371357270,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 71,
    Value = 
new System.Int32[4]
{
1855935767,
1766029474,
602055237,
1743032774,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 120,
    Value = 
new System.Int32[3]
{
1974087471,
1285192091,
2050854083,
},
    NullableValue = 
new System.Int32[3]
{
10990159,
2131076214,
1953894747,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 78,
    Value = 
new System.Int32[4]
{
1078951511,
1492835762,
2096221175,
1553068567,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 123,
    Value = 
new System.Int32[3]
{
85191006,
1642262521,
1722569026,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 85,
    Value = 
new System.Int32[3]
{
1021230206,
978449098,
1530102761,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 132,
    Value = 
new System.Int32[4]
{
1699804254,
1765020742,
77714953,
1411744835,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 87,
    Value = 
new System.Int32[3]
{
1284208717,
1450421675,
1500777307,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 138,
    Value = 
new System.Int32[4]
{
223366050,
620723585,
446526401,
1199057382,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
81472066,
1812647638,
1330054669,
2059524463,
},
},
            new Int32Int32Array1M
{
    Id = 89,
    Value = 
new System.Int32[3]
{
1998865465,
1081193241,
1238482512,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 146,
    Value = 
new System.Int32[3]
{
1881786771,
291347325,
185247494,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 94,
    Value = 
new System.Int32[3]
{
184368231,
721717024,
1087556000,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 148,
    Value = 
new System.Int32[3]
{
1058589882,
245638499,
380801977,
},
    NullableValue = 
new System.Int32[3]
{
1247655522,
1488139451,
1161889711,
},
},
    NullableValue = 
new System.Int32[4]
{
397068928,
383486900,
2045562935,
196269066,
},
},
            new Int32Int32Array1M
{
    Id = 99,
    Value = 
new System.Int32[4]
{
889921343,
1028120735,
132769958,
1798786308,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 155,
    Value = 
new System.Int32[4]
{
996098188,
907937032,
1643877103,
1296561094,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 102,
    Value = 
new System.Int32[3]
{
313974686,
833967045,
1980658516,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 162,
    Value = 
new System.Int32[3]
{
601206589,
1356830679,
36388585,
},
    NullableValue = 
new System.Int32[3]
{
2124348087,
1376940984,
1677641961,
},
},
    NullableValue = 
new System.Int32[3]
{
762325100,
487716623,
1680380694,
},
},
            new Int32Int32Array1M
{
    Id = 105,
    Value = 
new System.Int32[4]
{
1609205819,
1585175837,
1052436574,
734756054,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 165,
    Value = 
new System.Int32[3]
{
1000421745,
1299959096,
341713695,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 108,
    Value = 
new System.Int32[4]
{
208575494,
1954984944,
1239702813,
562383647,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 169,
    Value = 
new System.Int32[3]
{
445451782,
2124035161,
1281939580,
},
    NullableValue = 
new System.Int32[3]
{
3969113,
286568273,
1445792651,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 110,
    Value = 
new System.Int32[3]
{
1629640653,
1272490075,
1858206791,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 176,
    Value = 
new System.Int32[4]
{
1288095647,
27029994,
846108925,
1797665222,
},
    NullableValue = 
new System.Int32[4]
{
966031935,
1402689374,
1796076666,
1112919522,
},
},
    NullableValue = null,
},
            new Int32Int32Array1M
{
    Id = 119,
    Value = 
new System.Int32[4]
{
148760985,
1931929102,
1779770787,
1254940311,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 183,
    Value = 
new System.Int32[4]
{
160803954,
357372574,
521347114,
1954129479,
},
    NullableValue = 
new System.Int32[4]
{
1673506643,
2023809001,
693263756,
332226332,
},
},
    NullableValue = 
new System.Int32[4]
{
372296573,
1085996046,
820428058,
907988219,
},
},
            new Int32Int32Array1M
{
    Id = 122,
    Value = 
new System.Int32[3]
{
779102982,
677790458,
1259360259,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 187,
    Value = 
new System.Int32[4]
{
168479413,
13974960,
116936748,
1714520195,
},
    NullableValue = 
new System.Int32[3]
{
455251980,
904893981,
2073644593,
},
},
    NullableValue = 
new System.Int32[3]
{
691991069,
754510916,
778590749,
},
},
            new Int32Int32Array1M
{
    Id = 128,
    Value = 
new System.Int32[3]
{
1477732636,
759460470,
872342812,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 193,
    Value = 
new System.Int32[4]
{
1227581233,
1336093920,
69718553,
1688970573,
},
    NullableValue = 
new System.Int32[4]
{
886535276,
1737303327,
1946063481,
1395820620,
},
},
    NullableValue = 
new System.Int32[4]
{
2120609582,
1549783885,
2050621128,
1793432821,
},
},
            new Int32Int32Array1M
{
    Id = 132,
    Value = 
new System.Int32[3]
{
1120375097,
118577948,
56511662,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 199,
    Value = 
new System.Int32[3]
{
1126642917,
554596919,
1315614982,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
101200290,
1004384170,
49441625,
},
},
            new Int32Int32Array1M
{
    Id = 141,
    Value = 
new System.Int32[3]
{
1413057986,
1177595341,
2111846240,
},
    ModelInner = new Int32Int32Array1MI
{
    Id = 207,
    Value = 
new System.Int32[4]
{
273957082,
285183192,
1195434840,
606150009,
},
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
INSERT INTO gedaqtests.int32int32array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int32[]}, 
    {mi_id:Int32},
    {mi_value:Int32[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayInt32Array)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
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
                    await ((IInt32ArrayInt32Array)this).InsertModelDbConnectionAsync(
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
                     ((IInt32ArrayInt32Array)this).InsertModelDbConnection(
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
FROM gedaqtests.int32int32array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32Int32Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayInt32Array)),
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
                    var models = await ((IInt32ArrayInt32Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32Int32Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32ArrayInt32Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32Int32Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


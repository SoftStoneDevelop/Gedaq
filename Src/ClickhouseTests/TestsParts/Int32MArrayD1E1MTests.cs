

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
    internal partial interface IInt32MArrayMArrayD1
    {
    }
    
    internal partial class Int32MArrayMArrayD1 : IInt32MArrayMArrayD1
    {


#region TestData

        private readonly Int32MArrayD1E1M[] _testData = new Int32MArrayD1E1M[]
        {
            new Int32MArrayD1E1M
{
    Id = 6,
    Value = 
new System.Int32[3]
{
676212420,
1525035056,
494560198,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int32[3]
{
477126018,
92450031,
1971639725,
},
    NullableValue = 
new System.Int32[3]
{
525057452,
321686433,
1062146321,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int32[3]
{
1193651389,
1229934257,
471236500,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Int32[4]
{
1191258157,
1940959187,
1716637607,
1683764894,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int32[3]
{
1573760041,
469825309,
1048046220,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Int32[4]
{
1775921836,
1434966754,
1572296982,
1438188872,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
785995716,
193841691,
1458494192,
},
},
            new Int32MArrayD1E1M
{
    Id = 10,
    Value = 
new System.Int32[3]
{
1111941653,
1690892794,
610347546,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Int32[4]
{
2000400076,
1566169485,
537459809,
493331832,
},
    NullableValue = 
new System.Int32[3]
{
1011283994,
279669563,
1588087057,
},
},
    NullableValue = 
new System.Int32[3]
{
1142899649,
299571451,
1928948712,
},
},
            new Int32MArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int32[3]
{
376430210,
1522647968,
707707027,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Int32[3]
{
284125194,
206101864,
710213923,
},
    NullableValue = 
new System.Int32[4]
{
835485951,
1327772844,
772786817,
133232301,
},
},
    NullableValue = 
new System.Int32[4]
{
1069747628,
1733507144,
277871251,
2085855933,
},
},
            new Int32MArrayD1E1M
{
    Id = 27,
    Value = 
new System.Int32[4]
{
2045233606,
2125483549,
751526121,
1600274218,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int32[4]
{
1358008308,
1583787998,
299083488,
1679707866,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int32[3]
{
752632064,
35290045,
236708643,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Int32[3]
{
391470413,
1267526603,
679858304,
},
    NullableValue = 
new System.Int32[3]
{
1814938035,
605964200,
1101921233,
},
},
    NullableValue = 
new System.Int32[4]
{
295647832,
957446541,
221995375,
1981077278,
},
},
            new Int32MArrayD1E1M
{
    Id = 44,
    Value = 
new System.Int32[3]
{
2092585512,
1103507120,
975958243,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Int32[3]
{
1925630948,
2146456002,
761228318,
},
    NullableValue = 
new System.Int32[3]
{
1098313664,
1206644518,
179833008,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int32[4]
{
1089587968,
1727262092,
1854816446,
2112721127,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Int32[3]
{
1050174545,
1943035678,
172358391,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
448313315,
2132474108,
1761603014,
},
},
            new Int32MArrayD1E1M
{
    Id = 49,
    Value = 
new System.Int32[3]
{
1162737614,
1897565518,
954048659,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int32[3]
{
1111406239,
239684177,
1568481977,
},
    NullableValue = 
new System.Int32[4]
{
38138346,
18801656,
261326797,
1056804851,
},
},
    NullableValue = 
new System.Int32[4]
{
699884939,
1872766169,
1599236137,
677034169,
},
},
            new Int32MArrayD1E1M
{
    Id = 58,
    Value = 
new System.Int32[3]
{
2131670857,
1367169100,
2055506033,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Int32[3]
{
2028213246,
1380381919,
350937479,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
826802718,
1618221942,
1706243242,
1272020376,
},
},
            new Int32MArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int32[3]
{
845410500,
2003101421,
1866862544,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int32[4]
{
504691063,
1211711391,
1798520408,
887180648,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 74,
    Value = 
new System.Int32[3]
{
2084760887,
1223922871,
746750318,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Int32[3]
{
1524623447,
42146980,
1329712425,
},
    NullableValue = 
new System.Int32[4]
{
270918483,
1628532387,
949010205,
1050242353,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 82,
    Value = 
new System.Int32[4]
{
835537839,
444749458,
2080795185,
612011040,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Int32[3]
{
20145951,
1733319437,
1563767972,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 91,
    Value = 
new System.Int32[4]
{
277812187,
10550146,
1001034826,
862791858,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Int32[4]
{
1372385209,
1483036611,
511843217,
1969873005,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
446311698,
1162308590,
567321560,
366690992,
},
},
            new Int32MArrayD1E1M
{
    Id = 96,
    Value = 
new System.Int32[4]
{
410076563,
1978015339,
799380026,
1954097267,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int32[3]
{
1179538391,
668637350,
106101604,
},
    NullableValue = 
new System.Int32[3]
{
962702638,
791720423,
831777780,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int32[3]
{
292600648,
2038008409,
1776219831,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Int32[4]
{
1288639343,
1880490979,
637043326,
950569936,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1219826637,
192299980,
1334631501,
1160103044,
},
},
            new Int32MArrayD1E1M
{
    Id = 106,
    Value = 
new System.Int32[4]
{
471657870,
442604995,
1713661637,
469891334,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Int32[4]
{
1552723131,
857193775,
903260854,
1130160641,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int32[3]
{
2104245811,
530137009,
1125380510,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.Int32[4]
{
525625076,
1531908750,
83987051,
1010355022,
},
    NullableValue = 
new System.Int32[4]
{
1473235852,
545854238,
838876858,
1305169014,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 119,
    Value = 
new System.Int32[3]
{
1261518480,
1142323194,
1937435921,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.Int32[3]
{
936337422,
1935526980,
1114279089,
},
    NullableValue = 
new System.Int32[3]
{
219147428,
244342316,
196130064,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 125,
    Value = 
new System.Int32[3]
{
330665723,
1935624174,
1886242078,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 117,
    Value = 
new System.Int32[4]
{
1184342451,
1018733114,
756864331,
361338834,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 128,
    Value = 
new System.Int32[3]
{
232882039,
1023390451,
381858647,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Int32[3]
{
1032798823,
1281405675,
1084660109,
},
    NullableValue = 
new System.Int32[3]
{
206436093,
1114698667,
464872102,
},
},
    NullableValue = 
new System.Int32[4]
{
2139286542,
2125751089,
1092970883,
40388258,
},
},
            new Int32MArrayD1E1M
{
    Id = 130,
    Value = 
new System.Int32[3]
{
1227307115,
1615945932,
187329322,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Int32[4]
{
1969379051,
1615317679,
1677077582,
1266137025,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 137,
    Value = 
new System.Int32[3]
{
1892388602,
1594556628,
2109108149,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Int32[3]
{
802689681,
244095686,
1204866540,
},
    NullableValue = 
new System.Int32[3]
{
2100031664,
1508141365,
811538033,
},
},
    NullableValue = 
new System.Int32[3]
{
392214562,
392743152,
731741401,
},
},
            new Int32MArrayD1E1M
{
    Id = 142,
    Value = 
new System.Int32[3]
{
1716517545,
97473241,
1395449089,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 144,
    Value = 
new System.Int32[4]
{
800676571,
614280252,
1862744701,
1440697281,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1814457316,
930157821,
1743368524,
},
},
            new Int32MArrayD1E1M
{
    Id = 150,
    Value = 
new System.Int32[3]
{
2019618030,
241540284,
1735049846,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Int32[3]
{
1132080335,
356584124,
1245457014,
},
    NullableValue = 
new System.Int32[3]
{
926760507,
116183052,
1989084583,
},
},
    NullableValue = 
new System.Int32[4]
{
630195464,
1046667605,
1863985713,
586891928,
},
},
            new Int32MArrayD1E1M
{
    Id = 156,
    Value = 
new System.Int32[4]
{
960640106,
22365523,
975902266,
291784140,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 152,
    Value = 
new System.Int32[4]
{
660813575,
1639244731,
507989161,
1461882937,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 162,
    Value = 
new System.Int32[4]
{
1945121133,
838156469,
1551985504,
1324725241,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Int32[3]
{
1686823565,
732948383,
802228117,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 164,
    Value = 
new System.Int32[4]
{
962058397,
282974023,
550417089,
1110178355,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 161,
    Value = 
new System.Int32[4]
{
412090587,
1796187665,
718850102,
2060079159,
},
    NullableValue = 
new System.Int32[3]
{
7367574,
236204582,
340762572,
},
},
    NullableValue = 
new System.Int32[3]
{
1562525977,
949780211,
1196663156,
},
},
            new Int32MArrayD1E1M
{
    Id = 170,
    Value = 
new System.Int32[3]
{
1247859674,
1707637262,
466166007,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Int32[3]
{
1633076971,
561308469,
500358648,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
407062302,
159086705,
188260508,
},
},
            new Int32MArrayD1E1M
{
    Id = 179,
    Value = 
new System.Int32[4]
{
1523798624,
1866630661,
648119911,
439336774,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.Int32[3]
{
1769777983,
1909188899,
1241607093,
},
    NullableValue = 
new System.Int32[3]
{
1400317768,
1431967882,
867073354,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 185,
    Value = 
new System.Int32[4]
{
599641646,
625699532,
1410879980,
1728049145,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 175,
    Value = 
new System.Int32[3]
{
2106753350,
1244060127,
47877192,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1296418722,
1347484890,
2047976397,
1536984411,
},
},
            new Int32MArrayD1E1M
{
    Id = 190,
    Value = 
new System.Int32[3]
{
875523352,
1030520951,
2102007053,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 176,
    Value = 
new System.Int32[3]
{
1127752865,
2053384611,
468994590,
},
    NullableValue = 
new System.Int32[3]
{
1606097222,
1797106097,
1260223066,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 193,
    Value = 
new System.Int32[4]
{
1342232157,
610863226,
881481297,
371969529,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 185,
    Value = 
new System.Int32[4]
{
359555578,
1936998909,
1730353575,
1915075953,
},
    NullableValue = 
new System.Int32[4]
{
175268774,
1793447023,
1041427872,
1573959877,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 201,
    Value = 
new System.Int32[4]
{
493525196,
1682791870,
1414914597,
1420257099,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 192,
    Value = 
new System.Int32[4]
{
42406619,
726593646,
368793593,
589665000,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
6823486,
1914691814,
118491756,
468621571,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int32)}, 
    {mi_id:Int32},
    {mi_value:Array(Int32)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayMArrayD1)),
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
                    await ((IInt32MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IInt32MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.int32marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayMArrayD1)),
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
                    var models = await ((IInt32MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}




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
new System.Int32[,] { {
807839894,
1336941286, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Int32[,] { {
357784653,
1314827901, } },
    NullableValue = 
new System.Int32[,] { {
1043210909,
83444552, } },
},
    NullableValue = 
new System.Int32[,] { {
456061461,
1394450572, } },
},
            new Int32MArrayD2E1M
{
    Id = 12,
    Value = 
new System.Int32[,] { {
315613266,
1989011036, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int32[,] { {
1207350200,
1119612823, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int32[,] { {
1718090181,
76401283, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Int32[,] { {
1594168442,
467226941, } },
    NullableValue = 
new System.Int32[,] { {
40956241,
79125828, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 22,
    Value = 
new System.Int32[,] { {
1177943532,
1631427821, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int32[,] { {
1693416280,
1580957320, } },
    NullableValue = 
new System.Int32[,] { {
764487992,
1099133276, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 30,
    Value = 
new System.Int32[,] { {
1301763564,
1528586903, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Int32[,] { {
523115915,
560824716, } },
    NullableValue = 
new System.Int32[,] { {
497766339,
1455071183, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 35,
    Value = 
new System.Int32[,] { {
162529970,
1149389710, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Int32[,] { {
31105929,
1093749759, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
190712920,
2025970623, } },
},
            new Int32MArrayD2E1M
{
    Id = 38,
    Value = 
new System.Int32[,] { {
1592826837,
472238215, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Int32[,] { {
905730170,
1087748201, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
1534849678,
856544033, } },
},
            new Int32MArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int32[,] { {
535031214,
1803172595, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Int32[,] { {
1745939974,
1936170807, } },
    NullableValue = 
new System.Int32[,] { {
1281361861,
1856519263, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 52,
    Value = 
new System.Int32[,] { {
1861487540,
845164229, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Int32[,] { {
1017485364,
261692694, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
216375559,
673747986, } },
},
            new Int32MArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int32[,] { {
1103543600,
870447471, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Int32[,] { {
347518200,
1213792603, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 67,
    Value = 
new System.Int32[,] { {
1315141772,
1670281925, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int32[,] { {
1613898910,
989688960, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
758030810,
830845391, } },
},
            new Int32MArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int32[,] { {
1316654806,
450359684, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Int32[,] { {
1284838254,
972476339, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 77,
    Value = 
new System.Int32[,] { {
136479122,
801008341, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int32[,] { {
750628294,
178556495, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
1187736776,
1136782567, } },
},
            new Int32MArrayD2E1M
{
    Id = 78,
    Value = 
new System.Int32[,] { {
1542321627,
45125499, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Int32[,] { {
1252599954,
63772775, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
666295279,
569364363, } },
},
            new Int32MArrayD2E1M
{
    Id = 80,
    Value = 
new System.Int32[,] { {
1003227260,
637835564, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Int32[,] { {
1505938411,
99760846, } },
    NullableValue = 
new System.Int32[,] { {
921879655,
1428237276, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 82,
    Value = 
new System.Int32[,] { {
310441053,
917921102, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Int32[,] { {
325000450,
260177621, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 85,
    Value = 
new System.Int32[,] { {
686306055,
858127597, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Int32[,] { {
543908920,
2086288624, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
1971822993,
1498744327, } },
},
            new Int32MArrayD2E1M
{
    Id = 92,
    Value = 
new System.Int32[,] { {
1128362065,
36596290, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Int32[,] { {
689239450,
49801786, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 100,
    Value = 
new System.Int32[,] { {
1843491257,
987022806, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Int32[,] { {
2002695862,
254715692, } },
    NullableValue = 
new System.Int32[,] { {
1925969369,
1212376513, } },
},
    NullableValue = 
new System.Int32[,] { {
1558437348,
973059072, } },
},
            new Int32MArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int32[,] { {
1705979228,
1029907596, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Int32[,] { {
1297637849,
1502442971, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
675839427,
1396041886, } },
},
            new Int32MArrayD2E1M
{
    Id = 106,
    Value = 
new System.Int32[,] { {
265022502,
520744456, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 106,
    Value = 
new System.Int32[,] { {
66405644,
1639524964, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 114,
    Value = 
new System.Int32[,] { {
1346325207,
482247565, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Int32[,] { {
494204010,
1336028753, } },
    NullableValue = 
new System.Int32[,] { {
227980186,
405347262, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 116,
    Value = 
new System.Int32[,] { {
394266327,
1164216295, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 121,
    Value = 
new System.Int32[,] { {
553971216,
139242272, } },
    NullableValue = 
new System.Int32[,] { {
1402648445,
1575927202, } },
},
    NullableValue = 
new System.Int32[,] { {
1672710620,
4153724, } },
},
            new Int32MArrayD2E1M
{
    Id = 125,
    Value = 
new System.Int32[,] { {
578180991,
2129855009, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Int32[,] { {
1178504204,
673883718, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int32[,] { {
619500735,
227035511, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Int32[,] { {
1770059457,
949419063, } },
    NullableValue = 
new System.Int32[,] { {
951759198,
898384214, } },
},
    NullableValue = 
new System.Int32[,] { {
256455551,
1609247178, } },
},
            new Int32MArrayD2E1M
{
    Id = 139,
    Value = 
new System.Int32[,] { {
373373535,
1439264540, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 127,
    Value = 
new System.Int32[,] { {
1397817074,
1612167199, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 143,
    Value = 
new System.Int32[,] { {
1260115274,
205745896, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Int32[,] { {
1432439856,
590702848, } },
    NullableValue = 
new System.Int32[,] { {
1176543940,
508670889, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int32[,] { {
1185901795,
1970339604, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 138,
    Value = 
new System.Int32[,] { {
1013399606,
1847619341, } },
    NullableValue = 
new System.Int32[,] { {
843524195,
301598584, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int32[,] { {
382838475,
794492153, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Int32[,] { {
761672710,
1796220953, } },
    NullableValue = 
new System.Int32[,] { {
176830169,
1621685825, } },
},
    NullableValue = 
new System.Int32[,] { {
2041274129,
680710223, } },
},
            new Int32MArrayD2E1M
{
    Id = 162,
    Value = 
new System.Int32[,] { {
1301874287,
831430269, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Int32[,] { {
2068783524,
1937800410, } },
    NullableValue = 
new System.Int32[,] { {
1506136566,
1349019173, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 165,
    Value = 
new System.Int32[,] { {
161675709,
372664311, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Int32[,] { {
443306981,
1933496772, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 166,
    Value = 
new System.Int32[,] { {
545079234,
1756718837, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Int32[,] { {
67879795,
1539138537, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
417099471,
1588107173, } },
},
            new Int32MArrayD2E1M
{
    Id = 169,
    Value = 
new System.Int32[,] { {
2126812636,
2131881523, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Int32[,] { {
670118055,
207065636, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
965768883,
979298067, } },
},
            new Int32MArrayD2E1M
{
    Id = 172,
    Value = 
new System.Int32[,] { {
1244387179,
1475229351, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 168,
    Value = 
new System.Int32[,] { {
27243475,
198816424, } },
    NullableValue = 
new System.Int32[,] { {
985947487,
1539685820, } },
},
    NullableValue = null,
},
            new Int32MArrayD2E1M
{
    Id = 179,
    Value = 
new System.Int32[,] { {
1488676431,
700870514, } },
    ModelInner = new Int32MArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Int32[,] { {
256410270,
85612462, } },
    NullableValue = 
new System.Int32[,] { {
1315967009,
632988395, } },
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


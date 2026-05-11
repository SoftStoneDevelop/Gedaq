

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
    internal partial interface IInt32MArrayArrayArrayInt32
    {
    }
    
    internal partial class Int32MArrayArrayArrayInt32 : IInt32MArrayArrayArrayInt32
    {


#region TestData

        private readonly Int32ArrayArrayInt32E1M[] _testData = new Int32ArrayArrayInt32E1M[]
        {
            new Int32ArrayArrayInt32E1M
{
    Id = 3,
    Value = 
new System.Int32[,] { {
158469345,
695130560, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 1,
    Value = 
new System.Int32[,] { {
2008719183,
1872095175, } },
    NullableValue = 
new System.Int32[,] { {
1319918884,
1906569656, } },
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 10,
    Value = 
new System.Int32[,] { {
1839727059,
81551591, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 3,
    Value = 
new System.Int32[,] { {
1245428601,
220010544, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
1502898902,
672585873, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 16,
    Value = 
new System.Int32[,] { {
823219722,
1810388532, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 9,
    Value = 
new System.Int32[,] { {
534827136,
882042735, } },
    NullableValue = 
new System.Int32[,] { {
354769548,
969907042, } },
},
    NullableValue = 
new System.Int32[,] { {
1482024352,
866276853, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 25,
    Value = 
new System.Int32[,] { {
297869513,
308025412, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 12,
    Value = 
new System.Int32[,] { {
283746112,
1086602609, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 28,
    Value = 
new System.Int32[,] { {
177372671,
1534965763, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 21,
    Value = 
new System.Int32[,] { {
1463606769,
579531306, } },
    NullableValue = 
new System.Int32[,] { {
1525368868,
18693474, } },
},
    NullableValue = 
new System.Int32[,] { {
1807510409,
672527, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 37,
    Value = 
new System.Int32[,] { {
2029229021,
1323490069, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 28,
    Value = 
new System.Int32[,] { {
1776001351,
51818100, } },
    NullableValue = 
new System.Int32[,] { {
346542151,
1262382061, } },
},
    NullableValue = 
new System.Int32[,] { {
1902560639,
264417733, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 45,
    Value = 
new System.Int32[,] { {
1076940794,
1849588385, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 34,
    Value = 
new System.Int32[,] { {
1916435647,
2123917486, } },
    NullableValue = 
new System.Int32[,] { {
1573698533,
1770790197, } },
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 53,
    Value = 
new System.Int32[,] { {
307622738,
691540772, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 41,
    Value = 
new System.Int32[,] { {
1078406252,
1602419566, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 58,
    Value = 
new System.Int32[,] { {
2009808771,
231787900, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 42,
    Value = 
new System.Int32[,] { {
193703649,
1223597598, } },
    NullableValue = 
new System.Int32[,] { {
1119193641,
1663993064, } },
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 61,
    Value = 
new System.Int32[,] { {
1261848596,
1585372421, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 51,
    Value = 
new System.Int32[,] { {
573689917,
970914230, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 68,
    Value = 
new System.Int32[,] { {
1843666580,
60059520, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 52,
    Value = 
new System.Int32[,] { {
828282284,
926754323, } },
    NullableValue = 
new System.Int32[,] { {
681238731,
930157536, } },
},
    NullableValue = 
new System.Int32[,] { {
31571448,
530073545, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 75,
    Value = 
new System.Int32[,] { {
1095042867,
1455008320, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 54,
    Value = 
new System.Int32[,] { {
666864598,
1775094256, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 80,
    Value = 
new System.Int32[,] { {
25568458,
365197395, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 55,
    Value = 
new System.Int32[,] { {
370974484,
437909476, } },
    NullableValue = 
new System.Int32[,] { {
1827430069,
70495692, } },
},
    NullableValue = 
new System.Int32[,] { {
2085943142,
10065221, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 88,
    Value = 
new System.Int32[,] { {
655910478,
1150662202, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 63,
    Value = 
new System.Int32[,] { {
583886669,
1825242713, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 97,
    Value = 
new System.Int32[,] { {
1945791170,
910755262, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 71,
    Value = 
new System.Int32[,] { {
1621887767,
19949405, } },
    NullableValue = 
new System.Int32[,] { {
1982745691,
2072333501, } },
},
    NullableValue = 
new System.Int32[,] { {
1910381678,
1714467336, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 105,
    Value = 
new System.Int32[,] { {
846413488,
1764845445, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 80,
    Value = 
new System.Int32[,] { {
1195510083,
1779238125, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 107,
    Value = 
new System.Int32[,] { {
962426952,
547701791, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 84,
    Value = 
new System.Int32[,] { {
159758187,
968486532, } },
    NullableValue = 
new System.Int32[,] { {
1689294291,
271463274, } },
},
    NullableValue = 
new System.Int32[,] { {
1842972840,
1858226654, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 108,
    Value = 
new System.Int32[,] { {
20706559,
1478023445, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 86,
    Value = 
new System.Int32[,] { {
603925893,
1635914962, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
44434444,
1983375516, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 110,
    Value = 
new System.Int32[,] { {
1825788248,
1364902799, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 94,
    Value = 
new System.Int32[,] { {
684347338,
46438776, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
712223519,
1413706062, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 115,
    Value = 
new System.Int32[,] { {
472534697,
1209411964, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 98,
    Value = 
new System.Int32[,] { {
711463801,
1430472379, } },
    NullableValue = 
new System.Int32[,] { {
1649998693,
726200440, } },
},
    NullableValue = 
new System.Int32[,] { {
1489582900,
92611354, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 119,
    Value = 
new System.Int32[,] { {
446674945,
1481650705, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 107,
    Value = 
new System.Int32[,] { {
2000159018,
1088189583, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
1838562277,
47163173, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 122,
    Value = 
new System.Int32[,] { {
872154902,
104009964, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 116,
    Value = 
new System.Int32[,] { {
938286563,
1517810183, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 124,
    Value = 
new System.Int32[,] { {
1162383126,
1543412742, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 122,
    Value = 
new System.Int32[,] { {
772397647,
1003915330, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
1700439597,
742217544, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 129,
    Value = 
new System.Int32[,] { {
52470073,
1571339657, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 128,
    Value = 
new System.Int32[,] { {
482383034,
1139388696, } },
    NullableValue = 
new System.Int32[,] { {
120413280,
1598555026, } },
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 136,
    Value = 
new System.Int32[,] { {
2040050810,
1517248052, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 135,
    Value = 
new System.Int32[,] { {
1848227290,
1344647001, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 137,
    Value = 
new System.Int32[,] { {
554134338,
1700512529, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 141,
    Value = 
new System.Int32[,] { {
1840292058,
1960961309, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
602949334,
1103417686, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 146,
    Value = 
new System.Int32[,] { {
27675542,
1850546148, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 146,
    Value = 
new System.Int32[,] { {
116567015,
1011157573, } },
    NullableValue = 
new System.Int32[,] { {
2017837361,
457688865, } },
},
    NullableValue = 
new System.Int32[,] { {
1331564180,
1357708244, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 154,
    Value = 
new System.Int32[,] { {
1054744300,
1299647538, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 147,
    Value = 
new System.Int32[,] { {
431192593,
1847972256, } },
    NullableValue = 
new System.Int32[,] { {
2054197116,
375893308, } },
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 155,
    Value = 
new System.Int32[,] { {
912042075,
1437081052, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 152,
    Value = 
new System.Int32[,] { {
746269195,
1347001209, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
119930268,
770341855, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 161,
    Value = 
new System.Int32[,] { {
874778558,
759637797, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 155,
    Value = 
new System.Int32[,] { {
1004822423,
1562017435, } },
    NullableValue = 
new System.Int32[,] { {
1780793360,
1821092343, } },
},
    NullableValue = 
new System.Int32[,] { {
332573951,
682323727, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 170,
    Value = 
new System.Int32[,] { {
1684587466,
550939886, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 157,
    Value = 
new System.Int32[,] { {
1029889471,
1865777642, } },
    NullableValue = 
new System.Int32[,] { {
1362667769,
2017499941, } },
},
    NullableValue = 
new System.Int32[,] { {
2015147669,
820600091, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 177,
    Value = 
new System.Int32[,] { {
1455194868,
104869800, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 160,
    Value = 
new System.Int32[,] { {
122372978,
2089994327, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
1644869179,
1624899270, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 178,
    Value = 
new System.Int32[,] { {
1879096170,
2083092851, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 162,
    Value = 
new System.Int32[,] { {
1995270388,
110910851, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
513213790,
1397144284, } },
},
            new Int32ArrayArrayInt32E1M
{
    Id = 186,
    Value = 
new System.Int32[,] { {
1110483428,
1745877083, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 163,
    Value = 
new System.Int32[,] { {
1443486057,
1140076383, } },
    NullableValue = 
new System.Int32[,] { {
1618353250,
679933899, } },
},
    NullableValue = null,
},
            new Int32ArrayArrayInt32E1M
{
    Id = 190,
    Value = 
new System.Int32[,] { {
25371181,
1936760043, } },
    ModelInner = new Int32ArrayArrayInt321MI
{
    Id = 170,
    Value = 
new System.Int32[,] { {
810193691,
87593323, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { {
851778644,
1796512665, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32arrayarrayint32e1m(
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
            asPartInterface: typeof(IInt32MArrayArrayArrayInt32)),
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
                    await ((IInt32MArrayArrayArrayInt32)this).InsertModelDbConnectionAsync(
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
                     ((IInt32MArrayArrayArrayInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.int32arrayarrayint32e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32ArrayArrayInt32E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayArrayArrayInt32)),
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
                    var models = await ((IInt32MArrayArrayArrayInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32ArrayArrayInt32E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32MArrayArrayArrayInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32ArrayArrayInt32E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


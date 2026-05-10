

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
    internal partial interface IInt32ArrayArrayInt32
    {
    }
    
    internal partial class Int32ArrayArrayInt32 : IInt32ArrayArrayInt32
    {


#region TestData

        private readonly Int32ArrayInt321M[] _testData = new Int32ArrayInt321M[]
        {
            new Int32ArrayInt321M
{
    Id = 5,
    Value = 
new System.Int32[3]
{
2095863425,
603903330,
1198807374,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 1,
    Value = 
new System.Int32[4]
{
992610221,
337007261,
1007549446,
2116453912,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
621763552,
584314864,
1113450665,
},
},
            new Int32ArrayInt321M
{
    Id = 12,
    Value = 
new System.Int32[4]
{
1139424790,
694711100,
2031664249,
1697657065,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 8,
    Value = 
new System.Int32[3]
{
2124601943,
1171634543,
87170902,
},
    NullableValue = 
new System.Int32[3]
{
2072220553,
45567204,
821886924,
},
},
    NullableValue = 
new System.Int32[4]
{
1369655765,
471320821,
473236962,
1389921335,
},
},
            new Int32ArrayInt321M
{
    Id = 19,
    Value = 
new System.Int32[3]
{
1868602554,
459669284,
1406305489,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 11,
    Value = 
new System.Int32[3]
{
558544984,
1914818299,
208483097,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
865694186,
334637341,
820508969,
},
},
            new Int32ArrayInt321M
{
    Id = 21,
    Value = 
new System.Int32[3]
{
628389147,
321087562,
1057757213,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 12,
    Value = 
new System.Int32[3]
{
1126452567,
52386662,
1987523307,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 29,
    Value = 
new System.Int32[4]
{
1628548602,
1599503390,
1763648477,
1475301660,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 15,
    Value = 
new System.Int32[3]
{
1073291613,
1688030800,
451521088,
},
    NullableValue = 
new System.Int32[3]
{
1284978987,
460638910,
243626128,
},
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 36,
    Value = 
new System.Int32[4]
{
406661322,
2064120329,
462241503,
1969130504,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 22,
    Value = 
new System.Int32[3]
{
1480285339,
90125224,
952714752,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 37,
    Value = 
new System.Int32[4]
{
808646969,
554999431,
882605960,
1120447194,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 24,
    Value = 
new System.Int32[4]
{
1903133073,
416190628,
806315241,
2081111039,
},
    NullableValue = 
new System.Int32[3]
{
1961266849,
741424679,
1299795518,
},
},
    NullableValue = 
new System.Int32[4]
{
47145682,
1625942237,
174603772,
1337019136,
},
},
            new Int32ArrayInt321M
{
    Id = 43,
    Value = 
new System.Int32[4]
{
1667399270,
1022511577,
565877217,
1193918422,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 27,
    Value = 
new System.Int32[3]
{
470541551,
2036233168,
2088990104,
},
    NullableValue = 
new System.Int32[3]
{
1074377818,
438175770,
1500538105,
},
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 50,
    Value = 
new System.Int32[3]
{
774028849,
1906035828,
1261513652,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 33,
    Value = 
new System.Int32[4]
{
2143352509,
1754240064,
1099698668,
441255104,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1708458552,
1300077586,
1606118259,
1722623161,
},
},
            new Int32ArrayInt321M
{
    Id = 57,
    Value = 
new System.Int32[4]
{
1616058839,
49002651,
1216520691,
558444850,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 40,
    Value = 
new System.Int32[4]
{
2065151237,
1424083181,
1133838813,
1486812493,
},
    NullableValue = 
new System.Int32[4]
{
264856568,
1298008777,
736913449,
1410017326,
},
},
    NullableValue = 
new System.Int32[3]
{
717867201,
1102849953,
527353893,
},
},
            new Int32ArrayInt321M
{
    Id = 65,
    Value = 
new System.Int32[4]
{
2007444079,
1499616736,
1678900743,
552065036,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 43,
    Value = 
new System.Int32[3]
{
928887312,
2147061850,
111019053,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 74,
    Value = 
new System.Int32[3]
{
2112023585,
983999597,
1336578348,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 44,
    Value = 
new System.Int32[4]
{
1963848722,
1537278473,
62133624,
829661699,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
638071117,
410182668,
637202310,
1822434573,
},
},
            new Int32ArrayInt321M
{
    Id = 76,
    Value = 
new System.Int32[3]
{
1230047844,
1646315992,
717446303,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 53,
    Value = 
new System.Int32[3]
{
1784009540,
435272589,
1611486832,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 85,
    Value = 
new System.Int32[3]
{
447131778,
437774591,
1029182236,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 57,
    Value = 
new System.Int32[3]
{
717742969,
767799144,
746065540,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 90,
    Value = 
new System.Int32[3]
{
1925616730,
1911700184,
1706961035,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 58,
    Value = 
new System.Int32[3]
{
1793200524,
1689923736,
378281783,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 96,
    Value = 
new System.Int32[3]
{
514941486,
1381858518,
1321495033,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 61,
    Value = 
new System.Int32[3]
{
1671676612,
742194168,
1930378366,
},
    NullableValue = 
new System.Int32[3]
{
1215263103,
516527973,
111599179,
},
},
    NullableValue = 
new System.Int32[4]
{
1999733669,
1158416956,
2013843533,
767764836,
},
},
            new Int32ArrayInt321M
{
    Id = 97,
    Value = 
new System.Int32[3]
{
1698275138,
1680040324,
856645227,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 64,
    Value = 
new System.Int32[4]
{
1344400012,
913545185,
399888404,
757835179,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 102,
    Value = 
new System.Int32[4]
{
2037835660,
596324653,
121005182,
1893091564,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 66,
    Value = 
new System.Int32[4]
{
1857107635,
146585489,
782790141,
1148920204,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 110,
    Value = 
new System.Int32[3]
{
1271428404,
2034857171,
2042666076,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 68,
    Value = 
new System.Int32[4]
{
1471323039,
147886319,
101479271,
677846357,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1956376046,
582560839,
794917661,
497476177,
},
},
            new Int32ArrayInt321M
{
    Id = 116,
    Value = 
new System.Int32[4]
{
251274551,
584372313,
1363904094,
1005835043,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 73,
    Value = 
new System.Int32[4]
{
881027260,
1022070556,
466881618,
735878325,
},
    NullableValue = 
new System.Int32[3]
{
1615535912,
1008705258,
776855829,
},
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 122,
    Value = 
new System.Int32[4]
{
1717210889,
97744344,
666596377,
1040600479,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 79,
    Value = 
new System.Int32[4]
{
1780743853,
1672609130,
1599413831,
1147096028,
},
    NullableValue = 
new System.Int32[3]
{
1698570756,
520021956,
831835691,
},
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 131,
    Value = 
new System.Int32[4]
{
1718984096,
2064509978,
530961359,
452982866,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 88,
    Value = 
new System.Int32[3]
{
1513807654,
1410615823,
181766544,
},
    NullableValue = 
new System.Int32[3]
{
1047735571,
825480620,
1537714828,
},
},
    NullableValue = 
new System.Int32[4]
{
304454686,
2002299583,
437787547,
907602576,
},
},
            new Int32ArrayInt321M
{
    Id = 140,
    Value = 
new System.Int32[4]
{
716163609,
1548018410,
1637679938,
1176789561,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 97,
    Value = 
new System.Int32[4]
{
468485018,
348385857,
1418006094,
354910864,
},
    NullableValue = 
new System.Int32[4]
{
570874551,
1821230324,
65149535,
274550567,
},
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 148,
    Value = 
new System.Int32[4]
{
1145917878,
1015964457,
1835263444,
301648560,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 99,
    Value = 
new System.Int32[4]
{
1194093208,
1640074604,
246541050,
1529071313,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 155,
    Value = 
new System.Int32[3]
{
1874796967,
893846048,
1021134934,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 107,
    Value = 
new System.Int32[3]
{
1689566270,
88441069,
1976251106,
},
    NullableValue = 
new System.Int32[3]
{
1565048534,
1608688654,
288773565,
},
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 158,
    Value = 
new System.Int32[3]
{
1173660735,
1666097177,
1272581276,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 109,
    Value = 
new System.Int32[3]
{
2012337997,
1113076138,
1069825915,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 166,
    Value = 
new System.Int32[3]
{
1958380854,
702742343,
1325266793,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 116,
    Value = 
new System.Int32[3]
{
2044649612,
622198333,
227707862,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
487451914,
889029899,
803914886,
1185396215,
},
},
            new Int32ArrayInt321M
{
    Id = 171,
    Value = 
new System.Int32[4]
{
441276112,
1292445705,
1331473914,
1714221094,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 123,
    Value = 
new System.Int32[4]
{
1229650895,
409176750,
341764212,
1032269857,
},
    NullableValue = 
new System.Int32[4]
{
491906026,
1234429280,
1540690475,
1521685483,
},
},
    NullableValue = 
new System.Int32[3]
{
1311094862,
1513614364,
435694068,
},
},
            new Int32ArrayInt321M
{
    Id = 179,
    Value = 
new System.Int32[3]
{
79475555,
938845456,
1722898325,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 127,
    Value = 
new System.Int32[3]
{
1384793035,
916228979,
941930098,
},
    NullableValue = 
new System.Int32[3]
{
1546159072,
1553218587,
172637703,
},
},
    NullableValue = 
new System.Int32[3]
{
1369264027,
1498997472,
452355064,
},
},
            new Int32ArrayInt321M
{
    Id = 182,
    Value = 
new System.Int32[4]
{
1213210931,
1281238053,
246332070,
1104353042,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 131,
    Value = 
new System.Int32[3]
{
2142164993,
1127777177,
1917341970,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
870004811,
807323531,
1159115673,
191267051,
},
},
            new Int32ArrayInt321M
{
    Id = 185,
    Value = 
new System.Int32[4]
{
1719357483,
1774335823,
1787999657,
959535804,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 135,
    Value = 
new System.Int32[4]
{
2137140462,
1554506176,
2094331500,
136914488,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1083299798,
723888087,
1824940322,
},
},
            new Int32ArrayInt321M
{
    Id = 188,
    Value = 
new System.Int32[4]
{
1598663809,
518288139,
2107261833,
788658075,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 142,
    Value = 
new System.Int32[4]
{
1821706978,
1658100727,
941480048,
799640292,
},
    NullableValue = 
new System.Int32[3]
{
1299549083,
1323435689,
764669285,
},
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 190,
    Value = 
new System.Int32[4]
{
1806807543,
1059300040,
1611987020,
1729815418,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 146,
    Value = 
new System.Int32[4]
{
61539181,
1256945211,
1007994545,
990405918,
},
    NullableValue = 
new System.Int32[4]
{
649701091,
1480044636,
1512086360,
1031128571,
},
},
    NullableValue = null,
},
            new Int32ArrayInt321M
{
    Id = 195,
    Value = 
new System.Int32[4]
{
1361998518,
1660693329,
842007515,
2064955866,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 148,
    Value = 
new System.Int32[4]
{
1240624965,
1961701502,
123964419,
2043799150,
},
    NullableValue = 
new System.Int32[4]
{
2041310025,
1903669085,
870632678,
662319750,
},
},
    NullableValue = 
new System.Int32[3]
{
1419699748,
1330302744,
774849277,
},
},
            new Int32ArrayInt321M
{
    Id = 202,
    Value = 
new System.Int32[4]
{
106435860,
2080035524,
165618062,
1214562991,
},
    ModelInner = new Int32ArrayInt321MI
{
    Id = 150,
    Value = 
new System.Int32[4]
{
1325044241,
2079311181,
555802490,
1142735048,
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
INSERT INTO gedaqtests.int32arrayint321m(
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
            asPartInterface: typeof(IInt32ArrayArrayInt32)),
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
                    await ((IInt32ArrayArrayInt32)this).InsertModelDbConnectionAsync(
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
                     ((IInt32ArrayArrayInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.int32arrayint321m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32ArrayInt321M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayArrayInt32)),
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
                    var models = await ((IInt32ArrayArrayInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32ArrayInt321M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32ArrayArrayInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32ArrayInt321M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


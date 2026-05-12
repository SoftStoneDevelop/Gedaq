

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
    Id = 1,
    Value = 
new System.Int32[3]
{
1577761022,
1825062997,
1242453691,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Int32[3]
{
625330271,
1861124039,
28677390,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1348830260,
364770572,
798012245,
716031205,
},
},
            new Int32MArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int32[4]
{
661125373,
356141647,
547822402,
697453783,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Int32[3]
{
25221463,
146092212,
1259747075,
},
    NullableValue = 
new System.Int32[3]
{
1824810276,
1529043075,
367474760,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 14,
    Value = 
new System.Int32[4]
{
151799103,
1929745431,
1810587391,
267294983,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Int32[4]
{
75182915,
1576928934,
364043845,
870992966,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1969728825,
574333450,
678787948,
733061018,
},
},
            new Int32MArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int32[3]
{
704314969,
1247582682,
1836520732,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int32[4]
{
345231376,
1147347177,
1807224963,
1610405964,
},
    NullableValue = 
new System.Int32[3]
{
1922291001,
1778837004,
1100409331,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 21,
    Value = 
new System.Int32[3]
{
516058960,
1353917367,
1369531368,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Int32[3]
{
1178275218,
1492160440,
356097157,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 25,
    Value = 
new System.Int32[4]
{
662617931,
998344164,
420218004,
666848208,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Int32[4]
{
1953510156,
1631302447,
1729175820,
2027852793,
},
    NullableValue = 
new System.Int32[4]
{
2073163460,
1190241337,
1527090838,
1901607888,
},
},
    NullableValue = 
new System.Int32[3]
{
186991208,
1962161694,
1855218188,
},
},
            new Int32MArrayD1E1M
{
    Id = 30,
    Value = 
new System.Int32[3]
{
1822526735,
821009703,
597329646,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int32[4]
{
498912018,
59392816,
787019066,
1452683773,
},
    NullableValue = 
new System.Int32[3]
{
1131578339,
2109927862,
852877039,
},
},
    NullableValue = 
new System.Int32[4]
{
626695446,
540237814,
956820201,
1393427373,
},
},
            new Int32MArrayD1E1M
{
    Id = 39,
    Value = 
new System.Int32[4]
{
242170002,
720155716,
668552350,
1965357458,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Int32[4]
{
1231647415,
1636559521,
138685878,
188626782,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
115594071,
262958928,
1017961287,
1622305096,
},
},
            new Int32MArrayD1E1M
{
    Id = 41,
    Value = 
new System.Int32[4]
{
1624909455,
1571219834,
940187503,
1028773556,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Int32[4]
{
781964975,
1632804613,
688140561,
65868015,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 44,
    Value = 
new System.Int32[3]
{
217091146,
1431474695,
146675003,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Int32[4]
{
1838864060,
642942196,
342648116,
970173925,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int32[3]
{
1421177072,
1510642056,
551084027,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int32[4]
{
175675605,
1266541474,
1009793801,
730988358,
},
    NullableValue = 
new System.Int32[4]
{
938477917,
1655026666,
495407156,
1474865227,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 58,
    Value = 
new System.Int32[4]
{
1961883411,
1369952614,
137403460,
51139950,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int32[3]
{
1945858437,
1302990128,
416550945,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1502925239,
943744950,
2137867100,
},
},
            new Int32MArrayD1E1M
{
    Id = 59,
    Value = 
new System.Int32[4]
{
1777296859,
1896829058,
1699901855,
271598620,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int32[4]
{
1561732913,
758761469,
1730446930,
699304961,
},
    NullableValue = 
new System.Int32[4]
{
1187817478,
1150845746,
1028469610,
1731689948,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int32[4]
{
261060790,
490768703,
902345979,
597449071,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Int32[4]
{
1732700991,
524997645,
76499415,
322020398,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
652261349,
486676724,
1988122194,
1177933236,
},
},
            new Int32MArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int32[3]
{
2113992645,
188472412,
526611674,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Int32[4]
{
856295396,
1258397101,
1581101246,
701323415,
},
    NullableValue = 
new System.Int32[4]
{
856623332,
937798041,
814127466,
776076630,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 84,
    Value = 
new System.Int32[3]
{
1593691430,
641709868,
560378307,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int32[3]
{
82155103,
831589958,
11970915,
},
    NullableValue = 
new System.Int32[3]
{
233974471,
1871637820,
1927666190,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 86,
    Value = 
new System.Int32[4]
{
930211878,
740264603,
192221698,
1757689696,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Int32[3]
{
2039150220,
1568565281,
390113830,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
2054561664,
1209732317,
1295957436,
},
},
            new Int32MArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int32[3]
{
499188421,
1006086631,
598306269,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Int32[4]
{
1725793082,
902129813,
932867764,
579894128,
},
    NullableValue = 
new System.Int32[3]
{
242246036,
25360064,
785373131,
},
},
    NullableValue = 
new System.Int32[3]
{
1092745670,
1656397758,
144322993,
},
},
            new Int32MArrayD1E1M
{
    Id = 97,
    Value = 
new System.Int32[4]
{
1032522207,
407622285,
1130951924,
1504649714,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Int32[4]
{
1457125899,
644858993,
46083665,
2095076906,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
713938972,
2011187293,
1919500787,
146089895,
},
},
            new Int32MArrayD1E1M
{
    Id = 106,
    Value = 
new System.Int32[4]
{
1478960257,
2016387858,
846045902,
1458659475,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Int32[4]
{
1522987159,
1333634636,
1835007371,
405474354,
},
    NullableValue = 
new System.Int32[4]
{
1257332341,
1999978311,
1578372722,
1988091082,
},
},
    NullableValue = 
new System.Int32[3]
{
900910283,
1447667168,
1005844048,
},
},
            new Int32MArrayD1E1M
{
    Id = 108,
    Value = 
new System.Int32[4]
{
2095352319,
1702972339,
1185071211,
892676090,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.Int32[3]
{
649966703,
602529373,
1450263930,
},
    NullableValue = 
new System.Int32[3]
{
1034894740,
732721956,
1856379573,
},
},
    NullableValue = 
new System.Int32[3]
{
1827728333,
216295931,
687422824,
},
},
            new Int32MArrayD1E1M
{
    Id = 115,
    Value = 
new System.Int32[4]
{
255890283,
997315409,
911359140,
718689924,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Int32[3]
{
1941357406,
1268807650,
1915669544,
},
    NullableValue = 
new System.Int32[4]
{
1313739212,
751700725,
2082688069,
342110614,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 118,
    Value = 
new System.Int32[3]
{
471667607,
1016529349,
970881374,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 122,
    Value = 
new System.Int32[3]
{
1176334609,
415884923,
1999478296,
},
    NullableValue = 
new System.Int32[3]
{
1219094906,
1309430474,
1939370390,
},
},
    NullableValue = 
new System.Int32[4]
{
1605948921,
1189229282,
910879769,
600643978,
},
},
            new Int32MArrayD1E1M
{
    Id = 120,
    Value = 
new System.Int32[3]
{
1540859379,
281080066,
1689382328,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Int32[3]
{
1298149833,
1758665927,
375820798,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int32[4]
{
1814960839,
982888238,
179462380,
1729948549,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Int32[3]
{
1882963884,
249013490,
2141671990,
},
    NullableValue = 
new System.Int32[3]
{
1043589549,
1645162500,
1692937112,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 128,
    Value = 
new System.Int32[4]
{
405656968,
152615212,
1026355565,
2102432241,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Int32[4]
{
169529444,
1564582724,
257327896,
1058844132,
},
    NullableValue = 
new System.Int32[3]
{
604118158,
59390806,
1237459253,
},
},
    NullableValue = 
new System.Int32[4]
{
1901477591,
1057291954,
1972793851,
259645750,
},
},
            new Int32MArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int32[3]
{
1183614571,
959551985,
2145929058,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 146,
    Value = 
new System.Int32[3]
{
142073628,
1088006196,
1303706995,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 139,
    Value = 
new System.Int32[4]
{
240976149,
1305579697,
1264427015,
1964913228,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Int32[4]
{
1787577438,
823613506,
873039141,
1218285476,
},
    NullableValue = 
new System.Int32[4]
{
197839654,
1971502854,
1006887132,
1715061001,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int32[3]
{
623177105,
1859823760,
23547814,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Int32[3]
{
1633782324,
1402253221,
883013604,
},
    NullableValue = 
new System.Int32[4]
{
409062380,
1527383146,
226104834,
1355187146,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 148,
    Value = 
new System.Int32[4]
{
1112364802,
345939346,
864781552,
719524369,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 156,
    Value = 
new System.Int32[4]
{
1604750355,
803421635,
210962236,
1441691884,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int32[4]
{
1601749415,
769845635,
180947913,
388203139,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 161,
    Value = 
new System.Int32[4]
{
2064181948,
920602039,
1168745183,
1542910925,
},
    NullableValue = 
new System.Int32[3]
{
1396057025,
241949267,
1401170052,
},
},
    NullableValue = 
new System.Int32[4]
{
1751053669,
756365824,
1672815373,
1126735096,
},
},
            new Int32MArrayD1E1M
{
    Id = 153,
    Value = 
new System.Int32[4]
{
18785652,
1824360080,
1516918610,
819447512,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Int32[3]
{
1494984243,
431503457,
2086876223,
},
    NullableValue = 
new System.Int32[4]
{
1558084292,
766692175,
913098468,
2140027757,
},
},
    NullableValue = 
new System.Int32[4]
{
658332601,
2014170410,
1879275189,
1430132127,
},
},
            new Int32MArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int32[4]
{
929436742,
1454598466,
1160946141,
2012683633,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Int32[4]
{
1060563064,
697009840,
2064563910,
1535981278,
},
    NullableValue = 
new System.Int32[4]
{
823119564,
1328990038,
1914743588,
1337657840,
},
},
    NullableValue = 
new System.Int32[4]
{
1454783977,
898651523,
659264723,
783765396,
},
},
            new Int32MArrayD1E1M
{
    Id = 158,
    Value = 
new System.Int32[3]
{
1433004904,
1767754139,
116660019,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.Int32[3]
{
1354583002,
1398892887,
2133082347,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1050572547,
133712064,
1438233432,
},
},
            new Int32MArrayD1E1M
{
    Id = 166,
    Value = 
new System.Int32[3]
{
1305455802,
1371373967,
250502842,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 178,
    Value = 
new System.Int32[3]
{
141029923,
582170526,
261149041,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1555868983,
719669722,
487331219,
1419766435,
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




using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IInt32MArrayintegerMMArrayD2
    {
    }
    
    internal partial class Int32MArrayintegerMMArrayD2 : IInt32MArrayintegerMMArrayD2
    {


#region TestData

        private readonly Int32integerMMArrayD2E1M[] _testData = new Int32integerMMArrayD2E1M[]
        {
            new Int32integerMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Int32[,] { { 691618782, 2092904413, }, { 115101233, 1988169122, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1093720220, 888297940, }, { 570248181, 141666759, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int32[,] { { 1793261534, 748042370, }, { 995885988, 1410530030, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Int32[,] { { 106491702, 210708259, }, { 145353468, 1603823423, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 992771977, 1735128598, }, { 1631562188, 83541801, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Int32[,] { { 1390361763, 435822197, }, { 1263262718, 1364009097, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 2047359174, 1350125800, }, { 697190869, 278849322, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Int32[,] { { 1148889983, 1876062933, }, { 1661977486, 1126393334, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Int32[,] { { 1308253469, 133697597, }, { 1211694004, 1686646177, }, },
    NullableValue = 
new System.Int32[,] { { 1110996462, 1913927642, }, { 1327570947, 1394616960, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Int32[,] { { 1508814404, 12188482, }, { 1856148995, 81352904, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 2029150852, 720030926, }, { 1286167897, 1142683284, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Int32[,] { { 974035768, 1288467074, }, { 440098688, 140151595, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Int32[,] { { 1153793298, 603086228, }, { 1705714783, 2120612139, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 807081515, 1520619066, }, { 1534314577, 1466508295, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Int32[,] { { 28708554, 325620745, }, { 1941265081, 1056273091, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 832105769, 178878066, }, { 1188633009, 548412962, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Int32[,] { { 1986509224, 499777636, }, { 661701853, 2032259441, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Int32[,] { { 19369690, 1065142862, }, { 1785319037, 1230637980, }, },
    NullableValue = 
new System.Int32[,] { { 635546820, 1518787711, }, { 1743143697, 87384597, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Int32[,] { { 966258483, 726010389, }, { 564696396, 1315849500, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Int32[,] { { 697092884, 1391813369, }, { 1865146268, 983047910, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int32[,] { { 1933264274, 1843613414, }, { 408067126, 2055316155, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 215366867, 1883472303, }, { 282386208, 1926763156, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int32[,] { { 985109841, 229089599, }, { 573331429, 458436032, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 670099312, 643155408, }, { 1473479845, 1388119709, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int32[,] { { 969445816, 939140771, }, { 1507389305, 83303937, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.Int32[,] { { 220023703, 412879340, }, { 2022858735, 18084131, }, },
    NullableValue = 
new System.Int32[,] { { 120312425, 1449519485, }, { 1207585299, 1029333763, }, },
},
    NullableValue = 
new System.Int32[,] { { 1254676461, 1028914612, }, { 278021937, 1353893074, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Int32[,] { { 81326915, 183447358, }, { 655228778, 1508027986, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Int32[,] { { 1831053949, 500590021, }, { 985850496, 515467233, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Int32[,] { { 1522997526, 974413105, }, { 541808036, 1413138489, }, },
    NullableValue = 
new System.Int32[,] { { 547529151, 435915559, }, { 1261838861, 2070129757, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Int32[,] { { 259509050, 498050876, }, { 1978130562, 1026161656, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 927901477, 1277802397, }, { 1796980409, 1137786782, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Int32[,] { { 190507748, 1743982067, }, { 889662158, 694811288, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Int32[,] { { 2117520125, 845063747, }, { 931364265, 1872850672, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Int32[,] { { 674083266, 203109142, }, { 1557830064, 567544437, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1091041374, 2045163458, }, { 1207951177, 817551891, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Int32[,] { { 106863435, 941105584, }, { 665013095, 726070180, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Int32[,] { { 1572082400, 129675502, }, { 663162816, 1442682011, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 635878742, 729687410, }, { 1260261641, 1096770227, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Int32[,] { { 1823916219, 1205822524, }, { 1839133627, 854577264, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Int32[,] { { 985994358, 1806131331, }, { 786789199, 1872333952, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Int32[,] { { 502422076, 1629765979, }, { 2074396194, 951654568, }, },
    NullableValue = 
new System.Int32[,] { { 1011968671, 1083114135, }, { 1483970123, 1350703995, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Int32[,] { { 1397506587, 802021243, }, { 1012890304, 1954350000, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Int32[,] { { 1450726787, 553561571, }, { 1839293399, 2119567304, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Int32[,] { { 1375762740, 380955817, }, { 592932343, 1684500714, }, },
    NullableValue = 
new System.Int32[,] { { 1983522707, 1918701528, }, { 858539465, 1553004751, }, },
},
    NullableValue = 
new System.Int32[,] { { 200929773, 1050646070, }, { 602437372, 1818557385, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int32[,] { { 69956762, 1836811594, }, { 394540794, 1908357457, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1935314291, 838030677, }, { 1582752369, 1009606487, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int32[,] { { 2126269168, 1014847217, }, { 1360445887, 825086863, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int32[,] { { 1466911318, 141806870, }, { 1277793602, 1057992010, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1651634436, 629893948, }, { 845505951, 1221708839, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Int32[,] { { 498784241, 1932068882, }, { 499867354, 658937137, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Int32[,] { { 1795182380, 1900507551, }, { 1040814383, 1910701675, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int32[,] { { 653765898, 2044127621, }, { 1116083490, 1866013703, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Int32[,] { { 1336352922, 1983490767, }, { 372047195, 2095871601, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 2099315761, 310737347, }, { 868288665, 1399700961, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Int32[,] { { 1934377729, 514525712, }, { 1864406974, 765545843, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Int32[,] { { 792471261, 2117422636, }, { 1338307647, 437402731, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 500426290, 35636998, }, { 1763736037, 1466415857, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Int32[,] { { 872528647, 837330637, }, { 826168480, 1345215620, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Int32[,] { { 554730568, 127616763, }, { 190082429, 952776849, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int32[,] { { 268735287, 89192092, }, { 1545689903, 497672459, }, },
    NullableValue = 
new System.Int32[,] { { 1653047020, 1117344830, }, { 1611777871, 1008660675, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Int32[,] { { 816812929, 381068714, }, { 697435159, 1722463640, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1342972089, 2016105078, }, { 1053443193, 1130146615, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Int32[,] { { 85565274, 1720741972, }, { 992156071, 1360958716, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Int32[,] { { 816605415, 2078859111, }, { 2026063033, 565648453, }, },
    NullableValue = 
new System.Int32[,] { { 1461999111, 1368872456, }, { 548157553, 1862623150, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Int32[,] { { 819878949, 24476631, }, { 550287052, 2108759537, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1658589432, 1698144084, }, { 1039211415, 1946196605, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Int32[,] { { 969137841, 14913360, }, { 809377199, 1719424660, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Int32[,] { { 1913843418, 235508163, }, { 929100580, 1086397892, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 179,
    Value = 
new System.Int32[,] { { 957540762, 87187254, }, { 1949917045, 512375968, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd2e1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd2e1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IInt32MArrayintegerMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32MArrayintegerMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd2e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integermmarrayd2e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((IInt32MArrayintegerMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32MArrayintegerMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd2e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    int32integermmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[,]>();
                    ((NpgsqlParameter<System.Int32[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 2029150852, 720030926, }, { 1286167897, 1142683284, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[,]>();
                    ((NpgsqlParameter<System.Int32[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 807081515, 1520619066, }, { 1534314577, 1466508295, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[,]>();
                    ((NpgsqlParameter<System.Int32[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 832105769, 178878066, }, { 1188633009, 548412962, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[,]>();
                    ((NpgsqlParameter<System.Int32[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd2e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    int32integermmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integermmarrayd2e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[,] nullable = null;
                nullable =  ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 215366867, 1883472303, }, { 282386208, 1926763156, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[,] nullable = null;
                nullable = await ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 670099312, 643155408, }, { 1473479845, 1388119709, }, }));
                nullable = await ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 1254676461, 1028914612, }, { 278021937, 1353893074, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerMMArrayD2E1M> models = null;

                models =  ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerMMArrayD2E1M> models = null;

                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt32MArrayintegerMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD2E1M), typeof(FlatInt32integerMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerMMArrayD2E1M>();
                var models2 = new List<FlatInt32integerMMArrayD2E1M>();
                await ((IInt32MArrayintegerMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerMMArrayD2E1M>();
                var models2 = new List<FlatInt32integerMMArrayD2E1M>();
                ((IInt32MArrayintegerMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32MArrayintegerMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32MArrayintegerMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
LEFT JOIN public.int32integermmarrayd2e1mi mi ON mi.id = m.int32integermmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32MArrayintegerMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32MArrayintegerMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD2E1M), typeof(FlatInt32integerMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD2E1M>();
                var models2 = new List<FlatInt32integerMMArrayD2E1M>();
                await ((IInt32MArrayintegerMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD2E1M>();
                var models2 = new List<FlatInt32integerMMArrayD2E1M>();
                ((IInt32MArrayintegerMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32MArrayintegerMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32MArrayintegerMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
LEFT JOIN public.int32integermmarrayd2e1mi mi ON mi.id = m.int32integermmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32MArrayintegerMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32MArrayintegerMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD2E1M), typeof(FlatInt32integerMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerMMArrayD2E1M>();
                var models2 = new List<FlatInt32integerMMArrayD2E1M>();
                await((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerMMArrayD2E1M>();
                var models2 = new List<FlatInt32integerMMArrayD2E1M>();
                ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
LEFT JOIN public.int32integermmarrayd2e1mi mi ON mi.id = m.int32integermmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32MArrayintegerMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD2E1M), typeof(FlatInt32integerMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD2E1M>();
                var models2 = new List<FlatInt32integerMMArrayD2E1M>();
                await((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 74, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD2E1M>();
                var models2 = new List<FlatInt32integerMMArrayD2E1M>();
                ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 130, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 111, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 141, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 161, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 76, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD2E1M>();
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 97, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.int32integermmarrayd2e1m m
LEFT JOIN public.int32integermmarrayd2e1mi mi ON mi.id = m.int32integermmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IInt32MArrayintegerMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 165, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 29, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt32MArrayintegerMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32MArrayintegerMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models = await ((IInt32MArrayintegerMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32MArrayintegerMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32MArrayintegerMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models =  ((IInt32MArrayintegerMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integermmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integermmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32MArrayintegerMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integermmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32MArrayintegerMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integermmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integermmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32MArrayintegerMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integermmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32MArrayintegerMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integermmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32MArrayintegerMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD2E1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32MArrayintegerMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD2E1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integermmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integermmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_int32integermmarrayd2e1m m
LEFT JOIN public.binary_int32integermmarrayd2e1mi mi ON mi.id = m.int32integermmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt32MArrayintegerMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt32MArrayintegerMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integermmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32MArrayintegerMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32MArrayintegerMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA), typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD2E1MIWA>();
                var models2 = new List<Int32integerMMArrayD2E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD2E1MIWA>();
                var models2 = new List<Int32integerMMArrayD2E1MIWA>();
                ((IInt32MArrayintegerMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt32MArrayintegerMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int32integermmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt32MArrayintegerMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int32integermmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA), typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD2E1MIWA>();
                var models2 = new List<Int32integerMMArrayD2E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD2E1MIWA>();
                var models2 = new List<Int32integerMMArrayD2E1MIWA>();
                ((IInt32MArrayintegerMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt32MArrayintegerMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int32integermmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt32MArrayintegerMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int32integermmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MI), typeof(Int32integerMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD2E1MI>();
                var models2 = new List<Int32integerMMArrayD2E1MI>();
                await ((IInt32MArrayintegerMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD2E1MI>();
                var models2 = new List<Int32integerMMArrayD2E1MI>();
                ((IInt32MArrayintegerMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt32MArrayintegerMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD2E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt32MArrayintegerMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD2E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA), typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD2E1MIWA>();
                var models2 = new List<Int32integerMMArrayD2E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD2E1MIWA>();
                var models2 = new List<Int32integerMMArrayD2E1MIWA>();
                ((IInt32MArrayintegerMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD2))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt32MArrayintegerMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt32MArrayintegerMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


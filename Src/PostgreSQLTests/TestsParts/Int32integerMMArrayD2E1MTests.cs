

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
    Id = 5,
    Value = 
new System.Int32[,] { { 1106620901, 1852875804, }, { 752263349, 945888355, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 476695102, 1983432340, }, { 1829819626, 1469544031, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Int32[,] { { 1370468400, 1223759744, }, { 1401754835, 1078378738, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Int32[,] { { 1437159380, 1677516318, }, { 111467854, 1217351637, }, },
    NullableValue = 
new System.Int32[,] { { 1776091834, 832454566, }, { 699594756, 588086834, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Int32[,] { { 2136807595, 234630143, }, { 1839026234, 1818990810, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 937631040, 1389725939, }, { 448540050, 535572482, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Int32[,] { { 783213526, 2108762096, }, { 337862496, 1600335049, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int32[,] { { 443200881, 195581782, }, { 294744562, 1990485297, }, },
    NullableValue = 
new System.Int32[,] { { 2119756449, 1002472219, }, { 1477734201, 944967952, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Int32[,] { { 1919708205, 724003407, }, { 467319774, 1922404051, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1715853796, 102435239, }, { 1079006047, 440218751, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Int32[,] { { 1288786264, 2072627321, }, { 388617209, 1337130055, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Int32[,] { { 1120051914, 1302232610, }, { 695477, 1241959829, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1620689292, 1601542530, }, { 657454677, 1937353333, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Int32[,] { { 256228995, 207928939, }, { 1685868959, 1269443828, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Int32[,] { { 912017783, 1260696272, }, { 1438313560, 1509989541, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Int32[,] { { 502697154, 1378917730, }, { 386082966, 49742959, }, },
    NullableValue = 
new System.Int32[,] { { 989975166, 1839198801, }, { 1107572020, 1179913482, }, },
},
    NullableValue = 
new System.Int32[,] { { 1379440512, 975659290, }, { 334623279, 1578536144, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Int32[,] { { 1252323738, 1135735533, }, { 1735145112, 386781675, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Int32[,] { { 1017024590, 1240873560, }, { 106476531, 1933314062, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Int32[,] { { 1085046370, 645523062, }, { 1329878433, 262778674, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Int32[,] { { 2009250178, 1173316837, }, { 606972429, 1516784741, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 2003003424, 1864883673, }, { 928774023, 701996851, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Int32[,] { { 1852895391, 382650526, }, { 648053683, 37626258, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Int32[,] { { 1432539680, 1327218924, }, { 1163664591, 1182355558, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 568522660, 1500772719, }, { 284175395, 1520867042, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Int32[,] { { 1608122611, 1899333212, }, { 1367989971, 1556415595, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1029791868, 1925710412, }, { 1677696111, 198624049, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Int32[,] { { 1856127360, 1802952921, }, { 1835232812, 715738856, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Int32[,] { { 981562533, 173668938, }, { 2011340771, 1304692853, }, },
    NullableValue = 
new System.Int32[,] { { 1105471953, 1745261213, }, { 1900827639, 1981927270, }, },
},
    NullableValue = 
new System.Int32[,] { { 2130294883, 367956689, }, { 2007258290, 2036931407, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Int32[,] { { 362414493, 132704965, }, { 1936179519, 1850008581, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 2070322719, 719026660, }, { 1057284639, 2107868538, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int32[,] { { 1917081383, 488248434, }, { 358713897, 436960537, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Int32[,] { { 1436488721, 1295611256, }, { 77122120, 2068300046, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Int32[,] { { 903758632, 1064645214, }, { 755802524, 229764314, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int32[,] { { 98078289, 2059364542, }, { 1661684608, 886420885, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int32[,] { { 1197963208, 1757651194, }, { 48695887, 1620455026, }, },
    NullableValue = 
new System.Int32[,] { { 1355201191, 1692388148, }, { 1784106674, 1737584183, }, },
},
    NullableValue = 
new System.Int32[,] { { 159910738, 1635347701, }, { 368747068, 102493050, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Int32[,] { { 236468210, 1845050598, }, { 2071062215, 1721564058, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1372431665, 1681142555, }, { 1969579526, 2063840833, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 108,
    Value = 
new System.Int32[,] { { 980488991, 81210862, }, { 508055844, 1773515413, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Int32[,] { { 1398636193, 1016420583, }, { 828764566, 98973124, }, },
    NullableValue = 
new System.Int32[,] { { 1626596400, 1438315284, }, { 1751341830, 1523551258, }, },
},
    NullableValue = 
new System.Int32[,] { { 1058176865, 1294006115, }, { 263520120, 2029119935, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Int32[,] { { 2006749982, 1588693249, }, { 48507392, 1223230756, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 29094433, 1534039920, }, { 600072148, 1149693018, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Int32[,] { { 1259035729, 1743307721, }, { 621338086, 1145856513, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int32[,] { { 2140321582, 1587246364, }, { 691084939, 2118495746, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Int32[,] { { 455290700, 1756932003, }, { 789788745, 323131649, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 2030161168, 1610153575, }, { 1445051117, 673277206, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int32[,] { { 970268933, 1294740972, }, { 2120263163, 1452625139, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Int32[,] { { 58352021, 1198182680, }, { 1743890529, 1372429965, }, },
    NullableValue = 
new System.Int32[,] { { 487078515, 1056984153, }, { 916227116, 1545665646, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Int32[,] { { 1970901886, 109568243, }, { 1961519822, 1347845057, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Int32[,] { { 1113488657, 1558095067, }, { 2063968355, 1601097248, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Int32[,] { { 2051074612, 1746332443, }, { 1208066292, 1449829761, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int32[,] { { 825321654, 536398137, }, { 1943406565, 487605205, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1124223724, 297245578, }, { 32715989, 892519429, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int32[,] { { 379238073, 1497917356, }, { 1431411144, 1991041157, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Int32[,] { { 585762682, 1836328644, }, { 644515553, 704840026, }, },
    NullableValue = 
new System.Int32[,] { { 965155744, 2107885042, }, { 1263300379, 1672323544, }, },
},
    NullableValue = 
new System.Int32[,] { { 1801837611, 367608426, }, { 1504426697, 933030474, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Int32[,] { { 1928324684, 494313424, }, { 2064584141, 2021285150, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1129154842, 563980135, }, { 1185466521, 1012847857, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Int32[,] { { 2025891809, 1761992915, }, { 1278606168, 1507623724, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Int32[,] { { 97246082, 1433723225, }, { 400768407, 1090296693, }, },
    NullableValue = 
new System.Int32[,] { { 1735493131, 53650216, }, { 1579525584, 1246413085, }, },
},
    NullableValue = 
new System.Int32[,] { { 1630312560, 609054524, }, { 642094905, 494694084, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Int32[,] { { 923277983, 755272613, }, { 205782084, 1379849985, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 176,
    Value = 
new System.Int32[,] { { 459905623, 396420363, }, { 1870664631, 1153203463, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Int32[,] { { 1628564272, 1503558971, }, { 725903456, 1476781699, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Int32[,] { { 2093794721, 881091410, }, { 278580965, 198349756, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 189,
    Value = 
new System.Int32[,] { { 1899977336, 2098926262, }, { 580638632, 1382785034, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Int32[,] { { 985119039, 2072256797, }, { 1127393523, 345750597, }, },
    NullableValue = 
new System.Int32[,] { { 1241667254, 1281454710, }, { 1030595350, 822000670, }, },
},
    NullableValue = 
new System.Int32[,] { { 1102651635, 1050827418, }, { 874458083, 1518451110, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 190,
    Value = 
new System.Int32[,] { { 646019868, 1379429519, }, { 666996966, 1541398690, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 27213205, 2066097183, }, { 1811094988, 1568782783, }, },
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
new System.Int32[,] { { 1715853796, 102435239, }, { 1079006047, 440218751, }, }));
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
new System.Int32[,] { { 1620689292, 1601542530, }, { 657454677, 1937353333, }, }));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 1379440512, 975659290, }, { 334623279, 1578536144, }, }));
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
                Assert.That(nullable, Is.Null);
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
new System.Int32[,] { { 2003003424, 1864883673, }, { 928774023, 701996851, }, }));
                nullable = await ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 568522660, 1500772719, }, { 284175395, 1520867042, }, }));
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 156, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 117, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 176, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 176, query1, 146, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 115, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 5, query1, 180, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 72, 115))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                ((IInt32MArrayintegerMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((IInt32MArrayintegerMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32MArrayintegerMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32MArrayintegerMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((IInt32MArrayintegerMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                Int32integerMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                Int32integerMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                Int32integerMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                Int32integerMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                Int32integerMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                Int32integerMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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




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
    Id = 3,
    Value = 
new System.Int32[,] { { 208477712, 344390134, }, { 1325499287, 262465042, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 374184109, 24594536, }, { 1674345374, 1913581464, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Int32[,] { { 18438859, 917110253, }, { 729330423, 1659426882, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Int32[,] { { 1590942555, 949271756, }, { 2060984980, 469665079, }, },
    NullableValue = 
new System.Int32[,] { { 371073350, 764812613, }, { 2113135242, 1723865330, }, },
},
    NullableValue = 
new System.Int32[,] { { 275957212, 968775190, }, { 396517461, 940088757, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Int32[,] { { 921135328, 63329315, }, { 978899029, 245473979, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1601557502, 592267128, }, { 531879668, 1769674494, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Int32[,] { { 418969421, 931601928, }, { 542858239, 1949733249, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 5,
    Value = 
new System.Int32[,] { { 1351969071, 1877058809, }, { 1032293195, 948555876, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1982030371, 620110950, }, { 2014673506, 589509730, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Int32[,] { { 1072472628, 841180590, }, { 619325240, 184935399, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 913121174, 522816299, }, { 112887716, 1395014186, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Int32[,] { { 461317981, 236017083, }, { 867537277, 1311121569, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int32[,] { { 205424162, 960828325, }, { 1657128146, 1108660598, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 560805969, 1653048742, }, { 1109630639, 1711677148, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Int32[,] { { 401341408, 1118467192, }, { 152953542, 1605873424, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1378253468, 1993449292, }, { 928789833, 1208039037, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Int32[,] { { 938388408, 1326611139, }, { 410782464, 1707861960, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Int32[,] { { 575537411, 2063298319, }, { 2000236707, 948700, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 872734190, 1525605819, }, { 1830855560, 362068837, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int32[,] { { 1815262918, 783254198, }, { 1676261755, 1309402437, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int32[,] { { 32878087, 2029878743, }, { 1622438681, 1170604250, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Int32[,] { { 116642076, 1025494999, }, { 1545195432, 921880346, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Int32[,] { { 15282587, 539621524, }, { 923154997, 1700607796, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Int32[,] { { 1820785836, 636471743, }, { 581352096, 2090916627, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Int32[,] { { 2118783479, 1105013786, }, { 33545266, 1808127164, }, },
    NullableValue = 
new System.Int32[,] { { 1151741803, 979063817, }, { 2070890151, 350499126, }, },
},
    NullableValue = 
new System.Int32[,] { { 695446865, 1833591605, }, { 1587628308, 474655127, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int32[,] { { 187701734, 530050760, }, { 150570985, 503786966, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 503399607, 1605280216, }, { 206782466, 1914109488, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Int32[,] { { 1499145894, 1722911369, }, { 457951679, 975674204, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Int32[,] { { 649956175, 1385730418, }, { 423169871, 1876932694, }, },
    NullableValue = 
new System.Int32[,] { { 888558534, 312301615, }, { 1192145218, 1081027776, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Int32[,] { { 1206167965, 1490999245, }, { 1734857760, 2058718472, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Int32[,] { { 226662616, 443839779, }, { 1166996407, 1224254123, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Int32[,] { { 1368375743, 751103323, }, { 1329914239, 6815436, }, },
    NullableValue = 
new System.Int32[,] { { 954205535, 1013544227, }, { 1296871126, 1476910231, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Int32[,] { { 1521851811, 607377316, }, { 2143456351, 307257346, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Int32[,] { { 835826916, 18008680, }, { 45402545, 93082472, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Int32[,] { { 2076967782, 680500177, }, { 2023002905, 1056444422, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int32[,] { { 331616301, 310410120, }, { 367039660, 148129227, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Int32[,] { { 1491676637, 1521905395, }, { 172661897, 621394429, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Int32[,] { { 2094175801, 368784527, }, { 1977930310, 759329597, }, },
    NullableValue = 
new System.Int32[,] { { 358908654, 1122099151, }, { 88722141, 1153856642, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Int32[,] { { 1368824087, 197781884, }, { 2008857364, 1055979891, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1264139115, 634754860, }, { 1776024116, 1275916274, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Int32[,] { { 1631310176, 2049746565, }, { 807140083, 1951309076, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Int32[,] { { 1491164181, 2065654626, }, { 2094937849, 850721426, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 336454414, 64251724, }, { 1216308396, 641543320, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Int32[,] { { 124534744, 307834820, }, { 635176708, 1705332984, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1665434221, 600940070, }, { 982974681, 1907411402, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int32[,] { { 1632104524, 1601224072, }, { 241673614, 2120276514, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Int32[,] { { 1178634070, 1959199663, }, { 1874892587, 399784064, }, },
    NullableValue = 
new System.Int32[,] { { 99552199, 1775843850, }, { 211995976, 2073438751, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Int32[,] { { 571605242, 1832151550, }, { 1592959578, 1608642128, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1707709331, 1979710940, }, { 1175346969, 625316372, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int32[,] { { 2068543889, 1265720289, }, { 689708127, 1795993268, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Int32[,] { { 905927543, 287517193, }, { 1950788320, 19531799, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Int32[,] { { 1141641713, 362548773, }, { 1990286888, 1377244138, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1839929029, 1852135218, }, { 1881182121, 434442025, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Int32[,] { { 757102242, 980995520, }, { 287977525, 699928871, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int32[,] { { 741381520, 46220451, }, { 906445307, 629329775, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int32[,] { { 1864293135, 911847128, }, { 793224028, 130430469, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int32[,] { { 1480376350, 1753113268, }, { 705764327, 784804321, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 2142948191, 1646402559, }, { 850008094, 1284542616, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Int32[,] { { 1634251387, 543265811, }, { 358480138, 463271223, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Int32[,] { { 722077118, 1070583087, }, { 190598294, 1217441181, }, },
    NullableValue = 
new System.Int32[,] { { 502916985, 961058490, }, { 2110024957, 554825415, }, },
},
    NullableValue = 
new System.Int32[,] { { 1066520359, 1505209596, }, { 431109019, 1721255884, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Int32[,] { { 843907475, 323401054, }, { 1483954631, 1004950134, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 817484382, 1992258751, }, { 288231837, 112256756, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int32[,] { { 3650870, 711800056, }, { 968244171, 909541060, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Int32[,] { { 1013786188, 1456355634, }, { 380307397, 1325239559, }, },
    NullableValue = 
new System.Int32[,] { { 494119463, 1006341674, }, { 400406954, 1465352191, }, },
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Int32[,] { { 1186791796, 991478551, }, { 33241937, 1719513815, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 1800149905, 1811467491, }, { 1405245455, 1654325272, }, },
},
            new Int32integerMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Int32[,] { { 752735109, 177038508, }, { 1151600678, 427638777, }, },
    ModelInner = new Int32integerMMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Int32[,] { { 1647192071, 1699437204, }, { 1350299888, 1902531905, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Int32[,] { { 1914782121, 1307390789, }, { 1985208481, 212881153, }, },
    ModelInner = null,
    NullableValue = 
new System.Int32[,] { { 82072686, 423417237, }, { 107058151, 1786287397, }, },
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
new System.Int32[,] { { 913121174, 522816299, }, { 112887716, 1395014186, }, }));
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
new System.Int32[,] { { 560805969, 1653048742, }, { 1109630639, 1711677148, }, }));
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
new System.Int32[,] { { 1378253468, 1993449292, }, { 928789833, 1208039037, }, }));
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
new System.Int32[,] { { 872734190, 1525605819, }, { 1830855560, 362068837, }, }));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt32MArrayintegerMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[,] { { 695446865, 1833591605, }, { 1587628308, 474655127, }, }));
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 154, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 91, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 33, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 133, query2))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 36, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integerMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 20, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt32integerMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 13, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        Int32integerMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 109, 104))
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
                ((IInt32MArrayintegerMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((IInt32MArrayintegerMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32MArrayintegerMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32MArrayintegerMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models =  ((IInt32MArrayintegerMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Int32integerMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                Int32integerMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                Int32integerMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                Int32integerMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                Int32integerMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                Int32integerMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                Int32integerMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                Int32integerMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                Int32integerMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                Int32integerMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                Int32integerMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                Int32integerMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                Int32integerMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                Int32integerMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                Int32integerMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                Int32integerMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                Int32integerMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                Int32integerMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                Int32integerMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                Int32integerMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                Int32integerMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                Int32integerMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                Int32integerMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                Int32integerMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                Int32integerMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                Int32integerMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                Int32integerMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                Int32integerMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                Int32integerMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                Int32integerMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                Int32integerMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                Int32integerMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                Int32integerMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                Int32integerMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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


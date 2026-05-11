

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
    internal partial interface IInt32MArrayintegerMMArrayD1
    {
    }
    
    internal partial class Int32MArrayintegerMMArrayD1 : IInt32MArrayintegerMMArrayD1
    {


#region TestData

        private readonly Int32integerMMArrayD1E1M[] _testData = new Int32integerMMArrayD1E1M[]
        {
            new Int32integerMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Int32[4]
{
556798339,
1267505910,
1206104690,
1442421516,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
141178753,
2122479761,
1134994326,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 12,
    Value = 
new System.Int32[3]
{
1326487630,
52218308,
300893591,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int32[3]
{
825403272,
997952078,
1893865653,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
90025961,
1347319233,
281803230,
1182206668,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int32[3]
{
1900335533,
558440193,
1624041186,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
411734252,
1335882697,
969644368,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int32[4]
{
1651051648,
682737791,
1456508037,
1993341466,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Int32[4]
{
1154931487,
2064298855,
1854001964,
793447741,
},
    NullableValue = 
new System.Int32[4]
{
1097760587,
1431878409,
793138967,
1281253619,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Int32[3]
{
1013388882,
502687934,
344514041,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Int32[4]
{
1683367160,
890205758,
2057406445,
1120516398,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Int32[4]
{
118809838,
105665715,
116761123,
1915502360,
},
    NullableValue = 
new System.Int32[3]
{
1855402963,
1488314131,
1782088892,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int32[4]
{
1400631878,
482210900,
638459396,
1674703760,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Int32[4]
{
931958026,
1615352261,
982325341,
1935404742,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Int32[4]
{
235080227,
1847005598,
959047464,
1245192054,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1707456740,
1162115475,
515453122,
1219250185,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Int32[4]
{
550975377,
2006867954,
1959737733,
783362086,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Int32[3]
{
586744059,
129481826,
635278942,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int32[3]
{
1172048989,
1498467856,
1373457090,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Int32[4]
{
1490139177,
1579225989,
1694614357,
1962747952,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1558505217,
1535632764,
722607200,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int32[3]
{
965183881,
388408898,
1170180352,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Int32[3]
{
865208135,
1641030414,
1747042954,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int32[3]
{
1649380336,
1241381465,
1341218021,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Int32[3]
{
1527169610,
1293822783,
1196831772,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Int32[4]
{
1082131174,
1977513580,
1178204376,
2092790226,
},
    NullableValue = 
new System.Int32[4]
{
1145815833,
1690566536,
958360683,
947212127,
},
},
    NullableValue = 
new System.Int32[3]
{
1550321872,
849883050,
1363632936,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Int32[3]
{
123510825,
653587181,
114094958,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Int32[3]
{
478893397,
312758002,
357569369,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Int32[3]
{
1701370155,
1236435356,
1612621485,
},
    NullableValue = 
new System.Int32[3]
{
1982962516,
1603972137,
898343309,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int32[3]
{
1300849239,
1067066991,
668823400,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1765937665,
475624352,
474247890,
1991804050,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int32[3]
{
1489588020,
1653081069,
2062315192,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Int32[4]
{
1434643822,
927074265,
1577903526,
1955175979,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int32[4]
{
1953725726,
2119268366,
769079745,
1363441661,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
974817041,
535990287,
1463391658,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Int32[3]
{
298921463,
786325631,
1742633692,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Int32[3]
{
578057459,
880948234,
452180221,
},
    NullableValue = 
new System.Int32[3]
{
2030936563,
1218904668,
1402306239,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Int32[4]
{
1206481008,
1796912076,
623341777,
1999780107,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Int32[3]
{
1384951838,
1199838240,
185625595,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int32[3]
{
591641483,
1876729037,
490123357,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
527181941,
1773605775,
700847939,
1282845969,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int32[3]
{
2054998367,
43106288,
1987525185,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1435534737,
1075428614,
634668882,
2064937121,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Int32[4]
{
1020423209,
1626136972,
1180564335,
63519388,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Int32[3]
{
1890165604,
531583585,
1905615089,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1058996320,
1777201374,
34796323,
1075671560,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Int32[4]
{
1904556791,
1759841563,
1378893280,
419965603,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Int32[3]
{
708388352,
1725064663,
78456157,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Int32[4]
{
1040287170,
512666230,
1686575324,
577306632,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Int32[4]
{
1943884227,
947411826,
914299164,
1780900995,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1208631268,
1830097381,
802450361,
1923196988,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int32[4]
{
1552716503,
1473381620,
447644120,
332175359,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Int32[3]
{
959564024,
1208670387,
1462776895,
},
    NullableValue = 
new System.Int32[4]
{
1474017545,
1765883202,
903515473,
1509708335,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Int32[4]
{
788339342,
439953370,
353449738,
2132966322,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 175,
    Value = 
new System.Int32[3]
{
1661490212,
19530609,
1578815970,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Int32[4]
{
1447085946,
1302084658,
191424798,
1954149141,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 183,
    Value = 
new System.Int32[4]
{
1622663366,
989894534,
980593350,
86133275,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1900295794,
1852975304,
606456847,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 192,
    Value = 
new System.Int32[4]
{
1155079336,
1702662741,
966715646,
1501996420,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Int32[3]
{
1415931232,
1401242988,
1517488323,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 198,
    Value = 
new System.Int32[3]
{
1640501280,
804573129,
1425370578,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
500502356,
1824200551,
1627690692,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 199,
    Value = 
new System.Int32[3]
{
1354329481,
1537156079,
1080561437,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Int32[4]
{
1171497108,
1632568027,
1865367167,
676869652,
},
    NullableValue = 
new System.Int32[3]
{
1952510313,
55255658,
569371832,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 201,
    Value = 
new System.Int32[4]
{
956927021,
74318574,
60093802,
428401647,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
2017099698,
48683680,
1498811813,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1mi(
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1mi(
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
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
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

                changedRows =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd1e1mi_id
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integermmarrayd1e1mi_id", 
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
                changedRows =  ((IInt32MArrayintegerMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32MArrayintegerMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd1e1mi_id
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
    int32integermmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                System.Int32[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[]>();
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[]>();
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[]>();
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[]>();
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
1707456740,
1162115475,
515453122,
1219250185,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd1e1mi_id
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
    int32integermmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integermmarrayd1e1mi_id", 
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
                System.Int32[] nullable = null;
                nullable =  ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[] nullable = null;
                nullable = await ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1558505217,
1535632764,
722607200,
}));
                nullable = await ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerMMArrayD1E1M> models = null;

                models =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerMMArrayD1E1M> models = null;

                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M), typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                ((IInt32MArrayintegerMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
LEFT JOIN public.int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models = await ((IInt32MArrayintegerMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32MArrayintegerMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M), typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                ((IInt32MArrayintegerMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
LEFT JOIN public.int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models = await ((IInt32MArrayintegerMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32MArrayintegerMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M), typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                await((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 192;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
LEFT JOIN public.int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models = await((IInt32MArrayintegerMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 192;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M), typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                await((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 116, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 149, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 149, query1, 198, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 71, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 183, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 58, query1, 99, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 12, query1, 171, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
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
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 149, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int32integermmarrayd1e1m m
LEFT JOIN public.int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models = await((IInt32MArrayintegerMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 105, 165))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 165, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IInt32MArrayintegerMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32MArrayintegerMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                Int32integerMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                Int32integerMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32MArrayintegerMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32MArrayintegerMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models =  ((IInt32MArrayintegerMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                Int32integerMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                Int32integerMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                Int32integerMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                Int32integerMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                Int32integerMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                Int32integerMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_int32integermmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integermmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integermmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD1E1MI),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32MArrayintegerMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32MArrayintegerMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int32integermmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integermmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerMMArrayD1E1M),
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
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
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
FROM public.binary_int32integermmarrayd1e1m m
LEFT JOIN public.binary_int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt32MArrayintegerMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt32MArrayintegerMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integermmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models =  ((IInt32MArrayintegerMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32MArrayintegerMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA), typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                ((IInt32MArrayintegerMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int32integermmarrayd1e1mi
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
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int32integermmarrayd1e1mi
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
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA), typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
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
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                ((IInt32MArrayintegerMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
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
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int32integermmarrayd1e1mi
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
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int32integermmarrayd1e1mi
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
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MI), typeof(Int32integerMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models1 = new List<Int32integerMMArrayD1E1MI>();
                var models2 = new List<Int32integerMMArrayD1E1MI>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerMMArrayD1E1MI>();
                var models2 = new List<Int32integerMMArrayD1E1MI>();
                ((IInt32MArrayintegerMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
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
                var models = await ((IInt32MArrayintegerMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32MArrayintegerMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA), typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
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
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                ((IInt32MArrayintegerMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
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
                var models = await ((IInt32MArrayintegerMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32MArrayintegerMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


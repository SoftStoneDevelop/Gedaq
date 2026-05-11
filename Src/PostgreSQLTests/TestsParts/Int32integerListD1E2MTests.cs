

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
    internal partial interface IInt32ListintegerListD1
    {
    }
    
    internal partial class Int32ListintegerListD1 : IInt32ListintegerListD1
    {


#region TestData

        private readonly Int32integerListD1E2M[] _testData = new Int32integerListD1E2M[]
        {
            new Int32integerListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2005885969,

670274343,

1342372345,

1745232439,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1584722909,

296480843,

1167006663,

81372742,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
622789899,

1171238852,

1818742025,

861430404,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1446731810,

757402153,

968112992,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
919325859,

1370341824,

1169571030,

1934066131,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
404128242,

1987871109,

1430746861,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
426676086,

845989597,

298595926,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1387697756,

4230310,

1448153070,

1207787518,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
669914863,

1019006102,

763210687,

551858815,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1122789936,

513255236,

305693924,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
848083192,

218414318,

458435871,

},
},
            new Int32integerListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
438598937,

356967681,

1608725798,

1498329906,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1861271780,

543287009,

460696828,

},
},
            new Int32integerListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
728907276,

2125300577,

1874773667,

1047211687,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
79684510,

806197141,

1682342641,

984489329,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
360907933,

1767156659,

1894722495,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1159278302,

38899868,

324645049,

2134472418,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1654717677,

868457648,

61732351,

673104355,

},
},
            new Int32integerListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
3675571,

1974684576,

869403579,

342103950,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1966078962,

563830585,

611313640,

1125842018,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1117103625,

1896015992,

337642386,

},
},
            new Int32integerListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1613971527,

218296532,

1524436097,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1849494091,

1390228681,

609280013,

1173276092,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
209428394,

687487083,

265597339,

717620298,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
738398477,

1388388739,

2030680994,

700972558,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2080020370,

1732706753,

1239952056,

1632504038,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1995525239,

236629462,

1645492309,

1971893878,

},
},
            new Int32integerListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1974409592,

2128254088,

1549534794,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
234021361,

774489686,

1571421938,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1850224990,

278722608,

1908333580,

},
},
            new Int32integerListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
745733031,

379591603,

1790895868,

1896238026,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2084771664,

499065528,

559067473,

326921258,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2058643040,

1877067349,

832542476,

958572335,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1796497702,

540017222,

1258210626,

1765707436,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
687267976,

823458609,

534931535,

1724772336,

},
},
            new Int32integerListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1749086683,

1022405360,

1280753921,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
490657204,

246641426,

1604020439,

756984564,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
527648365,

1537343590,

1937292690,

1569571133,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
786308403,

956847456,

2024580286,

558637783,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
362679568,

1128324294,

1398044736,

636204002,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
550981079,

818952644,

2071522694,

599587374,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1448875393,

1523927841,

2078579182,

598778153,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1532481934,

1653086736,

2018095531,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1543854737,

1924864703,

1352447065,

956094873,

},
},
            new Int32integerListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1897393495,

2052239112,

1371121368,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
346906135,

212467421,

940420496,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
554623830,

1812008085,

2088858702,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
141364431,

1468831052,

1295776188,

504967821,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2011347800,

451415605,

1084405183,

1169609723,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1448388361,

2066019383,

1391795127,

387755092,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1711221854,

2117765857,

623276442,

864517811,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
839284247,

1921772580,

61186435,

},
},
            new Int32integerListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
642170920,

1566435203,

1835690631,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1696896219,

2115992177,

1139581977,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
417547548,

1156107458,

615876027,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1984142854,

819866028,

50534999,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1210479254,

1436013963,

1287099578,

},
},
            new Int32integerListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1657043061,

1319738745,

828834370,

502479894,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1802602254,

315186327,

2093700935,

1131336131,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1291127941,

1455183918,

1756097652,

1352820837,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
521121019,

1421951270,

24233127,

},
},
            new Int32integerListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1810539752,

1347257799,

707542026,

1635127011,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1833917741,

1063695996,

1231766773,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
291594612,

1609303161,

1629885254,

},
},
            new Int32integerListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
628583464,

2041638784,

1840807207,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
509246994,

1953727276,

2008729406,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1110604191,

768985991,

307339086,

1636901731,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1143007828,

155168420,

95222812,

436455855,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1188163149,

970338623,

1567158088,

359803270,

},
    ModelInner = new Int32integerListD12MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1178344497,

1746574291,

1550521124,

1085568402,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
8855720,

1477711852,

628345077,

523220501,

},
},
            new Int32integerListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
336348995,

2139404586,

706785664,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerlistd12mi(
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
            asPartInterface: typeof(IInt32ListintegerListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerlistd12mi(
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
            queryMapTypes: [typeof(Int32integerListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>), 
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

                changedRows =  ((IInt32ListintegerListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32ListintegerListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32ListintegerListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32ListintegerListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32ListintegerListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32ListintegerListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt32ListintegerListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerlistd1e2m(
	id,
    value,
    nullablevalue,
    int32integerlistd12mi_id
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
            asPartInterface: typeof(IInt32ListintegerListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integerlistd12mi_id", 
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
                changedRows =  ((IInt32ListintegerListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32ListintegerListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32ListintegerListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32ListintegerListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerlistd1e2m(
	id,
    value,
    nullablevalue,
    int32integerlistd12mi_id
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
    int32integerlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerlistd1e2m(
	id,
    value,
    nullablevalue,
    int32integerlistd12mi_id
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
    int32integerlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integerlistd12mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerListD1E2M> models = null;

                models =  ((IInt32ListintegerListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt32ListintegerListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt32ListintegerListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt32ListintegerListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerListD1E2M> models = null;

                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt32ListintegerListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerListD1E2M), typeof(FlatInt32integerListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
FROM public.int32integerlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerListD1E2M>();
                var models2 = new List<FlatInt32integerListD1E2M>();
                await ((IInt32ListintegerListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerListD1E2M>();
                var models2 = new List<FlatInt32integerListD1E2M>();
                ((IInt32ListintegerListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
FROM public.int32integerlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32ListintegerListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32ListintegerListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
LEFT JOIN public.int32integerlistd12mi mi ON mi.id = m.int32integerlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models = await ((IInt32ListintegerListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32ListintegerListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerListD1E2M), typeof(FlatInt32integerListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
FROM public.int32integerlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerListD1E2M>();
                var models2 = new List<FlatInt32integerListD1E2M>();
                await ((IInt32ListintegerListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerListD1E2M>();
                var models2 = new List<FlatInt32integerListD1E2M>();
                ((IInt32ListintegerListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
FROM public.int32integerlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32ListintegerListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32ListintegerListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
LEFT JOIN public.int32integerlistd12mi mi ON mi.id = m.int32integerlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models = await ((IInt32ListintegerListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32ListintegerListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerListD1E2M), typeof(FlatInt32integerListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerListD1E2M>();
                var models2 = new List<FlatInt32integerListD1E2M>();
                await((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var firstItems2 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems2 = new List<FlatInt32integerListD1E2M>();
                await ((IInt32ListintegerListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var firstItems2 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                await ((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerListD1E2M>();
                var models2 = new List<FlatInt32integerListD1E2M>();
                ((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var firstItems2 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems2 = new List<FlatInt32integerListD1E2M>();
                 ((IInt32ListintegerListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var firstItems2 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                 ((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems2 = new List<FlatInt32integerListD1E2M>();
                await ((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems2 = new List<FlatInt32integerListD1E2M>();
                 ((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
LEFT JOIN public.int32integerlistd12mi mi ON mi.id = m.int32integerlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models = await((IInt32ListintegerListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[7], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[8], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[9], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[10], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[11], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[12], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[13], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[14], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[15], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[16], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[18],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[19],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[20],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[21],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[22],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[23],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[24],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[25],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[26],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IInt32ListintegerListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[7], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[8], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[9], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[10], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[11], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[12], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[13], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[14], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[15], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[16], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[18],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[19],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[20],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[21],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[22],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[23],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[24],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[25],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[26],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerListD1E2M), typeof(FlatInt32integerListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerListD1E2M>();
                var models2 = new List<FlatInt32integerListD1E2M>();
                await((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var firstItems2 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems2 = new List<FlatInt32integerListD1E2M>();
                await ((IInt32ListintegerListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var firstItems2 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                await ((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 41, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerListD1E2M>();
                var models2 = new List<FlatInt32integerListD1E2M>();
                ((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var firstItems2 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems2 = new List<FlatInt32integerListD1E2M>();
                 ((IInt32ListintegerListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 151, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var firstItems2 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                 ((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems2 = new List<FlatInt32integerListD1E2M>();
                await ((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 162, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 50, query1, 155, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
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
FROM public.int32integerlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems1 = new List<FlatInt32integerListD1E2M>();
                var secondItems2 = new List<FlatInt32integerListD1E2M>();
                 ((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.int32integerlistd1e2m m
LEFT JOIN public.int32integerlistd12mi mi ON mi.id = m.int32integerlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models = await((IInt32ListintegerListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32ListintegerListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 55, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[12], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[13], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[14], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[15], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[16], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[18],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[19],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[20],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[21],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IInt32ListintegerListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32ListintegerListD1)this).DbConnectionSTSelectModelBatch(connection, 41, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[8], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[9], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[10], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[11], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[12], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[13], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[14], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[15], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[16], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[18],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[19],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[20],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[21],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[22],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[23],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[24],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[25],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[15], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[16], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[18],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((IInt32ListintegerListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32ListintegerListD1)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models = await ((IInt32ListintegerListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                Int32integerListD1E2M.AssertModel(models[0],_testData[10], false);
                Int32integerListD1E2M.AssertModel(models[1],_testData[11], false);
                Int32integerListD1E2M.AssertModel(models[2],_testData[12], false);
                Int32integerListD1E2M.AssertModel(models[3],_testData[13], false);
                Int32integerListD1E2M.AssertModel(models[4],_testData[14], false);
                Int32integerListD1E2M.AssertModel(models[5],_testData[15], false);
                Int32integerListD1E2M.AssertModel(models[6],_testData[16], false);
                Int32integerListD1E2M.AssertModel(models[7],_testData[17], false);
                Int32integerListD1E2M.AssertModel(models[8],_testData[18], false);
                Int32integerListD1E2M.AssertModel(models[9],_testData[19], false);
                Int32integerListD1E2M.AssertModel(models[10],_testData[20], false);
                Int32integerListD1E2M.AssertModel(models[11],_testData[21], false);
                Int32integerListD1E2M.AssertModel(models[12],_testData[22], false);
                Int32integerListD1E2M.AssertModel(models[13],_testData[23], false);
                Int32integerListD1E2M.AssertModel(models[14],_testData[24], false);
                Int32integerListD1E2M.AssertModel(models[15],_testData[25], false);
                Int32integerListD1E2M.AssertModel(models[16],_testData[26], false);
                Int32integerListD1E2M.AssertModel(models[17],_testData[27], false);
                Int32integerListD1E2M.AssertModel(models[18],_testData[28], false);
                Int32integerListD1E2M.AssertModel(models[19],_testData[29], false);
                Int32integerListD1E2M.AssertModel(models[20],_testData[30], false);
                Int32integerListD1E2M.AssertModel(models[21],_testData[31], false);
                Int32integerListD1E2M.AssertModel(models[22],_testData[32], false);
                Int32integerListD1E2M.AssertModel(models[23],_testData[33], false);
                Int32integerListD1E2M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerListD1)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((IInt32ListintegerListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                Int32integerListD1E2M.AssertModel(models[0],_testData[20], false);
                Int32integerListD1E2M.AssertModel(models[1],_testData[21], false);
                Int32integerListD1E2M.AssertModel(models[2],_testData[22], false);
                Int32integerListD1E2M.AssertModel(models[3],_testData[23], false);
                Int32integerListD1E2M.AssertModel(models[4],_testData[24], false);
                Int32integerListD1E2M.AssertModel(models[5],_testData[25], false);
                Int32integerListD1E2M.AssertModel(models[6],_testData[26], false);
                Int32integerListD1E2M.AssertModel(models[7],_testData[27], false);
                Int32integerListD1E2M.AssertModel(models[8],_testData[28], false);
                Int32integerListD1E2M.AssertModel(models[9],_testData[29], false);
                Int32integerListD1E2M.AssertModel(models[10],_testData[30], false);
                Int32integerListD1E2M.AssertModel(models[11],_testData[31], false);
                Int32integerListD1E2M.AssertModel(models[12],_testData[32], false);
                Int32integerListD1E2M.AssertModel(models[13],_testData[33], false);
                Int32integerListD1E2M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_int32integerlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int32integerListD12MIWA),
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
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ListintegerListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32ListintegerListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ListintegerListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32ListintegerListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integerListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ListintegerListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32ListintegerListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ListintegerListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32ListintegerListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integerListD12MI),
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
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32ListintegerListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32ListintegerListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32ListintegerListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt32ListintegerListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ListintegerListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32ListintegerListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ListintegerListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32ListintegerListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integerlistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerListD1E2M),
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
            asPartInterface: typeof(IInt32ListintegerListD1))]
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
FROM public.binary_int32integerlistd1e2m m
LEFT JOIN public.binary_int32integerlistd12mi mi ON mi.id = m.int32integerlistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt32ListintegerListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt32ListintegerListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt32ListintegerListD1)this).ImportModel(connection, importCollection);
                var models = ((IInt32ListintegerListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integerlistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models =  ((IInt32ListintegerListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ListintegerListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA), typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models1 = new List<Int32integerListD12MIWA>();
                var models2 = new List<Int32integerListD12MIWA>();
                await ((IInt32ListintegerListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerListD12MIWA>();
                var models2 = new List<Int32integerListD12MIWA>();
                ((IInt32ListintegerListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models = await ((IInt32ListintegerListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int32integerlistd12mi
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
                    Int32integerListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ListintegerListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int32integerlistd12mi
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
                    Int32integerListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA), typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
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
                var models1 = new List<Int32integerListD12MIWA>();
                var models2 = new List<Int32integerListD12MIWA>();
                await ((IInt32ListintegerListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerListD12MIWA>();
                var models2 = new List<Int32integerListD12MIWA>();
                ((IInt32ListintegerListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
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
                var models = await ((IInt32ListintegerListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int32integerlistd12mi
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
                    Int32integerListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ListintegerListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int32integerlistd12mi
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
                    Int32integerListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integerlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MI), typeof(Int32integerListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models1 = new List<Int32integerListD12MI>();
                var models2 = new List<Int32integerListD12MI>();
                await ((IInt32ListintegerListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerListD12MI>();
                var models2 = new List<Int32integerListD12MI>();
                ((IInt32ListintegerListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1)),
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
                var models = await ((IInt32ListintegerListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ListintegerListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integerlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA), typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
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
                var models1 = new List<Int32integerListD12MIWA>();
                var models2 = new List<Int32integerListD12MIWA>();
                await ((IInt32ListintegerListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerListD12MIWA>();
                var models2 = new List<Int32integerListD12MIWA>();
                ((IInt32ListintegerListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerListD1))]
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
                var models = await ((IInt32ListintegerListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ListintegerListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


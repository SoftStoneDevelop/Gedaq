

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
    internal partial interface IInt32ListintegerArray
    {
    }
    
    internal partial class Int32ListintegerArray : IInt32ListintegerArray
    {


#region TestData

        private readonly Int32integerArray2M[] _testData = new Int32integerArray2M[]
        {
            new Int32integerArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1876906675,

108747623,

1572523058,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1475049637,

416738328,

60641803,

},
},
            new Int32integerArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1753997479,

1938459386,

682502638,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
880113814,

874732184,

164873591,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
990312436,

1427389115,

1191680191,

926384777,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
561649771,

1345089137,

1295684180,

},
},
            new Int32integerArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1180916681,

2062568692,

1042533864,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
231042482,

725046183,

1449499938,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
178663986,

493512461,

692387147,

1992150917,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1517851364,

1756518638,

845138797,

1477482444,

},
},
            new Int32integerArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1978712603,

516292199,

1924400690,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1577943706,

464714627,

1723819874,

1334341357,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1371668695,

2055540804,

1188530102,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
826107240,

926101368,

377021670,

1098261605,

},
},
            new Int32integerArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1212161726,

1342877824,

617103234,

783817762,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1236379102,

841473317,

633899106,

1163965289,

},
},
            new Int32integerArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1396024211,

194951191,

1268555801,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2036725285,

961619909,

2008856578,

555422642,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
715662130,

1390726133,

1758823990,

1394413980,

},
},
            new Int32integerArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1469948542,

2083368010,

175017581,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
2110886024,

559416756,

1219242227,

},
},
            new Int32integerArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
331686138,

653498843,

708157382,

1143490452,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
26504278,

553815270,

246869404,

1576409823,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
267737452,

2064640890,

2115110260,

495794060,

},
},
            new Int32integerArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
328025216,

1623172197,

851408751,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1735896883,

443646637,

844518465,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2090131528,

1271218724,

1731857334,

1123886876,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
587611156,

629734178,

1221099279,

424942951,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1812709891,

466614413,

1611457869,

85865726,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1541825619,

541647229,

445189034,

229087357,

},
},
            new Int32integerArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1757773767,

1650838680,

551162326,

504660490,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1496240462,

504626881,

2120503506,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
994070354,

1654809434,

2133009140,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
838927272,

630551693,

1155891043,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1636750842,

1255858672,

105670175,

},
},
            new Int32integerArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
236027441,

2133173261,

1332897992,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
491307170,

419864331,

670696620,

635821619,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
256634563,

912908218,

2027639355,

1455501885,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
2109301152,

337408356,

351806268,

},
},
            new Int32integerArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1835560882,

1239115738,

1817863348,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
130001443,

722876133,

58600547,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1480046101,

224256857,

2127957800,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
576164915,

1508237257,

683119705,

1471802672,

},
},
            new Int32integerArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
889469895,

575852648,

839414911,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1886260117,

1666050636,

842168497,

1831425729,

},
},
            new Int32integerArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
197422342,

316357833,

498942268,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
326556843,

1049876991,

415939457,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1596364194,

1698296664,

1529591478,

2005572072,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1279867009,

232795301,

603062347,

2072927475,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1743469748,

1197561228,

1428302968,

},
},
            new Int32integerArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
240089299,

1331084117,

1040308212,

1932007306,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
456135453,

927541889,

1592870572,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
671529436,

1208704675,

180799998,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
983322220,

511100337,

1522469011,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
522337758,

62177918,

864083164,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1054337520,

623993942,

233082112,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
237344726,

1392722547,

1371854725,

1739916515,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1828677952,

449840664,

527056462,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1968885658,

123856639,

2111046253,

1570968292,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
912059225,

458593729,

1592826631,

1633930869,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1474736121,

1592538092,

849017426,

920689745,

},
},
            new Int32integerArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1975515802,

258260544,

277611137,

294347442,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
662004050,

1844706955,

870423620,

1253392769,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
449894863,

1261351143,

1404894482,

1003397468,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1631959995,

494028279,

84534525,

243471192,

},
},
            new Int32integerArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
783154755,

620719703,

2017681887,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1545714418,

403347071,

1258551944,

162260354,

},
},
            new Int32integerArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
164306465,

148112046,

1311510398,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1986869090,

1422226069,

1894795228,

1757563550,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1033102672,

576220648,

947606747,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1635693343,

617512105,

1710482693,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
29806511,

1271939760,

684818906,

1356265140,

},
},
            new Int32integerArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
600904267,

1510098181,

1823374759,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
145974675,

1045879372,

703458257,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
913553634,

1636579733,

9657195,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1089784718,

2134946197,

1977961399,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
289740121,

1409314359,

1781742596,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
337951044,

188866836,

435747580,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
740578961,

849349937,

1342890289,

922973569,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2mi(
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
INSERT INTO public.int32integerarray2mi(
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
            queryMapTypes: [typeof(Int32integerArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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

                changedRows =  ((IInt32ListintegerArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32ListintegerArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32ListintegerArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32ListintegerArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32ListintegerArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32ListintegerArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2m(
	id,
    value,
    nullablevalue,
    int32integerarray2mi_id
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
            asPartInterface: typeof(IInt32ListintegerArray)), 
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
                methodParametrName: "int32integerarray2mi_id", 
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
                changedRows =  ((IInt32ListintegerArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32ListintegerArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32ListintegerArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32ListintegerArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2m(
	id,
    value,
    nullablevalue,
    int32integerarray2mi_id
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
    int32integerarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2m(
	id,
    value,
    nullablevalue,
    int32integerarray2mi_id
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
    int32integerarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                methodParametrName: "int32integerarray2mi_id", 
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
                List<Int32integerArray2M> models = null;

                models =  ((IInt32ListintegerArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt32ListintegerArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt32ListintegerArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt32ListintegerArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerArray2M> models = null;

                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M), typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                ((IInt32ListintegerArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32ListintegerArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32ListintegerArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                var models = await ((IInt32ListintegerArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32ListintegerArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M), typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                ((IInt32ListintegerArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32ListintegerArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32ListintegerArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                var models = await ((IInt32ListintegerArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32ListintegerArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M), typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                await((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 138;
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[23],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[24],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[25],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[23],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[24],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[25],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[26],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[27],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[28],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[29],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                var models = await((IInt32ListintegerArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int32integerArray2M.AssertModel(models[0],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32integerArray2M.AssertModel(models[0],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[34], false);
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
                var models = ((IInt32ListintegerArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int32integerArray2M.AssertModel(models[0],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32integerArray2M.AssertModel(models[0],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M), typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                await((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 59, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 98, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 117, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 83, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 138, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[23],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[24],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[25],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[26],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[27],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[28],_testData[34], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 83, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 77, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[34], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 98, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                var models = await((IInt32ListintegerArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 104, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int32integerArray2M.AssertModel(models[0],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32integerArray2M.AssertModel(models[0],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IInt32ListintegerArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatch(connection, 117, 147))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32integerArray2M.AssertModel(models[0],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integerArray2M.AssertModel(models[0],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Int32integerArray2M.AssertModel(models[0],_testData[30], false);Int32integerArray2M.AssertModel(models[1],_testData[31], false);Int32integerArray2M.AssertModel(models[2],_testData[32], false);Int32integerArray2M.AssertModel(models[3],_testData[33], false);Int32integerArray2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Int32integerArray2M.AssertModel(models[0],_testData[10], false);Int32integerArray2M.AssertModel(models[1],_testData[11], false);Int32integerArray2M.AssertModel(models[2],_testData[12], false);Int32integerArray2M.AssertModel(models[3],_testData[13], false);Int32integerArray2M.AssertModel(models[4],_testData[14], false);Int32integerArray2M.AssertModel(models[5],_testData[15], false);Int32integerArray2M.AssertModel(models[6],_testData[16], false);Int32integerArray2M.AssertModel(models[7],_testData[17], false);Int32integerArray2M.AssertModel(models[8],_testData[18], false);Int32integerArray2M.AssertModel(models[9],_testData[19], false);Int32integerArray2M.AssertModel(models[10],_testData[20], false);Int32integerArray2M.AssertModel(models[11],_testData[21], false);Int32integerArray2M.AssertModel(models[12],_testData[22], false);Int32integerArray2M.AssertModel(models[13],_testData[23], false);Int32integerArray2M.AssertModel(models[14],_testData[24], false);Int32integerArray2M.AssertModel(models[15],_testData[25], false);Int32integerArray2M.AssertModel(models[16],_testData[26], false);Int32integerArray2M.AssertModel(models[17],_testData[27], false);Int32integerArray2M.AssertModel(models[18],_testData[28], false);Int32integerArray2M.AssertModel(models[19],_testData[29], false);Int32integerArray2M.AssertModel(models[20],_testData[30], false);Int32integerArray2M.AssertModel(models[21],_testData[31], false);Int32integerArray2M.AssertModel(models[22],_testData[32], false);Int32integerArray2M.AssertModel(models[23],_testData[33], false);Int32integerArray2M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_int32integerarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int32integerArray2MIWA),
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
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ListintegerArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32ListintegerArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ListintegerArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32ListintegerArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integerArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ListintegerArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32ListintegerArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ListintegerArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32ListintegerArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integerArray2MI),
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
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32ListintegerArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32ListintegerArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32ListintegerArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt32ListintegerArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ListintegerArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32ListintegerArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ListintegerArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32ListintegerArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integerarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerArray2M),
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
FROM public.binary_int32integerarray2m m
LEFT JOIN public.binary_int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt32ListintegerArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt32ListintegerArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt32ListintegerArray)this).ImportModel(connection, importCollection);
                var models = ((IInt32ListintegerArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integerarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerArray2M)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32ListintegerArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ListintegerArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA), typeof(Int32integerArray2MIWA)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
                var models1 = new List<Int32integerArray2MIWA>();
                var models2 = new List<Int32integerArray2MIWA>();
                await ((IInt32ListintegerArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerArray2MIWA>();
                var models2 = new List<Int32integerArray2MIWA>();
                ((IInt32ListintegerArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
                var models = await ((IInt32ListintegerArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int32integerarray2mi
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
                    Int32integerArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ListintegerArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int32integerarray2mi
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
                    Int32integerArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA), typeof(Int32integerArray2MIWA)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
                var models1 = new List<Int32integerArray2MIWA>();
                var models2 = new List<Int32integerArray2MIWA>();
                await ((IInt32ListintegerArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerArray2MIWA>();
                var models2 = new List<Int32integerArray2MIWA>();
                ((IInt32ListintegerArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
                var models = await ((IInt32ListintegerArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int32integerarray2mi
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
                    Int32integerArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ListintegerArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int32integerarray2mi
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
                    Int32integerArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integerarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MI), typeof(Int32integerArray2MI)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
                var models1 = new List<Int32integerArray2MI>();
                var models2 = new List<Int32integerArray2MI>();
                await ((IInt32ListintegerArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerArray2MI>();
                var models2 = new List<Int32integerArray2MI>();
                ((IInt32ListintegerArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MI)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
                var models = await ((IInt32ListintegerArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ListintegerArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integerarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA), typeof(Int32integerArray2MIWA)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
                var models1 = new List<Int32integerArray2MIWA>();
                var models2 = new List<Int32integerArray2MIWA>();
                await ((IInt32ListintegerArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerArray2MIWA>();
                var models2 = new List<Int32integerArray2MIWA>();
                ((IInt32ListintegerArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MIWA)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
                var models = await ((IInt32ListintegerArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ListintegerArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


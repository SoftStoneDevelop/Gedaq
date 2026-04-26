

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
484261631,

899987695,

685571150,

1699093038,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1515887521,

1771439842,

345849400,

},
},
            new Int32integerArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1254840173,

1555250457,

1588689905,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
394760586,

518590849,

1841390208,

505216010,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1574428000,

1914122729,

1787661862,

669560496,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1894392236,

585691057,

1235279051,

},
},
            new Int32integerArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1911112715,

1496024015,

725802439,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
193260055,

613298966,

633424847,

},
},
            new Int32integerArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
223822896,

916415503,

931035792,

329266358,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
940932053,

482239352,

705151338,

790933536,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
205230953,

482925687,

428459087,

399625950,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
832510653,

1117514404,

621259336,

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
1588900275,

1608083727,

1844305003,

659183244,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
177498266,

1571964984,

1315161620,

1547922457,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
287185444,

632597512,

648975239,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1742999711,

1787140473,

175000482,

617606927,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
496844500,

587923644,

34045582,

1495677049,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
210104612,

283461538,

1752196295,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1546543687,

123112849,

457527091,

},
},
            new Int32integerArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
594107765,

1610914986,

1584255047,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
757685344,

212915655,

1730479804,

2056715836,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
832119757,

104877380,

1600355918,

1450255807,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
808778841,

1136501975,

1366812625,

1173054457,

},
},
            new Int32integerArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1895784277,

1463488697,

997350139,

4779121,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
2065616251,

183966881,

1632893461,

1091930592,

},
},
            new Int32integerArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
716114800,

1125405374,

1432882633,

556884213,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2014276888,

2082197766,

436225706,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
190990525,

499922768,

908063720,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1932296584,

1378997,

2028098144,

1766577372,

},
},
            new Int32integerArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1648941744,

349191632,

778886560,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2006336287,

795199816,

1270921886,

849846337,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
262416478,

594774001,

613983245,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
936002285,

1322608136,

1943151276,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1322961908,

1435268784,

1256690718,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
359909778,

491171008,

404450021,

309626284,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
177142035,

1410668318,

341914454,

1129752012,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
315354353,

1470722550,

2121378620,

1470916406,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1485657122,

185726927,

1543528691,

1628478719,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1642426027,

211427672,

650926992,

1568536619,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1962379863,

1909652074,

1483632944,

1837603764,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
436162161,

100284785,

771503063,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1381188765,

1342246201,

540020366,

1735260910,

},
},
            new Int32integerArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1602380035,

278035325,

1952013578,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
2081982439,

1767601858,

139284778,

1328043146,

},
},
            new Int32integerArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1569145339,

571788694,

1473730929,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1877495257,

807515485,

653764386,

1530863192,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
574825629,

493288786,

245701419,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2058955319,

788090373,

91257088,

802661795,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1339373103,

1137668036,

168021355,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1628544218,

17678693,

64210141,

1631273825,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1918350266,

2055817656,

104609218,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1540581234,

1674524528,

1773566639,

},
},
            new Int32integerArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1172173740,

1806626801,

341408232,

412722764,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1375212482,

387628566,

814487653,

552568449,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
565430939,

270862237,

198195542,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1399240328,

1020868275,

1589577110,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1258835567,

1383992817,

1943264701,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1775403511,

305864052,

519208093,

},
},
            new Int32integerArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2112754300,

183926772,

1306761164,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
733035380,

1249978436,

836855416,

1070829181,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1674304496,

187887681,

1916560511,

353457983,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
559989786,

1854418151,

53308172,

},
},
            new Int32integerArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
282790476,

1039558824,

1010327859,

1447682066,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
260988110,

1273964425,

1721606120,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1984383605,

1754164728,

1666336749,

1935812050,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
886441453,

739444823,

1863060493,

724550010,

},
},
    NullableValue = null,
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IInt32ListintegerArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IInt32ListintegerArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((IInt32ListintegerArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32ListintegerArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IInt32ListintegerArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((IInt32ListintegerArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatInt32integerArray2M.AssertModel(models[0],_testData[1], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[2], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[3], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[4], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[5], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[6], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[7], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[8], false);FlatInt32integerArray2M.AssertModel(models[8],_testData[9], false);FlatInt32integerArray2M.AssertModel(models[9],_testData[10], false);FlatInt32integerArray2M.AssertModel(models[10],_testData[11], false);FlatInt32integerArray2M.AssertModel(models[11],_testData[12], false);FlatInt32integerArray2M.AssertModel(models[12],_testData[13], false);FlatInt32integerArray2M.AssertModel(models[13],_testData[14], false);FlatInt32integerArray2M.AssertModel(models[14],_testData[15], false);FlatInt32integerArray2M.AssertModel(models[15],_testData[16], false);FlatInt32integerArray2M.AssertModel(models[16],_testData[17], false);FlatInt32integerArray2M.AssertModel(models[17],_testData[18], false);FlatInt32integerArray2M.AssertModel(models[18],_testData[19], false);FlatInt32integerArray2M.AssertModel(models[19],_testData[20], false);FlatInt32integerArray2M.AssertModel(models[20],_testData[21], false);FlatInt32integerArray2M.AssertModel(models[21],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[22],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[23],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[24],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[25],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[26],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[27],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatInt32integerArray2M.AssertModel(models[0],_testData[5], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[6], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[7], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[8], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[9], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[10], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[11], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[12], false);FlatInt32integerArray2M.AssertModel(models[8],_testData[13], false);FlatInt32integerArray2M.AssertModel(models[9],_testData[14], false);FlatInt32integerArray2M.AssertModel(models[10],_testData[15], false);FlatInt32integerArray2M.AssertModel(models[11],_testData[16], false);FlatInt32integerArray2M.AssertModel(models[12],_testData[17], false);FlatInt32integerArray2M.AssertModel(models[13],_testData[18], false);FlatInt32integerArray2M.AssertModel(models[14],_testData[19], false);FlatInt32integerArray2M.AssertModel(models[15],_testData[20], false);FlatInt32integerArray2M.AssertModel(models[16],_testData[21], false);FlatInt32integerArray2M.AssertModel(models[17],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[18],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[19],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[20],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[21],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[22],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[23],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatInt32integerArray2M.AssertModel(models[0],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatInt32integerArray2M.AssertModel(models[0],_testData[13], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[14], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[15], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[16], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[17], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[18], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[19], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[20], false);FlatInt32integerArray2M.AssertModel(models[8],_testData[21], false);FlatInt32integerArray2M.AssertModel(models[9],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[10],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[11],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[12],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[13],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[14],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[15],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IInt32ListintegerArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Int32integerArray2M.AssertModel(models[0],_testData[6], false);Int32integerArray2M.AssertModel(models[1],_testData[7], false);Int32integerArray2M.AssertModel(models[2],_testData[8], false);Int32integerArray2M.AssertModel(models[3],_testData[9], false);Int32integerArray2M.AssertModel(models[4],_testData[10], false);Int32integerArray2M.AssertModel(models[5],_testData[11], false);Int32integerArray2M.AssertModel(models[6],_testData[12], false);Int32integerArray2M.AssertModel(models[7],_testData[13], false);Int32integerArray2M.AssertModel(models[8],_testData[14], false);Int32integerArray2M.AssertModel(models[9],_testData[15], false);Int32integerArray2M.AssertModel(models[10],_testData[16], false);Int32integerArray2M.AssertModel(models[11],_testData[17], false);Int32integerArray2M.AssertModel(models[12],_testData[18], false);Int32integerArray2M.AssertModel(models[13],_testData[19], false);Int32integerArray2M.AssertModel(models[14],_testData[20], false);Int32integerArray2M.AssertModel(models[15],_testData[21], false);Int32integerArray2M.AssertModel(models[16],_testData[22], false);Int32integerArray2M.AssertModel(models[17],_testData[23], false);Int32integerArray2M.AssertModel(models[18],_testData[24], false);Int32integerArray2M.AssertModel(models[19],_testData[25], false);Int32integerArray2M.AssertModel(models[20],_testData[26], false);Int32integerArray2M.AssertModel(models[21],_testData[27], false);Int32integerArray2M.AssertModel(models[22],_testData[28], false);Int32integerArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
Int32integerArray2M.AssertModel(models[0],_testData[4], false);Int32integerArray2M.AssertModel(models[1],_testData[5], false);Int32integerArray2M.AssertModel(models[2],_testData[6], false);Int32integerArray2M.AssertModel(models[3],_testData[7], false);Int32integerArray2M.AssertModel(models[4],_testData[8], false);Int32integerArray2M.AssertModel(models[5],_testData[9], false);Int32integerArray2M.AssertModel(models[6],_testData[10], false);Int32integerArray2M.AssertModel(models[7],_testData[11], false);Int32integerArray2M.AssertModel(models[8],_testData[12], false);Int32integerArray2M.AssertModel(models[9],_testData[13], false);Int32integerArray2M.AssertModel(models[10],_testData[14], false);Int32integerArray2M.AssertModel(models[11],_testData[15], false);Int32integerArray2M.AssertModel(models[12],_testData[16], false);Int32integerArray2M.AssertModel(models[13],_testData[17], false);Int32integerArray2M.AssertModel(models[14],_testData[18], false);Int32integerArray2M.AssertModel(models[15],_testData[19], false);Int32integerArray2M.AssertModel(models[16],_testData[20], false);Int32integerArray2M.AssertModel(models[17],_testData[21], false);Int32integerArray2M.AssertModel(models[18],_testData[22], false);Int32integerArray2M.AssertModel(models[19],_testData[23], false);Int32integerArray2M.AssertModel(models[20],_testData[24], false);Int32integerArray2M.AssertModel(models[21],_testData[25], false);Int32integerArray2M.AssertModel(models[22],_testData[26], false);Int32integerArray2M.AssertModel(models[23],_testData[27], false);Int32integerArray2M.AssertModel(models[24],_testData[28], false);Int32integerArray2M.AssertModel(models[25],_testData[29], false);
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

                var models =  ((IInt32ListintegerArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
Int32integerArray2M.AssertModel(models[0],_testData[21], false);Int32integerArray2M.AssertModel(models[1],_testData[22], false);Int32integerArray2M.AssertModel(models[2],_testData[23], false);Int32integerArray2M.AssertModel(models[3],_testData[24], false);Int32integerArray2M.AssertModel(models[4],_testData[25], false);Int32integerArray2M.AssertModel(models[5],_testData[26], false);Int32integerArray2M.AssertModel(models[6],_testData[27], false);Int32integerArray2M.AssertModel(models[7],_testData[28], false);Int32integerArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
Int32integerArray2M.AssertModel(models[0],_testData[18], false);Int32integerArray2M.AssertModel(models[1],_testData[19], false);Int32integerArray2M.AssertModel(models[2],_testData[20], false);Int32integerArray2M.AssertModel(models[3],_testData[21], false);Int32integerArray2M.AssertModel(models[4],_testData[22], false);Int32integerArray2M.AssertModel(models[5],_testData[23], false);Int32integerArray2M.AssertModel(models[6],_testData[24], false);Int32integerArray2M.AssertModel(models[7],_testData[25], false);Int32integerArray2M.AssertModel(models[8],_testData[26], false);Int32integerArray2M.AssertModel(models[9],_testData[27], false);Int32integerArray2M.AssertModel(models[10],_testData[28], false);Int32integerArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 124, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatInt32integerArray2M.AssertModel(models[0],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatInt32integerArray2M.AssertModel(models[0],_testData[21], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
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
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatInt32integerArray2M.AssertModel(models[0],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatInt32integerArray2M.AssertModel(models[0],_testData[18], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[19], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[20], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[21], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[8],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[9],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[10],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ListintegerArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSelectModelBatchAsync(connection, 14, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
Int32integerArray2M.AssertModel(models[0],_testData[5], false);Int32integerArray2M.AssertModel(models[1],_testData[6], false);Int32integerArray2M.AssertModel(models[2],_testData[7], false);Int32integerArray2M.AssertModel(models[3],_testData[8], false);Int32integerArray2M.AssertModel(models[4],_testData[9], false);Int32integerArray2M.AssertModel(models[5],_testData[10], false);Int32integerArray2M.AssertModel(models[6],_testData[11], false);Int32integerArray2M.AssertModel(models[7],_testData[12], false);Int32integerArray2M.AssertModel(models[8],_testData[13], false);Int32integerArray2M.AssertModel(models[9],_testData[14], false);Int32integerArray2M.AssertModel(models[10],_testData[15], false);Int32integerArray2M.AssertModel(models[11],_testData[16], false);Int32integerArray2M.AssertModel(models[12],_testData[17], false);Int32integerArray2M.AssertModel(models[13],_testData[18], false);Int32integerArray2M.AssertModel(models[14],_testData[19], false);Int32integerArray2M.AssertModel(models[15],_testData[20], false);Int32integerArray2M.AssertModel(models[16],_testData[21], false);Int32integerArray2M.AssertModel(models[17],_testData[22], false);Int32integerArray2M.AssertModel(models[18],_testData[23], false);Int32integerArray2M.AssertModel(models[19],_testData[24], false);Int32integerArray2M.AssertModel(models[20],_testData[25], false);Int32integerArray2M.AssertModel(models[21],_testData[26], false);Int32integerArray2M.AssertModel(models[22],_testData[27], false);Int32integerArray2M.AssertModel(models[23],_testData[28], false);Int32integerArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
Int32integerArray2M.AssertModel(models[0],_testData[3], false);Int32integerArray2M.AssertModel(models[1],_testData[4], false);Int32integerArray2M.AssertModel(models[2],_testData[5], false);Int32integerArray2M.AssertModel(models[3],_testData[6], false);Int32integerArray2M.AssertModel(models[4],_testData[7], false);Int32integerArray2M.AssertModel(models[5],_testData[8], false);Int32integerArray2M.AssertModel(models[6],_testData[9], false);Int32integerArray2M.AssertModel(models[7],_testData[10], false);Int32integerArray2M.AssertModel(models[8],_testData[11], false);Int32integerArray2M.AssertModel(models[9],_testData[12], false);Int32integerArray2M.AssertModel(models[10],_testData[13], false);Int32integerArray2M.AssertModel(models[11],_testData[14], false);Int32integerArray2M.AssertModel(models[12],_testData[15], false);Int32integerArray2M.AssertModel(models[13],_testData[16], false);Int32integerArray2M.AssertModel(models[14],_testData[17], false);Int32integerArray2M.AssertModel(models[15],_testData[18], false);Int32integerArray2M.AssertModel(models[16],_testData[19], false);Int32integerArray2M.AssertModel(models[17],_testData[20], false);Int32integerArray2M.AssertModel(models[18],_testData[21], false);Int32integerArray2M.AssertModel(models[19],_testData[22], false);Int32integerArray2M.AssertModel(models[20],_testData[23], false);Int32integerArray2M.AssertModel(models[21],_testData[24], false);Int32integerArray2M.AssertModel(models[22],_testData[25], false);Int32integerArray2M.AssertModel(models[23],_testData[26], false);Int32integerArray2M.AssertModel(models[24],_testData[27], false);Int32integerArray2M.AssertModel(models[25],_testData[28], false);Int32integerArray2M.AssertModel(models[26],_testData[29], false);
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
                var models =  ((IInt32ListintegerArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSelectModelBatch(connection, 83, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
Int32integerArray2M.AssertModel(models[0],_testData[20], false);Int32integerArray2M.AssertModel(models[1],_testData[21], false);Int32integerArray2M.AssertModel(models[2],_testData[22], false);Int32integerArray2M.AssertModel(models[3],_testData[23], false);Int32integerArray2M.AssertModel(models[4],_testData[24], false);Int32integerArray2M.AssertModel(models[5],_testData[25], false);Int32integerArray2M.AssertModel(models[6],_testData[26], false);Int32integerArray2M.AssertModel(models[7],_testData[27], false);Int32integerArray2M.AssertModel(models[8],_testData[28], false);Int32integerArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
Int32integerArray2M.AssertModel(models[0],_testData[17], false);Int32integerArray2M.AssertModel(models[1],_testData[18], false);Int32integerArray2M.AssertModel(models[2],_testData[19], false);Int32integerArray2M.AssertModel(models[3],_testData[20], false);Int32integerArray2M.AssertModel(models[4],_testData[21], false);Int32integerArray2M.AssertModel(models[5],_testData[22], false);Int32integerArray2M.AssertModel(models[6],_testData[23], false);Int32integerArray2M.AssertModel(models[7],_testData[24], false);Int32integerArray2M.AssertModel(models[8],_testData[25], false);Int32integerArray2M.AssertModel(models[9],_testData[26], false);Int32integerArray2M.AssertModel(models[10],_testData[27], false);Int32integerArray2M.AssertModel(models[11],_testData[28], false);Int32integerArray2M.AssertModel(models[12],_testData[29], false);
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
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Int32integerArray2M.AssertModel(models[0],_testData[3], false);Int32integerArray2M.AssertModel(models[1],_testData[4], false);Int32integerArray2M.AssertModel(models[2],_testData[5], false);Int32integerArray2M.AssertModel(models[3],_testData[6], false);Int32integerArray2M.AssertModel(models[4],_testData[7], false);Int32integerArray2M.AssertModel(models[5],_testData[8], false);Int32integerArray2M.AssertModel(models[6],_testData[9], false);Int32integerArray2M.AssertModel(models[7],_testData[10], false);Int32integerArray2M.AssertModel(models[8],_testData[11], false);Int32integerArray2M.AssertModel(models[9],_testData[12], false);Int32integerArray2M.AssertModel(models[10],_testData[13], false);Int32integerArray2M.AssertModel(models[11],_testData[14], false);Int32integerArray2M.AssertModel(models[12],_testData[15], false);Int32integerArray2M.AssertModel(models[13],_testData[16], false);Int32integerArray2M.AssertModel(models[14],_testData[17], false);Int32integerArray2M.AssertModel(models[15],_testData[18], false);Int32integerArray2M.AssertModel(models[16],_testData[19], false);Int32integerArray2M.AssertModel(models[17],_testData[20], false);Int32integerArray2M.AssertModel(models[18],_testData[21], false);Int32integerArray2M.AssertModel(models[19],_testData[22], false);Int32integerArray2M.AssertModel(models[20],_testData[23], false);Int32integerArray2M.AssertModel(models[21],_testData[24], false);Int32integerArray2M.AssertModel(models[22],_testData[25], false);Int32integerArray2M.AssertModel(models[23],_testData[26], false);Int32integerArray2M.AssertModel(models[24],_testData[27], false);Int32integerArray2M.AssertModel(models[25],_testData[28], false);Int32integerArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Int32integerArray2M.AssertModel(models[0],_testData[14], false);Int32integerArray2M.AssertModel(models[1],_testData[15], false);Int32integerArray2M.AssertModel(models[2],_testData[16], false);Int32integerArray2M.AssertModel(models[3],_testData[17], false);Int32integerArray2M.AssertModel(models[4],_testData[18], false);Int32integerArray2M.AssertModel(models[5],_testData[19], false);Int32integerArray2M.AssertModel(models[6],_testData[20], false);Int32integerArray2M.AssertModel(models[7],_testData[21], false);Int32integerArray2M.AssertModel(models[8],_testData[22], false);Int32integerArray2M.AssertModel(models[9],_testData[23], false);Int32integerArray2M.AssertModel(models[10],_testData[24], false);Int32integerArray2M.AssertModel(models[11],_testData[25], false);Int32integerArray2M.AssertModel(models[12],_testData[26], false);Int32integerArray2M.AssertModel(models[13],_testData[27], false);Int32integerArray2M.AssertModel(models[14],_testData[28], false);Int32integerArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(Int32integerArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integerArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt32ListintegerArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32ListintegerArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IInt32ListintegerArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt32ListintegerArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integerArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IInt32ListintegerArray)this).ImportModel(connection, importCollection);
                var models = ((IInt32ListintegerArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int32integerArray2M.AssertModel(models[0],_testData[0], false);
                Int32integerArray2M.AssertModel(models[1],_testData[1], false);
                Int32integerArray2M.AssertModel(models[2],_testData[2], false);
                Int32integerArray2M.AssertModel(models[3],_testData[3], false);
                Int32integerArray2M.AssertModel(models[4],_testData[4], false);
                Int32integerArray2M.AssertModel(models[5],_testData[5], false);
                Int32integerArray2M.AssertModel(models[6],_testData[6], false);
                Int32integerArray2M.AssertModel(models[7],_testData[7], false);
                Int32integerArray2M.AssertModel(models[8],_testData[8], false);
                Int32integerArray2M.AssertModel(models[9],_testData[9], false);
                Int32integerArray2M.AssertModel(models[10],_testData[10], false);
                Int32integerArray2M.AssertModel(models[11],_testData[11], false);
                Int32integerArray2M.AssertModel(models[12],_testData[12], false);
                Int32integerArray2M.AssertModel(models[13],_testData[13], false);
                Int32integerArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IInt32ListintegerArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt32ListintegerArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int32integerArray2M.AssertModel(models[0],_testData[0], false);
                Int32integerArray2M.AssertModel(models[1],_testData[1], false);
                Int32integerArray2M.AssertModel(models[2],_testData[2], false);
                Int32integerArray2M.AssertModel(models[3],_testData[3], false);
                Int32integerArray2M.AssertModel(models[4],_testData[4], false);
                Int32integerArray2M.AssertModel(models[5],_testData[5], false);
                Int32integerArray2M.AssertModel(models[6],_testData[6], false);
                Int32integerArray2M.AssertModel(models[7],_testData[7], false);
                Int32integerArray2M.AssertModel(models[8],_testData[8], false);
                Int32integerArray2M.AssertModel(models[9],_testData[9], false);
                Int32integerArray2M.AssertModel(models[10],_testData[10], false);
                Int32integerArray2M.AssertModel(models[11],_testData[11], false);
                Int32integerArray2M.AssertModel(models[12],_testData[12], false);
                Int32integerArray2M.AssertModel(models[13],_testData[13], false);
                Int32integerArray2M.AssertModel(models[14],_testData[14], false);
                Int32integerArray2M.AssertModel(models[15],_testData[15], false);
                Int32integerArray2M.AssertModel(models[16],_testData[16], false);
                Int32integerArray2M.AssertModel(models[17],_testData[17], false);
                Int32integerArray2M.AssertModel(models[18],_testData[18], false);
                Int32integerArray2M.AssertModel(models[19],_testData[19], false);
                Int32integerArray2M.AssertModel(models[20],_testData[20], false);
                Int32integerArray2M.AssertModel(models[21],_testData[21], false);
                Int32integerArray2M.AssertModel(models[22],_testData[22], false);
                Int32integerArray2M.AssertModel(models[23],_testData[23], false);
                Int32integerArray2M.AssertModel(models[24],_testData[24], false);
                Int32integerArray2M.AssertModel(models[25],_testData[25], false);
                Int32integerArray2M.AssertModel(models[26],_testData[26], false);
                Int32integerArray2M.AssertModel(models[27],_testData[27], false);
                Int32integerArray2M.AssertModel(models[28],_testData[28], false);
                Int32integerArray2M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_int32integerarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32ListintegerArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ListintegerArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


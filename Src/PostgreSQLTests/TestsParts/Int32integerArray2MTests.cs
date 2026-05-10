

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2026428563,

844260761,

153851328,

221343420,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1715980694,

2076422077,

546582717,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
314325758,

1675896683,

962687619,

296337381,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
781718898,

1655353480,

90077774,

1752874970,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
971044744,

730827075,

1218221286,

},
},
            new Int32integerArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1223762968,

178809222,

677686292,

17829885,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1466843565,

944804582,

1726510943,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1765330424,

1248885848,

962503927,

},
},
            new Int32integerArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1339265040,

2044303140,

1740114651,

1879437678,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
966206578,

2124248655,

296875054,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
460119949,

1225917851,

2003093711,

701847849,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
33427281,

658820705,

156012912,

455086579,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1530960349,

325231242,

545320021,

2059840346,

},
},
            new Int32integerArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
887495055,

1058792077,

1954660518,

2105161930,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1072691618,

1464292726,

320414822,

497676951,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1687084547,

353529405,

672621720,

364844638,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
573110700,

1979973193,

1336438680,

},
},
            new Int32integerArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1962575685,

33254021,

1712004800,

542035188,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1494679049,

1728269639,

628208594,

},
},
            new Int32integerArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1359280585,

1300738379,

407769354,

1183859283,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1303898401,

679127560,

37554739,

694422042,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1324715099,

1789312947,

287762923,

1547111188,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
646306377,

102892325,

1932295516,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
458861964,

39734557,

370585570,

1859397198,

},
},
            new Int32integerArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1724091025,

1999284594,

1880545714,

1015541653,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1486821562,

469836974,

281923541,

2093862794,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1511750377,

966545610,

1562144012,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
320208414,

1388183315,

940816364,

2095127091,

},
},
            new Int32integerArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
207392650,

627179038,

498328092,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
316972159,

1851336468,

1599027580,

1601288666,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1841057852,

1917265390,

1705566925,

68840784,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
473889028,

1680936763,

98120184,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1399573588,

1932029149,

1558710270,

2105517159,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1981469332,

2079210479,

1566253913,

1184368212,

},
},
            new Int32integerArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
856198390,

809081988,

555076529,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1028059727,

394767214,

1173686335,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
760609444,

436815269,

1687445371,

391714955,

},
},
            new Int32integerArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1353265663,

1618899729,

1442585766,

628695317,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1239543837,

1937073354,

154965233,

},
},
            new Int32integerArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
565893487,

2129244044,

1503475267,

1050368253,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
759413789,

812224872,

480790941,

1822361871,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1141325099,

1010606096,

597450613,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1629882972,

292927182,

583367190,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
794677648,

1283741172,

487259705,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
237993558,

889646324,

1990479606,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1932138601,

696944326,

1296485188,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
90911399,

220532609,

1606098617,

758101982,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1174300629,

1842074158,

1487679811,

1367878853,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1223051076,

762825392,

1318087382,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
753127146,

237377278,

1543461313,

},
},
            new Int32integerArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
367986270,

1065525626,

504227350,

2025205701,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
178542026,

2013231406,

1455273470,

1174565730,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
167933585,

1472331857,

905297682,

752588787,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
325699798,

467103248,

1793369171,

},
},
            new Int32integerArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2094384286,

1372218868,

219364193,

1140881770,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
957968568,

480897222,

398374916,

1511738528,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1729089119,

1123321954,

702792967,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1554385665,

767190809,

407944019,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
385545572,

1031693188,

838802912,

},
},
            new Int32integerArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1445612260,

1765889453,

1821023100,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1123530588,

752289929,

841027428,

},
},
            new Int32integerArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1532223809,

2093116328,

69208984,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
982848667,

2000778677,

1088669176,

1195747402,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
167255722,

753851127,

1511451659,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
325370034,

2021483468,

1770681694,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1544375520,

1971032975,

1740120564,

},
},
            new Int32integerArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
449567404,

1060951914,

384142318,

1376280599,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2068716073,

1147506671,

162648745,

1112166961,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
245804161,

640106060,

1787913837,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
700951986,

1559418913,

667035634,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1964490839,

900593442,

900260593,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1787425133,

656070045,

399905782,

},
},
            new Int32integerArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1685483990,

1807792527,

2008539223,

994262648,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
487981159,

8562712,

685248300,

2129671218,

},
},
            new Int32integerArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
894453170,

1458097791,

887838082,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
150838514,

514052230,

796100711,

1699644741,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1497478171,

2012880383,

293718531,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
118213962,

1758062939,

1943493180,

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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[33],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[23],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[24],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[25],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[26],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[27],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[28],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[29],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[30],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 93;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[34], false);
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
                parametr2.Value = 87;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int32integerArray2M.AssertModel(models[0],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[15],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int32integerArray2M.AssertModel(models[0],_testData[7], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[8], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[9], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[10], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[11], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[12], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[13], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[14], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[15], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[15],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[16],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[17],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[18],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[19],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[20],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[21],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[22],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[23],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[24],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[25],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[26],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32integerArray2M.AssertModel(models[0],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 87, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                await ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 28, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[28],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 6, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 134, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 145, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 8, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[23],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[24],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[25],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[26],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[27],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[28],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[29],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[30],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[31],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[23],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[24],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[25],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[26],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[27],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(models[28],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(models[29],_testData[31], false);
                        FlatInt32integerArray2M.AssertModel(models[30],_testData[32], false);
                        FlatInt32integerArray2M.AssertModel(models[31],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(models[32],_testData[34], false);
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
                 ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 158, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 155, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32integerArray2M.AssertModel(models[0],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatch(connection, 38, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int32integerArray2M.AssertModel(models[0],_testData[9], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[10], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[11], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[12], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[13], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[14], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[15], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[15],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[16],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[17],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[18],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[19],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[20],_testData[29], false);
                        Int32integerArray2M.AssertModel(models[21],_testData[30], false);
                        Int32integerArray2M.AssertModel(models[22],_testData[31], false);
                        Int32integerArray2M.AssertModel(models[23],_testData[32], false);
                        Int32integerArray2M.AssertModel(models[24],_testData[33], false);
                        Int32integerArray2M.AssertModel(models[25],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                Int32integerArray2M.AssertModel(models[0],_testData[9], false);
                Int32integerArray2M.AssertModel(models[1],_testData[10], false);
                Int32integerArray2M.AssertModel(models[2],_testData[11], false);
                Int32integerArray2M.AssertModel(models[3],_testData[12], false);
                Int32integerArray2M.AssertModel(models[4],_testData[13], false);
                Int32integerArray2M.AssertModel(models[5],_testData[14], false);
                Int32integerArray2M.AssertModel(models[6],_testData[15], false);
                Int32integerArray2M.AssertModel(models[7],_testData[16], false);
                Int32integerArray2M.AssertModel(models[8],_testData[17], false);
                Int32integerArray2M.AssertModel(models[9],_testData[18], false);
                Int32integerArray2M.AssertModel(models[10],_testData[19], false);
                Int32integerArray2M.AssertModel(models[11],_testData[20], false);
                Int32integerArray2M.AssertModel(models[12],_testData[21], false);
                Int32integerArray2M.AssertModel(models[13],_testData[22], false);
                Int32integerArray2M.AssertModel(models[14],_testData[23], false);
                Int32integerArray2M.AssertModel(models[15],_testData[24], false);
                Int32integerArray2M.AssertModel(models[16],_testData[25], false);
                Int32integerArray2M.AssertModel(models[17],_testData[26], false);
                Int32integerArray2M.AssertModel(models[18],_testData[27], false);
                Int32integerArray2M.AssertModel(models[19],_testData[28], false);
                Int32integerArray2M.AssertModel(models[20],_testData[29], false);
                Int32integerArray2M.AssertModel(models[21],_testData[30], false);
                Int32integerArray2M.AssertModel(models[22],_testData[31], false);
                Int32integerArray2M.AssertModel(models[23],_testData[32], false);
                Int32integerArray2M.AssertModel(models[24],_testData[33], false);
                Int32integerArray2M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                Int32integerArray2M.AssertModel(models[0],_testData[13], false);
                Int32integerArray2M.AssertModel(models[1],_testData[14], false);
                Int32integerArray2M.AssertModel(models[2],_testData[15], false);
                Int32integerArray2M.AssertModel(models[3],_testData[16], false);
                Int32integerArray2M.AssertModel(models[4],_testData[17], false);
                Int32integerArray2M.AssertModel(models[5],_testData[18], false);
                Int32integerArray2M.AssertModel(models[6],_testData[19], false);
                Int32integerArray2M.AssertModel(models[7],_testData[20], false);
                Int32integerArray2M.AssertModel(models[8],_testData[21], false);
                Int32integerArray2M.AssertModel(models[9],_testData[22], false);
                Int32integerArray2M.AssertModel(models[10],_testData[23], false);
                Int32integerArray2M.AssertModel(models[11],_testData[24], false);
                Int32integerArray2M.AssertModel(models[12],_testData[25], false);
                Int32integerArray2M.AssertModel(models[13],_testData[26], false);
                Int32integerArray2M.AssertModel(models[14],_testData[27], false);
                Int32integerArray2M.AssertModel(models[15],_testData[28], false);
                Int32integerArray2M.AssertModel(models[16],_testData[29], false);
                Int32integerArray2M.AssertModel(models[17],_testData[30], false);
                Int32integerArray2M.AssertModel(models[18],_testData[31], false);
                Int32integerArray2M.AssertModel(models[19],_testData[32], false);
                Int32integerArray2M.AssertModel(models[20],_testData[33], false);
                Int32integerArray2M.AssertModel(models[21],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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


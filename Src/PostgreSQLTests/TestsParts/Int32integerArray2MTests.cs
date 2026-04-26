

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
2102876877,

1679010693,

1321652680,

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
514966055,

2066905144,

1467946957,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1970856781,

653538748,

1761445583,

139254950,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1102172039,

1200106913,

1089188275,

},
},
            new Int32integerArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
842316789,

396633571,

293612362,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1291577065,

1826640817,

571959438,

133960930,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
399699420,

95382231,

1221008316,

732188297,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
930187178,

1824197320,

996081805,

},
},
            new Int32integerArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
859560355,

1759058970,

2002187860,

1153476383,

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
2019876485,

231436498,

1144803817,

1561434335,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2043792899,

50479301,

1879065383,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
704449771,

124452595,

999628845,

},
},
            new Int32integerArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
818790226,

626640669,

1499175538,

1458087456,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1264798416,

1040564854,

1725489070,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2114967804,

674185394,

69630282,

1948279075,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
892667606,

1262387221,

534508444,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
835988942,

623992547,

133871376,

1603869320,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
688061027,

412034900,

2013988276,

1114728013,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
927893704,

393645906,

884070097,

1889530588,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
107955464,

1679007413,

1951466691,

2109290331,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1484273272,

274260798,

1644435394,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
2008412919,

1376935578,

1732525017,

},
},
            new Int32integerArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1338053667,

2074452088,

330826415,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
919961745,

1318854387,

427919272,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1827685896,

2027072723,

1316578637,

1556976311,

},
},
            new Int32integerArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
162897836,

390149754,

795887672,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
457379230,

1077713488,

123983990,

},
},
            new Int32integerArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
5535269,

730992122,

1722843106,

1205525750,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
85154355,

371712659,

1070534888,

534546456,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1833114137,

554844418,

286074986,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1705987455,

1191661276,

1553551015,

},
},
            new Int32integerArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2073210729,

940879666,

2097961857,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2046455050,

802522466,

1545674465,

1625101287,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1643517950,

1161265889,

1372560102,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
723911793,

729113955,

1745386782,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
20310093,

1778475342,

90716902,

},
},
            new Int32integerArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1068088758,

290109862,

2103971965,

248190201,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1387351573,

1138855262,

1463288051,

347702839,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
55112739,

1705888126,

1917480373,

91747323,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
187683550,

1225592864,

744087037,

1586733731,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
227355565,

1266469938,

181022035,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1387149756,

411814666,

1523413219,

932002170,

},
},
            new Int32integerArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
271043608,

1555925012,

1449688877,

1150260082,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
13570483,

1584947208,

1928896545,

1653644741,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
87240006,

2008789111,

1513224137,

147833657,

},
},
            new Int32integerArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
218361850,

1776133544,

1530653172,

1651559509,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
497386105,

1740421158,

212920414,

170108557,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1291255593,

844192844,

1132891534,

730901321,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
325019490,

344896486,

714094356,

},
},
            new Int32integerArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
960456640,

1550710625,

726946226,

697952625,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
228774773,

399688028,

1108253007,

1639118847,

},
},
            new Int32integerArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1656659118,

1154785538,

1610911958,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
302043239,

1408545965,

981769194,

58155668,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1797738552,

868875902,

15275964,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
67120269,

2096103960,

1422932917,

1472208890,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
845205154,

253821520,

1253117952,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1346262748,

59885714,

262260212,

1599903958,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1221913900,

697756463,

1067785046,

1651840882,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
169121088,

10732977,

1947604442,

},
},
            new Int32integerArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
221614064,

1823475333,

367357365,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1257593884,

767959227,

1695127664,

},
},
            new Int32integerArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1694220679,

969256415,

353768439,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1192187391,

1161912378,

84722237,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1602139098,

875608584,

1190522818,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1024328410,

1040339983,

585602724,

},
},
            new Int32integerArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2012160667,

453947284,

878940977,

662801936,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
814377157,

1661714162,

1366932960,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
420576943,

137073076,

219840599,

1962683030,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1795694835,

792506830,

1253621601,

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32ListintegerArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((IInt32ListintegerArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32ListintegerArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((IInt32ListintegerArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int32integerArray2M.AssertModel(models[0],_testData[15], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int32integerArray2M.AssertModel(models[0],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32integerArray2M.AssertModel(models[0],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                await ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 33, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                 ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[27],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 88, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[25],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 28, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 96, 115))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32integerArray2M.AssertModel(models[0],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32integerArray2M.AssertModel(models[0],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatch(connection, 132, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32integerArray2M.AssertModel(models[0],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

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
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models = await ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
Int32integerArray2M.AssertModel(models[0],_testData[23], false);Int32integerArray2M.AssertModel(models[1],_testData[24], false);Int32integerArray2M.AssertModel(models[2],_testData[25], false);Int32integerArray2M.AssertModel(models[3],_testData[26], false);Int32integerArray2M.AssertModel(models[4],_testData[27], false);Int32integerArray2M.AssertModel(models[5],_testData[28], false);Int32integerArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Int32integerArray2M.AssertModel(models[0],_testData[3], false);Int32integerArray2M.AssertModel(models[1],_testData[4], false);Int32integerArray2M.AssertModel(models[2],_testData[5], false);Int32integerArray2M.AssertModel(models[3],_testData[6], false);Int32integerArray2M.AssertModel(models[4],_testData[7], false);Int32integerArray2M.AssertModel(models[5],_testData[8], false);Int32integerArray2M.AssertModel(models[6],_testData[9], false);Int32integerArray2M.AssertModel(models[7],_testData[10], false);Int32integerArray2M.AssertModel(models[8],_testData[11], false);Int32integerArray2M.AssertModel(models[9],_testData[12], false);Int32integerArray2M.AssertModel(models[10],_testData[13], false);Int32integerArray2M.AssertModel(models[11],_testData[14], false);Int32integerArray2M.AssertModel(models[12],_testData[15], false);Int32integerArray2M.AssertModel(models[13],_testData[16], false);Int32integerArray2M.AssertModel(models[14],_testData[17], false);Int32integerArray2M.AssertModel(models[15],_testData[18], false);Int32integerArray2M.AssertModel(models[16],_testData[19], false);Int32integerArray2M.AssertModel(models[17],_testData[20], false);Int32integerArray2M.AssertModel(models[18],_testData[21], false);Int32integerArray2M.AssertModel(models[19],_testData[22], false);Int32integerArray2M.AssertModel(models[20],_testData[23], false);Int32integerArray2M.AssertModel(models[21],_testData[24], false);Int32integerArray2M.AssertModel(models[22],_testData[25], false);Int32integerArray2M.AssertModel(models[23],_testData[26], false);Int32integerArray2M.AssertModel(models[24],_testData[27], false);Int32integerArray2M.AssertModel(models[25],_testData[28], false);Int32integerArray2M.AssertModel(models[26],_testData[29], false);
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


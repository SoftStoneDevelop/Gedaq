

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1248566234,

950915893,

1498931050,

1165442088,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1954014904,

1352677684,

1679772278,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1082673810,

710411909,

61251534,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
75060693,

383252599,

99276456,

1957748047,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1294867719,

2102391409,

580903849,

978045809,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1488320068,

718985125,

972927205,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
678435600,

1818765518,

1317024978,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
326745341,

1885268898,

1946665176,

1220817271,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
2018584018,

1212607263,

581692377,

},
},
            new Int32integerListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1270603053,

1890117937,

578981370,

561955789,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1208948315,

312422242,

1438633374,

1768360555,

},
},
            new Int32integerListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1469192737,

2020787743,

1397234247,

436419635,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1383615317,

1022654627,

67460421,

428818755,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1347298963,

1711494125,

1534262805,

633701364,

},
},
            new Int32integerListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
373643708,

2046546459,

1854959265,

385151024,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1919996866,

381400706,

1700987970,

},
},
            new Int32integerListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1667676275,

636990288,

251155047,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2052867155,

1488400260,

1211677336,

889494515,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1402317563,

24772819,

909845351,

816343664,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1239734005,

1911707235,

1004438222,

1145521546,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1137939391,

2012268824,

1839251270,

1215490899,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
41294881,

948687865,

1197868933,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2074726059,

1219589722,

1919554342,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1985364460,

1740177561,

1767325639,

1557031806,

},
},
            new Int32integerListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1249074866,

923290430,

349497602,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
716677608,

9587664,

1577430472,

725408674,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1853589430,

64640324,

1388532946,

},
},
            new Int32integerListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
730117774,

943974998,

1896075325,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
141272853,

255143463,

1379804977,

},
},
            new Int32integerListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
598062101,

1900665362,

2119286764,

1894553149,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
61522128,

606409602,

525061483,

2078628623,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
354589632,

1763264895,

1429853335,

216741282,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1207153936,

681072646,

1192411781,

527865785,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
232224479,

1705612617,

1216283481,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
50463728,

147897007,

1318353583,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
156986978,

1005940721,

2123130572,

1908290654,

},
},
            new Int32integerListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1891614822,

1838127392,

498342493,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
363033767,

2033762810,

2126415864,

1202011885,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
924266269,

1996943303,

29021693,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1686140615,

1351919031,

2069920304,

1693136236,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
974360265,

1535887303,

977461523,

1370406433,

},
},
            new Int32integerListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1566003330,

1238846531,

2084336508,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
258483339,

926518992,

1017893409,

},
},
            new Int32integerListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
654040675,

184807433,

1022780792,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
166170674,

1371787782,

1224774675,

1155251279,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
441163182,

772819498,

803930438,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
531101371,

1131422435,

939866767,

1453902119,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
408960228,

847387524,

1825602209,

1116117821,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
524859536,

1502324303,

632723202,

88229708,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
986549104,

847118597,

727430551,

},
},
            new Int32integerListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
236478594,

557463224,

884218475,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
125804795,

1737281218,

975773789,

1569388288,

},
},
            new Int32integerListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2017292977,

2018940046,

1906941591,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1086767293,

1064207636,

1711943234,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
2045355690,

864162373,

685793957,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1081884718,

1587427698,

1471621365,

411956137,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1153851708,

2110346640,

1973300026,

1956512656,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2063961048,

1243316373,

188078038,

671699130,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
594763753,

281971171,

1348076311,

378285664,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
2036486969,

1379365937,

907472167,

1484005196,

},
},
            new Int32integerListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1467075264,

468442840,

1383965182,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1559019094,

1275749456,

1638506851,

2112768678,

},
},
            new Int32integerListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2042566496,

1153986717,

1802662798,

1562508235,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
198199724,

1102559075,

1099048241,

1589806329,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
696258350,

149542941,

16386301,

1842837915,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1775049898,

621222506,

574619219,

},
},
            new Int32integerListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
81029258,

1163879886,

860245951,

47450981,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1414905587,

1133606076,

1928849511,

182123809,

},
},
            new Int32integerListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1880480854,

499022953,

611532197,

1729715304,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
228069728,

81750577,

938739086,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1313230667,

613643904,

2031356829,

102309594,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1960082678,

1477006247,

630962344,

},
},
            new Int32integerListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1364947594,

1996515004,

73084540,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
358849671,

433434808,

1304246018,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2013563005,

296976164,

1865166654,

64200550,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1877662118,

409070240,

577467319,

1905244978,

},
    ModelInner = new Int32integerListD1E2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1620197493,

1433855219,

636341788,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1982988222,

1253511205,

1567185173,

1783606077,

},
},
    NullableValue = null,
},
            new Int32integerListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1734866439,

1577906274,

121180295,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerlistd1e2mi(
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
INSERT INTO public.int32integerlistd1e2mi(
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
            queryMapTypes: [typeof(Int32integerListD1E2MI)],
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
    int32integerlistd1e2mi_id
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
                methodParametrName: "int32integerlistd1e2mi_id", 
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
    int32integerlistd1e2mi_id
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
    int32integerlistd1e2mi_id,
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
    int32integerlistd1e2mi_id
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
    int32integerlistd1e2mi_id,
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
                methodParametrName: "int32integerlistd1e2mi_id", 
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
LEFT JOIN public.int32integerlistd1e2mi mi ON mi.id = m.int32integerlistd1e2mi_id
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
LEFT JOIN public.int32integerlistd1e2mi mi ON mi.id = m.int32integerlistd1e2mi_id
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
                parametr1.Value = 111;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 25;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
LEFT JOIN public.int32integerlistd1e2mi mi ON mi.id = m.int32integerlistd1e2mi_id
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[9], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[10], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[11], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[12], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[13], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[14], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[15], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[16], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[18],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[19],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[20],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[21],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[22],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[23],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[24],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[25],_testData[34], false);
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
                await ((IInt32ListintegerListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
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
                await ((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
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
                 ((IInt32ListintegerListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
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
                 ((IInt32ListintegerListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32ListintegerListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 34, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[22],_testData[34], false);
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
                await ((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 25, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32ListintegerListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32integerListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(models[20],_testData[34], false);
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
                 ((IInt32ListintegerListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt32integerListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
LEFT JOIN public.int32integerlistd1e2mi mi ON mi.id = m.int32integerlistd1e2mi_id
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
                foreach(var batchResult in await ((IInt32ListintegerListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 60, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[11], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[12], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[13], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[14], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[15], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[16], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[18],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[19],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[20],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[21],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[22],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32ListintegerListD1)this).DbConnectionSTSelectModelBatch(connection, 169, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int32integerListD1E2M.AssertModel(models[0],_testData[1], false);
                        Int32integerListD1E2M.AssertModel(models[1],_testData[2], false);
                        Int32integerListD1E2M.AssertModel(models[2],_testData[3], false);
                        Int32integerListD1E2M.AssertModel(models[3],_testData[4], false);
                        Int32integerListD1E2M.AssertModel(models[4],_testData[5], false);
                        Int32integerListD1E2M.AssertModel(models[5],_testData[6], false);
                        Int32integerListD1E2M.AssertModel(models[6],_testData[7], false);
                        Int32integerListD1E2M.AssertModel(models[7],_testData[8], false);
                        Int32integerListD1E2M.AssertModel(models[8],_testData[9], false);
                        Int32integerListD1E2M.AssertModel(models[9],_testData[10], false);
                        Int32integerListD1E2M.AssertModel(models[10],_testData[11], false);
                        Int32integerListD1E2M.AssertModel(models[11],_testData[12], false);
                        Int32integerListD1E2M.AssertModel(models[12],_testData[13], false);
                        Int32integerListD1E2M.AssertModel(models[13],_testData[14], false);
                        Int32integerListD1E2M.AssertModel(models[14],_testData[15], false);
                        Int32integerListD1E2M.AssertModel(models[15],_testData[16], false);
                        Int32integerListD1E2M.AssertModel(models[16],_testData[17], false);
                        Int32integerListD1E2M.AssertModel(models[17],_testData[18], false);
                        Int32integerListD1E2M.AssertModel(models[18],_testData[19], false);
                        Int32integerListD1E2M.AssertModel(models[19],_testData[20], false);
                        Int32integerListD1E2M.AssertModel(models[20],_testData[21], false);
                        Int32integerListD1E2M.AssertModel(models[21],_testData[22], false);
                        Int32integerListD1E2M.AssertModel(models[22],_testData[23], false);
                        Int32integerListD1E2M.AssertModel(models[23],_testData[24], false);
                        Int32integerListD1E2M.AssertModel(models[24],_testData[25], false);
                        Int32integerListD1E2M.AssertModel(models[25],_testData[26], false);
                        Int32integerListD1E2M.AssertModel(models[26],_testData[27], false);
                        Int32integerListD1E2M.AssertModel(models[27],_testData[28], false);
                        Int32integerListD1E2M.AssertModel(models[28],_testData[29], false);
                        Int32integerListD1E2M.AssertModel(models[29],_testData[30], false);
                        Int32integerListD1E2M.AssertModel(models[30],_testData[31], false);
                        Int32integerListD1E2M.AssertModel(models[31],_testData[32], false);
                        Int32integerListD1E2M.AssertModel(models[32],_testData[33], false);
                        Int32integerListD1E2M.AssertModel(models[33],_testData[34], false);
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
                ((IInt32ListintegerListD1)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models = await ((IInt32ListintegerListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Int32integerListD1E2M.AssertModel(models[0],_testData[26], false);
                Int32integerListD1E2M.AssertModel(models[1],_testData[27], false);
                Int32integerListD1E2M.AssertModel(models[2],_testData[28], false);
                Int32integerListD1E2M.AssertModel(models[3],_testData[29], false);
                Int32integerListD1E2M.AssertModel(models[4],_testData[30], false);
                Int32integerListD1E2M.AssertModel(models[5],_testData[31], false);
                Int32integerListD1E2M.AssertModel(models[6],_testData[32], false);
                Int32integerListD1E2M.AssertModel(models[7],_testData[33], false);
                Int32integerListD1E2M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerListD1)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models =  ((IInt32ListintegerListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                Int32integerListD1E2M.AssertModel(models[0],_testData[31], false);
                Int32integerListD1E2M.AssertModel(models[1],_testData[32], false);
                Int32integerListD1E2M.AssertModel(models[2],_testData[33], false);
                Int32integerListD1E2M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_int32integerlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MIWA)],
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
            queryMapType: typeof(Int32integerListD1E2MIWA),
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
                var importCollection = new List<Int32integerListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ListintegerListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerlistd1e2mi
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
                    Int32integerListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ListintegerListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerlistd1e2mi
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
                    Int32integerListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MIWA)],
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
            queryMapType: typeof(Int32integerListD1E2MIWA),
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
                var importCollection = new List<Int32integerListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ListintegerListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerlistd1e2mi
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
                    Int32integerListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ListintegerListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerlistd1e2mi
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
                    Int32integerListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MI)],
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
COPY public.binary_int32integerlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integerListD1E2MI),
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
                var importCollection = new List<Int32integerListD1E2MI>(2);
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
                    Int32integerListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD1E2MI>(2);
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
                    Int32integerListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MIWA)],
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
COPY public.binary_int32integerlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerListD1E2MIWA),
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
                var importCollection = new List<Int32integerListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD1E2MIWA
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
                    Int32integerListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerListD1E2MIWA
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
                    Int32integerListD1E2MIWA.AssertModel(actual, expect, false);
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
int32integerlistd1e2mi_id,
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
LEFT JOIN public.binary_int32integerlistd1e2mi mi ON mi.id = m.int32integerlistd1e2mi_id
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
    int32integerlistd1e2mi_id,
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
            queryMapTypes: [typeof(Int32integerListD1E2MIWA), typeof(Int32integerListD1E2MIWA)],
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
                var models1 = new List<Int32integerListD1E2MIWA>();
                var models2 = new List<Int32integerListD1E2MIWA>();
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
    FROM public.binary_int32integerlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerListD1E2MIWA>();
                var models2 = new List<Int32integerListD1E2MIWA>();
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
    FROM public.binary_int32integerlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MIWA)],
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
COPY public.binary_int32integerlistd1e2mi
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
                    Int32integerListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_int32integerlistd1e2mi
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
                    Int32integerListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MIWA), typeof(Int32integerListD1E2MIWA)],
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
                var models1 = new List<Int32integerListD1E2MIWA>();
                var models2 = new List<Int32integerListD1E2MIWA>();
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
    FROM public.binary_int32integerlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerListD1E2MIWA>();
                var models2 = new List<Int32integerListD1E2MIWA>();
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
    FROM public.binary_int32integerlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MIWA)],
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
COPY public.binary_int32integerlistd1e2mi
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
                    Int32integerListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_int32integerlistd1e2mi
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
                    Int32integerListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integerlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MI), typeof(Int32integerListD1E2MI)],
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
                var models1 = new List<Int32integerListD1E2MI>();
                var models2 = new List<Int32integerListD1E2MI>();
                await ((IInt32ListintegerListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerListD1E2MI>();
                var models2 = new List<Int32integerListD1E2MI>();
                ((IInt32ListintegerListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MI)],
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
                    Int32integerListD1E2MI.AssertModel(model, expectedModel, false);
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
                    Int32integerListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integerlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MIWA), typeof(Int32integerListD1E2MIWA)],
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
                var models1 = new List<Int32integerListD1E2MIWA>();
                var models2 = new List<Int32integerListD1E2MIWA>();
                await ((IInt32ListintegerListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerListD1E2MIWA>();
                var models2 = new List<Int32integerListD1E2MIWA>();
                ((IInt32ListintegerListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerListD1E2MIWA)],
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
                    Int32integerListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                    Int32integerListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


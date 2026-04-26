

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1649528167,

1547408704,

437670281,

1842665982,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1592054098,

1035788732,

536568315,

},
},
            new Int32integerArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
392790332,

1245545308,

1232999640,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2010722947,

1948847773,

1712306807,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1067588481,

960021915,

2142976493,

582593771,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
367080543,

1759873313,

564147761,

878102154,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1229239980,

16182000,

654487699,

834891934,

},
},
            new Int32integerArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1389567956,

998358675,

1443897728,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
575886210,

1352088847,

1032745136,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1214329847,

1608460898,

996681254,

680466444,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1795066902,

2101086365,

911919816,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1420036294,

567162018,

884289840,

1637062816,

},
},
            new Int32integerArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1300634493,

1234201401,

1949020799,

604697902,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1197125100,

1467729095,

662540362,

1849504160,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1575576865,

2053661764,

186630729,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
61408806,

118264865,

124387365,

},
},
            new Int32integerArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1961860939,

1336039872,

1526453632,

619255951,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1896972716,

1487330186,

1649449938,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1982555314,

607144488,

214613011,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2010006614,

726186395,

216246655,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
285732682,

1158421125,

1632279395,

},
},
            new Int32integerArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
254087004,

399802534,

1834111731,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
20262373,

1471522911,

1299443758,

486038799,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
844070724,

1509695053,

275151714,

1245794002,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
868110305,

988824732,

1491658515,

53375489,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1418504289,

915959356,

1291745352,

1257442791,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
407401107,

1107383650,

1337143043,

799165934,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1190593863,

2117686785,

219482570,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1681120434,

124888074,

1969395614,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1466346673,

914644903,

1045910765,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1991240681,

848638435,

563622140,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1825604318,

647151327,

1422389932,

1241746340,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1321327239,

12621279,

1288047093,

1571587735,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
167959215,

1006895547,

160630396,

1362557302,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
736699095,

118881079,

1470072948,

10971134,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
479702497,

48430861,

558814873,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1438195279,

2076541366,

853712129,

2057138384,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
380012079,

1629513328,

1309188464,

465496178,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1861033484,

981009812,

1948243680,

},
},
            new Int32integerArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
439204256,

1474863575,

631206698,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1389903928,

1929322655,

238564303,

465937905,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2034324659,

1626786096,

1099597509,

382014886,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1490646518,

1592362914,

260338313,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1275603995,

132139507,

1866670359,

121636713,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
2069466924,

1436069200,

1990220296,

815541594,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1323086697,

934942566,

1112082604,

1289410777,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1506931748,

1274305493,

1997596166,

903580256,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1735856897,

1070904283,

1770673096,

526472911,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
800518311,

1974241314,

816280780,

1958377365,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
419706049,

261438517,

618102395,

578964242,

},
},
            new Int32integerArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1217824748,

639579087,

881375697,

724384367,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
471004076,

1939518339,

2018639338,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
315898741,

1509774183,

1671997324,

956796820,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
184830189,

429122395,

1121286355,

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
1110060799,

109746891,

976905181,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
757723920,

1781492848,

329101671,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1054578237,

27986195,

197579443,

329412557,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1870049288,

502383370,

1344120156,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1074389214,

1816213057,

2136544130,

959635357,

},
},
            new Int32integerArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1640036790,

668708106,

1191212391,

676438286,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
236361945,

102391663,

85319586,

268999467,

},
},
            new Int32integerArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1194771011,

1100474211,

214746844,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1223790128,

1245127489,

800109116,

1782064338,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1494852376,

985996673,

1926494677,

765817108,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
797235559,

810803454,

1213992798,

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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                        Assert.That(models, Has.Count.EqualTo(25));
FlatInt32integerArray2M.AssertModel(models[0],_testData[5], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[6], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[7], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[8], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[9], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[10], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[11], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[12], false);FlatInt32integerArray2M.AssertModel(models[8],_testData[13], false);FlatInt32integerArray2M.AssertModel(models[9],_testData[14], false);FlatInt32integerArray2M.AssertModel(models[10],_testData[15], false);FlatInt32integerArray2M.AssertModel(models[11],_testData[16], false);FlatInt32integerArray2M.AssertModel(models[12],_testData[17], false);FlatInt32integerArray2M.AssertModel(models[13],_testData[18], false);FlatInt32integerArray2M.AssertModel(models[14],_testData[19], false);FlatInt32integerArray2M.AssertModel(models[15],_testData[20], false);FlatInt32integerArray2M.AssertModel(models[16],_testData[21], false);FlatInt32integerArray2M.AssertModel(models[17],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[18],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[19],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[20],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[21],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[22],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[23],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatInt32integerArray2M.AssertModel(models[0],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                        Assert.That(models, Has.Count.EqualTo(8));
FlatInt32integerArray2M.AssertModel(models[0],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatInt32integerArray2M.AssertModel(models[0],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Int32integerArray2M.AssertModel(models[0],_testData[7], false);Int32integerArray2M.AssertModel(models[1],_testData[8], false);Int32integerArray2M.AssertModel(models[2],_testData[9], false);Int32integerArray2M.AssertModel(models[3],_testData[10], false);Int32integerArray2M.AssertModel(models[4],_testData[11], false);Int32integerArray2M.AssertModel(models[5],_testData[12], false);Int32integerArray2M.AssertModel(models[6],_testData[13], false);Int32integerArray2M.AssertModel(models[7],_testData[14], false);Int32integerArray2M.AssertModel(models[8],_testData[15], false);Int32integerArray2M.AssertModel(models[9],_testData[16], false);Int32integerArray2M.AssertModel(models[10],_testData[17], false);Int32integerArray2M.AssertModel(models[11],_testData[18], false);Int32integerArray2M.AssertModel(models[12],_testData[19], false);Int32integerArray2M.AssertModel(models[13],_testData[20], false);Int32integerArray2M.AssertModel(models[14],_testData[21], false);Int32integerArray2M.AssertModel(models[15],_testData[22], false);Int32integerArray2M.AssertModel(models[16],_testData[23], false);Int32integerArray2M.AssertModel(models[17],_testData[24], false);Int32integerArray2M.AssertModel(models[18],_testData[25], false);Int32integerArray2M.AssertModel(models[19],_testData[26], false);Int32integerArray2M.AssertModel(models[20],_testData[27], false);Int32integerArray2M.AssertModel(models[21],_testData[28], false);Int32integerArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Int32integerArray2M.AssertModel(models[0],_testData[22], false);Int32integerArray2M.AssertModel(models[1],_testData[23], false);Int32integerArray2M.AssertModel(models[2],_testData[24], false);Int32integerArray2M.AssertModel(models[3],_testData[25], false);Int32integerArray2M.AssertModel(models[4],_testData[26], false);Int32integerArray2M.AssertModel(models[5],_testData[27], false);Int32integerArray2M.AssertModel(models[6],_testData[28], false);Int32integerArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
Int32integerArray2M.AssertModel(models[0],_testData[3], false);Int32integerArray2M.AssertModel(models[1],_testData[4], false);Int32integerArray2M.AssertModel(models[2],_testData[5], false);Int32integerArray2M.AssertModel(models[3],_testData[6], false);Int32integerArray2M.AssertModel(models[4],_testData[7], false);Int32integerArray2M.AssertModel(models[5],_testData[8], false);Int32integerArray2M.AssertModel(models[6],_testData[9], false);Int32integerArray2M.AssertModel(models[7],_testData[10], false);Int32integerArray2M.AssertModel(models[8],_testData[11], false);Int32integerArray2M.AssertModel(models[9],_testData[12], false);Int32integerArray2M.AssertModel(models[10],_testData[13], false);Int32integerArray2M.AssertModel(models[11],_testData[14], false);Int32integerArray2M.AssertModel(models[12],_testData[15], false);Int32integerArray2M.AssertModel(models[13],_testData[16], false);Int32integerArray2M.AssertModel(models[14],_testData[17], false);Int32integerArray2M.AssertModel(models[15],_testData[18], false);Int32integerArray2M.AssertModel(models[16],_testData[19], false);Int32integerArray2M.AssertModel(models[17],_testData[20], false);Int32integerArray2M.AssertModel(models[18],_testData[21], false);Int32integerArray2M.AssertModel(models[19],_testData[22], false);Int32integerArray2M.AssertModel(models[20],_testData[23], false);Int32integerArray2M.AssertModel(models[21],_testData[24], false);Int32integerArray2M.AssertModel(models[22],_testData[25], false);Int32integerArray2M.AssertModel(models[23],_testData[26], false);Int32integerArray2M.AssertModel(models[24],_testData[27], false);Int32integerArray2M.AssertModel(models[25],_testData[28], false);Int32integerArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
Int32integerArray2M.AssertModel(models[0],_testData[28], false);Int32integerArray2M.AssertModel(models[1],_testData[29], false);
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 73, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatInt32integerArray2M.AssertModel(models[0],_testData[12], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[13], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[14], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[15], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[16], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[17], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[18], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[19], false);FlatInt32integerArray2M.AssertModel(models[8],_testData[20], false);FlatInt32integerArray2M.AssertModel(models[9],_testData[21], false);FlatInt32integerArray2M.AssertModel(models[10],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[11],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[12],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[13],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[14],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[15],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[16],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatInt32integerArray2M.AssertModel(models[0],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 137, query1, 35, query2))
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
                        Assert.That(models, Has.Count.EqualTo(24));
FlatInt32integerArray2M.AssertModel(models[0],_testData[6], false);FlatInt32integerArray2M.AssertModel(models[1],_testData[7], false);FlatInt32integerArray2M.AssertModel(models[2],_testData[8], false);FlatInt32integerArray2M.AssertModel(models[3],_testData[9], false);FlatInt32integerArray2M.AssertModel(models[4],_testData[10], false);FlatInt32integerArray2M.AssertModel(models[5],_testData[11], false);FlatInt32integerArray2M.AssertModel(models[6],_testData[12], false);FlatInt32integerArray2M.AssertModel(models[7],_testData[13], false);FlatInt32integerArray2M.AssertModel(models[8],_testData[14], false);FlatInt32integerArray2M.AssertModel(models[9],_testData[15], false);FlatInt32integerArray2M.AssertModel(models[10],_testData[16], false);FlatInt32integerArray2M.AssertModel(models[11],_testData[17], false);FlatInt32integerArray2M.AssertModel(models[12],_testData[18], false);FlatInt32integerArray2M.AssertModel(models[13],_testData[19], false);FlatInt32integerArray2M.AssertModel(models[14],_testData[20], false);FlatInt32integerArray2M.AssertModel(models[15],_testData[21], false);FlatInt32integerArray2M.AssertModel(models[16],_testData[22], false);FlatInt32integerArray2M.AssertModel(models[17],_testData[23], false);FlatInt32integerArray2M.AssertModel(models[18],_testData[24], false);FlatInt32integerArray2M.AssertModel(models[19],_testData[25], false);FlatInt32integerArray2M.AssertModel(models[20],_testData[26], false);FlatInt32integerArray2M.AssertModel(models[21],_testData[27], false);FlatInt32integerArray2M.AssertModel(models[22],_testData[28], false);FlatInt32integerArray2M.AssertModel(models[23],_testData[29], false);
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSelectModelBatchAsync(connection, 6, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Int32integerArray2M.AssertModel(models[0],_testData[2], false);Int32integerArray2M.AssertModel(models[1],_testData[3], false);Int32integerArray2M.AssertModel(models[2],_testData[4], false);Int32integerArray2M.AssertModel(models[3],_testData[5], false);Int32integerArray2M.AssertModel(models[4],_testData[6], false);Int32integerArray2M.AssertModel(models[5],_testData[7], false);Int32integerArray2M.AssertModel(models[6],_testData[8], false);Int32integerArray2M.AssertModel(models[7],_testData[9], false);Int32integerArray2M.AssertModel(models[8],_testData[10], false);Int32integerArray2M.AssertModel(models[9],_testData[11], false);Int32integerArray2M.AssertModel(models[10],_testData[12], false);Int32integerArray2M.AssertModel(models[11],_testData[13], false);Int32integerArray2M.AssertModel(models[12],_testData[14], false);Int32integerArray2M.AssertModel(models[13],_testData[15], false);Int32integerArray2M.AssertModel(models[14],_testData[16], false);Int32integerArray2M.AssertModel(models[15],_testData[17], false);Int32integerArray2M.AssertModel(models[16],_testData[18], false);Int32integerArray2M.AssertModel(models[17],_testData[19], false);Int32integerArray2M.AssertModel(models[18],_testData[20], false);Int32integerArray2M.AssertModel(models[19],_testData[21], false);Int32integerArray2M.AssertModel(models[20],_testData[22], false);Int32integerArray2M.AssertModel(models[21],_testData[23], false);Int32integerArray2M.AssertModel(models[22],_testData[24], false);Int32integerArray2M.AssertModel(models[23],_testData[25], false);Int32integerArray2M.AssertModel(models[24],_testData[26], false);Int32integerArray2M.AssertModel(models[25],_testData[27], false);Int32integerArray2M.AssertModel(models[26],_testData[28], false);Int32integerArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
Int32integerArray2M.AssertModel(models[0],_testData[15], false);Int32integerArray2M.AssertModel(models[1],_testData[16], false);Int32integerArray2M.AssertModel(models[2],_testData[17], false);Int32integerArray2M.AssertModel(models[3],_testData[18], false);Int32integerArray2M.AssertModel(models[4],_testData[19], false);Int32integerArray2M.AssertModel(models[5],_testData[20], false);Int32integerArray2M.AssertModel(models[6],_testData[21], false);Int32integerArray2M.AssertModel(models[7],_testData[22], false);Int32integerArray2M.AssertModel(models[8],_testData[23], false);Int32integerArray2M.AssertModel(models[9],_testData[24], false);Int32integerArray2M.AssertModel(models[10],_testData[25], false);Int32integerArray2M.AssertModel(models[11],_testData[26], false);Int32integerArray2M.AssertModel(models[12],_testData[27], false);Int32integerArray2M.AssertModel(models[13],_testData[28], false);Int32integerArray2M.AssertModel(models[14],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSelectModelBatch(connection, 6, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Int32integerArray2M.AssertModel(models[0],_testData[2], false);Int32integerArray2M.AssertModel(models[1],_testData[3], false);Int32integerArray2M.AssertModel(models[2],_testData[4], false);Int32integerArray2M.AssertModel(models[3],_testData[5], false);Int32integerArray2M.AssertModel(models[4],_testData[6], false);Int32integerArray2M.AssertModel(models[5],_testData[7], false);Int32integerArray2M.AssertModel(models[6],_testData[8], false);Int32integerArray2M.AssertModel(models[7],_testData[9], false);Int32integerArray2M.AssertModel(models[8],_testData[10], false);Int32integerArray2M.AssertModel(models[9],_testData[11], false);Int32integerArray2M.AssertModel(models[10],_testData[12], false);Int32integerArray2M.AssertModel(models[11],_testData[13], false);Int32integerArray2M.AssertModel(models[12],_testData[14], false);Int32integerArray2M.AssertModel(models[13],_testData[15], false);Int32integerArray2M.AssertModel(models[14],_testData[16], false);Int32integerArray2M.AssertModel(models[15],_testData[17], false);Int32integerArray2M.AssertModel(models[16],_testData[18], false);Int32integerArray2M.AssertModel(models[17],_testData[19], false);Int32integerArray2M.AssertModel(models[18],_testData[20], false);Int32integerArray2M.AssertModel(models[19],_testData[21], false);Int32integerArray2M.AssertModel(models[20],_testData[22], false);Int32integerArray2M.AssertModel(models[21],_testData[23], false);Int32integerArray2M.AssertModel(models[22],_testData[24], false);Int32integerArray2M.AssertModel(models[23],_testData[25], false);Int32integerArray2M.AssertModel(models[24],_testData[26], false);Int32integerArray2M.AssertModel(models[25],_testData[27], false);Int32integerArray2M.AssertModel(models[26],_testData[28], false);Int32integerArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Int32integerArray2M.AssertModel(models[0],_testData[2], false);Int32integerArray2M.AssertModel(models[1],_testData[3], false);Int32integerArray2M.AssertModel(models[2],_testData[4], false);Int32integerArray2M.AssertModel(models[3],_testData[5], false);Int32integerArray2M.AssertModel(models[4],_testData[6], false);Int32integerArray2M.AssertModel(models[5],_testData[7], false);Int32integerArray2M.AssertModel(models[6],_testData[8], false);Int32integerArray2M.AssertModel(models[7],_testData[9], false);Int32integerArray2M.AssertModel(models[8],_testData[10], false);Int32integerArray2M.AssertModel(models[9],_testData[11], false);Int32integerArray2M.AssertModel(models[10],_testData[12], false);Int32integerArray2M.AssertModel(models[11],_testData[13], false);Int32integerArray2M.AssertModel(models[12],_testData[14], false);Int32integerArray2M.AssertModel(models[13],_testData[15], false);Int32integerArray2M.AssertModel(models[14],_testData[16], false);Int32integerArray2M.AssertModel(models[15],_testData[17], false);Int32integerArray2M.AssertModel(models[16],_testData[18], false);Int32integerArray2M.AssertModel(models[17],_testData[19], false);Int32integerArray2M.AssertModel(models[18],_testData[20], false);Int32integerArray2M.AssertModel(models[19],_testData[21], false);Int32integerArray2M.AssertModel(models[20],_testData[22], false);Int32integerArray2M.AssertModel(models[21],_testData[23], false);Int32integerArray2M.AssertModel(models[22],_testData[24], false);Int32integerArray2M.AssertModel(models[23],_testData[25], false);Int32integerArray2M.AssertModel(models[24],_testData[26], false);Int32integerArray2M.AssertModel(models[25],_testData[27], false);Int32integerArray2M.AssertModel(models[26],_testData[28], false);Int32integerArray2M.AssertModel(models[27],_testData[29], false);
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
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models = await ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Int32integerArray2M.AssertModel(models[0],_testData[11], false);Int32integerArray2M.AssertModel(models[1],_testData[12], false);Int32integerArray2M.AssertModel(models[2],_testData[13], false);Int32integerArray2M.AssertModel(models[3],_testData[14], false);Int32integerArray2M.AssertModel(models[4],_testData[15], false);Int32integerArray2M.AssertModel(models[5],_testData[16], false);Int32integerArray2M.AssertModel(models[6],_testData[17], false);Int32integerArray2M.AssertModel(models[7],_testData[18], false);Int32integerArray2M.AssertModel(models[8],_testData[19], false);Int32integerArray2M.AssertModel(models[9],_testData[20], false);Int32integerArray2M.AssertModel(models[10],_testData[21], false);Int32integerArray2M.AssertModel(models[11],_testData[22], false);Int32integerArray2M.AssertModel(models[12],_testData[23], false);Int32integerArray2M.AssertModel(models[13],_testData[24], false);Int32integerArray2M.AssertModel(models[14],_testData[25], false);Int32integerArray2M.AssertModel(models[15],_testData[26], false);Int32integerArray2M.AssertModel(models[16],_testData[27], false);Int32integerArray2M.AssertModel(models[17],_testData[28], false);Int32integerArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
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


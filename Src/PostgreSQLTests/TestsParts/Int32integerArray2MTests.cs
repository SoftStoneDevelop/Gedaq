

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2055521893,

1435811319,

239189647,

1451894161,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1395200044,

83545787,

717603761,

1851410968,

},
},
            new Int32integerArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1634916541,

2050763169,

950494927,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1458301812,

525741301,

465194978,

1611706284,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1637104563,

1057845064,

1918192774,

1796236269,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1825381765,

1762886627,

602762342,

1342975132,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
84418127,

117645799,

234599877,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1437033679,

1797896663,

1448481300,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1929995188,

2127169733,

541492137,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1411319752,

1883592341,

2115086495,

1433471583,

},
},
            new Int32integerArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1940655133,

913213845,

2034192607,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1464214970,

267420531,

446757152,

1832014752,

},
},
            new Int32integerArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
621724224,

1004790586,

1995339066,

766859201,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1678478550,

547694895,

1332886884,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
380724921,

989456165,

1631524579,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1606580023,

1746810367,

717122197,

},
},
            new Int32integerArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1796709999,

683131754,

1679467879,

1243085529,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1214716163,

229967654,

1992380435,

},
},
            new Int32integerArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1253192074,

1583549120,

1240997471,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2115061479,

1267290359,

1172367965,

1013553116,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
759625558,

1109796002,

812601772,

1199252143,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
553848573,

1695127348,

1002925296,

},
},
            new Int32integerArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1887996858,

1992310718,

469936327,

1870661725,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1327941310,

749926503,

1944520391,

1098692528,

},
},
            new Int32integerArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1289665853,

2027897877,

970414711,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
595047366,

825718662,

2039219880,

1808472849,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
607149041,

374632884,

1071779846,

357126810,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1652598638,

1582916377,

129104587,

1950865882,

},
},
            new Int32integerArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
423316207,

1604046027,

807966956,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
341541570,

44251214,

372612621,

383736109,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
656366616,

750273692,

953274931,

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
455803267,

1608623671,

647585317,

1659389799,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1621705044,

1725271489,

1096957838,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1516487372,

105060686,

739825341,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
856769825,

1849755013,

2143635251,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
2114370557,

588976649,

693589841,

},
},
            new Int32integerArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1116561891,

835522860,

2083847545,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
796522341,

476983,

1162289026,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1864840401,

2003591555,

1994350037,

905345510,

},
},
            new Int32integerArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1478269737,

1349199930,

1489408557,

447095960,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
922332686,

1249061713,

307620938,

},
},
            new Int32integerArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1903953996,

1974246487,

1650626232,

1937677664,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
320338052,

1037204000,

661079698,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
586638897,

1632451329,

1074754760,

1557185209,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
41208033,

2120060879,

1962725673,

},
},
            new Int32integerArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1356732924,

948704473,

277850625,

434995542,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1586254669,

1301642821,

1020912640,

2138522063,

},
},
            new Int32integerArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
717273965,

957565348,

1185740794,

278777966,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
650451610,

1938841522,

60180499,

591987974,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1347706071,

801206590,

1924058099,

1811823980,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
978985063,

718559479,

831316452,

},
},
            new Int32integerArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1513452796,

741384795,

1128595382,

1436496094,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
979858679,

949556556,

505168457,

182453194,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1687161548,

1471482888,

342711303,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1096737330,

2046489855,

281111109,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
734167832,

1746804911,

2022159098,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
544557739,

747169120,

774544399,

1615972204,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
847565298,

1345190641,

165889865,

492870173,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
611680620,

1912380317,

782930834,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1013832131,

701913039,

939675368,

},
},
            new Int32integerArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1463340401,

176315963,

1003323435,

1602294077,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2001191454,

984725,

1748658414,

541091491,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1797555040,

226820624,

1755632353,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1688375265,

564712974,

1294837234,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1063607546,

1175983981,

1853853752,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1597177926,

985387219,

1896510810,

},
},
            new Int32integerArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1234840820,

205765765,

1154304754,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1773515081,

503527103,

976880257,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1952168883,

178490419,

272130317,

342422777,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1277327942,

321070033,

1433448115,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1011733246,

636721887,

1488994702,

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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
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
                        Assert.That(models, Has.Count.EqualTo(15));

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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 18;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int32integerArray2M.AssertModel(models[0],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int32integerArray2M.AssertModel(models[0],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int32integerArray2M.AssertModel(models[0],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int32integerArray2M.AssertModel(models[0],_testData[5], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[6], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[7], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[8], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[9], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[10], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[11], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[12], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[13], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[14], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[15], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[15],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[16],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[17],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[18],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[19],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[20],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[21],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[22],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[23],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[24],_testData[29], false);
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
                await ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
                await ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
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
                 ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
                 ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 93, query1, 100, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 30, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 78, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                 ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 78, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 117, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32integerArray2M.AssertModel(models[0],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int32integerArray2M.AssertModel(models[0],_testData[1], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[2], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[3], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[4], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[5], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[6], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[7], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[8], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[9], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[10], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[11], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[12], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[13], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[14], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[15], false);
                        Int32integerArray2M.AssertModel(models[15],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[16],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[17],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[18],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[19],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[20],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[21],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[22],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[23],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[24],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[25],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[26],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[27],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[28],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatch(connection, 59, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int32integerArray2M.AssertModel(models[0],_testData[12], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[13], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[14], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[15], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[15],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[16],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models = await ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Int32integerArray2M.AssertModel(models[0],_testData[21], false);Int32integerArray2M.AssertModel(models[1],_testData[22], false);Int32integerArray2M.AssertModel(models[2],_testData[23], false);Int32integerArray2M.AssertModel(models[3],_testData[24], false);Int32integerArray2M.AssertModel(models[4],_testData[25], false);Int32integerArray2M.AssertModel(models[5],_testData[26], false);Int32integerArray2M.AssertModel(models[6],_testData[27], false);Int32integerArray2M.AssertModel(models[7],_testData[28], false);Int32integerArray2M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models =  ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Int32integerArray2M.AssertModel(models[0],_testData[25], false);Int32integerArray2M.AssertModel(models[1],_testData[26], false);Int32integerArray2M.AssertModel(models[2],_testData[27], false);Int32integerArray2M.AssertModel(models[3],_testData[28], false);Int32integerArray2M.AssertModel(models[4],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32ListintegerArray)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32ListintegerArray)this).DynQuerySelectImportModelInner(connection);
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32ListintegerArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32ListintegerArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32ListintegerArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32ListintegerArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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


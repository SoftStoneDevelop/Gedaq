

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
new System.Int32[3]
{
42571672,
1881139115,
842533173,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
648770542,
858649380,
1353146188,
1021528309,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Int32[4]
{
443644543,
384811545,
1967098571,
730065931,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int32[3]
{
1153818192,
318805676,
1512081531,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int32[4]
{
860899520,
1530746736,
1869818195,
1560086370,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
2009666399,
1123669157,
4460138,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Int32[3]
{
1180370343,
1559256603,
1720001108,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Int32[3]
{
475887260,
555341810,
245325411,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Int32[4]
{
165511095,
1195767595,
1333756923,
1625194966,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int32[4]
{
1590611408,
1555922093,
1164245851,
86027418,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int32[4]
{
2057094370,
2051331982,
1851953105,
702523801,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1741673821,
1787321429,
739764507,
1013003948,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Int32[4]
{
2147190002,
322794488,
655782451,
843208897,
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
2110635041,
1743154681,
764169492,
646674294,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Int32[3]
{
195102292,
1111752322,
969304253,
},
    NullableValue = 
new System.Int32[4]
{
85943367,
1340243248,
1872348248,
878029914,
},
},
    NullableValue = 
new System.Int32[4]
{
2046497649,
918011031,
342357726,
1214155289,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int32[3]
{
1314586981,
334463878,
1267629292,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1845742341,
1699175026,
995444829,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Int32[3]
{
2006796874,
225566291,
1815370256,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Int32[3]
{
1877650951,
1738386,
1138006112,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Int32[4]
{
996182427,
551565646,
1756023790,
1936635336,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Int32[3]
{
690268983,
23428421,
1607648549,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int32[3]
{
375577790,
1325441880,
312112394,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Int32[3]
{
317375020,
1813388357,
212239235,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int32[4]
{
2012724816,
755334580,
1614161670,
1754163990,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Int32[3]
{
1977011439,
319668972,
1388212768,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Int32[4]
{
70473015,
1011892796,
1371730379,
446384093,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Int32[4]
{
899638574,
1791409518,
1865311618,
165775266,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Int32[3]
{
1398462803,
1851337885,
780746608,
},
    NullableValue = 
new System.Int32[3]
{
1139085656,
1646280555,
1391095333,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Int32[4]
{
1400736253,
968972246,
1935642911,
973532759,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Int32[3]
{
332948173,
460549711,
522612293,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Int32[4]
{
1442115171,
442958299,
1023560744,
131328806,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1323735435,
962202005,
140087728,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Int32[4]
{
55637999,
973280761,
1086633454,
1527262417,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int32[4]
{
1355658110,
1734349884,
1739713615,
656713717,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Int32[4]
{
1767203722,
524365100,
788584691,
888835891,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int32[4]
{
1741362293,
906973115,
868552650,
1383228793,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1333221214,
867143000,
1229567765,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Int32[3]
{
134500351,
1881701762,
1300042420,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Int32[4]
{
1384326087,
1416707377,
2025546042,
2059583811,
},
    NullableValue = 
new System.Int32[3]
{
1239746053,
1145192154,
2024496725,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Int32[4]
{
66076324,
249136262,
1544067151,
579348763,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
2047073038,
1246751964,
1796945186,
1926886821,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int32[4]
{
12701660,
928629861,
1238709292,
1691878600,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Int32[4]
{
147060900,
750955279,
976369616,
774301988,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
997084316,
283676903,
906781464,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int32[4]
{
82707308,
2127965071,
736468224,
1490982931,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
221093356,
1699180645,
336586197,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Int32[4]
{
772958101,
458295281,
738538065,
1373096444,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int32[4]
{
736421942,
1905178038,
2138070580,
1916124836,
},
    NullableValue = 
new System.Int32[4]
{
227572310,
1452509434,
1964146421,
1172971267,
},
},
    NullableValue = 
new System.Int32[4]
{
657138520,
1968744841,
632707557,
792108842,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int32[3]
{
1351121601,
420510939,
1843995300,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Int32[4]
{
527892640,
406871971,
698380193,
468421329,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Int32[3]
{
1855168101,
1467095980,
1631067371,
},
    NullableValue = 
new System.Int32[3]
{
583504037,
884380772,
1336619793,
},
},
    NullableValue = 
new System.Int32[3]
{
1834649640,
2007186310,
62490932,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Int32[4]
{
71684014,
1637776956,
1035737708,
1806969839,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Int32[3]
{
1883334153,
522292667,
35668080,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int32[4]
{
2008515103,
1752774865,
1908907907,
10669588,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Int32[4]
{
1085166555,
801271742,
1223407634,
1961735142,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Int32[3]
{
1133235643,
2044466077,
1080194408,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Int32[4]
{
217369023,
835413345,
1884095206,
144072940,
},
    NullableValue = 
new System.Int32[4]
{
1418973845,
1966044877,
323362426,
422380414,
},
},
    NullableValue = 
new System.Int32[4]
{
1817698760,
344003448,
208255373,
683172665,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 177,
    Value = 
new System.Int32[3]
{
934525492,
1592213233,
1554734688,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1794666826,
1160745446,
1686439871,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 181,
    Value = 
new System.Int32[4]
{
1791398755,
1637335854,
344016778,
439582841,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Int32[3]
{
149469470,
300778981,
1278289763,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 182,
    Value = 
new System.Int32[4]
{
945148803,
927906949,
971449611,
727895420,
},
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
1741673821,
1787321429,
739764507,
1013003948,
}));
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
2046497649,
918011031,
342357726,
1214155289,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1845742341,
1699175026,
995444829,
}));
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 60, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 136, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 24, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 67, query1, 168, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 76, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 41, query1, 177, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 70, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 177))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 141, 168))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                ((IInt32MArrayintegerMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 160);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32MArrayintegerMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32MArrayintegerMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((IInt32MArrayintegerMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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


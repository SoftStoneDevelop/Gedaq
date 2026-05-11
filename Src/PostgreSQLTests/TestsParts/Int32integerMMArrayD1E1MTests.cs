

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
    Id = 4,
    Value = 
new System.Int32[3]
{
599668952,
1677159872,
1128314674,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
674335001,
1210278279,
1797951763,
521545538,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Int32[4]
{
51726329,
463997247,
196763609,
344491039,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Int32[4]
{
585799065,
302126919,
510478222,
734387526,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int32[4]
{
52448219,
1219389002,
1119321550,
1873762734,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Int32[4]
{
1506804632,
2109947700,
2133237523,
590388799,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int32[4]
{
1353336220,
1458187035,
1084776758,
1396542091,
},
    NullableValue = 
new System.Int32[4]
{
902203506,
368875508,
632419418,
1317196242,
},
},
    NullableValue = 
new System.Int32[4]
{
1501001014,
574648947,
441198330,
19013069,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Int32[3]
{
1157413694,
1710540500,
4234968,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int32[4]
{
810917025,
214307967,
1011833991,
1500832354,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Int32[4]
{
1640516481,
2105738497,
1841270524,
1910634424,
},
    NullableValue = 
new System.Int32[4]
{
692917424,
466043171,
1114111711,
619897489,
},
},
    NullableValue = 
new System.Int32[4]
{
1190740774,
137928777,
1673224060,
907433312,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Int32[3]
{
95298204,
235598043,
1806854455,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1945495227,
1782442282,
780566838,
1039113236,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Int32[3]
{
598216325,
1545325280,
1792060309,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Int32[3]
{
1399378520,
1560512064,
1178619783,
},
    NullableValue = 
new System.Int32[3]
{
1529159959,
880233973,
1062662722,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Int32[4]
{
2124972093,
1424982941,
808118309,
427023855,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Int32[3]
{
1033544288,
1105147829,
1950316906,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int32[3]
{
893951731,
488602646,
337004906,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
395954265,
1608925593,
633035232,
1583502400,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Int32[4]
{
701050234,
130250537,
176266194,
1754931564,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1090290266,
1419726288,
603304981,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Int32[3]
{
1511987752,
496305670,
1117384402,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int32[3]
{
492542746,
1166973869,
299552754,
},
    NullableValue = 
new System.Int32[3]
{
885748190,
233953391,
999216501,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Int32[3]
{
1900966963,
1131798758,
1883497759,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
739851320,
1070778048,
1448787480,
1195789233,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Int32[4]
{
834773548,
1436543687,
1733726412,
2121709563,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int32[4]
{
615282631,
953835525,
393764440,
370681412,
},
    NullableValue = 
new System.Int32[3]
{
133596525,
46128576,
1854956855,
},
},
    NullableValue = 
new System.Int32[3]
{
171686754,
1625955794,
1381185590,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int32[3]
{
1153166356,
130394251,
333774407,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
631207777,
2078361890,
1636050409,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Int32[4]
{
2051560790,
2031682525,
918283270,
689674927,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Int32[4]
{
2013261779,
1200456530,
328690569,
906596549,
},
    NullableValue = 
new System.Int32[4]
{
904422107,
159309626,
248131788,
348941479,
},
},
    NullableValue = 
new System.Int32[4]
{
1970652136,
1568221410,
141078915,
642231719,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Int32[4]
{
668093513,
1243581478,
673636351,
1922110240,
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
1060125040,
1518835978,
1578657967,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Int32[3]
{
394034022,
1852341302,
1034844031,
},
    NullableValue = 
new System.Int32[3]
{
871465139,
1234631759,
1382907328,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Int32[3]
{
977580246,
885916872,
478557629,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Int32[3]
{
1195899192,
618684676,
1721228384,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int32[4]
{
787911697,
674359406,
671896059,
294821383,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1110637305,
1599197547,
2021017869,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Int32[3]
{
608891191,
13786025,
2061476225,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
524644234,
235900898,
439922622,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Int32[3]
{
1626499192,
1755765531,
2112754813,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Int32[3]
{
1946643000,
161952160,
1410396026,
},
    NullableValue = 
new System.Int32[4]
{
71621574,
1597696215,
648511618,
125699706,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Int32[4]
{
1895208451,
2139383288,
1451539510,
781952306,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
481589048,
1854198907,
690132773,
1467936530,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Int32[3]
{
943686930,
1199035633,
633881586,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int32[4]
{
2063075185,
1350374289,
453038230,
1116297207,
},
    NullableValue = 
new System.Int32[3]
{
153503018,
1559918077,
870215370,
},
},
    NullableValue = 
new System.Int32[4]
{
1580153983,
1471468063,
357568368,
1561140417,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Int32[3]
{
520168260,
2102737117,
631141607,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 125,
    Value = 
new System.Int32[3]
{
383912757,
1124651236,
1236244405,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int32[3]
{
1817906154,
1409774510,
662830425,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1556446825,
1291825116,
200784441,
509014715,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Int32[3]
{
680728933,
1631830120,
905936261,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Int32[4]
{
614628420,
1915803775,
819917309,
1889853805,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Int32[4]
{
820671652,
504080389,
678036173,
171785773,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1891442559,
1383463884,
1507188561,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Int32[4]
{
909077452,
1703582146,
930012771,
519461833,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1258068642,
1777308616,
108494465,
941210327,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int32[4]
{
2145688705,
2076702831,
493145230,
1905689391,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Int32[4]
{
519212764,
546851635,
288743264,
957837618,
},
    NullableValue = 
new System.Int32[4]
{
598770319,
1839598368,
1413694016,
183119549,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Int32[4]
{
903979999,
1299582128,
1260560115,
1014966816,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1111551275,
1274256305,
412446537,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Int32[4]
{
1346658322,
196183914,
1097195595,
376026289,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Int32[3]
{
1479029637,
760523079,
1342259684,
},
    NullableValue = 
new System.Int32[3]
{
1380787073,
1160887263,
594661057,
},
},
    NullableValue = 
new System.Int32[4]
{
1849859647,
941435692,
1011090958,
249936562,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Int32[4]
{
944480124,
728337902,
328020274,
1986490757,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1309464894,
1159454874,
105288369,
1145202765,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Int32[4]
{
1014873501,
1810504343,
1404637543,
423270036,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Int32[3]
{
1860162474,
395707626,
1418077758,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 174,
    Value = 
new System.Int32[3]
{
2061242927,
510815928,
1748321118,
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
1190740774,
137928777,
1673224060,
907433312,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
1945495227,
1782442282,
780566838,
1039113236,
}));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
395954265,
1608925593,
633035232,
1583502400,
}));
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
1090290266,
1419726288,
603304981,
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 151;
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
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 151, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 116, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 33, query1, 15, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 136, 136))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt32MArrayintegerMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32MArrayintegerMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 160);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32MArrayintegerMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32MArrayintegerMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((IInt32MArrayintegerMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                Int32integerMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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


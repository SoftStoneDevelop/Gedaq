

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
    internal partial interface IInt32MArrayintegerMArrayD1
    {
    }
    
    internal partial class Int32MArrayintegerMArrayD1 : IInt32MArrayintegerMArrayD1
    {


#region TestData

        private readonly Int32integerMArrayD1E1M[] _testData = new Int32integerMArrayD1E1M[]
        {
            new Int32integerMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Int32[4]
{
233593690,
1216345322,
1568930924,
1496972212,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1825209371,
931442208,
1919387330,
220326183,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int32[3]
{
440272224,
564569318,
1692371890,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 9,
    Value = 
new System.Int32[4]
{
1979514604,
964622713,
2044645575,
977470585,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1021142593,
1811943797,
1021148964,
552542397,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int32[3]
{
1062263736,
607575686,
600778042,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int32[3]
{
466458639,
1701873538,
1393865223,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 17,
    Value = 
new System.Int32[4]
{
487970138,
1779120365,
1403617534,
1042249801,
},
    NullableValue = 
new System.Int32[4]
{
1653827855,
1955513608,
1482318638,
1071740356,
},
},
    NullableValue = 
new System.Int32[4]
{
768156261,
981286314,
1454439133,
814723129,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Int32[4]
{
1635632348,
1008491607,
961071638,
1522933379,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int32[3]
{
757302097,
1391352500,
1365206242,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 23,
    Value = 
new System.Int32[3]
{
199008435,
1949509062,
1692986168,
},
    NullableValue = 
new System.Int32[4]
{
1070341807,
1330949926,
781370615,
1582420839,
},
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Int32[4]
{
191862017,
1374705530,
1740726037,
917603924,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1843746952,
130866688,
478355015,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Int32[3]
{
1393169753,
1779710379,
1171369915,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 31,
    Value = 
new System.Int32[3]
{
1145980242,
1397162165,
992518518,
},
    NullableValue = 
new System.Int32[3]
{
2079062035,
1504809746,
983785387,
},
},
    NullableValue = 
new System.Int32[4]
{
1505524404,
1564509858,
1578878709,
1871357447,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Int32[4]
{
130138206,
798319677,
2012715481,
422019400,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Int32[4]
{
795848541,
1108333927,
652010399,
951726288,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 38,
    Value = 
new System.Int32[4]
{
1122517882,
911250478,
75251062,
1176531339,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
315893227,
1818727582,
1558195938,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Int32[3]
{
1758796904,
1732924696,
294374253,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1019074700,
1248011320,
347929858,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Int32[3]
{
111823936,
1938335221,
83728517,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 43,
    Value = 
new System.Int32[4]
{
889960615,
1680614941,
659151078,
880084826,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Int32[4]
{
1919945504,
1313552291,
92418987,
683039460,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int32[3]
{
1183150833,
1011675605,
1788823745,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 46,
    Value = 
new System.Int32[4]
{
1277907616,
1887151371,
573076124,
1834189466,
},
    NullableValue = 
new System.Int32[4]
{
1015686958,
1787509242,
157629046,
1672330230,
},
},
    NullableValue = 
new System.Int32[3]
{
1754351864,
1864036954,
562247102,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int32[4]
{
2084186218,
7475656,
1174725139,
1902248664,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
987834154,
751662981,
132143188,
752303598,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Int32[4]
{
2146465398,
1994498485,
985975637,
2056226046,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 55,
    Value = 
new System.Int32[3]
{
1378512482,
109450217,
280969083,
},
    NullableValue = 
new System.Int32[4]
{
656239555,
791669018,
1413267679,
921833400,
},
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Int32[3]
{
1713724974,
1479387953,
1127305349,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Int32[4]
{
1205039035,
1834828378,
485103069,
2001020372,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 61,
    Value = 
new System.Int32[3]
{
392578874,
243901576,
2009103869,
},
    NullableValue = 
new System.Int32[4]
{
529943219,
1362262197,
363958099,
717861068,
},
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int32[3]
{
936787527,
2021967726,
560271338,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
420512004,
1117686153,
1226422767,
506130255,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Int32[3]
{
217960901,
611273062,
1753489850,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 67,
    Value = 
new System.Int32[4]
{
1164513893,
1003164960,
1452641080,
488095339,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Int32[3]
{
1628660599,
1829968197,
55473723,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1403649389,
1835456234,
1299286890,
455622634,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int32[4]
{
379527398,
1812282867,
1081892717,
1092829671,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 72,
    Value = 
new System.Int32[3]
{
57724597,
524050099,
917961477,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Int32[4]
{
578052483,
317579470,
1291767528,
1561612514,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
187064788,
1670751680,
43415010,
227832477,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Int32[4]
{
1330539982,
2056137906,
787438870,
1057751654,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 73,
    Value = 
new System.Int32[4]
{
1492817198,
643856230,
1267623727,
216340979,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1872599534,
1738433850,
1587331869,
1612160191,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Int32[4]
{
1343086778,
2074660510,
2096239131,
1182072693,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
954372848,
836337482,
1685171602,
455587066,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Int32[4]
{
1272807727,
454282877,
2144596131,
273539932,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 75,
    Value = 
new System.Int32[3]
{
1879554520,
121115285,
2137582787,
},
    NullableValue = 
new System.Int32[4]
{
98501387,
2067348011,
73893636,
1729882363,
},
},
    NullableValue = 
new System.Int32[3]
{
1151166970,
1371561257,
219059646,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Int32[4]
{
2000241332,
1337084257,
1868616504,
1851330042,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 125,
    Value = 
new System.Int32[3]
{
1926285917,
382520373,
1716629943,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 79,
    Value = 
new System.Int32[3]
{
1194115332,
546410507,
477562131,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Int32[4]
{
685609955,
262771991,
929923817,
2097807573,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
425660895,
895890667,
2098859222,
883566394,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Int32[3]
{
1389699340,
524913781,
1825893201,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 88,
    Value = 
new System.Int32[3]
{
448719311,
1095186118,
1305881269,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 145,
    Value = 
new System.Int32[3]
{
92994578,
1721918725,
898569099,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1585106572,
663794701,
90512799,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Int32[3]
{
2038138442,
2008648709,
447255267,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 97,
    Value = 
new System.Int32[3]
{
1638036626,
738484619,
2001093374,
},
    NullableValue = 
new System.Int32[3]
{
1679816504,
1556916509,
1552650344,
},
},
    NullableValue = 
new System.Int32[4]
{
1265631884,
1924785380,
1284195542,
973720277,
},
},
            new Int32integerMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Int32[4]
{
959898169,
157807723,
170518628,
1775544971,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Int32[3]
{
1686899853,
1669070443,
1075376258,
},
    ModelInner = new Int32integerMArrayD11MI
{
    Id = 104,
    Value = 
new System.Int32[4]
{
19888620,
1588402582,
1883503071,
1628408685,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Int32[4]
{
1022767424,
1093415480,
2031351811,
901224626,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermarrayd11mi(
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
INSERT INTO public.int32integermarrayd11mi(
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
            queryMapTypes: [typeof(Int32integerMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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

                changedRows =  ((IInt32MArrayintegerMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32MArrayintegerMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt32MArrayintegerMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermarrayd11mi_id
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)), 
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
                methodParametrName: "int32integermarrayd11mi_id", 
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
                changedRows =  ((IInt32MArrayintegerMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32MArrayintegerMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32MArrayintegerMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32MArrayintegerMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermarrayd11mi_id
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
    int32integermarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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

                    nullable =  ((IInt32MArrayintegerMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IInt32MArrayintegerMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((IInt32MArrayintegerMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1843746952,
130866688,
478355015,
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

                    nullable = await ((IInt32MArrayintegerMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
1505524404,
1564509858,
1578878709,
1871357447,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermarrayd11mi_id
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
    int32integermarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                methodParametrName: "int32integermarrayd11mi_id", 
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
                nullable =  ((IInt32MArrayintegerMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt32MArrayintegerMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
315893227,
1818727582,
1558195938,
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
                nullable = await ((IInt32MArrayintegerMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1019074700,
1248011320,
347929858,
}));
                nullable = await ((IInt32MArrayintegerMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerMArrayD1E1M> models = null;

                models =  ((IInt32MArrayintegerMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt32MArrayintegerMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt32MArrayintegerMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt32MArrayintegerMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerMArrayD1E1M> models = null;

                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt32MArrayintegerMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMArrayD1E1M), typeof(FlatInt32integerMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
FROM public.int32integermarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMArrayD1E1M>();
                await ((IInt32MArrayintegerMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMArrayD1E1M>();
                ((IInt32MArrayintegerMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
FROM public.int32integermarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32MArrayintegerMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32MArrayintegerMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
LEFT JOIN public.int32integermarrayd11mi mi ON mi.id = m.int32integermarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models = await ((IInt32MArrayintegerMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32MArrayintegerMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMArrayD1E1M), typeof(FlatInt32integerMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
FROM public.int32integermarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMArrayD1E1M>();
                await ((IInt32MArrayintegerMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMArrayD1E1M>();
                ((IInt32MArrayintegerMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
FROM public.int32integermarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32MArrayintegerMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32MArrayintegerMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
LEFT JOIN public.int32integermarrayd11mi mi ON mi.id = m.int32integermarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models = await ((IInt32MArrayintegerMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32MArrayintegerMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMArrayD1E1M), typeof(FlatInt32integerMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMArrayD1E1M>();
                await((IInt32MArrayintegerMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMArrayD1E1M>();
                await ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                await ((IInt32MArrayintegerMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMArrayD1E1M>();
                ((IInt32MArrayintegerMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMArrayD1E1M>();
                 ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                 ((IInt32MArrayintegerMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32MArrayintegerMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt32integerMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt32integerMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMArrayD1E1M>();
                await ((IInt32MArrayintegerMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32MArrayintegerMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt32integerMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt32integerMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 33;
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMArrayD1E1M>();
                 ((IInt32MArrayintegerMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
LEFT JOIN public.int32integermarrayd11mi mi ON mi.id = m.int32integermarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models = await((IInt32MArrayintegerMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int32integerMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        Int32integerMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        Int32integerMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        Int32integerMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        Int32integerMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        Int32integerMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        Int32integerMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        Int32integerMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        Int32integerMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        Int32integerMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        Int32integerMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        Int32integerMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        Int32integerMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        Int32integerMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        Int32integerMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        Int32integerMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        Int32integerMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        Int32integerMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        Int32integerMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        Int32integerMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        Int32integerMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        Int32integerMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        Int32integerMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int32integerMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        Int32integerMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        Int32integerMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        Int32integerMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        Int32integerMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        Int32integerMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        Int32integerMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        Int32integerMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        Int32integerMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        Int32integerMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        Int32integerMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        Int32integerMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        Int32integerMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        Int32integerMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        Int32integerMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        Int32integerMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        Int32integerMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        Int32integerMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        Int32integerMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        Int32integerMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        Int32integerMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        Int32integerMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        Int32integerMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        Int32integerMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        Int32integerMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        Int32integerMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        Int32integerMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IInt32MArrayintegerMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32integerMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        Int32integerMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        Int32integerMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        Int32integerMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        Int32integerMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        Int32integerMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        Int32integerMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        Int32integerMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        Int32integerMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        Int32integerMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int32integerMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        Int32integerMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        Int32integerMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        Int32integerMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        Int32integerMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        Int32integerMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        Int32integerMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        Int32integerMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        Int32integerMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        Int32integerMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        Int32integerMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        Int32integerMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        Int32integerMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        Int32integerMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        Int32integerMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        Int32integerMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        Int32integerMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        Int32integerMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        Int32integerMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        Int32integerMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        Int32integerMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        Int32integerMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        Int32integerMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMArrayD1E1M), typeof(FlatInt32integerMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMArrayD1E1M>();
                await((IInt32MArrayintegerMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMArrayD1E1M>();
                await ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 78, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                await ((IInt32MArrayintegerMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 66, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMArrayD1E1M>();
                ((IInt32MArrayintegerMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMArrayD1E1M>();
                 ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 65, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                 ((IInt32MArrayintegerMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 120, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32MArrayintegerMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 154, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32integerMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt32integerMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMArrayD1E1M>();
                await ((IInt32MArrayintegerMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 49, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32MArrayintegerMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 71, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32integerMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32integerMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
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
FROM public.int32integermarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMArrayD1E1M>();
                 ((IInt32MArrayintegerMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 83, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt32integerMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.int32integermarrayd1e1m m
LEFT JOIN public.int32integermarrayd11mi mi ON mi.id = m.int32integermarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models = await((IInt32MArrayintegerMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int32integerMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        Int32integerMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        Int32integerMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        Int32integerMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        Int32integerMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        Int32integerMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        Int32integerMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        Int32integerMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        Int32integerMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        Int32integerMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        Int32integerMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        Int32integerMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        Int32integerMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        Int32integerMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        Int32integerMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        Int32integerMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        Int32integerMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        Int32integerMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        Int32integerMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        Int32integerMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        Int32integerMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        Int32integerMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        Int32integerMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        Int32integerMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        Int32integerMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        Int32integerMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        Int32integerMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        Int32integerMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        Int32integerMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        Int32integerMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        Int32integerMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32integerMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        Int32integerMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        Int32integerMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        Int32integerMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        Int32integerMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        Int32integerMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        Int32integerMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        Int32integerMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IInt32MArrayintegerMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32MArrayintegerMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 71, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int32integerMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        Int32integerMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        Int32integerMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        Int32integerMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        Int32integerMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        Int32integerMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        Int32integerMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        Int32integerMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        Int32integerMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        Int32integerMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        Int32integerMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        Int32integerMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        Int32integerMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        Int32integerMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        Int32integerMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        Int32integerMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        Int32integerMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        Int32integerMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        Int32integerMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        Int32integerMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        Int32integerMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int32integerMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        Int32integerMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        Int32integerMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        Int32integerMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        Int32integerMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        Int32integerMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        Int32integerMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        Int32integerMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        Int32integerMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        Int32integerMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        Int32integerMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        Int32integerMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        Int32integerMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        Int32integerMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        Int32integerMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        Int32integerMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        Int32integerMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        Int32integerMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        Int32integerMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        Int32integerMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        Int32integerMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        Int32integerMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        Int32integerMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        Int32integerMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        Int32integerMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        Int32integerMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        Int32integerMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        Int32integerMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        Int32integerMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        Int32integerMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        Int32integerMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        Int32integerMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        Int32integerMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        Int32integerMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IInt32MArrayintegerMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32MArrayintegerMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models = await ((IInt32MArrayintegerMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                Int32integerMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                Int32integerMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                Int32integerMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                Int32integerMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                Int32integerMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                Int32integerMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                Int32integerMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                Int32integerMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                Int32integerMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                Int32integerMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                Int32integerMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                Int32integerMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                Int32integerMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                Int32integerMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                Int32integerMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                Int32integerMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                Int32integerMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                Int32integerMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                Int32integerMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                Int32integerMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                Int32integerMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                Int32integerMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                Int32integerMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                Int32integerMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                Int32integerMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                Int32integerMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                Int32integerMArrayD1E1M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32MArrayintegerMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32MArrayintegerMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models =  ((IInt32MArrayintegerMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Int32integerMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                Int32integerMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                Int32integerMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                Int32integerMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                Int32integerMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                Int32integerMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                Int32integerMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_int32integermarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int32integerMArrayD11MIWA),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integermarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32MArrayintegerMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integermarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32MArrayintegerMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integermarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integerMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integermarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32MArrayintegerMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integermarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32MArrayintegerMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integermarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integerMArrayD11MI),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32MArrayintegerMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32MArrayintegerMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt32MArrayintegerMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_int32integermarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32MArrayintegerMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integermarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerMArrayD1E1M),
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
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
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
FROM public.binary_int32integermarrayd1e1m m
LEFT JOIN public.binary_int32integermarrayd11mi mi ON mi.id = m.int32integermarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt32MArrayintegerMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt32MArrayintegerMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IInt32MArrayintegerMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integermarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models =  ((IInt32MArrayintegerMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32MArrayintegerMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA), typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models1 = new List<Int32integerMArrayD11MIWA>();
                var models2 = new List<Int32integerMArrayD11MIWA>();
                await ((IInt32MArrayintegerMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerMArrayD11MIWA>();
                var models2 = new List<Int32integerMArrayD11MIWA>();
                ((IInt32MArrayintegerMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models = await ((IInt32MArrayintegerMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int32integermarrayd11mi
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
                    Int32integerMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32MArrayintegerMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int32integermarrayd11mi
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
                    Int32integerMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA), typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
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
                var models1 = new List<Int32integerMArrayD11MIWA>();
                var models2 = new List<Int32integerMArrayD11MIWA>();
                await ((IInt32MArrayintegerMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerMArrayD11MIWA>();
                var models2 = new List<Int32integerMArrayD11MIWA>();
                ((IInt32MArrayintegerMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
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
                var models = await ((IInt32MArrayintegerMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int32integermarrayd11mi
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
                    Int32integerMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32MArrayintegerMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int32integermarrayd11mi
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
                    Int32integerMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integermarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MI), typeof(Int32integerMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models1 = new List<Int32integerMArrayD11MI>();
                var models2 = new List<Int32integerMArrayD11MI>();
                await ((IInt32MArrayintegerMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerMArrayD11MI>();
                var models2 = new List<Int32integerMArrayD11MI>();
                ((IInt32MArrayintegerMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1)),
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
                var models = await ((IInt32MArrayintegerMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32MArrayintegerMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integermarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA), typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
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
                var models1 = new List<Int32integerMArrayD11MIWA>();
                var models2 = new List<Int32integerMArrayD11MIWA>();
                await ((IInt32MArrayintegerMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerMArrayD11MIWA>();
                var models2 = new List<Int32integerMArrayD11MIWA>();
                ((IInt32MArrayintegerMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMArrayD1))]
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
                var models = await ((IInt32MArrayintegerMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32MArrayintegerMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


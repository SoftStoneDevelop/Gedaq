

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
    internal partial interface IInt32ArrayintegerArray
    {
    }
    
    internal partial class Int32ArrayintegerArray : IInt32ArrayintegerArray
    {


#region TestData

        private readonly Int32integerArray1M[] _testData = new Int32integerArray1M[]
        {
            new Int32integerArray1M
{
    Id = 7,
    Value = 
new System.Int32[3]
{
1481037564,
1559642369,
151577876,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1149044609,
2051379650,
1992485270,
},
},
            new Int32integerArray1M
{
    Id = 13,
    Value = 
new System.Int32[3]
{
1177213607,
1009336360,
489065733,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 2,
    Value = 
new System.Int32[4]
{
778652501,
641136452,
2002987146,
1447682063,
},
    NullableValue = 
new System.Int32[4]
{
1666754741,
1047446510,
938825438,
1650119193,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 15,
    Value = 
new System.Int32[4]
{
1066014786,
749593646,
1746187110,
840095134,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1398463018,
276179968,
1736972840,
},
},
            new Int32integerArray1M
{
    Id = 20,
    Value = 
new System.Int32[4]
{
1057149187,
74384918,
414708408,
1212858680,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 5,
    Value = 
new System.Int32[4]
{
1185948793,
1087278037,
430292547,
1076534494,
},
    NullableValue = 
new System.Int32[4]
{
811007131,
2098737375,
1124122412,
468549841,
},
},
    NullableValue = 
new System.Int32[4]
{
1496682571,
631517601,
1962050525,
921396333,
},
},
            new Int32integerArray1M
{
    Id = 29,
    Value = 
new System.Int32[3]
{
2121317967,
408872763,
43821813,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
114343119,
171232251,
1835930757,
},
},
            new Int32integerArray1M
{
    Id = 35,
    Value = 
new System.Int32[3]
{
1324477506,
19688010,
1609828301,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 9,
    Value = 
new System.Int32[3]
{
621104740,
1757693579,
24747195,
},
    NullableValue = 
new System.Int32[4]
{
1923304664,
383006464,
972942691,
1048157770,
},
},
    NullableValue = 
new System.Int32[4]
{
1257828079,
28037639,
1325089043,
39938366,
},
},
            new Int32integerArray1M
{
    Id = 37,
    Value = 
new System.Int32[3]
{
576892916,
138086343,
714273183,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 41,
    Value = 
new System.Int32[3]
{
1812264207,
1634803607,
773367581,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 13,
    Value = 
new System.Int32[4]
{
1757950189,
138193794,
1190214888,
201314395,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 43,
    Value = 
new System.Int32[3]
{
2135009452,
1359115371,
47450034,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 47,
    Value = 
new System.Int32[3]
{
2145939234,
1398795759,
901519172,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 20,
    Value = 
new System.Int32[3]
{
456501071,
263632315,
586142796,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 50,
    Value = 
new System.Int32[3]
{
389647611,
486282572,
107128964,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1417001132,
340273311,
441827021,
},
},
            new Int32integerArray1M
{
    Id = 51,
    Value = 
new System.Int32[3]
{
988067173,
1397344821,
1252377603,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 26,
    Value = 
new System.Int32[3]
{
44176727,
53943012,
800352617,
},
    NullableValue = 
new System.Int32[4]
{
1269060693,
379795376,
297412483,
496189371,
},
},
    NullableValue = 
new System.Int32[4]
{
461242251,
1977884760,
1675464948,
688475881,
},
},
            new Int32integerArray1M
{
    Id = 56,
    Value = 
new System.Int32[4]
{
155019202,
429243900,
2067849670,
884770847,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1992050032,
1587765834,
1627181812,
},
},
            new Int32integerArray1M
{
    Id = 58,
    Value = 
new System.Int32[4]
{
132537429,
1443644156,
1510913831,
1359424177,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 31,
    Value = 
new System.Int32[3]
{
1361943874,
1865697903,
105276622,
},
    NullableValue = 
new System.Int32[3]
{
2116587395,
927478069,
281675090,
},
},
    NullableValue = 
new System.Int32[3]
{
1150353109,
2023310540,
651015082,
},
},
            new Int32integerArray1M
{
    Id = 63,
    Value = 
new System.Int32[4]
{
610389805,
929037237,
556309789,
680683413,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1285112879,
539304857,
956081307,
2125763479,
},
},
            new Int32integerArray1M
{
    Id = 68,
    Value = 
new System.Int32[3]
{
962917906,
1593019190,
2140539128,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 39,
    Value = 
new System.Int32[4]
{
967392497,
1893110325,
1507746640,
1004975807,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
126367109,
1378420041,
1686275720,
1041781190,
},
},
            new Int32integerArray1M
{
    Id = 76,
    Value = 
new System.Int32[3]
{
1949987762,
214392196,
1787398228,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1704131324,
1688790178,
2124811192,
},
},
            new Int32integerArray1M
{
    Id = 81,
    Value = 
new System.Int32[4]
{
1267150442,
99309451,
109713720,
147319952,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 42,
    Value = 
new System.Int32[4]
{
1321214816,
1041286021,
983402994,
1072001954,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
954741289,
811312879,
1332051275,
},
},
            new Int32integerArray1M
{
    Id = 90,
    Value = 
new System.Int32[4]
{
1200037244,
439483123,
1683570873,
1828906293,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1552710439,
1940029212,
1368415028,
1168738297,
},
},
            new Int32integerArray1M
{
    Id = 99,
    Value = 
new System.Int32[4]
{
299605407,
1877413309,
1958295612,
334540558,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 45,
    Value = 
new System.Int32[3]
{
2034706490,
1150459954,
540356890,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 104,
    Value = 
new System.Int32[3]
{
1134898478,
326139332,
1935326348,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 109,
    Value = 
new System.Int32[4]
{
838911229,
1017122266,
204193889,
285730985,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 51,
    Value = 
new System.Int32[3]
{
908551215,
1731497098,
2057581388,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 112,
    Value = 
new System.Int32[4]
{
688617442,
1375944971,
439264940,
2094414821,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 115,
    Value = 
new System.Int32[3]
{
1298570572,
355484460,
301773797,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 54,
    Value = 
new System.Int32[4]
{
1422914008,
1250383064,
717650170,
283158198,
},
    NullableValue = 
new System.Int32[4]
{
914996738,
31876024,
853986226,
2037166035,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 119,
    Value = 
new System.Int32[3]
{
417412865,
404688441,
987865978,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 120,
    Value = 
new System.Int32[3]
{
621933822,
1979010993,
1390944692,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 60,
    Value = 
new System.Int32[4]
{
1726994980,
2117385197,
796852259,
1390570254,
},
    NullableValue = 
new System.Int32[4]
{
172607395,
1236816418,
1720711694,
1406808872,
},
},
    NullableValue = 
new System.Int32[3]
{
1718164036,
431428859,
1388939325,
},
},
            new Int32integerArray1M
{
    Id = 122,
    Value = 
new System.Int32[3]
{
660850677,
1052015161,
1238387884,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 125,
    Value = 
new System.Int32[4]
{
1348960878,
1817034312,
968463922,
1238227028,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 62,
    Value = 
new System.Int32[3]
{
1849089669,
691663039,
244911443,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
860192377,
1645481366,
1248081129,
},
},
            new Int32integerArray1M
{
    Id = 130,
    Value = 
new System.Int32[4]
{
1344658781,
1828664749,
1827058989,
333843457,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 137,
    Value = 
new System.Int32[3]
{
626660375,
1858152487,
66510030,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 70,
    Value = 
new System.Int32[4]
{
1004727516,
1472052708,
1280651808,
1366592576,
},
    NullableValue = 
new System.Int32[4]
{
1537747750,
347506933,
642639789,
578749245,
},
},
    NullableValue = 
new System.Int32[3]
{
1189908894,
1684384626,
2020921134,
},
},
            new Int32integerArray1M
{
    Id = 143,
    Value = 
new System.Int32[3]
{
681208496,
573051145,
2146506354,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
22715102,
1916609337,
1574708519,
1835917428,
},
},
            new Int32integerArray1M
{
    Id = 147,
    Value = 
new System.Int32[3]
{
1128098427,
1957631478,
1188315386,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 71,
    Value = 
new System.Int32[4]
{
1406621901,
1322626894,
1334373574,
1077595245,
},
    NullableValue = 
new System.Int32[4]
{
529188530,
1949297474,
1561518733,
1063714998,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 148,
    Value = 
new System.Int32[4]
{
1127573740,
1017448726,
1770385819,
1421255955,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
413993677,
546780512,
1153009648,
},
},
            new Int32integerArray1M
{
    Id = 153,
    Value = 
new System.Int32[4]
{
852926144,
2032332334,
168915354,
307885705,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 72,
    Value = 
new System.Int32[3]
{
512601715,
609407045,
1612425113,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
789251089,
1633096964,
1454799929,
464032666,
},
},
            new Int32integerArray1M
{
    Id = 159,
    Value = 
new System.Int32[4]
{
887018906,
2081949234,
380827238,
1949575973,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1140109632,
1108292445,
643949054,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray1mi(
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
INSERT INTO public.int32integerarray1mi(
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
            queryMapTypes: [typeof(Int32integerArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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

                changedRows =  ((IInt32ArrayintegerArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32ArrayintegerArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32ArrayintegerArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32ArrayintegerArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32ArrayintegerArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32ArrayintegerArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray1m(
	id,
    value,
    nullablevalue,
    int32integerarray1mi_id
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
            asPartInterface: typeof(IInt32ArrayintegerArray)), 
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
                methodParametrName: "int32integerarray1mi_id", 
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
                changedRows =  ((IInt32ArrayintegerArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32ArrayintegerArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32ArrayintegerArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32ArrayintegerArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray1m(
	id,
    value,
    nullablevalue,
    int32integerarray1mi_id
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
    int32integerarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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

                    nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
114343119,
171232251,
1835930757,
}));
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

                    nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
1257828079,
28037639,
1325089043,
39938366,
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

                    nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray1m(
	id,
    value,
    nullablevalue,
    int32integerarray1mi_id
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
    int32integerarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                methodParametrName: "int32integerarray1mi_id", 
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
                nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1417001132,
340273311,
441827021,
}));
                nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
461242251,
1977884760,
1675464948,
688475881,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerArray1M> models = null;

                models =  ((IInt32ArrayintegerArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt32ArrayintegerArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt32ArrayintegerArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt32ArrayintegerArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerArray1M> models = null;

                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                ((IInt32ArrayintegerArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32ArrayintegerArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32ArrayintegerArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
LEFT JOIN public.int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await ((IInt32ArrayintegerArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32ArrayintegerArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                ((IInt32ArrayintegerArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32ArrayintegerArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32ArrayintegerArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
LEFT JOIN public.int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await ((IInt32ArrayintegerArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32ArrayintegerArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                await((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[23],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[24],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[25],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[26],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[27],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[28],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int32integerarray1m m
LEFT JOIN public.int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await((IInt32ArrayintegerArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int32integerArray1M.AssertModel(models[0],_testData[8], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[24],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[25],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int32integerArray1M.AssertModel(models[0],_testData[1], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[2], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[3], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[4], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[5], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[6], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[7], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[8], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[24],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[25],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[26],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[27],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[28],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[29],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[30],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[31],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[32],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IInt32ArrayintegerArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int32integerArray1M.AssertModel(models[0],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int32integerArray1M.AssertModel(models[0],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                await((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 7, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 37, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 58, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 143, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[34], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 29, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 50, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[23],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[24],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[25],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[26],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[27],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[28],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[29],_testData[34], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 41, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.int32integerarray1m m
LEFT JOIN public.int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await((IInt32ArrayintegerArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 68, 147))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int32integerArray1M.AssertModel(models[0],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32integerArray1M.AssertModel(models[0],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IInt32ArrayintegerArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelBatch(connection, 148, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integerArray1M.AssertModel(models[0],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32integerArray1M.AssertModel(models[0],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[34], false);
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
                await using var cmd = await ((IInt32ArrayintegerArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models = await ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Int32integerArray1M.AssertModel(models[0],_testData[14], false);
                Int32integerArray1M.AssertModel(models[1],_testData[15], false);
                Int32integerArray1M.AssertModel(models[2],_testData[16], false);
                Int32integerArray1M.AssertModel(models[3],_testData[17], false);
                Int32integerArray1M.AssertModel(models[4],_testData[18], false);
                Int32integerArray1M.AssertModel(models[5],_testData[19], false);
                Int32integerArray1M.AssertModel(models[6],_testData[20], false);
                Int32integerArray1M.AssertModel(models[7],_testData[21], false);
                Int32integerArray1M.AssertModel(models[8],_testData[22], false);
                Int32integerArray1M.AssertModel(models[9],_testData[23], false);
                Int32integerArray1M.AssertModel(models[10],_testData[24], false);
                Int32integerArray1M.AssertModel(models[11],_testData[25], false);
                Int32integerArray1M.AssertModel(models[12],_testData[26], false);
                Int32integerArray1M.AssertModel(models[13],_testData[27], false);
                Int32integerArray1M.AssertModel(models[14],_testData[28], false);
                Int32integerArray1M.AssertModel(models[15],_testData[29], false);
                Int32integerArray1M.AssertModel(models[16],_testData[30], false);
                Int32integerArray1M.AssertModel(models[17],_testData[31], false);
                Int32integerArray1M.AssertModel(models[18],_testData[32], false);
                Int32integerArray1M.AssertModel(models[19],_testData[33], false);
                Int32integerArray1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ArrayintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models =  ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                Int32integerArray1M.AssertModel(models[0],_testData[12], false);
                Int32integerArray1M.AssertModel(models[1],_testData[13], false);
                Int32integerArray1M.AssertModel(models[2],_testData[14], false);
                Int32integerArray1M.AssertModel(models[3],_testData[15], false);
                Int32integerArray1M.AssertModel(models[4],_testData[16], false);
                Int32integerArray1M.AssertModel(models[5],_testData[17], false);
                Int32integerArray1M.AssertModel(models[6],_testData[18], false);
                Int32integerArray1M.AssertModel(models[7],_testData[19], false);
                Int32integerArray1M.AssertModel(models[8],_testData[20], false);
                Int32integerArray1M.AssertModel(models[9],_testData[21], false);
                Int32integerArray1M.AssertModel(models[10],_testData[22], false);
                Int32integerArray1M.AssertModel(models[11],_testData[23], false);
                Int32integerArray1M.AssertModel(models[12],_testData[24], false);
                Int32integerArray1M.AssertModel(models[13],_testData[25], false);
                Int32integerArray1M.AssertModel(models[14],_testData[26], false);
                Int32integerArray1M.AssertModel(models[15],_testData[27], false);
                Int32integerArray1M.AssertModel(models[16],_testData[28], false);
                Int32integerArray1M.AssertModel(models[17],_testData[29], false);
                Int32integerArray1M.AssertModel(models[18],_testData[30], false);
                Int32integerArray1M.AssertModel(models[19],_testData[31], false);
                Int32integerArray1M.AssertModel(models[20],_testData[32], false);
                Int32integerArray1M.AssertModel(models[21],_testData[33], false);
                Int32integerArray1M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_int32integerarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int32integerArray1MIWA),
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
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ArrayintegerArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32ArrayintegerArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ArrayintegerArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32ArrayintegerArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integerArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ArrayintegerArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32ArrayintegerArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ArrayintegerArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32ArrayintegerArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integerArray1MI),
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
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32ArrayintegerArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32ArrayintegerArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32ArrayintegerArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt32ArrayintegerArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ArrayintegerArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32ArrayintegerArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ArrayintegerArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32ArrayintegerArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integerarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerArray1M),
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
            asPartInterface: typeof(IInt32ArrayintegerArray))]
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
FROM public.binary_int32integerarray1m m
LEFT JOIN public.binary_int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt32ArrayintegerArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt32ArrayintegerArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integerArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt32ArrayintegerArray)this).ImportModel(connection, importCollection);
                var models = ((IInt32ArrayintegerArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integerarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models =  ((IInt32ArrayintegerArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ArrayintegerArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA), typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models1 = new List<Int32integerArray1MIWA>();
                var models2 = new List<Int32integerArray1MIWA>();
                await ((IInt32ArrayintegerArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerArray1MIWA>();
                var models2 = new List<Int32integerArray1MIWA>();
                ((IInt32ArrayintegerArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await ((IInt32ArrayintegerArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int32integerarray1mi
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
                    Int32integerArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ArrayintegerArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int32integerarray1mi
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
                    Int32integerArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA), typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
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
                var models1 = new List<Int32integerArray1MIWA>();
                var models2 = new List<Int32integerArray1MIWA>();
                await ((IInt32ArrayintegerArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerArray1MIWA>();
                var models2 = new List<Int32integerArray1MIWA>();
                ((IInt32ArrayintegerArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integerarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
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
                var models = await ((IInt32ArrayintegerArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int32integerarray1mi
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
                    Int32integerArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ArrayintegerArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int32integerarray1mi
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
                    Int32integerArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integerarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MI), typeof(Int32integerArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models1 = new List<Int32integerArray1MI>();
                var models2 = new List<Int32integerArray1MI>();
                await ((IInt32ArrayintegerArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerArray1MI>();
                var models2 = new List<Int32integerArray1MI>();
                ((IInt32ArrayintegerArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await ((IInt32ArrayintegerArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ArrayintegerArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integerarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA), typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
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
                var models1 = new List<Int32integerArray1MIWA>();
                var models2 = new List<Int32integerArray1MIWA>();
                await ((IInt32ArrayintegerArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integerArray1MIWA>();
                var models2 = new List<Int32integerArray1MIWA>();
                ((IInt32ArrayintegerArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
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
                var models = await ((IInt32ArrayintegerArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32ArrayintegerArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


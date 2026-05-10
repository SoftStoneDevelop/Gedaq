

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
    Id = 5,
    Value = 
new System.Int32[3]
{
1451704190,
838770342,
610831305,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 12,
    Value = 
new System.Int32[3]
{
1151352914,
1489476887,
1402158461,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 2,
    Value = 
new System.Int32[3]
{
1291372066,
266419693,
489737864,
},
    NullableValue = 
new System.Int32[4]
{
28793233,
1501916059,
1819542435,
2096964331,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 18,
    Value = 
new System.Int32[3]
{
866284086,
2071920037,
1463065329,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 19,
    Value = 
new System.Int32[3]
{
957099657,
900044456,
986957672,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 11,
    Value = 
new System.Int32[4]
{
1296840103,
1326533135,
850730615,
1208249956,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
880299509,
1951508143,
619953301,
},
},
            new Int32integerArray1M
{
    Id = 28,
    Value = 
new System.Int32[3]
{
170176285,
223217150,
138841654,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1627981050,
573822980,
627566222,
},
},
            new Int32integerArray1M
{
    Id = 33,
    Value = 
new System.Int32[3]
{
426456283,
611397747,
917447913,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 20,
    Value = 
new System.Int32[4]
{
201474744,
161043273,
1019936028,
479249315,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 35,
    Value = 
new System.Int32[4]
{
163422324,
429984782,
1963862626,
2073324288,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 42,
    Value = 
new System.Int32[3]
{
405503583,
676936453,
494503904,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 25,
    Value = 
new System.Int32[4]
{
608637059,
251001062,
1591198231,
233256662,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1732779236,
35404281,
481637785,
},
},
            new Int32integerArray1M
{
    Id = 49,
    Value = 
new System.Int32[4]
{
1962034354,
1187808087,
2003244497,
1723599931,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1975214734,
56874176,
1153019832,
1316166198,
},
},
            new Int32integerArray1M
{
    Id = 56,
    Value = 
new System.Int32[3]
{
1616521302,
1447118459,
1440045762,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 27,
    Value = 
new System.Int32[4]
{
1000778464,
333423157,
60729795,
2056004888,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1661421404,
1529812452,
1521201865,
998985206,
},
},
            new Int32integerArray1M
{
    Id = 64,
    Value = 
new System.Int32[3]
{
757021750,
2097395617,
37150795,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 69,
    Value = 
new System.Int32[4]
{
1993329180,
934315736,
853520158,
183528371,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 36,
    Value = 
new System.Int32[3]
{
229542090,
461655081,
166050521,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1193502086,
277584360,
1939294406,
2014788606,
},
},
            new Int32integerArray1M
{
    Id = 77,
    Value = 
new System.Int32[3]
{
1800861057,
1632575149,
1448953731,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
780959652,
917207293,
683762823,
},
},
            new Int32integerArray1M
{
    Id = 80,
    Value = 
new System.Int32[4]
{
290404968,
1999702084,
301158060,
607839997,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 44,
    Value = 
new System.Int32[3]
{
1216911857,
872278323,
85978066,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 82,
    Value = 
new System.Int32[3]
{
2128386637,
890839797,
1075594891,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1065132613,
2003738334,
344536294,
402695792,
},
},
            new Int32integerArray1M
{
    Id = 89,
    Value = 
new System.Int32[3]
{
1870084835,
1181965480,
1242480664,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 45,
    Value = 
new System.Int32[3]
{
1433154088,
372467194,
316063802,
},
    NullableValue = 
new System.Int32[3]
{
1058214476,
912767939,
2121189876,
},
},
    NullableValue = 
new System.Int32[3]
{
1039462132,
779514204,
402500712,
},
},
            new Int32integerArray1M
{
    Id = 98,
    Value = 
new System.Int32[4]
{
1497453285,
846385430,
1815858287,
136351866,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 106,
    Value = 
new System.Int32[4]
{
1441766821,
1994174649,
237417196,
1027841381,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 51,
    Value = 
new System.Int32[4]
{
1502945150,
1980787668,
231525331,
984320819,
},
    NullableValue = 
new System.Int32[4]
{
95328255,
1605346868,
1075876831,
1903302216,
},
},
    NullableValue = 
new System.Int32[4]
{
510607163,
1497534763,
641993336,
1276004944,
},
},
            new Int32integerArray1M
{
    Id = 114,
    Value = 
new System.Int32[3]
{
593197377,
434268757,
378224246,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 119,
    Value = 
new System.Int32[4]
{
821308976,
163033160,
1340986013,
388433413,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 59,
    Value = 
new System.Int32[3]
{
1860159155,
28141069,
1599388330,
},
    NullableValue = 
new System.Int32[4]
{
329068367,
1505277043,
1782617387,
676096140,
},
},
    NullableValue = 
new System.Int32[4]
{
2136889350,
1287837657,
1594423195,
996620522,
},
},
            new Int32integerArray1M
{
    Id = 121,
    Value = 
new System.Int32[4]
{
639412577,
1470515656,
320910743,
1703649064,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 123,
    Value = 
new System.Int32[4]
{
1350756319,
1123835943,
385122280,
1427071190,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 62,
    Value = 
new System.Int32[4]
{
635381548,
327231414,
872758853,
870965741,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
908197240,
627451589,
1083774320,
1843744543,
},
},
            new Int32integerArray1M
{
    Id = 131,
    Value = 
new System.Int32[4]
{
936221723,
1774666473,
1487018610,
499702198,
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
1340001876,
260808510,
1023649211,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 65,
    Value = 
new System.Int32[4]
{
1917550867,
840557861,
1724936587,
776676103,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 142,
    Value = 
new System.Int32[4]
{
1273058357,
2041305059,
1674726219,
59666315,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 148,
    Value = 
new System.Int32[3]
{
666248859,
780807626,
1841117518,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 69,
    Value = 
new System.Int32[4]
{
1112787344,
1135371174,
5004620,
292544638,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
430951031,
1177339357,
1424348666,
1726205751,
},
},
            new Int32integerArray1M
{
    Id = 157,
    Value = 
new System.Int32[3]
{
2106527790,
422634480,
703979028,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 164,
    Value = 
new System.Int32[4]
{
178206949,
722038316,
1282231489,
1224355506,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 74,
    Value = 
new System.Int32[3]
{
471013581,
922205938,
221779329,
},
    NullableValue = 
new System.Int32[3]
{
1874404429,
1354132126,
1005146543,
},
},
    NullableValue = 
new System.Int32[3]
{
1614193298,
1149088672,
1641684325,
},
},
            new Int32integerArray1M
{
    Id = 165,
    Value = 
new System.Int32[4]
{
186677307,
669811330,
1126465437,
1802317777,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 169,
    Value = 
new System.Int32[3]
{
160477765,
133938360,
1406814466,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 83,
    Value = 
new System.Int32[4]
{
1938519805,
316076626,
891027763,
459477681,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
203297063,
1416599848,
828482295,
455639797,
},
},
            new Int32integerArray1M
{
    Id = 175,
    Value = 
new System.Int32[3]
{
1139765625,
428392886,
1549527646,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 177,
    Value = 
new System.Int32[3]
{
670434091,
1557719156,
1566146278,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 89,
    Value = 
new System.Int32[4]
{
301151445,
1850817028,
2006300105,
1293760508,
},
    NullableValue = 
new System.Int32[3]
{
2617901,
248388294,
881513782,
},
},
    NullableValue = 
new System.Int32[4]
{
1030604588,
165506490,
996854381,
1277825779,
},
},
            new Int32integerArray1M
{
    Id = 183,
    Value = 
new System.Int32[4]
{
941180595,
1733721159,
1162333856,
561242107,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 184,
    Value = 
new System.Int32[3]
{
1453147,
1531298238,
14682707,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 96,
    Value = 
new System.Int32[4]
{
1588579682,
1457070383,
1210275668,
645242696,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 189,
    Value = 
new System.Int32[4]
{
902283516,
365302384,
1086650701,
133959373,
},
    ModelInner = null,
    NullableValue = null,
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
1627981050,
573822980,
627566222,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1732779236,
35404281,
481637785,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
1975214734,
56874176,
1153019832,
1316166198,
}));
                nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
1661421404,
1529812452,
1521201865,
998985206,
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
                nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
1193502086,
277584360,
1939294406,
2014788606,
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
                parametr1.Value = 80;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[23],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 56;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[23],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[23],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[24],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[32],_testData[34], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32integerArray1M.AssertModel(models[0],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32integerArray1M.AssertModel(models[0],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int32integerArray1M.AssertModel(models[0],_testData[7], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[8], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[24],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[25],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[26],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[27],_testData[34], false);
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
                await ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 131, query1, 175, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                await ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 19, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 42, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 183, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[34], false);
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
                await ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 183, query1, 183, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 69, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[34], false);
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
                 ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 183, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 49, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int32integerArray1M.AssertModel(models[0],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[24],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelBatch(connection, 33, 131))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int32integerArray1M.AssertModel(models[0],_testData[6], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[7], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[8], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[29], false);
                        Int32integerArray1M.AssertModel(models[24],_testData[30], false);
                        Int32integerArray1M.AssertModel(models[25],_testData[31], false);
                        Int32integerArray1M.AssertModel(models[26],_testData[32], false);
                        Int32integerArray1M.AssertModel(models[27],_testData[33], false);
                        Int32integerArray1M.AssertModel(models[28],_testData[34], false);
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
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 142);
                var models = await ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                Int32integerArray1M.AssertModel(models[0],_testData[25], false);
                Int32integerArray1M.AssertModel(models[1],_testData[26], false);
                Int32integerArray1M.AssertModel(models[2],_testData[27], false);
                Int32integerArray1M.AssertModel(models[3],_testData[28], false);
                Int32integerArray1M.AssertModel(models[4],_testData[29], false);
                Int32integerArray1M.AssertModel(models[5],_testData[30], false);
                Int32integerArray1M.AssertModel(models[6],_testData[31], false);
                Int32integerArray1M.AssertModel(models[7],_testData[32], false);
                Int32integerArray1M.AssertModel(models[8],_testData[33], false);
                Int32integerArray1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ArrayintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models =  ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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


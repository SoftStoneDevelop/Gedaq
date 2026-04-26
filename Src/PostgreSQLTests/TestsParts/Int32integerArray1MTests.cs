

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
851542093,
410099504,
633484700,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 6,
    Value = 
new System.Int32[4]
{
562162030,
283951867,
1732374026,
811516033,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 6,
    Value = 
new System.Int32[3]
{
166717142,
130523060,
2021266827,
},
    NullableValue = 
new System.Int32[4]
{
766093786,
1506108464,
1681026353,
78953992,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 13,
    Value = 
new System.Int32[4]
{
1776948570,
790046441,
2101995858,
1690021998,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 15,
    Value = 
new System.Int32[4]
{
654746014,
1950730271,
97745859,
872263546,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 7,
    Value = 
new System.Int32[4]
{
1854677272,
529629986,
1019730312,
1176016223,
},
    NullableValue = 
new System.Int32[3]
{
1679775630,
866017575,
939040485,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 19,
    Value = 
new System.Int32[4]
{
1829975987,
974803355,
161646322,
447446047,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 24,
    Value = 
new System.Int32[4]
{
269598821,
925729465,
1875462136,
567500546,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 10,
    Value = 
new System.Int32[3]
{
101720665,
1739883118,
953148356,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 26,
    Value = 
new System.Int32[3]
{
795561318,
740932733,
427036437,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1347506427,
989057778,
1595119349,
},
},
            new Int32integerArray1M
{
    Id = 29,
    Value = 
new System.Int32[3]
{
1581526246,
413640514,
230434766,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 17,
    Value = 
new System.Int32[4]
{
1567936015,
2063823359,
100503108,
1294632532,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1025959253,
1559267562,
1753131112,
},
},
            new Int32integerArray1M
{
    Id = 33,
    Value = 
new System.Int32[4]
{
417411281,
1322766838,
1787645116,
1878654757,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 40,
    Value = 
new System.Int32[3]
{
1536423237,
1842147195,
328580378,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 26,
    Value = 
new System.Int32[3]
{
1805407675,
1378404637,
1524097633,
},
    NullableValue = 
new System.Int32[3]
{
620832515,
1361376623,
1959067169,
},
},
    NullableValue = 
new System.Int32[3]
{
174718656,
1922005525,
1397776970,
},
},
            new Int32integerArray1M
{
    Id = 45,
    Value = 
new System.Int32[3]
{
416164744,
783320316,
1548993933,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1932316292,
1187242872,
446941185,
},
},
            new Int32integerArray1M
{
    Id = 49,
    Value = 
new System.Int32[4]
{
1497904897,
1142806686,
877926245,
873539298,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 27,
    Value = 
new System.Int32[4]
{
930235671,
1652459189,
1436716837,
1274843635,
},
    NullableValue = 
new System.Int32[3]
{
1745472915,
316441315,
1276294807,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 51,
    Value = 
new System.Int32[4]
{
948397661,
1998323845,
1258279830,
408353885,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1023773670,
979992192,
592277619,
},
},
            new Int32integerArray1M
{
    Id = 52,
    Value = 
new System.Int32[3]
{
375315126,
446615017,
1029382839,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 28,
    Value = 
new System.Int32[4]
{
453173079,
1885377630,
1058427732,
978291089,
},
    NullableValue = 
new System.Int32[3]
{
458724874,
92736689,
2027039087,
},
},
    NullableValue = 
new System.Int32[4]
{
2030393743,
933687912,
571169801,
439407513,
},
},
            new Int32integerArray1M
{
    Id = 60,
    Value = 
new System.Int32[3]
{
1624481292,
2120894454,
1379110784,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 69,
    Value = 
new System.Int32[3]
{
906030262,
483924938,
486059386,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 29,
    Value = 
new System.Int32[3]
{
902429708,
1942338183,
1523811237,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 70,
    Value = 
new System.Int32[4]
{
969550762,
1605334388,
400100896,
1829107243,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 75,
    Value = 
new System.Int32[4]
{
310180754,
1631640599,
650412637,
1776543232,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 33,
    Value = 
new System.Int32[3]
{
1610123109,
1818908831,
1733868335,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
515909430,
1737602321,
1171777641,
1700644329,
},
},
            new Int32integerArray1M
{
    Id = 84,
    Value = 
new System.Int32[4]
{
1987053916,
833629134,
2006889212,
2016598861,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1329837548,
1608756047,
1447887598,
},
},
            new Int32integerArray1M
{
    Id = 85,
    Value = 
new System.Int32[3]
{
2002992494,
1205169798,
782535440,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 35,
    Value = 
new System.Int32[4]
{
2072414580,
497100571,
917143389,
866672141,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 87,
    Value = 
new System.Int32[3]
{
1683482509,
42708079,
1855810625,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 94,
    Value = 
new System.Int32[3]
{
1076778994,
747958134,
710537648,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 41,
    Value = 
new System.Int32[4]
{
1009708516,
742750028,
1758855547,
1195756968,
},
    NullableValue = 
new System.Int32[3]
{
618948390,
745710679,
240257514,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 95,
    Value = 
new System.Int32[3]
{
1169701454,
1371014089,
741819651,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 101,
    Value = 
new System.Int32[4]
{
2021987979,
691365259,
1971440765,
926726811,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 47,
    Value = 
new System.Int32[3]
{
53096871,
1011751416,
667226763,
},
    NullableValue = 
new System.Int32[4]
{
1718786875,
1901071389,
1356975960,
464451931,
},
},
    NullableValue = 
new System.Int32[3]
{
1328373768,
451458052,
1344972618,
},
},
            new Int32integerArray1M
{
    Id = 108,
    Value = 
new System.Int32[3]
{
1124926757,
319577306,
1713685923,
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
27651698,
1272542451,
247908415,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 53,
    Value = 
new System.Int32[4]
{
433935072,
1014556671,
1375384283,
1101403547,
},
    NullableValue = 
new System.Int32[4]
{
1292988798,
583645043,
1127224562,
655056395,
},
},
    NullableValue = 
new System.Int32[3]
{
770762794,
1592999788,
1773480027,
},
},
            new Int32integerArray1M
{
    Id = 117,
    Value = 
new System.Int32[3]
{
1404985380,
2032803048,
2023140597,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 124,
    Value = 
new System.Int32[3]
{
1458299281,
830813125,
822242094,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 59,
    Value = 
new System.Int32[4]
{
1559987539,
555583358,
1592211147,
1265985103,
},
    NullableValue = 
new System.Int32[3]
{
1454014803,
498314099,
104163644,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 130,
    Value = 
new System.Int32[4]
{
1170834047,
1161589989,
1554494335,
982926298,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
426535977,
1671844669,
82280606,
},
},
            new Int32integerArray1M
{
    Id = 135,
    Value = 
new System.Int32[3]
{
1874928410,
79092838,
1752792577,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 66,
    Value = 
new System.Int32[4]
{
1097159866,
163425714,
1150252444,
836656132,
},
    NullableValue = 
new System.Int32[3]
{
1831099527,
388170287,
149290371,
},
},
    NullableValue = 
new System.Int32[3]
{
800893753,
1343436560,
1715208181,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1347506427,
989057778,
1595119349,
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

                    nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1025959253,
1559267562,
1753131112,
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
174718656,
1922005525,
1397776970,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1932316292,
1187242872,
446941185,
}));
                nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatInt32integerArray1M.AssertModel(models[0],_testData[3], false);FlatInt32integerArray1M.AssertModel(models[1],_testData[4], false);FlatInt32integerArray1M.AssertModel(models[2],_testData[5], false);FlatInt32integerArray1M.AssertModel(models[3],_testData[6], false);FlatInt32integerArray1M.AssertModel(models[4],_testData[7], false);FlatInt32integerArray1M.AssertModel(models[5],_testData[8], false);FlatInt32integerArray1M.AssertModel(models[6],_testData[9], false);FlatInt32integerArray1M.AssertModel(models[7],_testData[10], false);FlatInt32integerArray1M.AssertModel(models[8],_testData[11], false);FlatInt32integerArray1M.AssertModel(models[9],_testData[12], false);FlatInt32integerArray1M.AssertModel(models[10],_testData[13], false);FlatInt32integerArray1M.AssertModel(models[11],_testData[14], false);FlatInt32integerArray1M.AssertModel(models[12],_testData[15], false);FlatInt32integerArray1M.AssertModel(models[13],_testData[16], false);FlatInt32integerArray1M.AssertModel(models[14],_testData[17], false);FlatInt32integerArray1M.AssertModel(models[15],_testData[18], false);FlatInt32integerArray1M.AssertModel(models[16],_testData[19], false);FlatInt32integerArray1M.AssertModel(models[17],_testData[20], false);FlatInt32integerArray1M.AssertModel(models[18],_testData[21], false);FlatInt32integerArray1M.AssertModel(models[19],_testData[22], false);FlatInt32integerArray1M.AssertModel(models[20],_testData[23], false);FlatInt32integerArray1M.AssertModel(models[21],_testData[24], false);FlatInt32integerArray1M.AssertModel(models[22],_testData[25], false);FlatInt32integerArray1M.AssertModel(models[23],_testData[26], false);FlatInt32integerArray1M.AssertModel(models[24],_testData[27], false);FlatInt32integerArray1M.AssertModel(models[25],_testData[28], false);FlatInt32integerArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatInt32integerArray1M.AssertModel(models[0],_testData[7], false);FlatInt32integerArray1M.AssertModel(models[1],_testData[8], false);FlatInt32integerArray1M.AssertModel(models[2],_testData[9], false);FlatInt32integerArray1M.AssertModel(models[3],_testData[10], false);FlatInt32integerArray1M.AssertModel(models[4],_testData[11], false);FlatInt32integerArray1M.AssertModel(models[5],_testData[12], false);FlatInt32integerArray1M.AssertModel(models[6],_testData[13], false);FlatInt32integerArray1M.AssertModel(models[7],_testData[14], false);FlatInt32integerArray1M.AssertModel(models[8],_testData[15], false);FlatInt32integerArray1M.AssertModel(models[9],_testData[16], false);FlatInt32integerArray1M.AssertModel(models[10],_testData[17], false);FlatInt32integerArray1M.AssertModel(models[11],_testData[18], false);FlatInt32integerArray1M.AssertModel(models[12],_testData[19], false);FlatInt32integerArray1M.AssertModel(models[13],_testData[20], false);FlatInt32integerArray1M.AssertModel(models[14],_testData[21], false);FlatInt32integerArray1M.AssertModel(models[15],_testData[22], false);FlatInt32integerArray1M.AssertModel(models[16],_testData[23], false);FlatInt32integerArray1M.AssertModel(models[17],_testData[24], false);FlatInt32integerArray1M.AssertModel(models[18],_testData[25], false);FlatInt32integerArray1M.AssertModel(models[19],_testData[26], false);FlatInt32integerArray1M.AssertModel(models[20],_testData[27], false);FlatInt32integerArray1M.AssertModel(models[21],_testData[28], false);FlatInt32integerArray1M.AssertModel(models[22],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatInt32integerArray1M.AssertModel(models[0],_testData[9], false);FlatInt32integerArray1M.AssertModel(models[1],_testData[10], false);FlatInt32integerArray1M.AssertModel(models[2],_testData[11], false);FlatInt32integerArray1M.AssertModel(models[3],_testData[12], false);FlatInt32integerArray1M.AssertModel(models[4],_testData[13], false);FlatInt32integerArray1M.AssertModel(models[5],_testData[14], false);FlatInt32integerArray1M.AssertModel(models[6],_testData[15], false);FlatInt32integerArray1M.AssertModel(models[7],_testData[16], false);FlatInt32integerArray1M.AssertModel(models[8],_testData[17], false);FlatInt32integerArray1M.AssertModel(models[9],_testData[18], false);FlatInt32integerArray1M.AssertModel(models[10],_testData[19], false);FlatInt32integerArray1M.AssertModel(models[11],_testData[20], false);FlatInt32integerArray1M.AssertModel(models[12],_testData[21], false);FlatInt32integerArray1M.AssertModel(models[13],_testData[22], false);FlatInt32integerArray1M.AssertModel(models[14],_testData[23], false);FlatInt32integerArray1M.AssertModel(models[15],_testData[24], false);FlatInt32integerArray1M.AssertModel(models[16],_testData[25], false);FlatInt32integerArray1M.AssertModel(models[17],_testData[26], false);FlatInt32integerArray1M.AssertModel(models[18],_testData[27], false);FlatInt32integerArray1M.AssertModel(models[19],_testData[28], false);FlatInt32integerArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatInt32integerArray1M.AssertModel(models[0],_testData[5], false);FlatInt32integerArray1M.AssertModel(models[1],_testData[6], false);FlatInt32integerArray1M.AssertModel(models[2],_testData[7], false);FlatInt32integerArray1M.AssertModel(models[3],_testData[8], false);FlatInt32integerArray1M.AssertModel(models[4],_testData[9], false);FlatInt32integerArray1M.AssertModel(models[5],_testData[10], false);FlatInt32integerArray1M.AssertModel(models[6],_testData[11], false);FlatInt32integerArray1M.AssertModel(models[7],_testData[12], false);FlatInt32integerArray1M.AssertModel(models[8],_testData[13], false);FlatInt32integerArray1M.AssertModel(models[9],_testData[14], false);FlatInt32integerArray1M.AssertModel(models[10],_testData[15], false);FlatInt32integerArray1M.AssertModel(models[11],_testData[16], false);FlatInt32integerArray1M.AssertModel(models[12],_testData[17], false);FlatInt32integerArray1M.AssertModel(models[13],_testData[18], false);FlatInt32integerArray1M.AssertModel(models[14],_testData[19], false);FlatInt32integerArray1M.AssertModel(models[15],_testData[20], false);FlatInt32integerArray1M.AssertModel(models[16],_testData[21], false);FlatInt32integerArray1M.AssertModel(models[17],_testData[22], false);FlatInt32integerArray1M.AssertModel(models[18],_testData[23], false);FlatInt32integerArray1M.AssertModel(models[19],_testData[24], false);FlatInt32integerArray1M.AssertModel(models[20],_testData[25], false);FlatInt32integerArray1M.AssertModel(models[21],_testData[26], false);FlatInt32integerArray1M.AssertModel(models[22],_testData[27], false);FlatInt32integerArray1M.AssertModel(models[23],_testData[28], false);FlatInt32integerArray1M.AssertModel(models[24],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((IInt32ArrayintegerArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
Int32integerArray1M.AssertModel(models[0],_testData[17], false);Int32integerArray1M.AssertModel(models[1],_testData[18], false);Int32integerArray1M.AssertModel(models[2],_testData[19], false);Int32integerArray1M.AssertModel(models[3],_testData[20], false);Int32integerArray1M.AssertModel(models[4],_testData[21], false);Int32integerArray1M.AssertModel(models[5],_testData[22], false);Int32integerArray1M.AssertModel(models[6],_testData[23], false);Int32integerArray1M.AssertModel(models[7],_testData[24], false);Int32integerArray1M.AssertModel(models[8],_testData[25], false);Int32integerArray1M.AssertModel(models[9],_testData[26], false);Int32integerArray1M.AssertModel(models[10],_testData[27], false);Int32integerArray1M.AssertModel(models[11],_testData[28], false);Int32integerArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Int32integerArray1M.AssertModel(models[0],_testData[19], false);Int32integerArray1M.AssertModel(models[1],_testData[20], false);Int32integerArray1M.AssertModel(models[2],_testData[21], false);Int32integerArray1M.AssertModel(models[3],_testData[22], false);Int32integerArray1M.AssertModel(models[4],_testData[23], false);Int32integerArray1M.AssertModel(models[5],_testData[24], false);Int32integerArray1M.AssertModel(models[6],_testData[25], false);Int32integerArray1M.AssertModel(models[7],_testData[26], false);Int32integerArray1M.AssertModel(models[8],_testData[27], false);Int32integerArray1M.AssertModel(models[9],_testData[28], false);Int32integerArray1M.AssertModel(models[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
Int32integerArray1M.AssertModel(models[0],_testData[5], false);Int32integerArray1M.AssertModel(models[1],_testData[6], false);Int32integerArray1M.AssertModel(models[2],_testData[7], false);Int32integerArray1M.AssertModel(models[3],_testData[8], false);Int32integerArray1M.AssertModel(models[4],_testData[9], false);Int32integerArray1M.AssertModel(models[5],_testData[10], false);Int32integerArray1M.AssertModel(models[6],_testData[11], false);Int32integerArray1M.AssertModel(models[7],_testData[12], false);Int32integerArray1M.AssertModel(models[8],_testData[13], false);Int32integerArray1M.AssertModel(models[9],_testData[14], false);Int32integerArray1M.AssertModel(models[10],_testData[15], false);Int32integerArray1M.AssertModel(models[11],_testData[16], false);Int32integerArray1M.AssertModel(models[12],_testData[17], false);Int32integerArray1M.AssertModel(models[13],_testData[18], false);Int32integerArray1M.AssertModel(models[14],_testData[19], false);Int32integerArray1M.AssertModel(models[15],_testData[20], false);Int32integerArray1M.AssertModel(models[16],_testData[21], false);Int32integerArray1M.AssertModel(models[17],_testData[22], false);Int32integerArray1M.AssertModel(models[18],_testData[23], false);Int32integerArray1M.AssertModel(models[19],_testData[24], false);Int32integerArray1M.AssertModel(models[20],_testData[25], false);Int32integerArray1M.AssertModel(models[21],_testData[26], false);Int32integerArray1M.AssertModel(models[22],_testData[27], false);Int32integerArray1M.AssertModel(models[23],_testData[28], false);Int32integerArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
Int32integerArray1M.AssertModel(models[0],_testData[3], false);Int32integerArray1M.AssertModel(models[1],_testData[4], false);Int32integerArray1M.AssertModel(models[2],_testData[5], false);Int32integerArray1M.AssertModel(models[3],_testData[6], false);Int32integerArray1M.AssertModel(models[4],_testData[7], false);Int32integerArray1M.AssertModel(models[5],_testData[8], false);Int32integerArray1M.AssertModel(models[6],_testData[9], false);Int32integerArray1M.AssertModel(models[7],_testData[10], false);Int32integerArray1M.AssertModel(models[8],_testData[11], false);Int32integerArray1M.AssertModel(models[9],_testData[12], false);Int32integerArray1M.AssertModel(models[10],_testData[13], false);Int32integerArray1M.AssertModel(models[11],_testData[14], false);Int32integerArray1M.AssertModel(models[12],_testData[15], false);Int32integerArray1M.AssertModel(models[13],_testData[16], false);Int32integerArray1M.AssertModel(models[14],_testData[17], false);Int32integerArray1M.AssertModel(models[15],_testData[18], false);Int32integerArray1M.AssertModel(models[16],_testData[19], false);Int32integerArray1M.AssertModel(models[17],_testData[20], false);Int32integerArray1M.AssertModel(models[18],_testData[21], false);Int32integerArray1M.AssertModel(models[19],_testData[22], false);Int32integerArray1M.AssertModel(models[20],_testData[23], false);Int32integerArray1M.AssertModel(models[21],_testData[24], false);Int32integerArray1M.AssertModel(models[22],_testData[25], false);Int32integerArray1M.AssertModel(models[23],_testData[26], false);Int32integerArray1M.AssertModel(models[24],_testData[27], false);Int32integerArray1M.AssertModel(models[25],_testData[28], false);Int32integerArray1M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 60, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatInt32integerArray1M.AssertModel(models[0],_testData[15], false);FlatInt32integerArray1M.AssertModel(models[1],_testData[16], false);FlatInt32integerArray1M.AssertModel(models[2],_testData[17], false);FlatInt32integerArray1M.AssertModel(models[3],_testData[18], false);FlatInt32integerArray1M.AssertModel(models[4],_testData[19], false);FlatInt32integerArray1M.AssertModel(models[5],_testData[20], false);FlatInt32integerArray1M.AssertModel(models[6],_testData[21], false);FlatInt32integerArray1M.AssertModel(models[7],_testData[22], false);FlatInt32integerArray1M.AssertModel(models[8],_testData[23], false);FlatInt32integerArray1M.AssertModel(models[9],_testData[24], false);FlatInt32integerArray1M.AssertModel(models[10],_testData[25], false);FlatInt32integerArray1M.AssertModel(models[11],_testData[26], false);FlatInt32integerArray1M.AssertModel(models[12],_testData[27], false);FlatInt32integerArray1M.AssertModel(models[13],_testData[28], false);FlatInt32integerArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatInt32integerArray1M.AssertModel(models[0],_testData[11], false);FlatInt32integerArray1M.AssertModel(models[1],_testData[12], false);FlatInt32integerArray1M.AssertModel(models[2],_testData[13], false);FlatInt32integerArray1M.AssertModel(models[3],_testData[14], false);FlatInt32integerArray1M.AssertModel(models[4],_testData[15], false);FlatInt32integerArray1M.AssertModel(models[5],_testData[16], false);FlatInt32integerArray1M.AssertModel(models[6],_testData[17], false);FlatInt32integerArray1M.AssertModel(models[7],_testData[18], false);FlatInt32integerArray1M.AssertModel(models[8],_testData[19], false);FlatInt32integerArray1M.AssertModel(models[9],_testData[20], false);FlatInt32integerArray1M.AssertModel(models[10],_testData[21], false);FlatInt32integerArray1M.AssertModel(models[11],_testData[22], false);FlatInt32integerArray1M.AssertModel(models[12],_testData[23], false);FlatInt32integerArray1M.AssertModel(models[13],_testData[24], false);FlatInt32integerArray1M.AssertModel(models[14],_testData[25], false);FlatInt32integerArray1M.AssertModel(models[15],_testData[26], false);FlatInt32integerArray1M.AssertModel(models[16],_testData[27], false);FlatInt32integerArray1M.AssertModel(models[17],_testData[28], false);FlatInt32integerArray1M.AssertModel(models[18],_testData[29], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatInt32integerArray1M.AssertModel(models[0],_testData[16], false);FlatInt32integerArray1M.AssertModel(models[1],_testData[17], false);FlatInt32integerArray1M.AssertModel(models[2],_testData[18], false);FlatInt32integerArray1M.AssertModel(models[3],_testData[19], false);FlatInt32integerArray1M.AssertModel(models[4],_testData[20], false);FlatInt32integerArray1M.AssertModel(models[5],_testData[21], false);FlatInt32integerArray1M.AssertModel(models[6],_testData[22], false);FlatInt32integerArray1M.AssertModel(models[7],_testData[23], false);FlatInt32integerArray1M.AssertModel(models[8],_testData[24], false);FlatInt32integerArray1M.AssertModel(models[9],_testData[25], false);FlatInt32integerArray1M.AssertModel(models[10],_testData[26], false);FlatInt32integerArray1M.AssertModel(models[11],_testData[27], false);FlatInt32integerArray1M.AssertModel(models[12],_testData[28], false);FlatInt32integerArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatInt32integerArray1M.AssertModel(models[0],_testData[14], false);FlatInt32integerArray1M.AssertModel(models[1],_testData[15], false);FlatInt32integerArray1M.AssertModel(models[2],_testData[16], false);FlatInt32integerArray1M.AssertModel(models[3],_testData[17], false);FlatInt32integerArray1M.AssertModel(models[4],_testData[18], false);FlatInt32integerArray1M.AssertModel(models[5],_testData[19], false);FlatInt32integerArray1M.AssertModel(models[6],_testData[20], false);FlatInt32integerArray1M.AssertModel(models[7],_testData[21], false);FlatInt32integerArray1M.AssertModel(models[8],_testData[22], false);FlatInt32integerArray1M.AssertModel(models[9],_testData[23], false);FlatInt32integerArray1M.AssertModel(models[10],_testData[24], false);FlatInt32integerArray1M.AssertModel(models[11],_testData[25], false);FlatInt32integerArray1M.AssertModel(models[12],_testData[26], false);FlatInt32integerArray1M.AssertModel(models[13],_testData[27], false);FlatInt32integerArray1M.AssertModel(models[14],_testData[28], false);FlatInt32integerArray1M.AssertModel(models[15],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IInt32ArrayintegerArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSelectModelBatchAsync(connection, 26, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Int32integerArray1M.AssertModel(models[0],_testData[7], false);Int32integerArray1M.AssertModel(models[1],_testData[8], false);Int32integerArray1M.AssertModel(models[2],_testData[9], false);Int32integerArray1M.AssertModel(models[3],_testData[10], false);Int32integerArray1M.AssertModel(models[4],_testData[11], false);Int32integerArray1M.AssertModel(models[5],_testData[12], false);Int32integerArray1M.AssertModel(models[6],_testData[13], false);Int32integerArray1M.AssertModel(models[7],_testData[14], false);Int32integerArray1M.AssertModel(models[8],_testData[15], false);Int32integerArray1M.AssertModel(models[9],_testData[16], false);Int32integerArray1M.AssertModel(models[10],_testData[17], false);Int32integerArray1M.AssertModel(models[11],_testData[18], false);Int32integerArray1M.AssertModel(models[12],_testData[19], false);Int32integerArray1M.AssertModel(models[13],_testData[20], false);Int32integerArray1M.AssertModel(models[14],_testData[21], false);Int32integerArray1M.AssertModel(models[15],_testData[22], false);Int32integerArray1M.AssertModel(models[16],_testData[23], false);Int32integerArray1M.AssertModel(models[17],_testData[24], false);Int32integerArray1M.AssertModel(models[18],_testData[25], false);Int32integerArray1M.AssertModel(models[19],_testData[26], false);Int32integerArray1M.AssertModel(models[20],_testData[27], false);Int32integerArray1M.AssertModel(models[21],_testData[28], false);Int32integerArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Int32integerArray1M.AssertModel(models[0],_testData[6], false);Int32integerArray1M.AssertModel(models[1],_testData[7], false);Int32integerArray1M.AssertModel(models[2],_testData[8], false);Int32integerArray1M.AssertModel(models[3],_testData[9], false);Int32integerArray1M.AssertModel(models[4],_testData[10], false);Int32integerArray1M.AssertModel(models[5],_testData[11], false);Int32integerArray1M.AssertModel(models[6],_testData[12], false);Int32integerArray1M.AssertModel(models[7],_testData[13], false);Int32integerArray1M.AssertModel(models[8],_testData[14], false);Int32integerArray1M.AssertModel(models[9],_testData[15], false);Int32integerArray1M.AssertModel(models[10],_testData[16], false);Int32integerArray1M.AssertModel(models[11],_testData[17], false);Int32integerArray1M.AssertModel(models[12],_testData[18], false);Int32integerArray1M.AssertModel(models[13],_testData[19], false);Int32integerArray1M.AssertModel(models[14],_testData[20], false);Int32integerArray1M.AssertModel(models[15],_testData[21], false);Int32integerArray1M.AssertModel(models[16],_testData[22], false);Int32integerArray1M.AssertModel(models[17],_testData[23], false);Int32integerArray1M.AssertModel(models[18],_testData[24], false);Int32integerArray1M.AssertModel(models[19],_testData[25], false);Int32integerArray1M.AssertModel(models[20],_testData[26], false);Int32integerArray1M.AssertModel(models[21],_testData[27], false);Int32integerArray1M.AssertModel(models[22],_testData[28], false);Int32integerArray1M.AssertModel(models[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSelectModelBatch(connection, 24, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Int32integerArray1M.AssertModel(models[0],_testData[6], false);Int32integerArray1M.AssertModel(models[1],_testData[7], false);Int32integerArray1M.AssertModel(models[2],_testData[8], false);Int32integerArray1M.AssertModel(models[3],_testData[9], false);Int32integerArray1M.AssertModel(models[4],_testData[10], false);Int32integerArray1M.AssertModel(models[5],_testData[11], false);Int32integerArray1M.AssertModel(models[6],_testData[12], false);Int32integerArray1M.AssertModel(models[7],_testData[13], false);Int32integerArray1M.AssertModel(models[8],_testData[14], false);Int32integerArray1M.AssertModel(models[9],_testData[15], false);Int32integerArray1M.AssertModel(models[10],_testData[16], false);Int32integerArray1M.AssertModel(models[11],_testData[17], false);Int32integerArray1M.AssertModel(models[12],_testData[18], false);Int32integerArray1M.AssertModel(models[13],_testData[19], false);Int32integerArray1M.AssertModel(models[14],_testData[20], false);Int32integerArray1M.AssertModel(models[15],_testData[21], false);Int32integerArray1M.AssertModel(models[16],_testData[22], false);Int32integerArray1M.AssertModel(models[17],_testData[23], false);Int32integerArray1M.AssertModel(models[18],_testData[24], false);Int32integerArray1M.AssertModel(models[19],_testData[25], false);Int32integerArray1M.AssertModel(models[20],_testData[26], false);Int32integerArray1M.AssertModel(models[21],_testData[27], false);Int32integerArray1M.AssertModel(models[22],_testData[28], false);Int32integerArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Int32integerArray1M.AssertModel(models[0],_testData[19], false);Int32integerArray1M.AssertModel(models[1],_testData[20], false);Int32integerArray1M.AssertModel(models[2],_testData[21], false);Int32integerArray1M.AssertModel(models[3],_testData[22], false);Int32integerArray1M.AssertModel(models[4],_testData[23], false);Int32integerArray1M.AssertModel(models[5],_testData[24], false);Int32integerArray1M.AssertModel(models[6],_testData[25], false);Int32integerArray1M.AssertModel(models[7],_testData[26], false);Int32integerArray1M.AssertModel(models[8],_testData[27], false);Int32integerArray1M.AssertModel(models[9],_testData[28], false);Int32integerArray1M.AssertModel(models[10],_testData[29], false);
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
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Int32integerArray1M.AssertModel(models[0],_testData[10], false);Int32integerArray1M.AssertModel(models[1],_testData[11], false);Int32integerArray1M.AssertModel(models[2],_testData[12], false);Int32integerArray1M.AssertModel(models[3],_testData[13], false);Int32integerArray1M.AssertModel(models[4],_testData[14], false);Int32integerArray1M.AssertModel(models[5],_testData[15], false);Int32integerArray1M.AssertModel(models[6],_testData[16], false);Int32integerArray1M.AssertModel(models[7],_testData[17], false);Int32integerArray1M.AssertModel(models[8],_testData[18], false);Int32integerArray1M.AssertModel(models[9],_testData[19], false);Int32integerArray1M.AssertModel(models[10],_testData[20], false);Int32integerArray1M.AssertModel(models[11],_testData[21], false);Int32integerArray1M.AssertModel(models[12],_testData[22], false);Int32integerArray1M.AssertModel(models[13],_testData[23], false);Int32integerArray1M.AssertModel(models[14],_testData[24], false);Int32integerArray1M.AssertModel(models[15],_testData[25], false);Int32integerArray1M.AssertModel(models[16],_testData[26], false);Int32integerArray1M.AssertModel(models[17],_testData[27], false);Int32integerArray1M.AssertModel(models[18],_testData[28], false);Int32integerArray1M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ArrayintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models =  ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
Int32integerArray1M.AssertModel(models[0],_testData[2], false);Int32integerArray1M.AssertModel(models[1],_testData[3], false);Int32integerArray1M.AssertModel(models[2],_testData[4], false);Int32integerArray1M.AssertModel(models[3],_testData[5], false);Int32integerArray1M.AssertModel(models[4],_testData[6], false);Int32integerArray1M.AssertModel(models[5],_testData[7], false);Int32integerArray1M.AssertModel(models[6],_testData[8], false);Int32integerArray1M.AssertModel(models[7],_testData[9], false);Int32integerArray1M.AssertModel(models[8],_testData[10], false);Int32integerArray1M.AssertModel(models[9],_testData[11], false);Int32integerArray1M.AssertModel(models[10],_testData[12], false);Int32integerArray1M.AssertModel(models[11],_testData[13], false);Int32integerArray1M.AssertModel(models[12],_testData[14], false);Int32integerArray1M.AssertModel(models[13],_testData[15], false);Int32integerArray1M.AssertModel(models[14],_testData[16], false);Int32integerArray1M.AssertModel(models[15],_testData[17], false);Int32integerArray1M.AssertModel(models[16],_testData[18], false);Int32integerArray1M.AssertModel(models[17],_testData[19], false);Int32integerArray1M.AssertModel(models[18],_testData[20], false);Int32integerArray1M.AssertModel(models[19],_testData[21], false);Int32integerArray1M.AssertModel(models[20],_testData[22], false);Int32integerArray1M.AssertModel(models[21],_testData[23], false);Int32integerArray1M.AssertModel(models[22],_testData[24], false);Int32integerArray1M.AssertModel(models[23],_testData[25], false);Int32integerArray1M.AssertModel(models[24],_testData[26], false);Int32integerArray1M.AssertModel(models[25],_testData[27], false);Int32integerArray1M.AssertModel(models[26],_testData[28], false);Int32integerArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MI)],
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
FROM public.binary_int32integerarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integerArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt32ArrayintegerArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32ArrayintegerArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(actual, expect, false);
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
                await ((IInt32ArrayintegerArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt32ArrayintegerArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(Int32integerArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integerArray1M>(15);

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
                ((IInt32ArrayintegerArray)this).ImportModel(connection, importCollection);
                var models = ((IInt32ArrayintegerArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int32integerArray1M.AssertModel(models[0],_testData[0], false);
                Int32integerArray1M.AssertModel(models[1],_testData[1], false);
                Int32integerArray1M.AssertModel(models[2],_testData[2], false);
                Int32integerArray1M.AssertModel(models[3],_testData[3], false);
                Int32integerArray1M.AssertModel(models[4],_testData[4], false);
                Int32integerArray1M.AssertModel(models[5],_testData[5], false);
                Int32integerArray1M.AssertModel(models[6],_testData[6], false);
                Int32integerArray1M.AssertModel(models[7],_testData[7], false);
                Int32integerArray1M.AssertModel(models[8],_testData[8], false);
                Int32integerArray1M.AssertModel(models[9],_testData[9], false);
                Int32integerArray1M.AssertModel(models[10],_testData[10], false);
                Int32integerArray1M.AssertModel(models[11],_testData[11], false);
                Int32integerArray1M.AssertModel(models[12],_testData[12], false);
                Int32integerArray1M.AssertModel(models[13],_testData[13], false);
                Int32integerArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt32ArrayintegerArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt32ArrayintegerArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int32integerArray1M.AssertModel(models[0],_testData[0], false);
                Int32integerArray1M.AssertModel(models[1],_testData[1], false);
                Int32integerArray1M.AssertModel(models[2],_testData[2], false);
                Int32integerArray1M.AssertModel(models[3],_testData[3], false);
                Int32integerArray1M.AssertModel(models[4],_testData[4], false);
                Int32integerArray1M.AssertModel(models[5],_testData[5], false);
                Int32integerArray1M.AssertModel(models[6],_testData[6], false);
                Int32integerArray1M.AssertModel(models[7],_testData[7], false);
                Int32integerArray1M.AssertModel(models[8],_testData[8], false);
                Int32integerArray1M.AssertModel(models[9],_testData[9], false);
                Int32integerArray1M.AssertModel(models[10],_testData[10], false);
                Int32integerArray1M.AssertModel(models[11],_testData[11], false);
                Int32integerArray1M.AssertModel(models[12],_testData[12], false);
                Int32integerArray1M.AssertModel(models[13],_testData[13], false);
                Int32integerArray1M.AssertModel(models[14],_testData[14], false);
                Int32integerArray1M.AssertModel(models[15],_testData[15], false);
                Int32integerArray1M.AssertModel(models[16],_testData[16], false);
                Int32integerArray1M.AssertModel(models[17],_testData[17], false);
                Int32integerArray1M.AssertModel(models[18],_testData[18], false);
                Int32integerArray1M.AssertModel(models[19],_testData[19], false);
                Int32integerArray1M.AssertModel(models[20],_testData[20], false);
                Int32integerArray1M.AssertModel(models[21],_testData[21], false);
                Int32integerArray1M.AssertModel(models[22],_testData[22], false);
                Int32integerArray1M.AssertModel(models[23],_testData[23], false);
                Int32integerArray1M.AssertModel(models[24],_testData[24], false);
                Int32integerArray1M.AssertModel(models[25],_testData[25], false);
                Int32integerArray1M.AssertModel(models[26],_testData[26], false);
                Int32integerArray1M.AssertModel(models[27],_testData[27], false);
                Int32integerArray1M.AssertModel(models[28],_testData[28], false);
                Int32integerArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_int32integerarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32ArrayintegerArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ArrayintegerArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}




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
1529147182,
659551755,
172018222,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1746268571,
1353236359,
2078559518,
},
},
            new Int32integerArray1M
{
    Id = 15,
    Value = 
new System.Int32[3]
{
16194103,
137460496,
147086515,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 3,
    Value = 
new System.Int32[4]
{
739570513,
1892730138,
1808247939,
652536862,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
461652499,
1597411396,
122598791,
1833400743,
},
},
            new Int32integerArray1M
{
    Id = 24,
    Value = 
new System.Int32[4]
{
605664205,
820539855,
2062346881,
1408293939,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
2053647611,
2079827389,
787390285,
},
},
            new Int32integerArray1M
{
    Id = 30,
    Value = 
new System.Int32[4]
{
1034941376,
1844684028,
134731164,
1637360459,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 5,
    Value = 
new System.Int32[3]
{
110983160,
1178856803,
1909671453,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 39,
    Value = 
new System.Int32[3]
{
877950068,
1810848815,
1724817876,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 45,
    Value = 
new System.Int32[3]
{
1254059865,
268854640,
122730984,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 10,
    Value = 
new System.Int32[4]
{
1046126000,
2068954431,
1659033177,
574416952,
},
    NullableValue = 
new System.Int32[4]
{
187231028,
597575716,
741305859,
1239065491,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 54,
    Value = 
new System.Int32[3]
{
1882368467,
1586241743,
1515773828,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1775017231,
97361135,
138290509,
483199746,
},
},
            new Int32integerArray1M
{
    Id = 63,
    Value = 
new System.Int32[3]
{
664594540,
1801884388,
1480868917,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 15,
    Value = 
new System.Int32[4]
{
923447013,
580037223,
135768665,
1390652952,
},
    NullableValue = 
new System.Int32[4]
{
266853547,
2091065406,
33222172,
430039429,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 68,
    Value = 
new System.Int32[4]
{
116487726,
1452962140,
232891709,
1173039533,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 74,
    Value = 
new System.Int32[3]
{
1136670165,
1886245191,
361539163,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 16,
    Value = 
new System.Int32[4]
{
1333364519,
1223840041,
1949807708,
1010795317,
},
    NullableValue = 
new System.Int32[4]
{
1577287472,
613138061,
1346403264,
1832378661,
},
},
    NullableValue = 
new System.Int32[4]
{
322063631,
1689684877,
1519064460,
1938159567,
},
},
            new Int32integerArray1M
{
    Id = 82,
    Value = 
new System.Int32[3]
{
1121158947,
1580454484,
285585456,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 89,
    Value = 
new System.Int32[4]
{
1319609400,
1444770212,
817930319,
1126060793,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 17,
    Value = 
new System.Int32[4]
{
1521069925,
143808662,
1962168154,
1285818769,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
31109149,
1402692926,
1777087807,
529309458,
},
},
            new Int32integerArray1M
{
    Id = 94,
    Value = 
new System.Int32[4]
{
1334676690,
1809731822,
33570808,
2098473556,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
944571104,
298097409,
1825121361,
1318745860,
},
},
            new Int32integerArray1M
{
    Id = 97,
    Value = 
new System.Int32[3]
{
871667095,
2112470236,
1459063238,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 23,
    Value = 
new System.Int32[4]
{
1326528782,
1531051435,
1377425031,
859492142,
},
    NullableValue = 
new System.Int32[4]
{
1063178308,
1392098963,
958647929,
334177103,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 105,
    Value = 
new System.Int32[3]
{
1689682463,
2051958997,
1579252710,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 109,
    Value = 
new System.Int32[3]
{
870564784,
1330212391,
619407640,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 32,
    Value = 
new System.Int32[4]
{
29433478,
342208847,
2081981587,
1851782331,
},
    NullableValue = 
new System.Int32[4]
{
2056340233,
1463830095,
2109851277,
1576735382,
},
},
    NullableValue = 
new System.Int32[4]
{
1857536374,
287431389,
1555545866,
1104111823,
},
},
            new Int32integerArray1M
{
    Id = 116,
    Value = 
new System.Int32[4]
{
1250200885,
2008452483,
577293230,
2142444631,
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
1242713348,
1661841779,
1828177914,
1993311860,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 41,
    Value = 
new System.Int32[4]
{
1407813333,
1279797713,
1704515464,
896329648,
},
    NullableValue = 
new System.Int32[4]
{
342107097,
15923131,
873745472,
577128411,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 128,
    Value = 
new System.Int32[3]
{
158362528,
932565638,
1231290397,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1445868338,
1001458307,
1309833352,
914613125,
},
},
            new Int32integerArray1M
{
    Id = 135,
    Value = 
new System.Int32[3]
{
1749784085,
1836996616,
299122449,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 46,
    Value = 
new System.Int32[4]
{
1732543991,
1950983146,
730100862,
2061897152,
},
    NullableValue = 
new System.Int32[4]
{
359355038,
702770468,
1069849218,
1543855257,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 144,
    Value = 
new System.Int32[3]
{
1894009741,
1158533068,
959559439,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 145,
    Value = 
new System.Int32[4]
{
974337690,
320055861,
1055225079,
305689199,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 50,
    Value = 
new System.Int32[3]
{
310015405,
508897510,
522761322,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
1433738212,
316650746,
1651076112,
260842559,
},
},
            new Int32integerArray1M
{
    Id = 154,
    Value = 
new System.Int32[4]
{
1998403996,
509887586,
328064249,
1602882822,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 156,
    Value = 
new System.Int32[4]
{
320923685,
1898433825,
439293381,
478855157,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 55,
    Value = 
new System.Int32[4]
{
792398167,
1297403209,
34684947,
1610298269,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1092105927,
1350334681,
647374748,
},
},
            new Int32integerArray1M
{
    Id = 160,
    Value = 
new System.Int32[3]
{
136757466,
2125398295,
432330819,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 168,
    Value = 
new System.Int32[3]
{
41942432,
2050841784,
244895632,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 64,
    Value = 
new System.Int32[4]
{
1855756610,
1794494289,
337131673,
947872748,
},
    NullableValue = 
new System.Int32[3]
{
35124902,
861737160,
1922885649,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 175,
    Value = 
new System.Int32[3]
{
1855086488,
2045733215,
1848292306,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
485889807,
97086498,
1980908201,
},
},
            new Int32integerArray1M
{
    Id = 181,
    Value = 
new System.Int32[3]
{
1435452946,
1129822077,
2077391352,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 71,
    Value = 
new System.Int32[3]
{
695531642,
1861464460,
77605131,
},
    NullableValue = 
new System.Int32[3]
{
2015205018,
1800267849,
2105894900,
},
},
    NullableValue = 
new System.Int32[3]
{
1048146299,
1290047043,
1061810281,
},
},
            new Int32integerArray1M
{
    Id = 182,
    Value = 
new System.Int32[4]
{
953949613,
2141258567,
1964751876,
253560292,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
953067368,
1423751900,
1143601110,
},
},
            new Int32integerArray1M
{
    Id = 184,
    Value = 
new System.Int32[3]
{
1359380956,
1686664172,
291405358,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 74,
    Value = 
new System.Int32[3]
{
814301093,
1073681372,
507259184,
},
    NullableValue = null,
},
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
new System.Int32[4]
{
1775017231,
97361135,
138290509,
483199746,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
322063631,
1689684877,
1519064460,
1938159567,
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
31109149,
1402692926,
1777087807,
529309458,
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[30], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[30], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[30], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32integerArray1M.AssertModel(models[0],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int32integerArray1M.AssertModel(models[0],_testData[4], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[5], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[6], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[7], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[8], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[24],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[25],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 181;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integerArray1M.AssertModel(models[0],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[29], false);
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
                await ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 144, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[30], false);
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
                await ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 109, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
                 ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 168, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[30], false);
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
                 ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 144, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 63, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[28],_testData[29], false);
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
                await ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 156, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[30], false);
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 128, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[28],_testData[29], false);
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
                 ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 39, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 168))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int32integerArray1M.AssertModel(models[0],_testData[2], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[3], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[4], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[5], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[6], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[7], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[8], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[24],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[25],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[26],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int32integerArray1M.AssertModel(models[0],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelBatch(connection, 144, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32integerArray1M.AssertModel(models[0],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models = await ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Int32integerArray1M.AssertModel(models[0],_testData[21], false);Int32integerArray1M.AssertModel(models[1],_testData[22], false);Int32integerArray1M.AssertModel(models[2],_testData[23], false);Int32integerArray1M.AssertModel(models[3],_testData[24], false);Int32integerArray1M.AssertModel(models[4],_testData[25], false);Int32integerArray1M.AssertModel(models[5],_testData[26], false);Int32integerArray1M.AssertModel(models[6],_testData[27], false);Int32integerArray1M.AssertModel(models[7],_testData[28], false);Int32integerArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ArrayintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models =  ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Int32integerArray1M.AssertModel(models[0],_testData[22], false);Int32integerArray1M.AssertModel(models[1],_testData[23], false);Int32integerArray1M.AssertModel(models[2],_testData[24], false);Int32integerArray1M.AssertModel(models[3],_testData[25], false);Int32integerArray1M.AssertModel(models[4],_testData[26], false);Int32integerArray1M.AssertModel(models[5],_testData[27], false);Int32integerArray1M.AssertModel(models[6],_testData[28], false);Int32integerArray1M.AssertModel(models[7],_testData[29], false);
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


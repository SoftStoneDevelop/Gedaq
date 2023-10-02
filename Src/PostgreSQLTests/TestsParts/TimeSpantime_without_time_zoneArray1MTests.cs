

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
    internal partial interface ITimeSpanArraytime_without_time_zoneArray
    {
    }
    
    internal partial class TimeSpanArraytime_without_time_zoneArray : ITimeSpanArraytime_without_time_zoneArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zonearray1mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArraytime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zonearray1mi(
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
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArraytime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                )
            ]
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

                changedRows =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInner(connection, 403420204, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInner(connection, 39547570, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

});
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

                changedRows = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerAsync(connection, 791721357, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerAsync(connection, 1303367224, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

});
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturning()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturning(connection, 2089552641, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

});
                Assert.That(id, Is.EqualTo(2089552641));

                id =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturning(connection, 1192637391, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

}, null);
                Assert.That(id, Is.EqualTo(1192637391));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 742933706, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

}, null);
                Assert.That(id, Is.EqualTo(742933706));

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2038206173, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

});
                Assert.That(id, Is.EqualTo(2038206173));

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1147879988, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

});
                Assert.That(id, Is.EqualTo(1147879988));

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1571126277, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

}, null);
                Assert.That(id, Is.EqualTo(1571126277));

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1387855415, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

});
                Assert.That(id, Is.EqualTo(1387855415));

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 169225345, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

});
                Assert.That(id, Is.EqualTo(169225345));

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 557191743, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

});
                Assert.That(id, Is.EqualTo(557191743));

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1881383262, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

});
                Assert.That(id, Is.EqualTo(1881383262));

                id = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 898447567, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

}, null);
                Assert.That(id, Is.EqualTo(898447567));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    timespantime_without_time_zonearray1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArraytime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespantime_without_time_zonearray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
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

                changedRows =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModel(connection, 946842692, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModel(connection, 1219747783, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

}, null, 403420204);
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

                changedRows = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelAsync(connection, 506968403, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelAsync(connection, 1759529606, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

}, null, 39547570);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;

                nullable =  ((ITimeSpanArraytime_without_time_zoneArray)this).ScalarInsertModelReturning(connection, 233664949, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

}, null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((ITimeSpanArraytime_without_time_zoneArray)this).ScalarInsertModelReturning(connection, 584378239, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

}, null, 791721357);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;

                nullable = await ((ITimeSpanArraytime_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, 1475983622, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

}));

                nullable = await ((ITimeSpanArraytime_without_time_zoneArray)this).ScalarInsertModelReturningAsync(connection, 1517648400, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

}, null, 1303367224);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    timespantime_without_time_zonearray1mi_id
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
    timespantime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArraytime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespantime_without_time_zonearray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpantime_without_time_zoneArray1M> models = null;
                TimeSpantime_without_time_zoneArray1M model = null;

                models =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturning(connection, 509152516, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509152516));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturning(connection, 1865008185, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

}, 2089552641).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturning(connection, 935055249, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturning(connection, 901880756, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

}, null, 1192637391).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpantime_without_time_zoneArray1M> models = null;
                TimeSpantime_without_time_zoneArray1M model = null;

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1375186572, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 16733382, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

}, 742933706).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16733382));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(742933706));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1753427887, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 58729774, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

}, 2038206173).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(58729774));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038206173));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1045192900, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1457773120, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

}, null, 1147879988).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 465774517, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(465774517));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1182168553, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

}, 1571126277).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1738462107, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1236555640, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

}, null, 1387855415).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1203149452, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1496758176, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

}, null, 169225345).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1865707878, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 304262985, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

}, null, 557191743).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304262985));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557191743));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1387472306, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 581467324, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

}, 1881383262).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1202867826, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 389332822, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

}, 898447567).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389332822));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898447567));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        #endregion

#region Select Models

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
FROM public.timespantime_without_time_zonearray1m m
LEFT JOIN public.timespantime_without_time_zonearray1mi mi ON mi.id = m.timespantime_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArraytime_without_time_zoneArray)
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanArraytime_without_time_zoneArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16733382));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(742933706));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(58729774));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038206173));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233664949));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304262985));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557191743));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389332822));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898447567));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(465774517));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506968403));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509152516));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArraytime_without_time_zoneArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16733382));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(742933706));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(58729774));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038206173));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233664949));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304262985));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557191743));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389332822));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898447567));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(465774517));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506968403));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509152516));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

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
FROM public.timespantime_without_time_zonearray1m m
LEFT JOIN public.timespantime_without_time_zonearray1mi mi ON mi.id = m.timespantime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArraytime_without_time_zoneArray)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11)
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanArraytime_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16733382));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(742933706));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(58729774));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038206173));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233664949));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304262985));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557191743));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389332822));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898447567));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(465774517));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506968403));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509152516));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArraytime_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16733382));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(742933706));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(58729774));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038206173));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233664949));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304262985));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557191743));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389332822));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898447567));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(465774517));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506968403));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509152516));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 946842692);
                var models =  ((ITimeSpanArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(17));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeSpanArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 946842692);
                var models = await ((ITimeSpanArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(17));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArraytime_without_time_zoneArray)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((ITimeSpanArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 509152516, 233664949))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304262985));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557191743));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389332822));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898447567));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(465774517));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506968403));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509152516));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
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
                await foreach(var batchResult in ((ITimeSpanArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 509152516, 1182168553))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespantime_without_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_timespantime_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpantime_without_time_zoneArray1MI>(7);

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 39547570,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 169225345,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 403420204,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 557191743,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 742933706,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 791721357,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 898447567,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39547570));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(169225345));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(403420204));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(557191743));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742933706));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791721357));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898447567));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 1147879988,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 1192637391,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 1303367224,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 1387855415,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 1571126277,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 1881383262,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 2038206173,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

}
                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1MI
                {
                    Id = 2089552641,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39547570));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(169225345));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(403420204));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(557191743));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742933706));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(791721357));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898447567));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1147879988));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192637391));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1303367224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387855415));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571126277));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881383262));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2038206173));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2089552641));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespantime_without_time_zonearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespantime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_timespantime_without_time_zonearray1m m
LEFT JOIN public.binary_timespantime_without_time_zonearray1mi mi ON mi.id = m.timespantime_without_time_zonearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpantime_without_time_zoneArray1M>(15);

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 16733382,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 742933706
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 58729774,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 2038206173
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 233664949,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 304262985,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 557191743
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 389332822,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 898447567
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 465774517,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 506968403,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 509152516,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 581467324,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 1881383262
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 584378239,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 791721357
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 901880756,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 1192637391
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 935055249,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 946842692,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1045192900,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1182168553,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 1571126277
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16733382));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(742933706));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(58729774));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038206173));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233664949));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304262985));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557191743));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389332822));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898447567));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(465774517));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506968403));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509152516));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1202867826,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1203149452,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1219747783,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 403420204
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1236555640,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 1387855415
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1375186572,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1387472306,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1457773120,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 1147879988
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1475983622,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1496758176,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 169225345
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1517648400,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 1303367224
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1738462107,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1753427887,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1759529606,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

},
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 39547570
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1865008185,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

},

                    ModelInner = new TimeSpantime_without_time_zoneArray1MI 
                    {
                        Id = 2089552641
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zoneArray1M
                {
                    Id = 1865707878,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

},

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16733382));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(742933706));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(58729774));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038206173));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233664949));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304262985));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557191743));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389332822));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(898447567));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(465774517));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506968403));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509152516));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581467324));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1881383262));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(584378239));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(791721357));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(901880756));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1192637391));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935055249));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(946842692));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045192900));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182168553));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1571126277));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1202867826));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1203149452));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219747783));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(403420204));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236555640));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1387855415));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375186572));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1387472306));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457773120));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1147879988));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475983622));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496758176));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(169225345));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517648400));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1303367224));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738462107));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1753427887));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759529606));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39547570));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865008185));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2089552641));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1865707878));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespantime_without_time_zonearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespantime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zoneArray1M>(30);

                expected.Add(
                    16733382,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 16733382,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 742933706,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    58729774,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 58729774,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 2038206173,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

}
                        }

                    }
                );

                expected.Add(
                    233664949,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 233664949,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    304262985,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 304262985,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 557191743,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

}
                        }

                    }
                );

                expected.Add(
                    389332822,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 389332822,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 898447567,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    465774517,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 465774517,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    506968403,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 506968403,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    509152516,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 509152516,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    581467324,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 581467324,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1881383262,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

}
                        }

                    }
                );

                expected.Add(
                    584378239,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 584378239,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 791721357,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    901880756,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 901880756,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1192637391,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    935055249,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 935055249,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    946842692,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 946842692,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1045192900,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1045192900,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1182168553,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1182168553,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1571126277,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1202867826,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1202867826,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1203149452,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1203149452,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1219747783,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1219747783,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 403420204,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1236555640,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1236555640,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1387855415,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

}
                        }

                    }
                );

                expected.Add(
                    1375186572,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1375186572,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1387472306,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1387472306,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1457773120,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1457773120,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1147879988,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

}
                        }

                    }
                );

                expected.Add(
                    1475983622,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1475983622,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1496758176,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1496758176,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 169225345,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

}
                        }

                    }
                );

                expected.Add(
                    1517648400,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1517648400,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1303367224,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

}
                        }

                    }
                );

                expected.Add(
                    1738462107,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1738462107,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1753427887,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1753427887,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1759529606,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1759529606,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 39547570,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

}
                        }

                    }
                );

                expected.Add(
                    1865008185,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1865008185,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 2089552641,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

}
                        }

                    }
                );

                expected.Add(
                    1865707878,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1865707878,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

},

                        ModelInner = null

                    }
                );

                var models =  ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zoneArray1M>(30);

                expected.Add(
                    16733382,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 16733382,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 25, milliseconds: 233),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 632),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 8, milliseconds: 478),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 37, milliseconds: 456),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 489),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 19, milliseconds: 298),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 742933706,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    58729774,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 58729774,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 52, milliseconds: 561),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 49, milliseconds: 531),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 38, milliseconds: 463),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 22, milliseconds: 799),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 52, milliseconds: 257),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 2038206173,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

}
                        }

                    }
                );

                expected.Add(
                    233664949,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 233664949,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 15, milliseconds: 606),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 40, milliseconds: 490),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 4, milliseconds: 717),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    304262985,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 304262985,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 44, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 47, milliseconds: 427),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 2, milliseconds: 539),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 557191743,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

}
                        }

                    }
                );

                expected.Add(
                    389332822,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 389332822,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 27, milliseconds: 538),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 49, milliseconds: 876),

new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 38, milliseconds: 46),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 9, milliseconds: 922),

new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 6, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 57, milliseconds: 541),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 898447567,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    465774517,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 465774517,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 4, milliseconds: 512),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 5, milliseconds: 321),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 33, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 31, milliseconds: 87),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    506968403,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 506968403,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 12, milliseconds: 175),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 12, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 28, milliseconds: 804),

new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 18, milliseconds: 59),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    509152516,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 509152516,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 9, milliseconds: 582),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 6, milliseconds: 315),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 47, milliseconds: 213),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 48, milliseconds: 968),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    581467324,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 581467324,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 32, milliseconds: 915),

new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 53, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 7, milliseconds: 63),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 28, milliseconds: 249),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 51, milliseconds: 319),

new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 51, milliseconds: 256),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1881383262,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

}
                        }

                    }
                );

                expected.Add(
                    584378239,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 584378239,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 3, milliseconds: 195),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 43, milliseconds: 695),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 34, milliseconds: 272),

new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 30, milliseconds: 441),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 791721357,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    901880756,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 901880756,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 18, milliseconds: 807),

new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 99),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1192637391,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    935055249,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 935055249,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 33, milliseconds: 270),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 28, milliseconds: 992),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 3, milliseconds: 241),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 47, milliseconds: 661),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 16, milliseconds: 25),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 538),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 48, milliseconds: 822),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 173),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    946842692,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 946842692,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 51, milliseconds: 324),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 53, milliseconds: 699),

new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 51, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 280),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1045192900,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1045192900,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 23, milliseconds: 948),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 53, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 56, milliseconds: 882),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 21, milliseconds: 785),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 42, milliseconds: 579),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 42, milliseconds: 661),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 42, milliseconds: 656),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1182168553,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1182168553,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 52, milliseconds: 5),

new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 41, milliseconds: 437),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 50, milliseconds: 773),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 984),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 52, milliseconds: 6),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 48, milliseconds: 232),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 36, milliseconds: 215),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 49, milliseconds: 620),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1571126277,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1202867826,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1202867826,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 45, milliseconds: 848),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 17, milliseconds: 726),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 30, milliseconds: 465),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 22, milliseconds: 723),

new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 43, milliseconds: 93),

new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 25, milliseconds: 52),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 17, milliseconds: 970),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1203149452,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1203149452,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 52, milliseconds: 294),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 6, milliseconds: 200),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 54, milliseconds: 817),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 456),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1219747783,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1219747783,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 23, milliseconds: 329),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 1, milliseconds: 545),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 653),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 403420204,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1236555640,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1236555640,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 7, milliseconds: 664),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 51, milliseconds: 858),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 40, milliseconds: 543),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1387855415,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

}
                        }

                    }
                );

                expected.Add(
                    1375186572,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1375186572,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 27, milliseconds: 52),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 44, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 37, milliseconds: 297),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1387472306,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1387472306,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 56, milliseconds: 998),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 17, milliseconds: 544),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 4, milliseconds: 756),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 527),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 4, milliseconds: 592),

new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 15, milliseconds: 453),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 32, milliseconds: 944),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 3, milliseconds: 881),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1457773120,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1457773120,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 18, milliseconds: 63),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1147879988,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

}
                        }

                    }
                );

                expected.Add(
                    1475983622,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1475983622,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 873),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 21, milliseconds: 95),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 54, milliseconds: 115),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 11, milliseconds: 345),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 41, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 533),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 30, milliseconds: 772),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1496758176,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1496758176,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 44, milliseconds: 610),

new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 51, milliseconds: 817),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 630),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 169225345,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

}
                        }

                    }
                );

                expected.Add(
                    1517648400,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1517648400,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 57, milliseconds: 915),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 8, milliseconds: 257),

new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 35, milliseconds: 355),

new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 35, milliseconds: 731),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 1303367224,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

}
                        }

                    }
                );

                expected.Add(
                    1738462107,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1738462107,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 172),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 52, milliseconds: 483),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 588),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1753427887,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1753427887,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 42, milliseconds: 181),

new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 17, milliseconds: 281),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 52, milliseconds: 705),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 725),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 10, milliseconds: 226),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 15, milliseconds: 946),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 57, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 761),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1759529606,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1759529606,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 56, milliseconds: 939),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 44, milliseconds: 21),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 15, milliseconds: 887),

new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 42, milliseconds: 841),

},
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 39547570,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

}
                        }

                    }
                );

                expected.Add(
                    1865008185,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1865008185,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 5, milliseconds: 729),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 53, milliseconds: 920),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 25, milliseconds: 793),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 36, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 0, milliseconds: 787),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 502),

},

                        ModelInner = new TimeSpantime_without_time_zoneArray1MI
                        {
                            Id = 2089552641,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

}
                        }

                    }
                );

                expected.Add(
                    1865707878,
                    new TimeSpantime_without_time_zoneArray1M
                    {
                        Id = 1865707878,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 49, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 54, milliseconds: 103),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 12, milliseconds: 214),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 4, milliseconds: 673),

new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 752),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 11, milliseconds: 259),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 15, milliseconds: 118),

},

                        ModelInner = null

                    }
                );

                var models = await ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespantime_without_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zoneArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zoneArray1MI>(15);

                expected.Add(
                    39547570,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 39547570,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

}
                    }
                );

                expected.Add(
                    169225345,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 169225345,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

}
                    }
                );

                expected.Add(
                    403420204,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 403420204,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    557191743,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 557191743,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

}
                    }
                );

                expected.Add(
                    742933706,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 742933706,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    791721357,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 791721357,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    898447567,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 898447567,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1147879988,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1147879988,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

}
                    }
                );

                expected.Add(
                    1192637391,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1192637391,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1303367224,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1303367224,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

}
                    }
                );

                expected.Add(
                    1387855415,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1387855415,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

}
                    }
                );

                expected.Add(
                    1571126277,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1571126277,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1881383262,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1881383262,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

}
                    }
                );

                expected.Add(
                    2038206173,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 2038206173,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

}
                    }
                );

                expected.Add(
                    2089552641,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 2089552641,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

}
                    }
                );

                var models =  ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zoneArray1MI>(15);

                expected.Add(
                    39547570,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 39547570,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 15, milliseconds: 908),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 585),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 10, milliseconds: 130),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 32, milliseconds: 568),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 44, milliseconds: 152),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 58, milliseconds: 137),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 50, milliseconds: 210),

}
                    }
                );

                expected.Add(
                    169225345,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 169225345,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 56, milliseconds: 705),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 23, milliseconds: 669),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 284),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 19, milliseconds: 430),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 8, milliseconds: 174),

new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 7, milliseconds: 618),

}
                    }
                );

                expected.Add(
                    403420204,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 403420204,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 29, milliseconds: 810),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 47, milliseconds: 296),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 40, milliseconds: 288),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    557191743,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 557191743,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 36, milliseconds: 385),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 58, milliseconds: 871),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 17, milliseconds: 534),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 213),

new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 17, milliseconds: 412),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 53, milliseconds: 98),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 302),

}
                    }
                );

                expected.Add(
                    742933706,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 742933706,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 53, milliseconds: 281),

new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 49, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 42, milliseconds: 392),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    791721357,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 791721357,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 24, milliseconds: 10),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 35, milliseconds: 171),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 5, milliseconds: 52),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 30, milliseconds: 262),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    898447567,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 898447567,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 38, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 43, milliseconds: 34),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 25, milliseconds: 660),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 14, milliseconds: 245),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1147879988,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1147879988,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 22, milliseconds: 219),

new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 5, milliseconds: 852),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 4, milliseconds: 846),

new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 4, milliseconds: 754),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 36, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 48, milliseconds: 508),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 653),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 43, milliseconds: 857),

}
                    }
                );

                expected.Add(
                    1192637391,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1192637391,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 1, milliseconds: 976),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 0, milliseconds: 39),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 31, milliseconds: 342),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1303367224,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1303367224,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 3, milliseconds: 823),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 20, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 10, milliseconds: 398),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 37, milliseconds: 360),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 969),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 3, milliseconds: 9),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 35, milliseconds: 225),

}
                    }
                );

                expected.Add(
                    1387855415,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1387855415,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 33, milliseconds: 748),

new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 23, milliseconds: 145),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 55, milliseconds: 734),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 1, milliseconds: 653),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 3, milliseconds: 811),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 142),

}
                    }
                );

                expected.Add(
                    1571126277,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1571126277,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 11, milliseconds: 561),

new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 43, milliseconds: 101),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 23, milliseconds: 91),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1881383262,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 1881383262,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 29, milliseconds: 963),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 2, milliseconds: 146),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 680),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 742),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 43, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 37, milliseconds: 606),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 0, milliseconds: 465),

}
                    }
                );

                expected.Add(
                    2038206173,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 2038206173,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 49, milliseconds: 221),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 46, milliseconds: 535),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 37, milliseconds: 21),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 28, milliseconds: 450),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 58, milliseconds: 807),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 45, milliseconds: 515),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 325),

}
                    }
                );

                expected.Add(
                    2089552641,
                    new TimeSpantime_without_time_zoneArray1MI
                    {
                        Id = 2089552641,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 38, milliseconds: 461),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 604),

new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 14),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 39, milliseconds: 819),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 34, milliseconds: 120),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 395),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 25, milliseconds: 334),

}
                    }
                );

                var models = await ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        #endregion

    }
}


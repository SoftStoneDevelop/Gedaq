

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
    internal partial interface ITimeSpanArrayintervalArray
    {
    }
    
    internal partial class TimeSpanArrayintervalArray : ITimeSpanArrayintervalArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1mi(
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1mi(
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
            queryMapType: typeof(TimeSpanintervalArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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

                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModelInner(connection, 889266690, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModelInner(connection, 273006292, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

}, null);
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

                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerAsync(connection, 825836395, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerAsync(connection, 830413700, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

}, null);
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

                id =  ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturning(connection, 1766401781, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

});
                Assert.That(id, Is.EqualTo(1766401781));

                id =  ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturning(connection, 143942450, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

});
                Assert.That(id, Is.EqualTo(143942450));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 194678162, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

}, null);
                Assert.That(id, Is.EqualTo(194678162));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1626715961, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

});
                Assert.That(id, Is.EqualTo(1626715961));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1618471161, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

});
                Assert.That(id, Is.EqualTo(1618471161));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 987312335, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

});
                Assert.That(id, Is.EqualTo(987312335));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1818381566, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

}, null);
                Assert.That(id, Is.EqualTo(1818381566));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1005419658, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

}, null);
                Assert.That(id, Is.EqualTo(1005419658));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 807620973, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

}, null);
                Assert.That(id, Is.EqualTo(807620973));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1840329346, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

}, null);
                Assert.That(id, Is.EqualTo(1840329346));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1786517806, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

});
                Assert.That(id, Is.EqualTo(1786517806));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1m(
	id,
    value,
    nullablevalue,
    timespanintervalarray1mi_id
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalarray1mi_id", 
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

                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModel(connection, 1125551917, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModel(connection, 1765166232, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

}, null, 889266690);
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

                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelAsync(connection, 1901475682, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelAsync(connection, 879599888, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

}, 273006292);
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

                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, 505775530, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

}));

                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, 1329419813, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

}, 825836395);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

}));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;

                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, 1355306085, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

}));

                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, 1737653439, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

}, null, 830413700);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1m(
	id,
    value,
    nullablevalue,
    timespanintervalarray1mi_id
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
    timespanintervalarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(TimeSpanintervalArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalarray1mi_id", 
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
                List<TimeSpanintervalArray1M> models = null;
                TimeSpanintervalArray1M model = null;

                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, 1071180730, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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

                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, 1098932744, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

}, null, 1766401781).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, 1487297851, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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

                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, 867819980, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

}, 143942450).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

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
                List<TimeSpanintervalArray1M> models = null;
                TimeSpanintervalArray1M model = null;

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 85920528, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(85920528));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

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
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 2136314065, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

}, 194678162).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 1929981654, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 1234540333, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

}, 1626715961).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 2078194901, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 1474254673, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

}, 1618471161).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 1724128927, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 36171505, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

}, null, 987312335).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36171505));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987312335));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 307449025, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(307449025));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 534367368, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

}, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

}, 1818381566).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 1530019777, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 349295623, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

}, null, 1005419658).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349295623));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005419658));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 1846108112, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 596891164, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

}, 807620973).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 1555316454, 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 1278570224, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

}, 1840329346).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 897743406, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, 2142358115, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

}, 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

}, 1786517806).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeSpanintervalArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)
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
                var models =  ((ITimeSpanArrayintervalArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36171505));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987312335));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

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
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

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
                Assert.That(model.Id, Is.EqualTo(85920528));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

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
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(307449025));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

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
                Assert.That(model.Id, Is.EqualTo(349295623));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005419658));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(505775530));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

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
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

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

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

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
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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
                Assert.That(model.Id, Is.EqualTo(1329419813));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(825836395));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

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
                Assert.That(model.Id, Is.EqualTo(1355306085));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

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
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

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
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArrayintervalArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36171505));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987312335));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

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
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

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
                Assert.That(model.Id, Is.EqualTo(85920528));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

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
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(307449025));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

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
                Assert.That(model.Id, Is.EqualTo(349295623));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005419658));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(505775530));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

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
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

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

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

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
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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
                Assert.That(model.Id, Is.EqualTo(1329419813));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(825836395));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

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
                Assert.That(model.Id, Is.EqualTo(1355306085));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

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
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

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
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeSpanintervalArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)
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
                var models =  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36171505));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987312335));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

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
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

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
                Assert.That(model.Id, Is.EqualTo(85920528));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

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
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(307449025));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

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
                Assert.That(model.Id, Is.EqualTo(349295623));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005419658));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(505775530));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

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
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

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

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

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
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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
                Assert.That(model.Id, Is.EqualTo(1329419813));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(825836395));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

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
                Assert.That(model.Id, Is.EqualTo(1355306085));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

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
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

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
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36171505));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987312335));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

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
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

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
                Assert.That(model.Id, Is.EqualTo(85920528));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

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
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(307449025));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

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
                Assert.That(model.Id, Is.EqualTo(349295623));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005419658));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(505775530));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

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
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

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

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

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
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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
                Assert.That(model.Id, Is.EqualTo(1329419813));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(825836395));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

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
                Assert.That(model.Id, Is.EqualTo(1355306085));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

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
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

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
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 1555316454);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(9));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 36171505);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(29));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(85920528));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

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
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

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
                Assert.That(model.Id, Is.EqualTo(307449025));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

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
                Assert.That(model.Id, Is.EqualTo(349295623));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005419658));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

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
                Assert.That(model.Id, Is.EqualTo(505775530));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

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
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

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
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

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
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

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
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329419813));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(825836395));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

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
                Assert.That(model.Id, Is.EqualTo(1355306085));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

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
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

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
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

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
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)
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
                 foreach(var batchResult in ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelBatch(connection, 505775530, 349295623))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(25));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

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
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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
                Assert.That(model.Id, Is.EqualTo(1329419813));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(825836395));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

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
                Assert.That(model.Id, Is.EqualTo(1355306085));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

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
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

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
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

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
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

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
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(505775530));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

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
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

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
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

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
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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
                Assert.That(model.Id, Is.EqualTo(1329419813));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(825836395));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

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
                Assert.That(model.Id, Is.EqualTo(1355306085));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

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
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

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
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

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
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

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
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
                await foreach(var batchResult in ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 1765166232, 2078194901))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
COPY public.binary_timespanintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MI),
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

                var importCollection = new List<TimeSpanintervalArray1MI>(7);

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 143942450,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 194678162,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 273006292,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 807620973,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 825836395,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 830413700,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 889266690,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143942450));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

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
                Assert.That(model.Id, Is.EqualTo(194678162));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273006292));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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
                Assert.That(model.Id, Is.EqualTo(807620973));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825836395));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(830413700));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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
                Assert.That(model.Id, Is.EqualTo(889266690));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 987312335,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 1005419658,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 1618471161,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 1626715961,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 1766401781,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 1786517806,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 1818381566,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray1MI
                {
                    Id = 1840329346,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143942450));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

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
                Assert.That(model.Id, Is.EqualTo(194678162));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273006292));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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
                Assert.That(model.Id, Is.EqualTo(807620973));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825836395));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(830413700));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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
                Assert.That(model.Id, Is.EqualTo(889266690));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(987312335));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

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
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

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
                Assert.That(model.Id, Is.EqualTo(1005419658));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

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
                Assert.That(model.Id, Is.EqualTo(1618471161));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

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
                Assert.That(model.Id, Is.EqualTo(1626715961));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1766401781));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1786517806));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

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
                Assert.That(model.Id, Is.EqualTo(1818381566));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1840329346));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
FROM public.binary_timespanintervalarray1m m
LEFT JOIN public.binary_timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeSpanintervalArray1M),
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

                var importCollection = new List<TimeSpanintervalArray1M>(15);

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 36171505,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 987312335
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 85920528,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 307449025,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 349295623,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 1005419658
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 505775530,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 534367368,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 1818381566
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 596891164,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 807620973
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 867819980,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 143942450
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 879599888,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 273006292
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 897743406,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1071180730,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1098932744,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 1766401781
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1125551917,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1234540333,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 1626715961
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1278570224,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 1840329346
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36171505));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987312335));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

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
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

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
                Assert.That(model.Id, Is.EqualTo(85920528));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

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
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(307449025));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

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
                Assert.That(model.Id, Is.EqualTo(349295623));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005419658));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

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

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(505775530));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

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
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

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

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

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
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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
                new TimeSpanintervalArray1M
                {
                    Id = 1329419813,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

},
                    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 825836395
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1355306085,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1474254673,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 1618471161
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1487297851,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1530019777,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1555316454,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1724128927,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1737653439,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 830413700
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1765166232,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 889266690
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1846108112,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1901475682,
                    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 1929981654,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 2078194901,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 2136314065,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 194678162
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray1M
                {
                    Id = 2142358115,
                    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

},
                    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

},

                    ModelInner = new TimeSpanintervalArray1MI 
                    {
                        Id = 1786517806
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36171505));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987312335));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

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
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

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
                Assert.That(model.Id, Is.EqualTo(85920528));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

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
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

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


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(307449025));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

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
                Assert.That(model.Id, Is.EqualTo(349295623));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005419658));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

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


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(505775530));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

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
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

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


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534367368));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

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
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818381566));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

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


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596891164));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

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
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(807620973));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

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
                Assert.That(model.Id, Is.EqualTo(867819980));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

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
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(143942450));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

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
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879599888));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

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
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(273006292));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

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


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897743406));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

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
                Assert.That(model.Id, Is.EqualTo(1071180730));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

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
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

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
                Assert.That(model.Id, Is.EqualTo(1098932744));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1766401781));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

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
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

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
                Assert.That(model.Id, Is.EqualTo(1125551917));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

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
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

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
                Assert.That(model.Id, Is.EqualTo(1234540333));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

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
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626715961));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

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
                Assert.That(model.Id, Is.EqualTo(1278570224));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

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
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1840329346));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

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
                Assert.That(model.Id, Is.EqualTo(1329419813));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(825836395));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

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
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

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
                Assert.That(model.Id, Is.EqualTo(1355306085));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

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
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

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


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1474254673));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

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
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618471161));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

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
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1487297851));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

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


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530019777));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

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
                Assert.That(model.Id, Is.EqualTo(1555316454));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

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


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724128927));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

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
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

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


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737653439));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(830413700));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

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


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765166232));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(889266690));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

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
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

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
                Assert.That(model.Id, Is.EqualTo(1846108112));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

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


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901475682));
                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

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
                Assert.That(model.Id, Is.EqualTo(1929981654));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

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
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

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
                Assert.That(model.Id, Is.EqualTo(2078194901));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

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


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2136314065));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

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
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(194678162));

                {
                    var expectEnumerValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142358115));
                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

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
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1786517806));

                {
                    var expectEnumerValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

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
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(TimeSpanintervalArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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

                var expected = new Dictionary<System.Int32,TimeSpanintervalArray1M>(30);

                expected.Add(
                    36171505,
                    new TimeSpanintervalArray1M
                    {
                        Id = 36171505,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 987312335,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

}
                        }

                    }
                );

                expected.Add(
                    85920528,
                    new TimeSpanintervalArray1M
                    {
                        Id = 85920528,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    307449025,
                    new TimeSpanintervalArray1M
                    {
                        Id = 307449025,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    349295623,
                    new TimeSpanintervalArray1M
                    {
                        Id = 349295623,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1005419658,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    505775530,
                    new TimeSpanintervalArray1M
                    {
                        Id = 505775530,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    534367368,
                    new TimeSpanintervalArray1M
                    {
                        Id = 534367368,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1818381566,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    596891164,
                    new TimeSpanintervalArray1M
                    {
                        Id = 596891164,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 807620973,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    867819980,
                    new TimeSpanintervalArray1M
                    {
                        Id = 867819980,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 143942450,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

}
                        }

                    }
                );

                expected.Add(
                    879599888,
                    new TimeSpanintervalArray1M
                    {
                        Id = 879599888,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 273006292,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    897743406,
                    new TimeSpanintervalArray1M
                    {
                        Id = 897743406,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1071180730,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1071180730,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1098932744,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1098932744,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1766401781,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

}
                        }

                    }
                );

                expected.Add(
                    1125551917,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1125551917,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1234540333,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1234540333,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1626715961,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

}
                        }

                    }
                );

                expected.Add(
                    1278570224,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1278570224,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1840329346,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1329419813,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1329419813,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 825836395,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

}
                        }

                    }
                );

                expected.Add(
                    1355306085,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1355306085,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1474254673,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1474254673,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1618471161,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

}
                        }

                    }
                );

                expected.Add(
                    1487297851,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1487297851,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1530019777,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1530019777,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1555316454,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1555316454,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1724128927,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1724128927,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1737653439,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1737653439,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 830413700,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1765166232,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1765166232,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 889266690,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

}
                        }

                    }
                );

                expected.Add(
                    1846108112,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1846108112,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1901475682,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1901475682,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1929981654,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1929981654,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2078194901,
                    new TimeSpanintervalArray1M
                    {
                        Id = 2078194901,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2136314065,
                    new TimeSpanintervalArray1M
                    {
                        Id = 2136314065,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 194678162,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2142358115,
                    new TimeSpanintervalArray1M
                    {
                        Id = 2142358115,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1786517806,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

}
                        }

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

                var expected = new Dictionary<System.Int32,TimeSpanintervalArray1M>(30);

                expected.Add(
                    36171505,
                    new TimeSpanintervalArray1M
                    {
                        Id = 36171505,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 6, milliseconds: 730),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 58, milliseconds: 356),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 30, milliseconds: 343),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 987312335,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

}
                        }

                    }
                );

                expected.Add(
                    85920528,
                    new TimeSpanintervalArray1M
                    {
                        Id = 85920528,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 9, milliseconds: 979),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 43, milliseconds: 718),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 20, milliseconds: 398),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 43, milliseconds: 962),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 54, milliseconds: 629),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 9, milliseconds: 663),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    307449025,
                    new TimeSpanintervalArray1M
                    {
                        Id = 307449025,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 41, milliseconds: 152),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 45, milliseconds: 305),

new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 46, milliseconds: 618),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    349295623,
                    new TimeSpanintervalArray1M
                    {
                        Id = 349295623,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 1, milliseconds: 355),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 6, milliseconds: 696),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 252),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1005419658,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    505775530,
                    new TimeSpanintervalArray1M
                    {
                        Id = 505775530,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 45, milliseconds: 992),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 696),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 52, milliseconds: 237),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 18, milliseconds: 57),

new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 961),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 37, milliseconds: 734),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    534367368,
                    new TimeSpanintervalArray1M
                    {
                        Id = 534367368,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 24, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 47, milliseconds: 819),

new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 15, milliseconds: 253),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 38, milliseconds: 476),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 24, milliseconds: 152),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 39, milliseconds: 85),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1818381566,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    596891164,
                    new TimeSpanintervalArray1M
                    {
                        Id = 596891164,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 207),

new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 1, milliseconds: 987),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 6, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 640),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 20, milliseconds: 815),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 11, milliseconds: 998),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 17, milliseconds: 659),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 805),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 807620973,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    867819980,
                    new TimeSpanintervalArray1M
                    {
                        Id = 867819980,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 54, milliseconds: 691),

new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 41, milliseconds: 403),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 20, milliseconds: 256),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 742),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 23, milliseconds: 690),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 43, milliseconds: 559),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 143942450,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

}
                        }

                    }
                );

                expected.Add(
                    879599888,
                    new TimeSpanintervalArray1M
                    {
                        Id = 879599888,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 4, milliseconds: 226),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 1, milliseconds: 8),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 53, milliseconds: 412),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 7, milliseconds: 914),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 50, milliseconds: 206),

new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 58, milliseconds: 575),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 273006292,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    897743406,
                    new TimeSpanintervalArray1M
                    {
                        Id = 897743406,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 23, milliseconds: 932),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 11, milliseconds: 711),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 45, milliseconds: 413),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 25, milliseconds: 657),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1071180730,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1071180730,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 50, milliseconds: 340),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 50, milliseconds: 368),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 40, milliseconds: 232),

new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 52, milliseconds: 879),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 29, milliseconds: 88),

new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 31, milliseconds: 950),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1098932744,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1098932744,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 17, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 3, milliseconds: 761),

new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 35, milliseconds: 133),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1766401781,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

}
                        }

                    }
                );

                expected.Add(
                    1125551917,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1125551917,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 20, milliseconds: 119),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 35, milliseconds: 383),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 49, milliseconds: 914),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 35, milliseconds: 708),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 30, milliseconds: 521),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 35, milliseconds: 434),

new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 30, milliseconds: 574),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1234540333,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1234540333,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 521),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 24, milliseconds: 814),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 851),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 22, milliseconds: 578),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 30, milliseconds: 433),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 905),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 2, milliseconds: 221),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1626715961,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

}
                        }

                    }
                );

                expected.Add(
                    1278570224,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1278570224,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 51, milliseconds: 580),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 52, milliseconds: 765),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 776),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 100),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 812),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 774),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 57, milliseconds: 318),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 25, milliseconds: 916),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1840329346,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1329419813,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1329419813,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 38, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 17, milliseconds: 443),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 5, milliseconds: 5),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 32, milliseconds: 351),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 30, milliseconds: 266),

new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 29, milliseconds: 844),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 825836395,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

}
                        }

                    }
                );

                expected.Add(
                    1355306085,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1355306085,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 292),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 32, milliseconds: 633),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 0, milliseconds: 645),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 36, milliseconds: 418),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 642),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 6, milliseconds: 481),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 18, milliseconds: 602),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1474254673,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1474254673,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 23, milliseconds: 506),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 22, milliseconds: 943),

new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 267),

new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 497),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 1, milliseconds: 652),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 57, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 1, milliseconds: 195),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 29, milliseconds: 689),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1618471161,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

}
                        }

                    }
                );

                expected.Add(
                    1487297851,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1487297851,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 15, milliseconds: 661),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 16, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 19, milliseconds: 721),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1530019777,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1530019777,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 616),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 40, milliseconds: 90),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 533),

new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 25, milliseconds: 562),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1555316454,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1555316454,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 14, milliseconds: 619),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 51, milliseconds: 218),

new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 49, milliseconds: 606),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1724128927,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1724128927,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 254),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 29, milliseconds: 967),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 4, milliseconds: 430),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 56, milliseconds: 5),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 985),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 41, milliseconds: 260),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 3, milliseconds: 847),

new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 47, milliseconds: 602),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1737653439,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1737653439,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 16, milliseconds: 232),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 101),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 3, milliseconds: 86),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 830413700,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1765166232,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1765166232,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 54, milliseconds: 824),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 22, milliseconds: 739),

new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 3, milliseconds: 747),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 17, milliseconds: 327),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 889266690,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

},
                            NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

}
                        }

                    }
                );

                expected.Add(
                    1846108112,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1846108112,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 30, milliseconds: 231),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 40, milliseconds: 924),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 53, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 5, milliseconds: 475),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1901475682,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1901475682,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 38, milliseconds: 276),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 40, milliseconds: 433),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 12, milliseconds: 332),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1929981654,
                    new TimeSpanintervalArray1M
                    {
                        Id = 1929981654,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 56, milliseconds: 180),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 21, milliseconds: 874),

new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 35, milliseconds: 426),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 9, milliseconds: 271),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 15, milliseconds: 121),

new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 13, milliseconds: 822),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 53, milliseconds: 397),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 12, milliseconds: 891),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2078194901,
                    new TimeSpanintervalArray1M
                    {
                        Id = 2078194901,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 0, milliseconds: 172),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 24, milliseconds: 761),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 296),

new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 294),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2136314065,
                    new TimeSpanintervalArray1M
                    {
                        Id = 2136314065,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 27, milliseconds: 312),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 40, milliseconds: 540),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 8, milliseconds: 926),

new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 17, milliseconds: 286),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 14, milliseconds: 496),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 477),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 32, milliseconds: 558),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 194678162,
                            Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2142358115,
                    new TimeSpanintervalArray1M
                    {
                        Id = 2142358115,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 26, milliseconds: 769),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 995),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 24, milliseconds: 274),

new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 36, milliseconds: 753),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 20, milliseconds: 171),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 2, milliseconds: 501),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 19, milliseconds: 505),

new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 12, milliseconds: 627),

},

                        ModelInner = new TimeSpanintervalArray1MI
                        {
                            Id = 1786517806,
                            Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

},
                            NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

}
                        }

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
COPY public.binary_timespanintervalarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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

                var expected = new Dictionary<System.Int32,TimeSpanintervalArray1MI>(15);

                expected.Add(
                    143942450,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 143942450,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

}
                    }
                );

                expected.Add(
                    194678162,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 194678162,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    273006292,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 273006292,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    807620973,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 807620973,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    825836395,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 825836395,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

}
                    }
                );

                expected.Add(
                    830413700,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 830413700,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    889266690,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 889266690,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

}
                    }
                );

                expected.Add(
                    987312335,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 987312335,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

}
                    }
                );

                expected.Add(
                    1005419658,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1005419658,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1618471161,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1618471161,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

}
                    }
                );

                expected.Add(
                    1626715961,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1626715961,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

}
                    }
                );

                expected.Add(
                    1766401781,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1766401781,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

}
                    }
                );

                expected.Add(
                    1786517806,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1786517806,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

}
                    }
                );

                expected.Add(
                    1818381566,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1818381566,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1840329346,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1840329346,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

},
                        NullableValue = null
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

                var expected = new Dictionary<System.Int32,TimeSpanintervalArray1MI>(15);

                expected.Add(
                    143942450,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 143942450,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 48, milliseconds: 898),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 11, milliseconds: 685),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 506),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 57, milliseconds: 615),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 4, milliseconds: 736),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 14, milliseconds: 201),

new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 15, milliseconds: 9),

}
                    }
                );

                expected.Add(
                    194678162,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 194678162,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 33, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 49, milliseconds: 805),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    273006292,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 273006292,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 21, milliseconds: 460),

new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 27, milliseconds: 752),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 50, milliseconds: 34),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    807620973,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 807620973,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 55, milliseconds: 507),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 53, milliseconds: 289),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 12, milliseconds: 935),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    825836395,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 825836395,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 24, milliseconds: 690),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 44, milliseconds: 823),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 418),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 15, milliseconds: 437),

new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 58, milliseconds: 289),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 30, milliseconds: 321),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 53, milliseconds: 860),

}
                    }
                );

                expected.Add(
                    830413700,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 830413700,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 407),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 36, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 21, milliseconds: 161),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 35, milliseconds: 643),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    889266690,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 889266690,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 56, milliseconds: 697),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 43, milliseconds: 825),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 26, milliseconds: 476),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 33, milliseconds: 645),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 9, milliseconds: 770),

new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 14, milliseconds: 905),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 13, milliseconds: 422),

}
                    }
                );

                expected.Add(
                    987312335,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 987312335,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 2, milliseconds: 956),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 32, milliseconds: 145),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 6),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 24, milliseconds: 829),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 20, milliseconds: 117),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 44, milliseconds: 566),

}
                    }
                );

                expected.Add(
                    1005419658,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1005419658,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 41, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 18, milliseconds: 942),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 12, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 717),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1618471161,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1618471161,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 37, milliseconds: 310),

new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 45, milliseconds: 847),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 225),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 44, milliseconds: 664),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 959),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 36, milliseconds: 955),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 279),

}
                    }
                );

                expected.Add(
                    1626715961,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1626715961,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 47, milliseconds: 460),

new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 56, milliseconds: 51),

new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 19, milliseconds: 532),

},
                        NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 42, milliseconds: 688),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 16, milliseconds: 731),

new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 23, milliseconds: 889),

new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 8, milliseconds: 985),

}
                    }
                );

                expected.Add(
                    1766401781,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1766401781,
                        Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 31, milliseconds: 651),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 43, milliseconds: 966),

new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 21, milliseconds: 918),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 53, milliseconds: 482),

new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 50, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 6, milliseconds: 119),

}
                    }
                );

                expected.Add(
                    1786517806,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1786517806,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 10, milliseconds: 345),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 18, milliseconds: 210),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 27, milliseconds: 201),

},
                        NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 32, milliseconds: 538),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 269),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 8, milliseconds: 491),

}
                    }
                );

                expected.Add(
                    1818381566,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1818381566,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 15, milliseconds: 599),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 5, milliseconds: 842),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 38, milliseconds: 357),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 1, milliseconds: 807),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1840329346,
                    new TimeSpanintervalArray1MI
                    {
                        Id = 1840329346,
                        Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 25, milliseconds: 649),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 898),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 20, milliseconds: 440),

new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 13, milliseconds: 884),

},
                        NullableValue = null
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

